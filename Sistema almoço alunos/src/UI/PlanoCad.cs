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
    public partial class PlanoCad : Form
    {
        public PlanoCad()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ServicePl sr = new ServicePl();

            Plano pla = new Plano();

            pla.setnome(txtNome.Text);
            pla.setvalor(Convert.ToDouble(txtValor.Text));

           sr.savePl(pla);



            this.Close();
        }
    }
}
