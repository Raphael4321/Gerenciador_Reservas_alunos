using Sistema_almoço_alunos.src.Controllers;
using Sistema_almoço_alunos.src.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.UI
{
    public partial class PlanoCad : Form
    {

        Plano plano = new();
        ControllerPlano controllerPlano = new();

        public PlanoCad()
        {
            InitializeComponent();

            Fill();
        }

        public void Fill()
        {
            DataTable consulta = new();

            // preenchendo a tabela com os dados no banco
            consulta = controllerPlano.ListaPlanos();

            dtPlanos.DataSource = consulta;
            dtPlanos.Columns["Id"].Visible = false;
            dtPlanos.Columns["Inicio"].Visible = false;
            dtPlanos.Columns["Fim"].Visible = false;
            dtPlanos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPlanos.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // recarregando a tabela para garantir
            dtPlanos.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Salvando novo plano com os dados fornecidos

            plano.setnome(txtNome.Text);
            plano.setvalor(Convert.ToDouble(txtValor.Text));
            plano.setInicio(txtInicio.Text);
            plano.setFim(txtFim.Text);
            

            controllerPlano.salvar(plano);
            
            // Preenchendo a lista de planos disponiveis
            Fill();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setupPl(0, true, false);
        }

        private void setupPl(int sinal, bool state1, bool state2)
        {
            // Se o sinal for igual a 1, um novo plano esta sendo cadastrado
            if (sinal == 1)
            {
                plano.setid(0);
                txtNome.Text = null;
                txtInicio.Text = null;
                txtFim.Text = null;
                txtValor.Text = null;

            }

            // Define estado dos campos
            txtNome.ReadOnly = state1;
            txtValor.ReadOnly = state1;
            txtInicio.ReadOnly = state1;
            txtFim.ReadOnly = state1;


            //Define visibilidade dos botoes Editar e Detalhe
            btnEdit.Visible = state1;
            btnDeletar.Visible = state1;
            //Define se os botões Editar e detalhe estarão ativos
            btnEdit.Enabled = state1;
            btnDeletar.Enabled = state1;

            // Define se os botões Salvar e Cancelar estarão ativos
            btnSave.Enabled = state2;
            btnCancel.Enabled = state2;
            // Define a visibilidade dos botões Salvar e Cancelar
            btnSave.Visible = state2;
            btnCancel.Visible = state2;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setupPl(0, false, true);
        }

        private void dtPlanos_SelectionChanged(object sender, EventArgs e)
        {

            setupPl(0, true, false);
            try { 
                 if (dtPlanos.CurrentRow != null)
                 {
                     DateTime hora;
                     plano.setid(Convert.ToInt32(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Id"].Value));
                     plano.setnome(Convert.ToString(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Nome"].Value));
                     plano.setvalor(Convert.ToDouble(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Valor"].Value.ToString()));
                     hora = Convert.ToDateTime(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Inicio"].Value);
                     plano.setInicio(Convert.ToString(hora.TimeOfDay));
                     hora = Convert.ToDateTime(dtPlanos.Rows[dtPlanos.CurrentRow.Index].Cells["Fim"].Value);
                     plano.setFim(Convert.ToString(hora.TimeOfDay));

                     txtNome.Text = plano.getnome();
                     txtInicio.Text = plano.getInicio();
                     txtFim.Text = plano.getFim();
                     txtValor.Text = Convert.ToString(plano.getvalor());

                     if (plano.getid() > 0)
                     {
                         setupPl(0, true, false);
                     }
                 }
            } catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setupPl(1, false, true);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            controllerPlano.deletarPlano(plano.getid());
            Fill();
        }
    }
}
