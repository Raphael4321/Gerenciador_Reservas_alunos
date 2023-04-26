using Sistema_almoço_alunos.src.Entities;
using System;
using System.Collections.Generic;
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
        Plano plano = new();

        AlunoController controller = new();
        PlanoController controllerPlano = new();
        TurmaController controllerTurma = new();

        Utilidades util = new();
        public CadAluno()
        {
            InitializeComponent();
            try
            {
                ConfigurarComboBoxFiltro();
                PreencherListaAlunos();
                PreencherListaPlanos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void ConfigurarComboBoxFiltro()
        {
            cbfiltro.DataSource = util.listFiltro();
        }

        private void PreencherListaAlunos()
        {
            Fill(txtBusca.Text, cbfiltro.Text);
        }

        private void PreencherListaPlanos()
        {
            FillPlanos(txtBuscaPlano.Text);
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

                // Preencher os campos da interface com os dados do objeto aluno selecionado
                preencher(aluno);
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

        // Ao clicar no botão "Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fecha a janela
            this.Close();
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
            // Verifica se algum campo obrigatório está vazio
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtTurma.Text))
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Por favor, preencha o nome e a turma do aluno antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Preenche o objeto aluno com os dados dos campos
            aluno.Nome = txtNome.Text;
            aluno.Responsavel = txtResponsavel.Text;
            aluno.Turma = txtTurma.Text;
            aluno.Telefone = txtTelefone.Text;

            // Salva ou atualiza o aluno no banco de dados
            controller.SalvarAluno(aluno);

            // Restaura os campos para o estado original
            setup(0, true, false);

            // Atualiza a lista com a tabela de alunos
            Fill(txtBusca.Text, cbfiltro.Text);
        }


        // Ao clicar no botão "Deletar"
        private void btnDel_Click(object sender, EventArgs e)
        {
            // Executa a função para deletar o aluno
            controller.DeletarAluno(aluno);

            // Preencher a tabela com os dados atualizados
            Fill(txtBusca.Text, cbfiltro.Text);
        }

        // Ao digitar no campo de busca
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // Preenche a lista de alunos com base no termo de busca e filtro selecionado
            Fill(txtBusca.Text, cbfiltro.Text);
        }

        // Ao digitar no campo "Telefone"
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite somente a digitação de números no campo de telefone
            Program.Num(e);
        }

        // Ao digitar no campo "Nome"
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não permite a digitação de números no campo de nome
            Program.Let(e);
        }

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
                txtTurma.Text = null;
            }

            // Define o estado dos campos para leitura ou escrita
            txtNome.ReadOnly = state1;
            txtResponsavel.ReadOnly = state1;
            txtTelefone.ReadOnly = state1;
            txtTurma.ReadOnly = state1;

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


        // Verifica se há campos obrigatórios vazios
        private bool textBoxVazias()
        {
            // Itera por todos os controles no formulário
            foreach (Control c in this.Controls)
            {
                // Verifica se é uma text box e não é um campo opcional
                if (c is TextBox && c != txtBusca && c != txtResponsavel)
                {
                    // Verifica se é uma text box obrigatória vazia
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        // Se for, retorna verdadeiro
                        return true;
                    }
                }
            }
            // Retorna falso se não há campos obrigatórios vazios
            return false;
        }


        // Função que preenche a tabela com os dados armazenados no banco de dados
        public void Fill(string dado, string filtro)
        {
            // Obter lista de alunos do controlador e preencher a tabela com ela
            dtAlunos.DataSource = controller.ListarAlunos(dado, filtro);

            DefineColunas();

            EscondeColunas();

            // Recarregar a tabela para garantir que as mudanças sejam exibidas
            dtAlunos.Refresh();
        }

        // Função que define a largura e títulos das colunas
        private void DefineColunas()
        {
            dtAlunos.Columns["Id"].HeaderText = "Id";
            dtAlunos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Nome"].HeaderText = "Nome";
            dtAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAlunos.Columns["Turma"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Função que esconde colunas que não são relevantes para o usuário
        private void EscondeColunas()
        {
            dtAlunos.Columns["Id"].Visible = false;
            dtAlunos.Columns["Responsavel"].Visible = false;
            dtAlunos.Columns["Telefone"].Visible = false;
        }



        // Ao clicar no botão "Relatorio"
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioGeral rel= new();
            rel.Show();
           
        }

        private void preencher(Aluno aluno)
        {
            // Preenchendo os campos com os dados do aluno
            txtNome.Text = aluno.Nome;
            txtResponsavel.Text = aluno.Responsavel;
            txtTelefone.Text = aluno.Telefone;
            txtTurma.Text = aluno.Turma;
        }


        //-------------------Aba Gerenciar Planos-------------------------

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


        private void btnCancelarPlano_Click(object sender, EventArgs e)
        {
            setupPl(0, true, false);
        }

        private void setupPl(int sinal, bool state1, bool state2)
        {
            // Se o sinal for igual a 1, um novo plano esta sendo cadastrado
            if (sinal == 1)
            {
                plano.Id = 0;
                txtNomePlano.Text = null;
                mskInicio.Text = null;
                mskFim.Text = null;
                txtValorPlano.Text = null;

            }

            // Define estado dos campos
            txtNomePlano.ReadOnly = state1;
            txtValorPlano.ReadOnly = state1;
            mskInicio.ReadOnly = state1;
            mskFim.ReadOnly = state1;

            //Define visibilidade dos botoes Editar e Detalhe
            btnEditarPlano.Visible = state1;
            btnDeletarPlano.Visible = state1;
            //Define se os botões Editar e detalhe estarão ativos
            btnEditarPlano.Enabled = state1;
            btnDeletarPlano.Enabled = state1;

            // Define se os botões Salvar e Cancelar estarão ativos
            btnSalvarPlano.Enabled = state2;
            btnCancelarPlano.Enabled = state2;
            // Define a visibilidade dos botões Salvar e Cancelar
            btnSalvarPlano.Visible = state2;
            btnCancelarPlano.Visible = state2;

        }

        private void btnEditarPlano_Click(object sender, EventArgs e)
        {
            setupPl(0, false, true);
        }

        private void dtPlanos_SelectionChanged(object sender, EventArgs e)
        {
            // Chamando o método "setupPl" para preparar os campos
            setupPl(0, true, false);

            try
            {
                // Verificando se a linha atual não é nula
                if (dtPlanos.CurrentRow != null)
                {
                    // Atribuindo os valores das colunas da linha atual aos atributos do objeto "plano"
                    plano.Id = Convert.ToInt32(dtPlanos.CurrentRow.Cells["Id"].Value);
                    plano.Nome = Convert.ToString(dtPlanos.CurrentRow.Cells["Nome"].Value);
                    plano.Valor = Convert.ToDouble(dtPlanos.CurrentRow.Cells["Valor"].Value);
                    DateTime hora = Convert.ToDateTime(dtPlanos.CurrentRow.Cells["Inicio"].Value);
                    plano.Inicio = Convert.ToString(hora.TimeOfDay);
                    hora = Convert.ToDateTime(dtPlanos.CurrentRow.Cells["Fim"].Value);
                    plano.Fim = Convert.ToString(hora.TimeOfDay);

                    // Atribuindo os valores dos atributos do objeto "plano" aos campos correspondentes na tela
                    txtNomePlano.Text = plano.Nome;
                    mskInicio.Text = plano.Inicio;
                    mskFim.Text = plano.Fim;
                    txtValorPlano.Text = Convert.ToString(plano.Valor);

                    // Verificando se o atributo "id" do objeto "plano" é maior que zero
                    // e preparando os campos se necessário
                    if (plano.Id > 0)
                    {
                        setupPl(0, true, false);
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
            setupPl(1, false, true);
        }

        private void btnDeletarPlano_Click(object sender, EventArgs e)
        {
            // Chamando o metodo para deletar o plano selecionado
            controllerPlano.deletarPlano(plano.Id);
            // Preenchendo tabela de planos novamente
            FillPlanos(txtBuscaPlano.Text);
        }

        //-------------------Aba Gerenciar Turmas-------------------------


        public void FillTurmas()
        {
            DataTable consulta = controllerTurma.ListarTurmas();
            ConfigurarColunasTabelaTurmas();
            PreencherTabelaTurmas(consulta);
        }

        // Configura as colunas da tabela de planos
        private void ConfigurarColunasTabelaTurmas()
        {
            dtPlanos.Columns["Id"].Visible = false;
            dtPlanos.Columns["Inicio"].Visible = false;
            dtPlanos.Columns["Fim"].Visible = false;
            dtPlanos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPlanos.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Preenche a tabela de planos com os dados da consulta
        private void PreencherTabelaTurmas(DataTable consulta)
        {
            dtPlanos.DataSource = consulta;
            dtPlanos.Refresh();
        }

        private void btnSalvarTurma_Click(object sender, EventArgs e)
        {
            TurmaController control = new();

            Turma turma = new Turma();

            turma.Nome = txtNomePlano.Text;
            turma.Ano = Convert.ToInt32(txtAnoTurma.Text);
            turma.Turno=txtTurnoTurma.Text;
            turma.Nivel = txtNivelTurma.Text;

            control.SalvarTurma(turma);
        }

        private void txtBuscaPlano_TextChanged(object sender, EventArgs e)
        {
            FillPlanos(txtBuscaPlano.Text);
        }
    }
}
