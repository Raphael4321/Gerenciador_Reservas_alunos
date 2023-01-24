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
        ServicePl servicePl = new ServicePl();

        Plano plano = new Plano();

        public PlanoCad()
        {
            InitializeComponent();

            Fill();
        }

        public void Fill()
        {
            DataTable consulta = new DataTable();

            // preenchendo a tabela com os dados no banco
            consulta = servicePl.ListaPlanos();

            dtPlanos.DataSource = consulta;

            // recarregando a tabela para garantir
            dtPlanos.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ServicePl sr = new ServicePl();

            Plano pla = new Plano();

            pla.setnome(txtNome.Text);
            pla.setvalor(Convert.ToDouble(txtValor.Text));

            sr.savePl(pla);

            Fill();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupPl(int sinal, bool state1, bool state2)
        {
            if (sinal == 1)
            {
                plano.setid(0);
                txtNome.Text = null;
                txtValor.Text = null;

            }

            //Desbloqueia campos
            txtNome.ReadOnly = state1;
            txtValor.ReadOnly = state1;


            //Esconde os botões Editar e Detalhe
            btnEdit.Visible = state1;
            btnCancel.Visible = state1;
            //Desabilita os botões Editar e detalhe
            btnEdit.Enabled = state1;
            btnCancel.Enabled = state1;

            //Habilita os botões Salvar e Cancelar
            btnSave.Enabled = state2;
            btnCancel.Enabled = state2;
            //Mostra os botões Salvar e Cancelar
            btnSave.Visible = state2;
            btnCancel.Visible = state2;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setupPl(0, false, true);
        }

        private void dtPlanos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtPlanos.CurrentRow != null)
            {
                Plano plano = new Plano();
                plano.setid(Convert.ToInt32(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Id"].Value));
                plano.setnome(Convert.ToString(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Nome"].Value));
                plano.setvalor(Convert.ToDouble(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Valor"].Value.ToString()));

                txtNome.Text = plano.getnome();
                txtValor.Text = Convert.ToString(plano.getvalor());

                if (plano.getid() > 0)
                {
                    setupPl(0, true, false);
                }
            }
                
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setupPl(1, false, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
