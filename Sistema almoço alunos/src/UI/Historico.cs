using Sistema_almoço_alunos.src.Controllers;
using Sistema_almoço_alunos.src.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.UI
{
    public partial class Historico : Form
    {

        Agendamento agendamento = new();

        DataTable dt = new();

        ControllerAge controllerAge = new();

        ControllerPlano controllerPlano = new();

        Aluno aluno = new();

        public Historico(Aluno aluno)
        {
            InitializeComponent();

            //tentando preencher a janela
            try
            {
                this.aluno = aluno;

                agendamento.setidAluno(aluno.getid());

                // Alimentando a combobox com os planos cadastrados
                dt = controllerPlano.ListaPlanos();
                cmbPlano.DataSource = dt;
                cmbPlano.DisplayMember = "Nome";
                cmbPlano.ValueMember = "Id";

                // Preenchendo a lista de agendamentos feitos pelo aluno
                Fill(aluno.getid(), txtMes.Text, txtAno.Text) ;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnAgen_Click(object sender, EventArgs e)
        {
            // Preparando formulario para novo cadastro
            setup(1, false, true);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxVazias() == true || MaskedtextBoxVazias() == true)
            {
                DialogResult confirm = MessageBox.Show("Por favor, preencha todos os campos antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            else
            {
                // Retornando forumalrio para estado original e salvando novo agendamento
                setup(0, true, false);

                agendamento.plano = new Plano();
                agendamento.setidAluno(aluno.getid());
                agendamento.setdata(DateTime.Parse(txtData.Text));
                agendamento.plano.setid(Convert.ToInt32(cmbPlano.SelectedValue));
                controllerAge.salvarAgendamento(agendamento);

                // Preenchendo lista de agendamentos cadsatrados
                Fill(agendamento.getidAluno(),txtMes.Text, txtAno.Text); 
            }
        }

        private void cmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se houverem planos disponiveis, pegar o plano selecionado e exibir seu valor abaixo
            if(cmbPlano.Items.Count > 0)
            {
                string id = Convert.ToString(cmbPlano.SelectedValue);
                Plano plano = controllerPlano.Selectplano(id);

                txtInicio.Text = Convert.ToString(plano.getInicio());

                txtFim.Text = Convert.ToString(plano.getFim());

                txtValor.Text = Convert.ToString(plano.getvalor());

                txtPlano.Text = Convert.ToString(plano.getnome());
            }
        }

        private void btnAdcPl_Click(object sender, EventArgs e)
        {
           // Abrir janela para cadastrar um novo plano
            PlanoCad planoCad = new();

            planoCad.Show();
        }

        private bool textBoxVazias()
        {
            // Para cada campo no formulario
            foreach (Control c in this.Controls)
                // Verifica se é uma text box e se não é o campo de busca
                if (c is TextBox && c!=txtMes && c != txtValorTotal && c!=txtPlano)
                {
                    // Se não for o campo de busca e for uma text box,
                    // verifica se está vazia e avisa se houver um campo se quer
                    // que esteja
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }

            // Também avisa se não á nenhuma text box vazia
            return false;
        }

        // Este metodo faz o memso que o metodo anterior, mas
        // com text boxes que utilizam mascara
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

        private void setup(int sinal, bool state1, bool state2)
        {
            // Se o sinal for igual a 1, então um novo agendamento esta sendo cadastrado
            if (sinal == 1)
            {
                agendamento.setid(0);
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
            btnRecarregar.Enabled = state2;
            // Define a visibilidade dos botões Salvar, Cancelar, Recarregar e seleção de plano
            btnSalvar.Visible = state2;
            btnCancelar.Visible = state2;
            cmbPlano.Visible = state2;
            btnRecarregar.Visible = state2;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setup(0, true, false);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            controllerAge.DeletarAgendamento(agendamento);
            Fill(aluno.getid(), txtMes.Text, txtAno.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            setup(0, false, true);
        }

        public void Fill(int id, string mes, string ano)
        {
            DataTable consulta = new();

            // preenchendo a tabela com os dados no banco
             consulta = controllerAge.ListarAgendamentos(id, mes, ano);

            dtHistorico.DataSource = consulta;

            dtHistorico.Columns["Id"].Visible = false;
            dtHistorico.Columns["IdAluno"].Visible = false;
            dtHistorico.Columns["IdPlano"].Visible = false;
            dtHistorico.Columns["Id1"].Visible = false;
            dtHistorico.Columns["Nome"].Visible = false;
            dtHistorico.Columns["Inicio"].Visible = false;
            dtHistorico.Columns["Fim"].Visible = false;
            dtHistorico.Columns["Ano"].Visible = false;

            // determina o tamanho das colunas na tabela
            dtHistorico.Columns["Data"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtHistorico.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            double total = controllerAge.SomaTotal(consulta);

            txtValorTotal.Text = Convert.ToString(total);
            // recarregando a tabela para garantir
            dtHistorico.Refresh();
        }

        private void dtHistorico_SelectionChanged(object sender, EventArgs e)
        {
            setup(0, true, false);
            if (dtHistorico.CurrentRow != null)
            {
                agendamento.plano = new Plano();
                agendamento.setid(Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Id"].Value));
                agendamento.setidAluno(Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["IdAluno"].Value));
                agendamento.setdata(DateTime.Parse(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Data"].Value.ToString()));
                agendamento.plano = controllerPlano.Selectplano(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Id1"].Value.ToString());

                txtPlano.Text = cmbPlano.SelectedText;
                txtData.Text = Convert.ToString(agendamento.getdata());
                txtInicio.Text = agendamento.plano.getInicio();
                txtFim.Text = agendamento.plano.getFim();
                cmbPlano.SelectedValue = agendamento.plano.getid();
                txtValor.Text = Convert.ToString(agendamento.plano.getvalor());
                txtPlano.Text = agendamento.plano.getnome();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Fill(aluno.getid(), txtMes.Text, txtAno.Text);
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            dt = controllerPlano.ListaPlanos();
            cmbPlano.DataSource = dt;
            cmbPlano.DisplayMember = "Nome";
            cmbPlano.ValueMember = "Id";
        }
    }
}
