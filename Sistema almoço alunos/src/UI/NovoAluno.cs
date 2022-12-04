using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
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
    public partial class NovoAluno : Form
    {
        ServiceStu stu = new ServiceStu();

        public NovoAluno()
        {
            
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //instanciando a classe aluno e a preenchendo
            Aluno aluno = new Aluno();

            aluno.setnome(txtNome.Text);

            aluno.setresponsavel(txtResponsavel.Text);

            aluno.settelefone(txtTelefone.Text);

            // executa o salvamento do aluno no banco de dados
            stu.SalvarAluno(aluno);
            
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
