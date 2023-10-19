using Sistema_almoço_alunos.src.Entities;
using System;
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

        // Ao clicar no conteúdo de uma célula na tabela
        private void dtAlunos_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                // Prepara a interface do usuário para a edição de um novo aluno
                Setup(0, true);
                SelecionarAluno();
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso ocorra alguma exceção
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Ao clicar no botão "Novo"
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Chama a função "setup" para permitir cadastrar um novo aluno
            Setup(1, false);
        }

        // Ao clicar no botão "Detalhes"
        private void btnDetail_Click(object sender, EventArgs e)
        {
            // Cria um novo objeto Gerenciamento para exibir o histórico do aluno
            Gerenciamento ger = new Gerenciamento(aluno);

            // Exibe a janela do objeto Gerenciamento
            ger.Show();
        }

        // Ao clicar no botão "Editar"
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Prepara campos para editar o aluno
            Setup(0, false);
        }

        // Ao clicar no botão "Cancelar" durante a edição ou adição de um aluno
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            // Restaura os campos para o estado anterior
            Setup(0, true);
        }

        // Ao clicar no botão "Salvar"
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
            Setup(0, true);

            // Atualiza a lista com a tabela de alunos
            Fill(txtBusca.Text, cmbFiltro.Text, 1);
        }

        // Ao clicar no botão "Deletar"
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Verifica se o aluno já está inativo
            if (aluno.Status == 0)
            {
                MessageBox.Show("O aluno já está inativo!");
            }

            // Pergunta ao usuário se deseja realmente inativar o aluno
            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja inativar o aluno {aluno.Nome}?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Executa a função para inativar o aluno
                controller.InativarAluno(aluno);
            }

            // Preenche a tabela com os dados atualizados
            Fill(txtBusca.Text, cmbFiltro.Text, 1);
        }

        // Ao clicar no botão "Deletar"
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Pergunta ao usuário se deseja realmente deletar o aluno
            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja deletar o aluno {aluno.Nome}? Isso também excluirá todos os agendamentos relacionados a ele(a).", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Executa a função para deletar o aluno e recarrega a tabela em seguida
                controller.DeletarAluno(aluno);
                Fill(txtBusca.Text, cmbFiltro.Text, 2);
            }
        }

        // Ao clicar no botão "Ativar"
        private void btnAtivar_Click(object sender, EventArgs e)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Verifica se o aluno já está ativo
            if (aluno.Status == 1)
            {
                MessageBox.Show("O aluno já está ativo!");
            }

            // Pergunta ao usuário se deseja realmente ativar o aluno
            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja ativar o aluno {aluno.Nome} novamente?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Executa a função para ativar o aluno e recarrega a tabela em seguida
                controller.AtivarAluno(aluno);
                Fill(txtBusca.Text, cmbFiltro.Text, 2);
            }
        }

        // Ao digitar no campo de busca
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // Preenche a lista de alunos com base no termo de busca e filtros selecionados
            if (rdbAtivo.Checked)
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

        // Impede a digitação de números no campo "Nome"
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.Let(e);
        }

        // Exibe o formulário de relatório
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioGeral rel = new();
            rel.Show();
        }

        // Exibe apenas registros marcados como "Ativo"
        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAtivo.Checked)
            {
                rdbInativo.Checked = false;
                SetupAtivoInativo(false);
                Fill(txtBusca.Text, cmbFiltro.Text, 1);
            }
        }

        // Exibe apenas registros marcados como "Inativo"
        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInativo.Checked)
            {
                rdbAtivo.Checked = false;
                SetupAtivoInativo(true);
                Fill(txtBusca.Text, cmbFiltro.Text, 0);
            }
        }



        //-------------------------Configurações de campos e afins (Alunos)-------------------

        // Função que preenche as tabelas no formulário
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
            dtAlunos.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Exemplo de personalização do título das colunas
            dtAlunos.Columns["Nome"].HeaderText = "Nome do Aluno";
        }

        // Função que esconde colunas que não são relevantes para o usuário
        private void EscondeColunas()
        {
            dtAlunos.Columns["Id"].Visible = false;
            dtAlunos.Columns["Responsavel"].Visible = false;
            dtAlunos.Columns["Telefone"].Visible = false;
            dtAlunos.Columns["Status"].Visible = false;
        }

        // Cria um objeto Aluno com os dados presentes na linha da tabela em que o usuário clicou
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
                aluno.Status = Convert.ToInt32(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Status"].Value);

                // Preencher os campos da interface com os dados do objeto aluno selecionado
                PreencherCampos(aluno);
            }
        }

        // Preenche os campos do formulário com os dados do aluno utilizando o objeto Aluno
        private void PreencherCampos(Aluno aluno)
        {
            txtNome.Text = aluno.Nome;
            txtResponsavel.Text = aluno.Responsavel;
            txtTelefone.Text = aluno.Telefone;
            txtTurma.Text = aluno.Turma;
        }

        // Alimenta as comboboxes com as opções
        private void ConfigurarComboBoxes()
        {
            Utilidades util = new Utilidades();
            cmbSerieTurma.DataSource = util.ListaSerie();
            cmbNomeTurma.DataSource = util.ListaAlfabeto();
            cmbEnsinoTurma.DataSource = util.ListaEnsino();
            cmbTurnoTurma.DataSource = util.ListaTurnos();
            cmbFiltro.DataSource = util.ListaFiltro();
        }


        //=========================Preparação de campos nas abas=====================

        // Configura campos e botões para cadastro ou edição de um novo aluno
        private void Setup(int signal, bool state)
        {
            // Se o sinal for igual a 1, limpa os campos para cadastrar um novo aluno
            if (signal == 1)
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
            lblNomeTurma.Visible = !state;
            lblSerie.Visible = !state;
            lblEnsino.Visible = !state;
            lblTurno.Visible = !state;

            // Define o estado dos campos para leitura ou escrita
            txtNome.ReadOnly = state;
            txtResponsavel.ReadOnly = state;
            txtTelefone.ReadOnly = state;
            cmbNomeTurma.Enabled = !state;
            cmbSerieTurma.Enabled = !state;
            cmbEnsinoTurma.Enabled = !state;
            cmbTurnoTurma.Enabled = !state;

            // Define a visibilidade dos campos relacionados à turma
            txtTurma.ReadOnly = state;
            txtTurma.Visible = state;

            // Define a visibilidade das combobox relacionadas à turma
            cmbNomeTurma.Visible = !state;
            cmbSerieTurma.Visible = !state;
            cmbEnsinoTurma.Visible = !state;
            cmbTurnoTurma.Visible = !state;

            // Define a visibilidade dos botões Editar e Detalhe
            btnEditar.Visible = state;
            btnDetail.Visible = state;

            // Define se os botões Editar e Detalhe estarão habilitados
            btnDetail.Enabled = state;
            btnEditar.Enabled = state;

            // Define a visibilidade dos botões Salvar e Cancelar e se eles estarão habilitados
            btnSalvarEdit.Enabled = !state;
            btnCancelEdit.Enabled = !state;
            btnSalvarEdit.Visible = !state;
            btnCancelEdit.Visible = !state;
        }

        // Configura os botões dependendo se a tabela mostra alunos ativos ou inativos
        private void SetupAtivoInativo(bool state)
        {
            btnCancelEdit.Enabled = !state;
            btnDesativar.Enabled = !state;
            btnEditar.Enabled = !state;
            btnSalvarEdit.Enabled = !state;

            btnCancelEdit.Visible = !state;
            btnDesativar.Visible = !state;
            btnEditar.Visible = !state;
            btnSalvarEdit.Visible = !state;

            btnAtivar.Enabled = state;
            btnDeletar.Enabled = state;
            btnAtivar.Visible = state;
            btnDeletar.Visible = state;
        }


    }
}
