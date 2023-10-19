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

                agendamento.IdAluno = aluno.Id;

                // Preenchendo a lista de agendamentos feitos pelo aluno
                Fill(aluno.Id, txtMes.Text, txtAno.Text,1);
                FillPlanos(txtBuscaPlano.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        //----------------------------Interações do usuario-------------------

        // Ao clicar no botão "Agendamento"
        private void btnAgen_Click(object sender, EventArgs e)
        {
            // Preparando formulario para novo cadastro
            Setup(1, false);
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
            if (TextBoxesVazias() == true || MaskedTextBoxesVazias() == true)
            {
                // Exibir notificação
                DialogResult confirm = MessageBox.Show("Por favor, preencha todos os campos antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            else
            {
                // Retornando forumalrio para estado original
                Setup(0, true);

                // Alimentando o objeto agendamento com os dados nos campos 
                agendamento.Plano = new Plano();
                agendamento.IdAluno = aluno.Id;
                agendamento.Data = DateTime.Parse(txtData.Text);
                agendamento.Plano.Id = Convert.ToInt32(cmbPlano.SelectedValue);

                // Executa a função que salva ou atualiza o agendamento no banco de dados
                controllerAge.SalvarAgendamento(agendamento);

                // Preenchendo lista de agendamentos cadsatrados
                Fill(aluno.Id, txtMes.Text, txtAno.Text, 1);
            }
        }

        // Ao Selecionar um plano
        private void cmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se houverem planos disponiveis, salvar plano selecionado
            if (cmbPlano.Items.Count > 0)
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
            Setup(0, true);
        }

        // Ao clicar no botão "Deletar"
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se um agendamento está selecionado
            if (agendamento != null)
            {
                // Exibe uma caixa de diálogo de confirmação para o usuário
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verifica se o usuário confirmou a exclusão
                if (result == DialogResult.Yes)
                {
                    // Chama o método que deleta o agendamento do banco de dados
                    controllerAge.DeletarAgendamento(agendamento);

                    // Atualiza a exibição dos agendamentos
                    Fill(aluno.Id, txtMes.Text, txtAno.Text, 1);
                }
            }
            else
            {
                MessageBox.Show("Nenhum agendamento selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Ao clicar no botão "Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Setup(0, false);
        }

        // Ao selecionar uma linha da tabela
        private void dtHistorico_SelectionChanged(object sender, EventArgs e)
        {
            // Preparando campos para seleção
            Setup(0, true);

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

        // Ao pesquisar um agendamento
        private void txtBuscaAgendamento_TextChanged(object sender, EventArgs e)
        {
            Fill(aluno.Id, txtMes.Text, txtAno.Text, 1);
        }


        //-------------------------Configurações de campos e afins (Planos)-------------------

        // Método que preenche a tabela
        // Preenche a tabela com os dados armazenados no banco de dados
        public void Fill(int id, string mes, string ano, int status)
        {
            DataTable consulta = ListarAgendamentos(id, mes, ano, status);
            dtHistorico.DataSource = consulta;
            EsconderColunasDesnecessarias();
            DeterminarTamanhoColunas();
            SomarValorTotal(consulta);

            DataTable consulta2 = controllerPlano.ListaPlanos("");

            cmbPlano.DataSource = consulta2;
            cmbPlano.DisplayMember = "Nome";
            cmbPlano.ValueMember = "Id";
        }


        // Obtém a lista de agendamentos do controlador
        private DataTable ListarAgendamentos(int id, string mes, string ano, int status)
        {
            return controllerAge.ListarAgendamentos(id, mes, ano, status);
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

        // Método para verificar se existem campos vazios
        private bool TextBoxesVazias()
        {
            // Itera por cada controle no formulário
            foreach (Control c in this.Controls)
            {
                // Verifica se o controle é uma caixa de texto e se não é um dos campos que não precisa ser validado
                if (c is TextBox textBox && c != txtMes && c != txtValorTotal && c != txtPlano)
                {
                    // Se for uma caixa de texto que precisa ser validada, verifica se está vazia
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        // Se estiver vazia, retorna verdadeiro indicando que há campos vazios
                        return true;
                    }
                }
            }

            // Se todas as caixas de texto obrigatórias estiverem preenchidas, retorna falso
            return false;
        }

        // Este método faz o mesmo que o método TextBoxesVazias, mas com caixas de texto que utilizam máscara
        private bool MaskedTextBoxesVazias()
        {
            foreach (Control c in this.Controls)
            {
                // Verifica se o controle é uma caixa de texto com máscara e se não é um dos campos que não precisa ser validado
                if (c is MaskedTextBox maskedTextBox && c != txtMes && c != txtAno)
                {
                    // Verifica se a caixa de texto com máscara está vazia ou se contém apenas a máscara
                    if (string.IsNullOrWhiteSpace(maskedTextBox.Text) || maskedTextBox.Text == "  /  /" || maskedTextBox.Text == "  :")
                    {
                        // Se estiver vazia ou contiver apenas a máscara, retorna verdadeiro indicando que há campos vazios
                        return true;
                    }
                }
            }

            // Se todas as caixas de texto com máscara obrigatórias estiverem preenchidas, retorna falso
            return false;
        }
      
        //-------------------------Configurações de campos e afins (Planos)-------------------

        // Preenche a tabela de planos
        public void FillPlanos(string dado)
        {
            DataTable consulta = controllerPlano.ListaPlanos(dado);
            ConfigurarColunasTabelaPlanos();
            PreencherTabelaPlanos(consulta);
        }

        // Configura as colunas da tabela de planos
        private void ConfigurarColunasTabelaPlanos()
        {
            if (dtPlanos.Rows.Count > 0)
            {
                dtPlanos.Columns["Id"].Visible = false;
                dtPlanos.Columns["Inicio"].Visible = false;
                dtPlanos.Columns["Fim"].Visible = false;
                dtPlanos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtPlanos.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // Preenche a tabela de planos com os dados da consulta
        private void PreencherTabelaPlanos(DataTable consulta)
        {
            dtPlanos.DataSource = consulta;
            dtPlanos.Refresh();
        }

        private void AtribuirValoresAoPlano()
        {
            // Obtém os valores das células da linha selecionada na tabela
            plano.Id = Convert.ToInt32(dtPlanos.CurrentRow.Cells["Id"].Value);
            plano.Nome = Convert.ToString(dtPlanos.CurrentRow.Cells["Nome"].Value);
            plano.Valor = Convert.ToDouble(dtPlanos.CurrentRow.Cells["Valor"].Value);
            // Obtém os valores das células "Inicio" e "Fim" da linha selecionada na tabela
            // e converte para formato de hora (HH:mm)
            plano.Inicio = Convert.ToDateTime(dtPlanos.CurrentRow.Cells["Inicio"].Value).ToString("HH:mm");
            plano.Fim = Convert.ToDateTime(dtPlanos.CurrentRow.Cells["Fim"].Value).ToString("HH:mm");
        }

        private void PreencherCamposComPlano()
        {
            // Preenche os campos da tela com os valores do objeto "plano"
            txtNomePlano.Text = plano.Nome;
            mskInicio.Text = plano.Inicio;
            mskFim.Text = plano.Fim;
            // Converte o valor do atributo "Valor" para formato monetário (R$)
            txtValorPlano.Text = plano.Valor.ToString("C2");
        }

        //-------------------Aba Gerenciar Planos-------------------------

        private void btnSalvarPlano_Click(object sender, EventArgs e)
        {
            // Salvando novo plano com os dados fornecidos
            plano.Nome = txtNomePlano.Text;
            plano.Valor = Convert.ToDouble(txtValorPlano.Text);
            plano.Inicio = mskInicio.Text;
            plano.Fim = mskFim.Text;

            controllerPlano.salvar(plano);

            // Preenchendo a lista de planos disponiveis
            FillPlanos(txtBuscaPlano.Text);
        }

        // Define o comportamento do botão de cancelamento de plano
        private void btnCancelarPlano_Click(object sender, EventArgs e)
        {
            // Configura o estado do formulário para edição de plano
            setupPl(0, true);
        }

        // Define o comportamento do botão de edição de plano
        private void btnEditarPlano_Click(object sender, EventArgs e)
        {
            // Configura o estado do formulário para edição de plano
            setupPl(0, false);
        }

        private void dtPlanos_SelectionChanged(object sender, EventArgs e)
        {
            // Chamando o método "setupPl" para preparar os campos
            setupPl(0, true);

            try
            {
                // Verificando se a linha atual não é nula
                if (dtPlanos.CurrentRow != null)
                {
                    // Atribuindo os valores das colunas da linha atual aos atributos do objeto "plano"
                    AtribuirValoresAoPlano();

                    // Atribuindo os valores dos atributos do objeto "plano" aos campos correspondentes na tela
                    PreencherCamposComPlano();

                    // Verificando se o atributo "id" do objeto "plano" é maior que zero
                    // e preparando os campos se necessário
                    if (plano.Id > 0)
                    {
                        setupPl(0, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnNovoPlano_Click(object sender, EventArgs e)
        {
            // Preparando os campos para um novo cadastro
            setupPl(1, false);
        }

        private void btnDeletarPlano_Click(object sender, EventArgs e)
        {
            // Chamando o metodo para deletar o plano selecionado
            controllerPlano.deletarPlano(plano.Id);
            // Preenchendo tabela de planos novamente
            FillPlanos(txtBuscaPlano.Text);
        }

        // Preenche a tabela de turmas com os dados filtrados a partir do texto inserido no campo de busca
        private void txtBuscaPlano_TextChanged(object sender, EventArgs e)
        {
            FillPlanos(txtBuscaPlano.Text);
        }

        //=========================Preparação de campos nas abas=====================

        // Método para preparar os campos para um cadastro ou edição
        private void Setup(int signal, bool state)
        {
            // Se o sinal for igual a 1, então um novo agendamento está sendo cadastrado
            if (signal == 1)
            {
                agendamento.Id = 0;
                txtData.Text = null;
                txtInicio.Text = null;
                txtFim.Text = null;
                txtValor.Text = null;
                cmbPlano.Text = null;
            }

            // Define o estado dos campos
            txtData.ReadOnly = state;
            txtInicio.ReadOnly = state;
            txtFim.ReadOnly = state;
            txtValor.ReadOnly = state;

            // Bloqueia e esconde o textbox de plano
            txtPlano.ReadOnly = state;
            txtPlano.Visible = state;

            // Define a visibilidade dos botões Editar e Deletar
            btnEditar.Visible = state;
            btnEditar.Enabled = state;
            btnDeletar.Visible = state;
            btnDeletar.Enabled = state;

            // Define se os botões Salvar, Cancelar e a seleção de plano estarão ativos
            btnSalvar.Enabled = !state;
            btnCancelar.Enabled = !state;
            cmbPlano.Enabled = !state;

            // Define a visibilidade dos botões Salvar, Cancelar e a seleção de plano
            btnSalvar.Visible = !state;
            cmbPlano.Visible = !state;
            btnCancelar.Visible = !state;
        }


        // Configura o estado do formulário para edição de plano
        private void setupPl(int sinal, bool state)
        {
            // Se o sinal for igual a 1, um novo plano está sendo cadastrado
            if (sinal == 1)
            {
                // Limpa os campos de entrada de dados
                plano.Id = 0;
                txtNomePlano.Text = null;
                mskInicio.Text = null;
                mskFim.Text = null;
                txtValorPlano.Text = null;
            }

            // Configura o estado de leitura dos campos de entrada de dados
            txtNomePlano.ReadOnly = state;
            txtValorPlano.ReadOnly = state;
            mskInicio.ReadOnly = state;
            mskFim.ReadOnly = state;

            // Configura a visibilidade dos botões Editar e Detalhe
            btnEditarPlano.Visible = state;
            btnDeletarPlano.Visible = state;

            // Configura o estado dos botões Editar e Detalhe
            btnEditarPlano.Enabled = state;
            btnDeletarPlano.Enabled = state;

            // Configura o estado dos botões Salvar e Cancelar
            btnSalvarPlano.Enabled = !state;
            btnCancelarPlano.Enabled = !state;

            // Configura a visibilidade dos botões Salvar e Cancelar
            btnSalvarPlano.Visible = !state;
            btnCancelarPlano.Visible = !state;
        }


    }
}
