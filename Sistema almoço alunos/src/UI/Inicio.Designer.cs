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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.cmbNomeTurma = new System.Windows.Forms.ComboBox();
            this.cmbTurnoTurma = new System.Windows.Forms.ComboBox();
            this.cmbEnsinoTurma = new System.Windows.Forms.ComboBox();
            this.cmbSerieTurma = new System.Windows.Forms.ComboBox();
            this.lblEnsino = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dtAlunos = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Buscar por:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(485, 77);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(65, 21);
            this.cmbFiltro.TabIndex = 81;
            // 
            // cmbNomeTurma
            // 
            this.cmbNomeTurma.FormattingEnabled = true;
            this.cmbNomeTurma.Location = new System.Drawing.Point(56, 173);
            this.cmbNomeTurma.Name = "cmbNomeTurma";
            this.cmbNomeTurma.Size = new System.Drawing.Size(32, 21);
            this.cmbNomeTurma.TabIndex = 80;
            // 
            // cmbTurnoTurma
            // 
            this.cmbTurnoTurma.FormattingEnabled = true;
            this.cmbTurnoTurma.Location = new System.Drawing.Point(158, 173);
            this.cmbTurnoTurma.Name = "cmbTurnoTurma";
            this.cmbTurnoTurma.Size = new System.Drawing.Size(58, 21);
            this.cmbTurnoTurma.TabIndex = 79;
            // 
            // cmbEnsinoTurma
            // 
            this.cmbEnsinoTurma.FormattingEnabled = true;
            this.cmbEnsinoTurma.Location = new System.Drawing.Point(94, 173);
            this.cmbEnsinoTurma.Name = "cmbEnsinoTurma";
            this.cmbEnsinoTurma.Size = new System.Drawing.Size(58, 21);
            this.cmbEnsinoTurma.TabIndex = 78;
            // 
            // cmbSerieTurma
            // 
            this.cmbSerieTurma.FormattingEnabled = true;
            this.cmbSerieTurma.Location = new System.Drawing.Point(15, 173);
            this.cmbSerieTurma.Name = "cmbSerieTurma";
            this.cmbSerieTurma.Size = new System.Drawing.Size(32, 21);
            this.cmbSerieTurma.TabIndex = 77;
            // 
            // lblEnsino
            // 
            this.lblEnsino.AutoSize = true;
            this.lblEnsino.Location = new System.Drawing.Point(91, 157);
            this.lblEnsino.Name = "lblEnsino";
            this.lblEnsino.Size = new System.Drawing.Size(39, 13);
            this.lblEnsino.TabIndex = 76;
            this.lblEnsino.Text = "Ensino";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(15, 157);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(176, 20);
            this.txtTurma.TabIndex = 74;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 61;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(238, 77);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(241, 20);
            this.txtBusca.TabIndex = 58;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(15, 218);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(176, 20);
            this.txtResponsavel.TabIndex = 62;
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Location = new System.Drawing.Point(53, 157);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(35, 13);
            this.lblNomeTurma.TabIndex = 72;
            this.lblNomeTurma.Text = "Nome";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(15, 157);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(31, 13);
            this.lblSerie.TabIndex = 73;
            this.lblSerie.Text = "Série";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(156, 157);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 75;
            this.lblTurno.Text = "Turno";
            // 
            // dtAlunos
            // 
            this.dtAlunos.AllowUserToAddRows = false;
            this.dtAlunos.AllowUserToDeleteRows = false;
            this.dtAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlunos.Location = new System.Drawing.Point(238, 103);
            this.dtAlunos.MultiSelect = false;
            this.dtAlunos.Name = "dtAlunos";
            this.dtAlunos.ReadOnly = true;
            this.dtAlunos.RowHeadersVisible = false;
            this.dtAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAlunos.Size = new System.Drawing.Size(376, 306);
            this.dtAlunos.TabIndex = 55;
            this.dtAlunos.SelectionChanged += new System.EventHandler(this.dtAlunos_CellContentClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 59;
            this.lblNome.Text = "Nome";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(351, 16);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(133, 32);
            this.btnRelatorio.TabIndex = 71;
            this.btnRelatorio.Text = "Relatorio Geral";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 262);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(176, 20);
            this.txtTelefone.TabIndex = 69;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(15, 135);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 68;
            this.lblTurma.Text = "Turma";
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.Enabled = false;
            this.btnSalvarEdit.Location = new System.Drawing.Point(20, 293);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(78, 24);
            this.btnSalvarEdit.TabIndex = 65;
            this.btnSalvarEdit.Text = "Salvar";
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            this.btnSalvarEdit.Visible = false;
            this.btnSalvarEdit.Click += new System.EventHandler(this.btnSalvarEdit_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(19, 293);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 24);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(15, 202);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 60;
            this.lblResponsavel.Text = "Responsavel";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(29, 28);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 34);
            this.btnNew.TabIndex = 56;
            this.btnNew.Text = "Novo Aluno";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Location = new System.Drawing.Point(101, 293);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(79, 24);
            this.btnCancelEdit.TabIndex = 66;
            this.btnCancelEdit.Text = "Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 246);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 63;
            this.lblTelefone.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Digite para buscar:";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(29, 341);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(139, 48);
            this.btnDetail.TabIndex = 57;
            this.btnDetail.Text = "Gerenciar Agendamentos do aluno";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(103, 293);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(78, 23);
            this.btnDesativar.TabIndex = 67;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(556, 61);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(89, 17);
            this.rdbAtivo.TabIndex = 83;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Alunos Ativos";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(556, 80);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(97, 17);
            this.rdbInativo.TabIndex = 84;
            this.rdbInativo.Text = "Alunos Inativos";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.CheckedChanged += new System.EventHandler(this.rdbInativo_CheckedChanged);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Enabled = false;
            this.btnAtivar.Location = new System.Drawing.Point(20, 293);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(78, 23);
            this.btnAtivar.TabIndex = 85;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Visible = false;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(102, 294);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(78, 23);
            this.btnDeletar.TabIndex = 86;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 431);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.rdbInativo);
            this.Controls.Add(this.rdbAtivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.cmbNomeTurma);
            this.Controls.Add(this.cmbTurnoTurma);
            this.Controls.Add(this.cmbEnsinoTurma);
            this.Controls.Add(this.cmbSerieTurma);
            this.Controls.Add(this.lblEnsino);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.lblNomeTurma);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.dtAlunos);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnDesativar);
            this.Name = "CadAluno";
            this.Text = "Gerenciador de alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.ComboBox cmbNomeTurma;
        private System.Windows.Forms.ComboBox cmbTurnoTurma;
        private System.Windows.Forms.ComboBox cmbEnsinoTurma;
        private System.Windows.Forms.ComboBox cmbSerieTurma;
        private System.Windows.Forms.Label lblEnsino;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DataGridView dtAlunos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnSalvarEdit;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnDeletar;
    }
}

