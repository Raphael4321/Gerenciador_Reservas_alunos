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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.ControleDeAbas = new System.Windows.Forms.TabControl();
            this.tabAlunos = new System.Windows.Forms.TabPage();
            this.tabPlanos = new System.Windows.Forms.TabPage();
            this.txtBuscaPlano = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskFim = new System.Windows.Forms.MaskedTextBox();
            this.mskInicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoPlano = new System.Windows.Forms.Button();
            this.btnEditarPlano = new System.Windows.Forms.Button();
            this.btnDeletarPlano = new System.Windows.Forms.Button();
            this.dtPlanos = new System.Windows.Forms.DataGridView();
            this.txtValorPlano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarPlano = new System.Windows.Forms.Button();
            this.btnSalvarPlano = new System.Windows.Forms.Button();
            this.txtNomePlano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabTurmas = new System.Windows.Forms.TabPage();
            this.btnDeletarTurma = new System.Windows.Forms.Button();
            this.btnEditarTurma = new System.Windows.Forms.Button();
            this.btnCancelarTurma = new System.Windows.Forms.Button();
            this.btnSalvarTurma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTurnoTurma = new System.Windows.Forms.TextBox();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAnoTurma = new System.Windows.Forms.TextBox();
            this.txtNivelTurma = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).BeginInit();
            this.ControleDeAbas.SuspendLayout();
            this.tabAlunos.SuspendLayout();
            this.tabPlanos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanos)).BeginInit();
            this.tabTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAlunos
            // 
            this.dtAlunos.AllowUserToAddRows = false;
            this.dtAlunos.AllowUserToDeleteRows = false;
            this.dtAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlunos.Location = new System.Drawing.Point(235, 90);
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
            this.btnNew.Location = new System.Drawing.Point(16, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 34);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Novo Aluno";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(26, 323);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(139, 48);
            this.btnDetail.TabIndex = 12;
            this.btnDetail.Text = "Gerenciar Agendamentos do aluno";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(259, 60);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(241, 20);
            this.txtBusca.TabIndex = 13;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // cbfiltro
            // 
            this.cbfiltro.Location = new System.Drawing.Point(506, 59);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(61, 21);
            this.cbfiltro.TabIndex = 15;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 195);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 24;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(15, 167);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(164, 20);
            this.txtResponsavel.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 22;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(12, 151);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 21;
            this.lblResponsavel.Text = "Responsavel";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(16, 242);
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
            this.btnSalvarEdit.Location = new System.Drawing.Point(16, 242);
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
            this.btnCancelEdit.Location = new System.Drawing.Point(101, 242);
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
            this.btnDeletar.Location = new System.Drawing.Point(100, 242);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(78, 23);
            this.btnDeletar.TabIndex = 29;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(16, 126);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(89, 20);
            this.txtTurma.TabIndex = 30;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(12, 110);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 31;
            this.lblTurma.Text = "Turma";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(16, 211);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(164, 20);
            this.txtTelefone.TabIndex = 32;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Digite para buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bsucar pelo:";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(348, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(133, 32);
            this.btnRelatorio.TabIndex = 37;
            this.btnRelatorio.Text = "Relatorio Geral";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // ControleDeAbas
            // 
            this.ControleDeAbas.Controls.Add(this.tabAlunos);
            this.ControleDeAbas.Controls.Add(this.tabPlanos);
            this.ControleDeAbas.Controls.Add(this.tabTurmas);
            this.ControleDeAbas.Location = new System.Drawing.Point(12, 12);
            this.ControleDeAbas.Name = "ControleDeAbas";
            this.ControleDeAbas.SelectedIndex = 0;
            this.ControleDeAbas.Size = new System.Drawing.Size(639, 426);
            this.ControleDeAbas.TabIndex = 38;
            // 
            // tabAlunos
            // 
            this.tabAlunos.Controls.Add(this.dtAlunos);
            this.tabAlunos.Controls.Add(this.txtNome);
            this.tabAlunos.Controls.Add(this.lblNome);
            this.tabAlunos.Controls.Add(this.btnRelatorio);
            this.tabAlunos.Controls.Add(this.txtTelefone);
            this.tabAlunos.Controls.Add(this.lblTurma);
            this.tabAlunos.Controls.Add(this.btnSalvarEdit);
            this.tabAlunos.Controls.Add(this.cbfiltro);
            this.tabAlunos.Controls.Add(this.btnEditar);
            this.tabAlunos.Controls.Add(this.lblResponsavel);
            this.tabAlunos.Controls.Add(this.btnNew);
            this.tabAlunos.Controls.Add(this.txtTurma);
            this.tabAlunos.Controls.Add(this.btnCancelEdit);
            this.tabAlunos.Controls.Add(this.txtBusca);
            this.tabAlunos.Controls.Add(this.label2);
            this.tabAlunos.Controls.Add(this.txtResponsavel);
            this.tabAlunos.Controls.Add(this.lblTelefone);
            this.tabAlunos.Controls.Add(this.label1);
            this.tabAlunos.Controls.Add(this.btnDetail);
            this.tabAlunos.Controls.Add(this.btnDeletar);
            this.tabAlunos.Location = new System.Drawing.Point(4, 22);
            this.tabAlunos.Name = "tabAlunos";
            this.tabAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlunos.Size = new System.Drawing.Size(631, 400);
            this.tabAlunos.TabIndex = 0;
            this.tabAlunos.Text = "Gerenciar alunos";
            this.tabAlunos.UseVisualStyleBackColor = true;
            // 
            // tabPlanos
            // 
            this.tabPlanos.Controls.Add(this.txtBuscaPlano);
            this.tabPlanos.Controls.Add(this.label12);
            this.tabPlanos.Controls.Add(this.label7);
            this.tabPlanos.Controls.Add(this.label6);
            this.tabPlanos.Controls.Add(this.mskFim);
            this.tabPlanos.Controls.Add(this.mskInicio);
            this.tabPlanos.Controls.Add(this.label3);
            this.tabPlanos.Controls.Add(this.btnNovoPlano);
            this.tabPlanos.Controls.Add(this.btnEditarPlano);
            this.tabPlanos.Controls.Add(this.btnDeletarPlano);
            this.tabPlanos.Controls.Add(this.dtPlanos);
            this.tabPlanos.Controls.Add(this.txtValorPlano);
            this.tabPlanos.Controls.Add(this.label4);
            this.tabPlanos.Controls.Add(this.btnCancelarPlano);
            this.tabPlanos.Controls.Add(this.btnSalvarPlano);
            this.tabPlanos.Controls.Add(this.txtNomePlano);
            this.tabPlanos.Controls.Add(this.label5);
            this.tabPlanos.Location = new System.Drawing.Point(4, 22);
            this.tabPlanos.Name = "tabPlanos";
            this.tabPlanos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanos.Size = new System.Drawing.Size(631, 400);
            this.tabPlanos.TabIndex = 1;
            this.tabPlanos.Text = "Gerenciar planos";
            this.tabPlanos.UseVisualStyleBackColor = true;
            // 
            // txtBuscaPlano
            // 
            this.txtBuscaPlano.Location = new System.Drawing.Point(297, 45);
            this.txtBuscaPlano.Name = "txtBuscaPlano";
            this.txtBuscaPlano.Size = new System.Drawing.Size(241, 20);
            this.txtBuscaPlano.TabIndex = 93;
            this.txtBuscaPlano.TextChanged += new System.EventHandler(this.txtBuscaPlano_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Digite para buscar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Saída:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Entrada:";
            // 
            // mskFim
            // 
            this.mskFim.Location = new System.Drawing.Point(60, 190);
            this.mskFim.Mask = "00:00";
            this.mskFim.Name = "mskFim";
            this.mskFim.ReadOnly = true;
            this.mskFim.Size = new System.Drawing.Size(62, 20);
            this.mskFim.TabIndex = 90;
            this.mskFim.ValidatingType = typeof(System.DateTime);
            // 
            // mskInicio
            // 
            this.mskInicio.Location = new System.Drawing.Point(59, 151);
            this.mskInicio.Mask = "00:00";
            this.mskInicio.Name = "mskInicio";
            this.mskInicio.ReadOnly = true;
            this.mskInicio.Size = new System.Drawing.Size(62, 20);
            this.mskInicio.TabIndex = 89;
            this.mskInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Horario";
            // 
            // btnNovoPlano
            // 
            this.btnNovoPlano.Location = new System.Drawing.Point(99, 54);
            this.btnNovoPlano.Name = "btnNovoPlano";
            this.btnNovoPlano.Size = new System.Drawing.Size(74, 27);
            this.btnNovoPlano.TabIndex = 87;
            this.btnNovoPlano.Text = "Novo Plano";
            this.btnNovoPlano.UseVisualStyleBackColor = true;
            this.btnNovoPlano.Click += new System.EventHandler(this.btnNovoPlano_Click);
            // 
            // btnEditarPlano
            // 
            this.btnEditarPlano.Location = new System.Drawing.Point(43, 276);
            this.btnEditarPlano.Name = "btnEditarPlano";
            this.btnEditarPlano.Size = new System.Drawing.Size(79, 27);
            this.btnEditarPlano.TabIndex = 86;
            this.btnEditarPlano.Text = "Editar";
            this.btnEditarPlano.UseVisualStyleBackColor = true;
            this.btnEditarPlano.Click += new System.EventHandler(this.btnEditarPlano_Click);
            // 
            // btnDeletarPlano
            // 
            this.btnDeletarPlano.Location = new System.Drawing.Point(139, 276);
            this.btnDeletarPlano.Name = "btnDeletarPlano";
            this.btnDeletarPlano.Size = new System.Drawing.Size(80, 28);
            this.btnDeletarPlano.TabIndex = 85;
            this.btnDeletarPlano.Text = "Deletar";
            this.btnDeletarPlano.UseVisualStyleBackColor = true;
            this.btnDeletarPlano.Click += new System.EventHandler(this.btnDeletarPlano_Click);
            // 
            // dtPlanos
            // 
            this.dtPlanos.AllowUserToAddRows = false;
            this.dtPlanos.AllowUserToDeleteRows = false;
            this.dtPlanos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPlanos.Location = new System.Drawing.Point(297, 71);
            this.dtPlanos.MultiSelect = false;
            this.dtPlanos.Name = "dtPlanos";
            this.dtPlanos.ReadOnly = true;
            this.dtPlanos.RowHeadersVisible = false;
            this.dtPlanos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtPlanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPlanos.Size = new System.Drawing.Size(248, 307);
            this.dtPlanos.TabIndex = 84;
            this.dtPlanos.SelectionChanged += new System.EventHandler(this.dtPlanos_SelectionChanged);
            // 
            // txtValorPlano
            // 
            this.txtValorPlano.Location = new System.Drawing.Point(60, 238);
            this.txtValorPlano.Name = "txtValorPlano";
            this.txtValorPlano.ReadOnly = true;
            this.txtValorPlano.Size = new System.Drawing.Size(145, 20);
            this.txtValorPlano.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Valor:";
            // 
            // btnCancelarPlano
            // 
            this.btnCancelarPlano.Enabled = false;
            this.btnCancelarPlano.Location = new System.Drawing.Point(140, 276);
            this.btnCancelarPlano.Name = "btnCancelarPlano";
            this.btnCancelarPlano.Size = new System.Drawing.Size(79, 27);
            this.btnCancelarPlano.TabIndex = 81;
            this.btnCancelarPlano.Text = "Cancelar";
            this.btnCancelarPlano.UseVisualStyleBackColor = true;
            this.btnCancelarPlano.Visible = false;
            this.btnCancelarPlano.Click += new System.EventHandler(this.btnCancelarPlano_Click);
            // 
            // btnSalvarPlano
            // 
            this.btnSalvarPlano.Enabled = false;
            this.btnSalvarPlano.Location = new System.Drawing.Point(43, 275);
            this.btnSalvarPlano.Name = "btnSalvarPlano";
            this.btnSalvarPlano.Size = new System.Drawing.Size(79, 27);
            this.btnSalvarPlano.TabIndex = 80;
            this.btnSalvarPlano.Text = "Salvar";
            this.btnSalvarPlano.UseVisualStyleBackColor = true;
            this.btnSalvarPlano.Visible = false;
            this.btnSalvarPlano.Click += new System.EventHandler(this.btnSalvarPlano_Click);
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.Location = new System.Drawing.Point(60, 95);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.ReadOnly = true;
            this.txtNomePlano.Size = new System.Drawing.Size(145, 20);
            this.txtNomePlano.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Nome:";
            // 
            // tabTurmas
            // 
            this.tabTurmas.Controls.Add(this.btnDeletarTurma);
            this.tabTurmas.Controls.Add(this.btnEditarTurma);
            this.tabTurmas.Controls.Add(this.btnCancelarTurma);
            this.tabTurmas.Controls.Add(this.btnSalvarTurma);
            this.tabTurmas.Controls.Add(this.dataGridView1);
            this.tabTurmas.Controls.Add(this.txtTurnoTurma);
            this.tabTurmas.Controls.Add(this.txtNomeTurma);
            this.tabTurmas.Controls.Add(this.label8);
            this.tabTurmas.Controls.Add(this.label9);
            this.tabTurmas.Controls.Add(this.label10);
            this.tabTurmas.Controls.Add(this.txtAnoTurma);
            this.tabTurmas.Controls.Add(this.txtNivelTurma);
            this.tabTurmas.Controls.Add(this.lbl);
            this.tabTurmas.Location = new System.Drawing.Point(4, 22);
            this.tabTurmas.Name = "tabTurmas";
            this.tabTurmas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTurmas.Size = new System.Drawing.Size(631, 400);
            this.tabTurmas.TabIndex = 2;
            this.tabTurmas.Text = "Gerenciar Turmas";
            this.tabTurmas.UseVisualStyleBackColor = true;
            // 
            // btnDeletarTurma
            // 
            this.btnDeletarTurma.Location = new System.Drawing.Point(162, 285);
            this.btnDeletarTurma.Name = "btnDeletarTurma";
            this.btnDeletarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarTurma.TabIndex = 44;
            this.btnDeletarTurma.Text = "Deletar";
            this.btnDeletarTurma.UseVisualStyleBackColor = true;
            // 
            // btnEditarTurma
            // 
            this.btnEditarTurma.Location = new System.Drawing.Point(162, 235);
            this.btnEditarTurma.Name = "btnEditarTurma";
            this.btnEditarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTurma.TabIndex = 43;
            this.btnEditarTurma.Text = "Editar";
            this.btnEditarTurma.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTurma
            // 
            this.btnCancelarTurma.Location = new System.Drawing.Point(45, 285);
            this.btnCancelarTurma.Name = "btnCancelarTurma";
            this.btnCancelarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTurma.TabIndex = 42;
            this.btnCancelarTurma.Text = "Cancelar";
            this.btnCancelarTurma.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTurma
            // 
            this.btnSalvarTurma.Location = new System.Drawing.Point(45, 235);
            this.btnSalvarTurma.Name = "btnSalvarTurma";
            this.btnSalvarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTurma.TabIndex = 41;
            this.btnSalvarTurma.Text = "Salvar";
            this.btnSalvarTurma.UseVisualStyleBackColor = true;
            this.btnSalvarTurma.Click += new System.EventHandler(this.btnSalvarTurma_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(301, 349);
            this.dataGridView1.TabIndex = 40;
            // 
            // txtTurnoTurma
            // 
            this.txtTurnoTurma.Location = new System.Drawing.Point(44, 182);
            this.txtTurnoTurma.Name = "txtTurnoTurma";
            this.txtTurnoTurma.ReadOnly = true;
            this.txtTurnoTurma.Size = new System.Drawing.Size(90, 20);
            this.txtTurnoTurma.TabIndex = 39;
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(43, 54);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.ReadOnly = true;
            this.txtNomeTurma.Size = new System.Drawing.Size(90, 20);
            this.txtNomeTurma.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ano";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Nivel";
            // 
            // txtAnoTurma
            // 
            this.txtAnoTurma.Location = new System.Drawing.Point(44, 95);
            this.txtAnoTurma.Name = "txtAnoTurma";
            this.txtAnoTurma.ReadOnly = true;
            this.txtAnoTurma.Size = new System.Drawing.Size(89, 20);
            this.txtAnoTurma.TabIndex = 37;
            // 
            // txtNivelTurma
            // 
            this.txtNivelTurma.Location = new System.Drawing.Point(44, 138);
            this.txtNivelTurma.Name = "txtNivelTurma";
            this.txtNivelTurma.ReadOnly = true;
            this.txtNivelTurma.Size = new System.Drawing.Size(90, 20);
            this.txtNivelTurma.TabIndex = 35;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(42, 166);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 36;
            this.lbl.Text = "Turno";
            // 
            // CadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 447);
            this.Controls.Add(this.ControleDeAbas);
            this.Name = "CadAluno";
            this.Text = "Gerenciador de alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).EndInit();
            this.ControleDeAbas.ResumeLayout(false);
            this.tabAlunos.ResumeLayout(false);
            this.tabAlunos.PerformLayout();
            this.tabPlanos.ResumeLayout(false);
            this.tabPlanos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanos)).EndInit();
            this.tabTurmas.ResumeLayout(false);
            this.tabTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.TabControl ControleDeAbas;
        private System.Windows.Forms.TabPage tabAlunos;
        private System.Windows.Forms.TabPage tabPlanos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskFim;
        private System.Windows.Forms.MaskedTextBox mskInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoPlano;
        private System.Windows.Forms.Button btnEditarPlano;
        private System.Windows.Forms.Button btnDeletarPlano;
        private System.Windows.Forms.DataGridView dtPlanos;
        private System.Windows.Forms.TextBox txtValorPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarPlano;
        private System.Windows.Forms.Button btnSalvarPlano;
        private System.Windows.Forms.TextBox txtNomePlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabTurmas;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAnoTurma;
        private System.Windows.Forms.TextBox txtNivelTurma;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCancelarTurma;
        private System.Windows.Forms.Button btnSalvarTurma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTurnoTurma;
        private System.Windows.Forms.Button btnDeletarTurma;
        private System.Windows.Forms.Button btnEditarTurma;
        private System.Windows.Forms.TextBox txtBuscaPlano;
        private System.Windows.Forms.Label label12;
    }
}

