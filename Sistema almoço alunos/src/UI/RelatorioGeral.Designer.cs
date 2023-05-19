namespace Sistema_almoço_alunos.src.UI
{
    partial class RelatorioGeral
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
            this.dtRelatorio = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtMes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRelatorio
            // 
            this.dtRelatorio.AllowUserToAddRows = false;
            this.dtRelatorio.AllowUserToDeleteRows = false;
            this.dtRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRelatorio.Location = new System.Drawing.Point(27, 62);
            this.dtRelatorio.MultiSelect = false;
            this.dtRelatorio.Name = "dtRelatorio";
            this.dtRelatorio.ReadOnly = true;
            this.dtRelatorio.RowHeadersVisible = false;
            this.dtRelatorio.Size = new System.Drawing.Size(376, 360);
            this.dtRelatorio.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mês:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(360, 36);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(32, 20);
            this.txtAno.TabIndex = 71;
            this.txtAno.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(303, 36);
            this.txtMes.Mask = "00";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(19, 20);
            this.txtMes.TabIndex = 69;
            this.txtMes.ValidatingType = typeof(int);
            this.txtMes.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nome do aluno:";
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(162, 428);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(108, 34);
            this.btnPDF.TabIndex = 75;
            this.btnPDF.Text = "Gerar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // RelatorioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 465);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtRelatorio);
            this.Name = "RelatorioGeral";
            this.Text = "Relatorio Geral";
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRelatorio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.MaskedTextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPDF;
    }
}