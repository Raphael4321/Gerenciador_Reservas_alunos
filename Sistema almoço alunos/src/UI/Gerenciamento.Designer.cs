namespace Sistema_almoço_alunos.src.UI
{
    partial class Gerenciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.dtHistorico = new System.Windows.Forms.DataGridView();
            this.btnAgendarAlmoço = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlano = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtFim = new System.Windows.Forms.MaskedTextBox();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(161, 371);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(133, 26);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dtHistorico
            // 
            this.dtHistorico.AllowUserToAddRows = false;
            this.dtHistorico.AllowUserToDeleteRows = false;
            this.dtHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistorico.Location = new System.Drawing.Point(202, 93);
            this.dtHistorico.MultiSelect = false;
            this.dtHistorico.Name = "dtHistorico";
            this.dtHistorico.ReadOnly = true;
            this.dtHistorico.RowHeadersVisible = false;
            this.dtHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHistorico.Size = new System.Drawing.Size(194, 231);
            this.dtHistorico.TabIndex = 70;
            // 
            // btnAgendarAlmoço
            // 
            this.btnAgendarAlmoço.Location = new System.Drawing.Point(12, 24);
            this.btnAgendarAlmoço.Name = "btnAgendarAlmoço";
            this.btnAgendarAlmoço.Size = new System.Drawing.Size(133, 45);
            this.btnAgendarAlmoço.TabIndex = 69;
            this.btnAgendarAlmoço.Text = "Agendar Almoço";
            this.btnAgendarAlmoço.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Ano:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(6, 164);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 71;
            this.lblHorario.Text = "Horario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Mês:";
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(7, 119);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(34, 13);
            this.lblPlano.TabIndex = 72;
            this.lblPlano.Text = "Plano";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(289, 35);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(32, 20);
            this.txtAno.TabIndex = 89;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 213);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 73;
            this.lblValor.Text = "Valor";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(327, 35);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(69, 23);
            this.btnBusca.TabIndex = 88;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(9, 254);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 24);
            this.btnEditar.TabIndex = 74;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(232, 35);
            this.txtMes.Mask = "00";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(19, 20);
            this.txtMes.TabIndex = 87;
            this.txtMes.ValidatingType = typeof(int);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(9, 254);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 24);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(10, 135);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.ReadOnly = true;
            this.txtPlano.Size = new System.Drawing.Size(133, 20);
            this.txtPlano.TabIndex = 86;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(93, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 24);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(11, 229);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 85;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(12, 296);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(140, 45);
            this.btnDeletar.TabIndex = 77;
            this.btnDeletar.Text = "Deletar Almoço";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(80, 180);
            this.txtFim.Mask = "00:00";
            this.txtFim.Name = "txtFim";
            this.txtFim.ReadOnly = true;
            this.txtFim.Size = new System.Drawing.Size(63, 20);
            this.txtFim.TabIndex = 84;
            this.txtFim.ValidatingType = typeof(System.DateTime);
            // 
            // cmbPlano
            // 
            this.cmbPlano.Enabled = false;
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(11, 135);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(132, 21);
            this.cmbPlano.TabIndex = 78;
            this.cmbPlano.Visible = false;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(10, 180);
            this.txtInicio.Mask = "00:00";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(63, 20);
            this.txtInicio.TabIndex = 83;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(11, 76);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 79;
            this.lblData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 93);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 82;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(62, 78);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 80;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(232, 64);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(164, 20);
            this.txtValorTotal.TabIndex = 81;
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 405);
            this.Controls.Add(this.dtHistorico);
            this.Controls.Add(this.btnAgendarAlmoço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlano);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.cmbPlano);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnFechar);
            this.Name = "Gerenciamento";
            this.Text = "Detalhes do Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dtHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dtHistorico;
        private System.Windows.Forms.Button btnAgendarAlmoço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox txtMes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MaskedTextBox txtFim;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}