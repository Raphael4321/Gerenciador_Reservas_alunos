using Sistema_almoço_alunos.src.Entities;
using System;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Utils;
using Sistema_almoço_alunos.src.UI;
using Sistema_almoço_alunos.src.Controllers;
using System.Data;

namespace Sistema_almoço_alunos
{
    public partial class CadAluno : Form
    {
        // instanciando classes necessarias

        Aluno aluno = new();

        AlunoController controller = new();

        public CadAluno()
        {
            InitializeComponent();
            try
            {
                ConfigurarComboBoxes();
                PreencherTabelas();
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Ao clicar no conteudo de uma celular na tabela
        private void dtAlunos_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                // Preparar a interface do usuário para a edição de um novo aluno
                setup(0, true, false);
                SelecionarAluno();
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro caso ocorra alguma exceção
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Ao clicar no botão "Novo"
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Chama a função "setup" para permitir cadastro de novo aluno
            setup(1, false, true);
        }

        // Ao clicar no botão "Detalhes"
        private void btnDetail_Click(object sender, EventArgs e)
        {
            // Cria um novo objeto Gerenciamento para exibir o histórico do aluno
            Gerenciamento ger = new(aluno);

            // Exibe a janela do objeto Gerenciamento
            ger.Show();
        }

        // Ao clicar no botão "Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Prepara campos para editar o aluno
            setup(0, false, true);
        }

        // Ao clicar no botão cancelar quando estiver editando ou adicionando um aluno
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            // Retorna campos para o estado anterior
            setup(0, true, false);
        }

        // Ao clicar no botão "salvar"
        private void btnSalvarEdit_Click(object sender, EventArgs e)
        {
            // Verifica se o campo de nome do aluno está vazio
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Por favor, preencha o nome do aluno antes de salvar", "Incluir/Editar Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifica se algum campo de turma está vazio
            if (string.IsNullOrEmpty(cmbSerieTurma.Text) || string.IsNullOrEmpty(cmbNomeTurma.Text) || string.IsNullOrEmpty(cmbEnsinoTurma.Text) || string.IsNullOrEmpty(cmbTurnoTurma.Text))
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Por favor, preencha todos os campos de turma do aluno antes de salvar", "Incluir/Editar Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Preenche o objeto aluno com os dados dos campos
            aluno.Nome = txtNome.Text;
            aluno.Responsavel = txtResponsavel.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.Turma = cmbSerieTurma.Text + cmbNomeTurma.Text + " - " + cmbEnsinoTurma.Text + " - " + cmbTurnoTurma.Text;

            // Chama o método SalvarAluno do controller
            controller.SalvarAluno(aluno);

            // Restaura os campos para o estado original
            setup(0, true, false);

            // Atualiza a lista com a tabela de alunos
            Fill(txtBusca.Text, cmbFiltro.Text, 1);
        }

        // Ao clicar no botão "Deletar"
        private void btnDel_Click(object sender, EventArgs e)
        {
            // Executa a função para inativar o aluno
            controller.InativarAluno(aluno);

            // Preencher a tabela com os dados atualizados
            Fill(txtBusca.Text, cmbFiltro.Text, 1);
        }


        // Ao digitar no campo de busca
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
             
            // Preenche a lista de alunos com base no termo de busca e filtros selecionados
            
            if(rdbAtivo.Checked)
            {
                Fill(txtBusca.Text, cmbFiltro.Text, 1);
            }

