using System;

namespace Sistema_almoço_alunos
{
    partial class CadAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtAlunos = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlanos = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAlunos
            // 
            this.dtAlunos.AllowUserToAddRows = false;
            this.dtAlunos.AllowUserToDeleteRows = false;
            this.dtAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlunos.Location = new System.Drawing.Point(241, 99);
            this.dtAlunos.MultiSelect = false;
            this.dtAlunos.Name = "dtAlunos";
            this.dtAlunos.ReadOnly = true;
            this.dtAlunos.RowHeadersVisible = false;
            this.dtAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAlunos.Size = new System.Drawing.Size(376, 306);
            this.dtAlunos.TabIndex = 10;
            this.dtAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAlunos_CellContentClick);
            this.dtAlunos.SelectionChanged += new System.EventHandler(this.dtAlunos_CellContentClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(14, 265);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 22);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Novo Aluno";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(12, 190);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(79, 24);
            this.btnDetail.TabIndex = 12;
            this.btnDetail.Text = "Histórico";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(265, 69);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(241, 20);
            this.txtBusca.TabIndex = 13;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // cbfiltro
            // 
            this.cbfiltro.Location = new System.Drawing.Point(512, 68);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(61, 21);
            this.cbfiltro.TabIndex = 15;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(11, 143);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(13, 115);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(164, 20);
            this.txtResponsavel.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 22;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(10, 99);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 21;
            this.lblResponsavel.Text = "Responsavel";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(97, 190);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 24);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.Enabled = false;
            this.btnSalvarEdit.Location = new System.Drawing.Point(13, 190);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(78, 24);
            this.btnSalvarEdit.TabIndex = 27;
            this.btnSalvarEdit.Text = "Salvar";
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            this.btnSalvarEdit.Visible = false;
            this.btnSalvarEdit.Click += new System.EventHandler(this.btnSalvarEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Location = new System.Drawing.Point(97, 190);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(79, 24);
            this.btnCancelEdit.TabIndex = 28;
            this.btnCancelEdit.Text = "Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(55, 220);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(78, 23);
            this.btnDeletar.TabIndex = 29;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(14, 74);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(89, 20);
            this.txtTurma.TabIndex = 30;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(10, 58);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 31;
            this.lblTurma.Text = "Turma";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(14, 159);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(164, 20);
            this.txtTelefone.TabIndex = 32;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(13, 340);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(133, 43);
            this.btnFechar.TabIndex = 33;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Digite para buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bsucar pelo:";
            // 
            // btnPlanos
            // 
            this.btnPlanos.Location = new System.Drawing.Point(14, 293);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(133, 32);
            this.btnPlanos.TabIndex = 36;
            this.btnPlanos.Text = "Planos";
            this.btnPlanos.UseVisualStyleBackColor = true;
            this.btnPlanos.Click += new System.EventHandler(this.btnPlanos_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(354, 12);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(133, 32);
            this.btnRelatorio.TabIndex = 37;
            this.btnRelatorio.Text = "Relatorio Geral";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 428);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnPlanos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbfiltro);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dtAlunos);
            this.Name = "CadAluno";
            this.Text = "Gerenciador de alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtAlunos;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvarEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

