namespace Sistema_almoço_alunos.src.UI
{
    partial class Historico
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
            this.btnAgendarAlmoço = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dtHistorico = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPlano = new System.Windows.Forms.Label();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnAdcPl = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFim = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtDataBusca = new System.Windows.Forms.MaskedTextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgendarAlmoço
            // 
            this.btnAgendarAlmoço.Location = new System.Drawing.Point(23, 12);
            this.btnAgendarAlmoço.Name = "btnAgendarAlmoço";
            this.btnAgendarAlmoço.Size = new System.Drawing.Size(133, 45);
            this.btnAgendarAlmoço.TabIndex = 20;
            this.btnAgendarAlmoço.Text = "Agendar Almoço";
            this.btnAgendarAlmoço.UseVisualStyleBackColor = true;
            this.btnAgendarAlmoço.Click += new System.EventHandler(this.btnAgen_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(211, 330);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(133, 43);
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
            this.dtHistorico.Location = new System.Drawing.Point(356, 112);
            this.dtHistorico.MultiSelect = false;
            this.dtHistorico.Name = "dtHistorico";
            this.dtHistorico.RowHeadersVisible = false;
            this.dtHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHistorico.Size = new System.Drawing.Size(194, 231);
            this.dtHistorico.TabIndex = 22;
            this.dtHistorico.SelectionChanged += new System.EventHandler(this.dtHistorico_SelectionChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(27, 298);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(140, 45);
            this.btnDeletar.TabIndex = 40;
            this.btnDeletar.Text = "Deletar Almoço";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(108, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 24);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 249);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 24);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 249);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 24);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(20, 206);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 35;
            this.lblValor.Text = "Valor";
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(20, 158);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(34, 13);
            this.lblPlano.TabIndex = 32;
            this.lblPlano.Text = "Plano";
            // 
            // cmbPlano
            // 
            this.cmbPlano.Enabled = false;
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(23, 173);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(101, 21);
            this.cmbPlano.TabIndex = 41;
            this.cmbPlano.Visible = false;
            this.cmbPlano.SelectedIndexChanged += new System.EventHandler(this.cmbPlano_SelectedIndexChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(24, 65);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 43;
            this.lblData.Text = "Data";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(20, 112);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 31;
            this.lblHorario.Text = "Horario";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(370, 81);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(164, 20);
            this.txtValorTotal.TabIndex = 54;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(306, 86);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 53;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // btnAdcPl
            // 
            this.btnAdcPl.Location = new System.Drawing.Point(130, 160);
            this.btnAdcPl.Name = "btnAdcPl";
            this.btnAdcPl.Size = new System.Drawing.Size(69, 45);
            this.btnAdcPl.TabIndex = 55;
            this.btnAdcPl.Text = "Adicionar Plano";
            this.btnAdcPl.UseVisualStyleBackColor = true;
            this.btnAdcPl.Click += new System.EventHandler(this.btnAdcPl_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(24, 81);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 56;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(24, 128);
            this.txtInicio.Mask = "00:00";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(63, 20);
            this.txtInicio.TabIndex = 57;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(93, 128);
            this.txtFim.Mask = "00:00";
            this.txtFim.Name = "txtFim";
            this.txtFim.ReadOnly = true;
            this.txtFim.Size = new System.Drawing.Size(63, 20);
            this.txtFim.TabIndex = 58;
            this.txtFim.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(24, 223);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 59;
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(23, 173);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.ReadOnly = true;
            this.txtPlano.Size = new System.Drawing.Size(100, 20);
            this.txtPlano.TabIndex = 60;
            // 
            // txtDataBusca
            // 
            this.txtDataBusca.Location = new System.Drawing.Point(370, 55);
            this.txtDataBusca.Mask = "00/00/0000";
            this.txtDataBusca.Name = "txtDataBusca";
            this.txtDataBusca.Size = new System.Drawing.Size(100, 20);
            this.txtDataBusca.TabIndex = 64;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(476, 53);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(69, 23);
            this.btnBusca.TabIndex = 65;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 380);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtDataBusca);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnAdcPl);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmbPlano);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblPlano);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dtHistorico);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAgendarAlmoço);
            this.Name = "Historico";
            this.Text = "Detalhes do Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dtHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgendarAlmoço;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dtHistorico;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnAdcPl;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.MaskedTextBox txtFim;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.MaskedTextBox txtDataBusca;
        private System.Windows.Forms.Button btnBusca;
    }
}