            if (rdbInativo.Checked)
            {
                Fill(txtBusca.Text, cmbFiltro.Text, 2);
            }

            
        }

        // Ao digitar no campo "Telefone"
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite somente a digitação de números no campo de telefone
            Program.Num(e);
        }

        // Impede a digitação de números no campo "Nome".
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.Let(e);
        }

        // Exibe o formulário de relatório.
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioGeral rel = new();
            rel.Show();
        }

        // Exibe apenas registros marcados como "Ativo".
        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAtivo.Checked)
            {
                rdbInativo.Checked = false;
                Fill(txtBusca.Text, cmbFiltro.Text, 1);
            }
        }

        // Exibe apenas registros marcados como "Inativo".
        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInativo.Checked)
            {
                rdbAtivo.Checked = false;
                Fill(txtBusca.Text, cmbFiltro.Text, 0);
            }
        }


        //-------------------------Configurações de campos e afins (Alunos)-------------------

        // Função que preenche as tabelas no formulario
        private void PreencherTabelas()
        {
            Fill(txtBusca.Text, cmbFiltro.Text, 1);
        }

        // Função que preenche a tabela com os dados armazenados no banco de dados
        public void Fill(string dado, string Filtro, int Ativo)
        {
            // Obter lista de alunos do controlador e preencher a tabela com ela
            dtAlunos.DataSource = controller.ListarAlunos(dado, Filtro, Ativo);

            DefineColunas();

            EscondeColunas();

            // Recarregar a tabela para garantir que as mudanças sejam exibidas
            dtAlunos.Refresh();
        }

        // Função que define a largura e títulos das colunas
        private void DefineColunas()
        {
            dtAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Turma"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        // Função que esconde colunas que não são relevantes para o usuário
        private void EscondeColunas()
        {
            dtAlunos.Columns["Id"].Visible = false;
            dtAlunos.Columns["Responsavel"].Visible = false;
            dtAlunos.Columns["Telefone"].Visible = false;
            dtAlunos.Columns["Ativo"].Visible = false;
        }

        // Cria um objeto Aluno com os dados presentes na linha da tabela em que o usuario
        // clicou
        private void SelecionarAluno()
        {
            // Verificar se uma linha da tabela de alunos está selecionada
            if (dtAlunos.CurrentRow != null)
            {
                // Obter o objeto aluno selecionado
                aluno.Id = Convert.ToInt32(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Id"].Value);
                aluno.Nome = Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Nome"].Value);
                aluno.Responsavel = Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Responsavel"].Value);
                aluno.Telefone = Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Telefone"].Value);
                aluno.Turma = Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Turma"].Value);
                aluno.Status = Convert.ToInt32(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Ativo"].Value);

                // Preencher os campos da interface com os dados do objeto aluno selecionado
                preencher(aluno);
            }
        }

        // Preenche os campos do formulário com os dados do aluno utilizando o objeto Aluno
        private void preencher(Aluno aluno)
        {        
            txtNome.Text = aluno.Nome;
            txtResponsavel.Text = aluno.Responsavel;
            txtTelefone.Text = aluno.Telefone;
            txtTurma.Text = aluno.Turma;
          
        }

        // Alimenta as comboboxes com as opções
        private void ConfigurarComboBoxes()
        {
            Utilidades util = new();
            cmbSerieTurma.DataSource = util.ListaSerie();
            cmbNomeTurma.DataSource = util.ListaAlfabeto();
            cmbEnsinoTurma.DataSource = util.ListaEnsino();
            cmbTurnoTurma.DataSource = util.ListaTurnos();
            cmbFiltro.DataSource = util.ListaFiltro();
        }

        //=========================Preparação de campos nas abas=====================

        // Configura campos e botões para cadastro ou edição de um novo aluno
        private void setup(int sinal, bool state1, bool state2)
        {
            // Se sinal for igual a 1, limpa os campos para cadastrar um novo aluno
            if (sinal == 1)
            {
                aluno.Id = 0;
                txtNome.Text = null;
                txtResponsavel.Text = null;
                txtTelefone.Text = null;
                cmbNomeTurma.Text = null;
                cmbSerieTurma.Text = null;
                cmbEnsinoTurma.Text = null;
                cmbTurnoTurma.Text = null;
            }

            // Define a visibilidade das etiquetas para turma
            lblNomeTurma.Visible = state2;
            lblSerie.Visible = state2;
            lblEnsino.Visible = state2;
            lblTurno.Visible = state2;

            // Define o estado dos campos para leitura ou escrita
            txtNome.ReadOnly = state1;
            txtResponsavel.ReadOnly = state1;
            txtTelefone.ReadOnly = state1;
            cmbNomeTurma.Enabled = state2;
            cmbSerieTurma.Enabled = state2;
            cmbEnsinoTurma.Enabled = state2;
            cmbTurnoTurma.Enabled = state2;

            // Define a visibilidade dos campos relacionados à turma
            txtTurma.ReadOnly = state1;
            txtTurma.Visible = state1;

            // Define a visibilidade das combobox relacionadas à turma
            cmbNomeTurma.Visible = state2;
            cmbSerieTurma.Visible = state2;
            cmbEnsinoTurma.Visible = state2;
            cmbTurnoTurma.Visible = state2;

            // Define a visibilidade dos botões Editar e Detalhe
            btnEditar.Visible = state1;
            btnDetail.Visible = state1;

            // Define se os botões Editar e detalhe estarão habilitados
            btnDetail.Enabled = state1;
            btnEditar.Enabled = state1;

            // Define a visibilidade dos botões Salvar e Cancelar e se eles estarão habilitados
            btnSalvarEdit.Enabled = state2;
            btnCancelEdit.Enabled = state2;
            btnSalvarEdit.Visible = state2;
            btnCancelEdit.Visible = state2;
        }
    }
}
