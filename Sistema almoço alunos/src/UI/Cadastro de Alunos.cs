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

        List<Aluno> alunos = new List<Aluno>();
        ServiceStu stu = new ServiceStu();


        public CadAluno()
        {
            // inicializando a janela
            InitializeComponent();

            //tentando preencher a janela
            try
            {

                // preenchendo a tabela com os dados no banco
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
                // recarregando a tabela para garantir
                dtAlunos.Refresh();
            }
            //se não conseguir, mostrar o motivo
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
                            
        }


        private void dtAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Aluno aluno = new Aluno();

            aluno.setid (Convert.ToInt32(dtAlunos.Rows[dtAlunos.CurrentCell.RowIndex].Cells["Id"].Value));
            aluno.setnome(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentCell.RowIndex].Cells["Nome"].Value));
            aluno.setresponsavel(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentCell.RowIndex].Cells["Responsavel"].Value));
            aluno.settelefone(Convert.ToString(dtAlunos.Rows[dtAlunos.CurrentCell.RowIndex].Cells["Telefone"].Value));

            DetalheAluno det = new DetalheAluno(aluno);

            det.Show();
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NovoAluno novoAluno = new NovoAluno();

            novoAluno.Show();
            try
            {

                // preenchendo a tabela com os dados no banco
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
                // recarregando a tabela para garantir
                dtAlunos.Refresh();
            }
            //se não conseguir, mostrar o motivo
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
