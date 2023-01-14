using NUnit.Framework;
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
    public partial class Historico : Form
    {

        ServiceAge serviceAge = new ServiceAge();

        Agendamento agendamento = new Agendamento();

        ServicePl servicePlano = new ServicePl();

        DataTable dt = new DataTable();

        Aluno aluno = new Aluno();

        public Historico(Aluno aluno)
        {
            InitializeComponent();

            //tentando preencher a janela
            try
            {
                this.aluno = aluno;

                btnSalvar.Enabled = false;
                btnSalvar.Visible = false;
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;

                List<string> filtro = new List<string>();

                string dado = "Mês";
                filtro.Add(dado);
                dado = "Ano";
                filtro.Add(dado);

                agendamento.setidAluno(aluno.getid());

                dt = servicePlano.ListaPlanos();
                cmbPlano.DataSource = dt;
                cmbPlano.DisplayMember = "Nome";
                cmbPlano.ValueMember = "Id";

                Fill(aluno.getid(), txtMes.Text, txtAno.Text);
                dtHistorico.Columns["Id"].Visible = false;
                dtHistorico.Columns["Inicio"].Visible = false;
                dtHistorico.Columns["Fim"].Visible = false;
                dtHistorico.Columns["IdAluno"].Visible = false;
                dtHistorico.Columns["IdPlano"].Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnAgen_Click(object sender, EventArgs e)
        {
            setup(1, false, true);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxVazias() == true)
            {
                DialogResult confirm = MessageBox.Show("Por favor, preencha todos os campos antes de salvar", "Incluir Aluno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            else
            {
                agendamento.plano = new Plano();
                agendamento.setidAluno(aluno.getid());
                agendamento.setdata(DateTime.Parse(txtData.Text));
                agendamento.setInicio(txtInicio.Text);
                agendamento.setFim(txtFim.Text);
                agendamento.plano.setid(Convert.ToInt32(cmbPlano.SelectedValue));
                agendamento.plano.setvalor(Convert.ToDouble(txtValor.Text));

                serviceAge.SalvarAgendamento(agendamento);
                Fill(agendamento.getidAluno(), txtMes.Text, txtAno.Text);
                setup(0, true, false);
            }
        }

        private void cmbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPlano.Items.Count > 0)
            {
                string id = Convert.ToString(cmbPlano.SelectedValue);
                double valor = servicePlano.SelecionadoValor(id);

                txtValor.Text = Convert.ToString(valor);

                txtPlano.Text = servicePlano.SelectPlano(id);
            }
        }

        private void btnAdcPl_Click(object sender, EventArgs e)
        {
            PlanoCad planoCad= new PlanoCad();

            planoCad.Show();

            if(planoCad.DialogResult == DialogResult.OK)
            {
                cmbPlano.DataSource = dt;
            }
            else
            {
                MessageBox.Show("sem retorno");
            }

        }

        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox && c != txtMes && c!=txtAno && c != txtValorTotal && c!=txtPlano)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }

        private void setup(int sinal, bool state1, bool state2)
        {
            if (sinal == 1)
            {
                agendamento.setid(0);
                txtData.Text = null;
                txtInicio.Text = null;
                txtFim.Text = null;
                txtValor.Text = null;
                cmbPlano.Text = null;
          
            }

            //Desbloqueia campos
            txtData.ReadOnly = state1;
            txtInicio.ReadOnly = state1;
            txtFim.ReadOnly = state1;
            txtValor.ReadOnly = state1;

            //Bloqueia e esconde o textbox de plano
            txtPlano.ReadOnly = state1;
            txtPlano.Visible = state1;

            //Esconde os botões Editar e Detalhe
            btnEditar.Visible = state1;
            //Desabilita os botões Editar e detalhe
            btnEditar.Enabled = state1;

            //Habilita os botões Salvar, Cancelar e seleção de plano
            btnSalvar.Enabled = state2;
            btnCancelar.Enabled = state2;
            cmbPlano.Enabled = state2;
            //Mostra os botões Salvar, Cancelar e seleção de plano
            btnSalvar.Visible = state2;
            btnCancelar.Visible = state2;
            cmbPlano.Visible = state2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setup(0, true, false);
        }

        public List<Plano> convert(DataTable dt)
        {
            List<Plano> planos = new List<Plano>();

            Plano plano1 = new Plano();

            planos.Add(plano1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Plano plano = new Plano();
                plano.setid(Convert.ToInt32(dt.Rows[i]["Id"]));
                plano.setvalor(Convert.ToDouble(dt.Rows[i]["Valor"]));
                planos.Add(plano);
            }
            return planos;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Avisando usuario da exclusão dos dados
            DialogResult confirm = MessageBox.Show("Excluir o aluno também excluirá seus agendamentos. Deseja continuar?", "Excluir Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            //prosseguir se usuario permitir
            if (confirm.ToString().ToUpper() == "YES")
            {
                serviceAge.DelAgendamento(agendamento);
                Fill(aluno.getid(), txtMes.Text, txtAno.Text);
            }
        }

        private void dtHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            agendamento.plano = new Plano();
            agendamento.setid(Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Id"].Value));
            agendamento.setidAluno(Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Id"].Value));
            agendamento.setdata(DateTime.Parse(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Data"].Value.ToString()));
            agendamento.setInicio(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Inicio"].Value.ToString());
            agendamento.setFim(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Fim"].Value.ToString());
            agendamento.plano.setid(Convert.ToInt32(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["IdPlano"].Value));
            agendamento.plano.setvalor(Convert.ToDouble(dtHistorico.Rows[dtHistorico.CurrentRow.Index].Cells["Valor"].Value.ToString()));

            txtPlano.Text = cmbPlano.SelectedText;
            txtData.Text = Convert.ToString(agendamento.getdata());
            txtInicio.Text = Convert.ToString(agendamento.getInicio());
            txtFim.Text = Convert.ToString(agendamento.getFim());
            cmbPlano.SelectedValue = agendamento.plano.getid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            setup(0, false, true);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        public void Fill(int id, string mes, string ano)
        {
            // preenchendo a tabela com os dados no banco
            if (mes == "" && ano == "") 
            {
                dtHistorico.DataSource = serviceAge.listAgendamentos(id);

            }
            else { dtHistorico.DataSource = serviceAge.listAgendamentoEsp(id, mes, ano);  }
            
            // determina o tamanho das colunas na tabela

            DateTime data = DateTime.Now;

            // recarregando a tabela para garantir
            dtHistorico.Refresh();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Fill(aluno.getid(), txtMes.Text, txtAno.Text);
        }
    }
}
