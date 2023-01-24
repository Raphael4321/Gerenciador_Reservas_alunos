using Sistema_almoço_alunos.src.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Utils;
using Sistema_almoço_alunos.src.Services;
using Sistema_almoço_alunos.src.Utils.dto;
using System.Drawing;
using Sistema_almoço_alunos.src.UI;

namespace Sistema_almoço_alunos
{
    public partial class CadAluno : Form
    {
        //instanciando classes necessarias
        ServiceStu stu = new ServiceStu();

        Aluno aluno = new Aluno();
        public CadAluno()
        {
            // inicializando a janela
            InitializeComponent();

            //tentando preencher a janela
            try
            {
                //Alimentando Combobox de filtro de busca
                List<string> filtro = stu.listFiltro();
                cbfiltro.DataSource = filtro;

                //Preenchendo lista de alunos
                Fill(txtBusca.Text, cbfiltro.Text);
                dtAlunos.Columns["Id"].Visible = false;
                dtAlunos.Columns["Responsavel"].Visible=false;
                dtAlunos.Columns["Telefone"].Visible = false;
            }
            //se não conseguir, mostrar o motivo
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
                            
        }

        private void dtAlunos_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                if(dtAlunos.CurrentRow != null)
                {
                    //Selecionando Aluno e mostrando detalhes
                    aluno.setid(Convert.ToInt32(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Id"].Value));
                    aluno.setnome(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Nome"].Value));
                    aluno.setresponsavel(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Responsavel"].Value));
                    aluno.settelefone(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Telefone"].Value));
                    aluno.setTurma(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentRow.Index].Cells["Turma"].Value));

                    txtNome.Text = aluno.getnome();
                    txtResponsavel.Text = aluno.getresponsavel();
                    txtTelefone.Text = aluno.gettelefone();
                    txtTurma.Text = aluno.getTurma();
                }
                else
                {
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
            //Desbloqueando campos para
            //permitir cadastro de novo Aluno
            setup(1, false, true);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //Estabelecendo tela de Historico e exibindo
            Historico det = new Historico(aluno);
            det.Show();
        }

        public void Fill(string dado, string filtro)
        {
            // preenchendo a tabela com os dados no banco
            if(dado != "")
            {
                dtAlunos.DataSource = stu.listAlunosEsp(dado, filtro);
               
                // determina o tamanho das colunas na tabela
                dtAlunos.Columns["Id"].HeaderText = "Id";
                dtAlunos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Nome"].HeaderText = "Nome";
                dtAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Responsavel"].HeaderText = "Responsavel Financeiro";
                dtAlunos.Columns["Responsavel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Telefone"].HeaderText = "Telefone";
                dtAlunos.Columns["Telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Turma"].HeaderText = "Turma";
                dtAlunos.Columns["Turma"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               
                //Escondendo colunas desnecessarias para o usuario
                dtAlunos.Columns["Id"].Visible = false;
                dtAlunos.Columns["Responsavel"].Visible = false;
                dtAlunos.Columns["Telefone"].Visible = false;

                // recarregando a tabela para garantir
                dtAlunos.Refresh();
            }
            else
            {
                dtAlunos.DataSource = stu.listAlunos();
               
                // determina o tamanho das colunas na tabela
                dtAlunos.Columns["Id"].HeaderText = "Id";
                dtAlunos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Nome"].HeaderText = "Nome";
                dtAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Responsavel"].HeaderText = "Responsavel Financeiro";
                dtAlunos.Columns["Responsavel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Telefone"].HeaderText = "Telefone";
                dtAlunos.Columns["Telefone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Turma"].HeaderText = "Turma";
                dtAlunos.Columns["Turma"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAlunos.Columns["Id"].Visible = false;
                dtAlunos.Columns["Responsavel"].Visible = false;
                dtAlunos.Columns["Telefone"].Visible = false;
               
                // recarregando a tabela para garantir
                dtAlunos.Refresh();
            }
            
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //Preenchendo lista de alunos de acordo com a busca
            Fill(txtBusca.Text, cbfiltro.Text);
            dtAlunos.Columns["Id"].Visible = false;
            dtAlunos.Columns["Responsavel"].Visible = false;
            dtAlunos.Columns["Telefone"].Visible = false;
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
            
           if(textBoxVazias() == true)
           {
                DialogResult confirm = MessageBox.Show("Por favor, preencha todos os campos antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
           //Se não, prosseguir com cadastro do aluno
            else
            {
                setup(0, true, false);

                 aluno.setnome(txtNome.Text);
                 aluno.setresponsavel(txtResponsavel.Text);
                 aluno.setTurma(txtTurma.Text);
                 aluno.settelefone(txtTelefone.Text);

                 stu.SalvarAluno(aluno);

                 Fill(txtBusca.Text, cbfiltro.Text);
                 dtAlunos.Columns["Id"].Visible = false;
                 dtAlunos.Columns["Responsavel"].Visible = false;
                 dtAlunos.Columns["Telefone"].Visible = false;
            };  
  
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Avisando usuario da exclusão dos dados
            DialogResult confirm = MessageBox.Show("Excluir o aluno também excluirá seus agendamentos. Deseja continuar?", "Excluir Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            
            //prosseguir se usuario permitir
            if (confirm.ToString().ToUpper() == "YES")
            {
                stu.DelAluno(aluno);
                ServiceAge age = new ServiceAge();
                age.DelTodos(aluno.getid());
                Fill(txtBusca.Text, cbfiltro.Text);
            }

        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.Num(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.Let(e);
        }

        private void setup(int sinal, bool state1, bool state2)
        {
           if(sinal == 1)
            {
                aluno.setid(0);
                txtNome.Text = null;
                txtResponsavel.Text = null;
                txtTelefone.Text = null;
                txtTurma.Text = null;
            }
            
            //Desbloqueia campos
            txtNome.ReadOnly = state1;
            txtResponsavel.ReadOnly = state1;
            txtTelefone.ReadOnly = state1;
            txtTurma.ReadOnly = state1;

            //Esconde os botões Editar e Detalhe
            btnEditar.Visible = state1;
            btnDetail.Visible = state1;
            //Desabilita os botões Editar e detalhe
            btnDetail.Enabled = state1;
            btnEditar.Enabled = state1;

            //Habilita os botões Salvar e Cancelar
            btnSalvarEdit.Enabled = state2;
            btnCancelEdit.Enabled = state2;
            //Mostra os botões Salvar e Cancelar
            btnSalvarEdit.Visible = state2;
            btnCancelEdit.Visible = state2;
        }

        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox && c != txtBusca)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }
    }
}
