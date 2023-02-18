using Sistema_almoço_alunos.src.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Utils;
using Sistema_almoço_alunos.src.UI;
using Sistema_almoço_alunos.src.Controllers;

namespace Sistema_almoço_alunos
{
    public partial class CadAluno : Form
    {
        // instanciando classes necessarias

        Aluno aluno = new();

        ControllerStu controller = new();

        Utilidades util = new();

        public CadAluno()
        {
            // inicializando a janela
            InitializeComponent();

            // Tentando preencher a janela
            try
            {
                // Alimentando Combobox de filtro de busca
                List<string> filtro = util.listFiltro();

                cbfiltro.DataSource = filtro;

                //Preenchendo lista de alunos
                Fill(txtBusca.Text, cbfiltro.Text);

            }
            // Se não conseguir, mostrar o motivo
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
                            
        }

        private void dtAlunos_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                // Preparando campos para seleção
                setup(0, true, false);
                if (dtAlunos.CurrentRow != null)
                {
                    // Selecionando Aluno
                    aluno.setid(Convert.ToInt32(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Id"].Value));
                    aluno.setnome(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Nome"].Value));
                    aluno.setresponsavel(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Responsavel"].Value));
                    aluno.settelefone(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Telefone"].Value));
                    aluno.setTurma(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Turma"].Value));

                    // Mostrando os dados nos campos
                    txtNome.Text = aluno.getnome();
                    txtResponsavel.Text = aluno.getresponsavel();
                    txtTelefone.Text = aluno.gettelefone();
                    txtTurma.Text = aluno.getTurma();
                }
                else
                {
                    // Esvaziar campos se nenhum aluno estiver selecionado
                    txtNome.Text = "";
                    txtResponsavel.Text ="";
                    txtTelefone.Text = "";
                    txtTurma.Text ="";

                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Desbloqueando campos para
            // permitir cadastro de novo Aluno
            setup(1, false, true);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            // Estabelecendo tela de Historico e exibindo
            Historico det = new(aluno);
            det.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fecha o formulario
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preparando campos para editar o aluno
            setup(0, false, true);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            //Retornando campos para o estado anterior
            setup(0, true, false);
        }

        private void btnSalvarEdit_Click(object sender, EventArgs e)
        {
            // Se algum campo estiver fazio, interromper processo e avisar
            // Usuario
            if (textBoxVazias() == true)
            {
                MessageBox.Show("Por favor, forneça o nome e a turma do aluno antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            // Se não, prosseguir com cadastro do aluno
            else
            {
                setup(0, true, false);
                
                // Alimentando o objeto aluno com os dados nos campos 
                aluno.setnome(txtNome.Text);
                aluno.setresponsavel(txtResponsavel.Text);
                aluno.setTurma(txtTurma.Text);
                aluno.settelefone(txtTelefone.Text);

                // Executa a função que salva ou atualiza o aluno no banco de dados
                controller.SalvarAluno(aluno);

                // Preencher a lista novamente, desta vez com o novo aluno cadastrado
                Fill(txtBusca.Text, cbfiltro.Text);
                dtAlunos.Columns["Id"].Visible = false;
                dtAlunos.Columns["Responsavel"].Visible = false;
                dtAlunos.Columns["Telefone"].Visible = false;
            };

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Executa a função para deletar o aluno
            controller.DeletarAluno(aluno);
            Fill(txtBusca.Text, cbfiltro.Text);
            

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //Preenchendo lista de alunos de acordo com a busca
            Fill(txtBusca.Text, cbfiltro.Text);
            dtAlunos.Columns["Id"].Visible = false;
            dtAlunos.Columns["Responsavel"].Visible = false;
            dtAlunos.Columns["Telefone"].Visible = false;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Executa função que só permite escrever numeros no campo
            Program.Num(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Executa função que não permite digitar numeros
            Program.Let(e);
        }

        private void setup(int sinal, bool state1, bool state2)
        {
            // Se o sinal for igual a 1, então um novo aluno esta sendo cadastrado
           if(sinal == 1)
            {
                aluno.setid(0);
                txtNome.Text = null;
                txtResponsavel.Text = null;
                txtTelefone.Text = null;
                txtTurma.Text = null;
            }
            
            // Define o estado dos campos
            txtNome.ReadOnly = state1;
            txtResponsavel.ReadOnly = state1;
            txtTelefone.ReadOnly = state1;
            txtTurma.ReadOnly = state1;

            // Define a visibilidade dos botões Editar e Detalhe
            btnEditar.Visible = state1;
            btnDetail.Visible = state1;
            // Define se os botões Editar e detalhe estarão ativos
            btnDetail.Enabled = state1;
            btnEditar.Enabled = state1;

            // Define a visibilidade dos botões Salvar e Cancelar estarão ativos
            btnSalvarEdit.Enabled = state2;
            btnCancelEdit.Enabled = state2;
            // Define a visibilidade d os botões Salvar e Cancelar
            btnSalvarEdit.Visible = state2;
            btnCancelEdit.Visible = state2;
        }

        private bool textBoxVazias()
        {
            // Para cada campo no formulario
            foreach (Control c in this.Controls)
                // Verifica se é uma text box e se não é o campo de busca
                if (c is TextBox && c != txtBusca && c != txtResponsavel)
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

        public void Fill(string dado, string filtro)
        {
            // Preenchendo a tabela com os dados no banco
            // Se algum dado foi fornecido pela busca, listar alunos baseado no dado
            dtAlunos.DataSource = controller.listAlunos(dado, filtro);

            // Determina o tamanho das colunas na tabela
            dtAlunos.Columns["Id"].HeaderText = "Id";
            dtAlunos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Nome"].HeaderText = "Nome";
            dtAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Responsavel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Turma"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Escondendo colunas desnecessarias para o usuario
            dtAlunos.Columns["Id"].Visible = false;
            dtAlunos.Columns["Responsavel"].Visible = false;
            dtAlunos.Columns["Telefone"].Visible = false;


            // Recarregando a tabela para garantir
            dtAlunos.Refresh();

        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            PlanoCad planoCad = new();

            // Abrir formulario de cadstro de planos
            planoCad.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioGeral rel= new();

            // Abrir formulario com relatorio geral
            rel.Show();
        }
    }
}
