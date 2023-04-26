using Sistema_almoço_alunos.src.Controllers;
using Sistema_almoço_alunos.src.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.UI
{
    public partial class Gerenciamento : Form
    {

        Agendamento agendamento = new();
        Plano plano = new();
        Aluno aluno = new();
        DataTable dt = new();

        AgendamentoController controllerAge = new();
        PlanoController controllerPlano = new(); 

        public Gerenciamento(Aluno aluno)
        {
            InitializeComponent();

            //Preenchendo a janela
            try
            {
                // Salvando o aluno para que possa ser usado fora deste metodo
                this.aluno = aluno;

                agendamento.IdAluno= aluno.Id;

                // Preenchendo a lista de agendamentos feitos pelo aluno
                Fill(aluno.Id, txtMes.Text, txtAno.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        // Metodo para verificar se existem campos vazios
        private bool textBoxVazias()
        {
            // Para cada campo no formulario
            foreach (Control c in this.Controls)
                // Verifica se é uma text box e se não é o campo de busca
                if (c is TextBox && c != txtMes && c != txtValorTotal && c != txtPlano)
                {
                    // Verifica se é uma text box, desconsiderando campos opcionais
                    TextBox textBox = c as TextBox;
                    // Se for uma text box obrigatoria, verifica se está vazia
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        // Se estiver, retorna uma resposta "true"
                        return true;
                }

            // Caso não haja campos obrigatorios vazios, retorna uma reposta "false"
            return false;
        }

        // Este metodo faz o memso que o metodo anterior,
        // mas com text boxes que utilizam mascara
        private bool MaskedtextBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is MaskedTextBox && c != txtMes && c != txtAno)
                {
                    MaskedTextBox textBox = c as MaskedTextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "  /  /" || textBox.Text == "  :")
                        return true;
                }
            return false;
        }

        // Metodo para preparar os campos para um cadastro ou edição
        private void setup(int sinal, bool state1, bool state2)
        {
            // Se o sinal for igual a 1, então um novo agendamento esta sendo cadastrado
            if (sinal == 1)
            {
                agendamento.Id = 0;
                txtData.Text = null;
                txtInicio.Text = null;
                txtFim.Text = null;
                txtValor.Text = null;
                cmbPlano.Text = null;

            }

            // Define o estado dos campos
            txtData.ReadOnly = state1;
            txtInicio.ReadOnly = state1;
            txtFim.ReadOnly = state1;
            txtValor.ReadOnly = state1;

            //Bloqueia e esconde o textbox de plano
            txtPlano.ReadOnly = state1;
            txtPlano.Visible = state1;

            // Define a visibilidade dos botões Editar
            btnEditar.Visible = state1;
            btnEditar.Enabled = state1;

            // Define se os botões Salvar, Cancelar, Recarregar e seleção de plano estarão ativos
            btnSalvar.Enabled = state2;
            btnCancelar.Enabled = state2;
            cmbPlano.Enabled = state2;

            // Define a visibilidade dos botões Salvar, Cancelar, Recarregar e seleção de plano
            btnSalvar.Visible = state2;
            btnCancelar.Visible = state2;
            cmbPlano.Visible = state2;

        }

        // Ao clicar no botão "Agendamento"
        private void btnAgen_Click(object sender, EventArgs e)
        {
            // Preparando formulario para novo cadastro
            setup(1, false, true);
        }

        // Ao clicar no botão "Fechar"
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ao clicar no botão "Salvar"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Se algum campo obrigatorio estiver vazio
            if (textBoxVazias() == true || MaskedtextBoxVazias() == true)
            {
                // Exibir notificação
                DialogResult confirm = MessageBox.Show("Por favor, preencha todos os campos antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            else
            {
                // Retornando forumalrio para estado original
                setup(0, true, false);

                // Alimentando o objeto agendamento com os dados nos campos 
                agendamento.Plano = new Plano();
                agendamento.IdAluno = aluno.Id;
                agendamento.Data = DateTime.Parse(txtData.Text);
                agendamento.Plano.Id = Convert.ToInt32(cmbPlano.SelectedValue);

                // Executa a função que salva ou atualiza o agendamento no banco de dados
                controllerAge.SalvarAgendamento(agendamento);

                // Preenchendo lista de agendamentos cadsatrados
                Fill(agendamento.Id,txtMes.Text, txtAno.Text); 
            }
        }

        // Ao Selecionar um plano
        private void cmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se houverem planos disponiveis, salvar plano selecionado
            if(cmbPlano.Items.Count > 0)
            {
                // exibir valores do plano selecionado
                string id = Convert.ToString(cmbPlano.SelectedValue);
                Plano plano = controllerPlano.Selectplano(id);

                txtInicio.Text = Convert.ToString(plano.Id);
                txtFim.Text = Convert.ToString(plano.Fim);
                txtValor.Text = Convert.ToString(plano.Valor);
                txtPlano.Text = Convert.ToString(plano.Nome);
            }
        }

        // Ao clicar no botão "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setup(0, true, false);
        }

        // Ao clicar no botão "Deletar"
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            controllerAge.DeletarAgendamento(agendamento);
            Fill(aluno.Id, txtMes.Text, txtAno.Text);
        }

        // Ao clicar no botão "Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            setup(0, false, true);
        }

        // Metodo que preenche a tabela
        // Preenche a tabela com os dados armazenados no banco de dados
        public void Fill(int id, string mes, string ano)
        {
            DataTable consulta = ListarAgendamentos(id, mes, ano);
            AtualizarTabela(consulta);
            EsconderColunasDesnecessarias();
            DeterminarTamanhoColunas();
            SomarValorTotal(consulta);
        }

        // Obtém a lista de agendamentos do controlador
        private DataTable ListarAgendamentos(int id, string mes, string ano)
        {
            return controllerAge.ListarAgendamentos(id, mes, ano);
        }

        // Atualiza a fonte de dados da tabela com uma nova DataTable
        private void AtualizarTabela(DataTable dataTable)
        {
            dtHistorico.DataSource = dataTable;
        }

        // Esconde colunas desnecessárias na tabela
        private void EsconderColunasDesnecessarias()
        {
            dtHistorico.Columns["Id"].Visible = false;
            dtHistorico.Columns["IdAluno"].Visible = false;
            dtHistorico.Columns["IdPlano"].Visible = false;
            dtHistorico.Columns["Id1"].Visible = false;
            dtHistorico.Columns["Nome"].Visible = false;
            dtHistorico.Columns["Inicio"].Visible = false;
            dtHistorico.Columns["Fim"].Visible = false;
            dtHistorico.Columns["Ano"].Visible = false;
        }

        // Define o tamanho das colunas na tabela
        private void DeterminarTamanhoColunas()
        {
            dtHistorico.Columns["Data"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtHistorico.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Soma o valor total dos agendamentos e exibe na caixa de texto
        private void SomarValorTotal(DataTable dataTable)
        {
            double total = controllerAge.SomaTotal(dataTable);
            txtValorTotal.Text = Convert.ToString(total);
        }


        // Ao selecionar uma linha da tabela
        private void dtHistorico_SelectionChanged(object sender, EventArgs e)
        {
            // Preparando campos para seleção
            setup(0, true, false);

            // Se a linha atual não estiver vazia (caso o usuario clique no cabeçalho da tabela)
            if (dtHistorico.CurrentRow != null)
            {
                // Selecionando Aluno
                agendamento.Plano = new Plano();
                agendamento.Id = Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Id"].Value);
                agendamento.IdAluno = Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["IdAluno"].Value);
                agendamento.Data = DateTime.Parse(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Data"].Value.ToString());
                agendamento.Plano = controllerPlano.Selectplano(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Id1"].Value.ToString());

                // Mostrando os dados nos campos
                preencher(agendamento);
            }
        }

        // Ao clicar o botão "Buscar"
        private void btnBusca_Click(object sender, EventArgs e)
        {
            Fill(aluno.Id, txtMes.Text, txtAno.Text);
        }

        private void preencher(Agendamento agendamento)
        {
            // Mostrando os dados nos campos
            txtData.Text = Convert.ToString(agendamento.Data);
            txtInicio.Text = agendamento.Plano.Inicio;
            txtFim.Text = agendamento.Plano.Fim;
            cmbPlano.SelectedValue = agendamento.Plano.Id;
            txtPlano.Text = cmbPlano.SelectedText;
            txtValor.Text = Convert.ToString(agendamento.Plano.Valor);
            txtPlano.Text = agendamento.Plano.Nome;
        }


    }
}
