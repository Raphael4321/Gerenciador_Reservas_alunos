using Sistema_almoço_alunos.src.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.UI
{
    public partial class DetalheAluno : Form
    {
        public DetalheAluno(Aluno aluno)
        {
            InitializeComponent();

            txtNome.Text = aluno.getnome();
            txtResponsavel.Text = aluno.getresponsavel();
            txtTelefone.Text = aluno.gettelefone();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtResponsavel.ReadOnly = false;
            txtTelefone.ReadOnly = false;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
