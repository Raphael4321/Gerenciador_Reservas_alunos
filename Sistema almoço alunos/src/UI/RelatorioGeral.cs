using Sistema_almoço_alunos.src.Controllers;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.UI
{
    public partial class RelatorioGeral : Form
    {
        Utilidades util = new();

        public RelatorioGeral()
        {
            InitializeComponent();
            
            Fill(txtNome.Text, txtMes.Text, txtAno.Text);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
             Fill(txtNome.Text, txtMes.Text, txtAno.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void Fill(string nome, string mes, string ano)
        {
            AgendamentoController control = new();

            dtRelatorio.DataSource = util.Relatorio(nome, mes, ano);

            dtRelatorio.Columns["Nome do aluno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtRelatorio.Columns["Valor total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

    }
}
