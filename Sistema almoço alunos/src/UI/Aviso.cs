using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.UI
{
    public partial class Aviso : Form
    {

        public Aviso()
        {
           
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
