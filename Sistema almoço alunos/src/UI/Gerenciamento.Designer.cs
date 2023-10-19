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
            this.ControleDeAbas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscaAgendamento = new System.Windows.Forms.TextBox();
            this.dtHistorico = new System.Windows.Forms.DataGridView();
            this.btnAgendarAlmoço = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlano = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBuscaPlano = new System.Windows.Forms.TextBox();
            this.txtValorPlano = new System.Windows.Forms.TextBox();
            this.txtNomePlano = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarPlano = new System.Windows.Forms.Button();
            this.btnSalvarPlano = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ControleDeAbas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistorico)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(155, 401);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(133, 26);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ControleDeAbas
            // 
            this.ControleDeAbas.Controls.Add(this.tabPage1);
            this.ControleDeAbas.Controls.Add(this.tabPage2);
            this.ControleDeAbas.Location = new System.Drawing.Point(4, 5);
            this.ControleDeAbas.Name = "ControleDeAbas";
            this.ControleDeAbas.SelectedIndex = 0;
            this.ControleDeAbas.Size = new System.Drawing.Size(440, 390);
            this.ControleDeAbas.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtBuscaAgendamento);
            this.tabPage1.Controls.Add(this.dtHistorico);
            this.tabPage1.Controls.Add(this.btnAgendarAlmoço);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblHorario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblPlano);
            this.tabPage1.Controls.Add(this.txtAno);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.txtMes);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.txtPlano);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.btnDeletar);
            this.tabPage1.Controls.Add(this.txtFim);
            this.tabPage1.Controls.Add(this.cmbPlano);
            this.tabPage1.Controls.Add(this.txtInicio);
            this.tabPage1.Controls.Add(this.lblData);
            this.tabPage1.Controls.Add(this.txtData);
            this.tabPage1.Controls.Add(this.lblValorTotal);
            this.tabPage1.Controls.Add(this.txtValorTotal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerenciar Agendamentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 118;
            this.label8.Text = "Valor Total";
            // 
            // txtBuscaAgendamento
            // 
            this.txtBuscaAgendamento.Location = new System.Drawing.Point(205, 48);
            this.txtBuscaAgendamento.Name = "txtBuscaAgendamento";
            this.txtBuscaAgendamento.ReadOnly = true;
            this.txtBuscaAgendamento.Size = new System.Drawing.Size(164, 20);
            this.txtBuscaAgendamento.TabIndex = 117;
            this.txtBuscaAgendamento.TextChanged += new System.EventHandler(this.txtBuscaAgendamento_TextChanged);
            // 
            // dtHistorico
            // 
            this.dtHistorico.AllowUserToAddRows = false;
            this.dtHistorico.AllowUserToDeleteRows = false;
            this.dtHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistorico.Location = new System.Drawing.Point(196, 74);
            this.dtHistorico.MultiSelect = false;
            this.dtHistorico.Name = "dtHistorico";
            this.dtHistorico.ReadOnly = true;
            this.dtHistorico.RowHeadersVisible = false;
            this.dtHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHistorico.Size = new System.Drawing.Size(194, 231);
            this.dtHistorico.TabIndex = 93;
            this.dtHistorico.SelectionChanged += new System.EventHandler(this.dtHistorico_SelectionChanged);
            // 
            // btnAgendarAlmoço
            // 
            this.btnAgendarAlmoço.Location = new System.Drawing.Point(17, 16);
            this.btnAgendarAlmoço.Name = "btnAgendarAlmoço";
            this.btnAgendarAlmoço.Size = new System.Drawing.Size(133, 45);
            this.btnAgendarAlmoço.TabIndex = 92;
            this.btnAgendarAlmoço.Text = "Agendar Almoço";
            this.btnAgendarAlmoço.UseVisualStyleBackColor = true;
            this.btnAgendarAlmoço.Click += new System.EventHandler(this.btnAgen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Ano:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(11, 156);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 94;
            this.lblHorario.Text = "Horario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Mês:";
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(12, 111);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(34, 13);
            this.lblPlano.TabIndex = 95;
            this.lblPlano.Text = "Plano";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(283, 16);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(32, 20);
            this.txtAno.TabIndex = 112;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(14, 205);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 96;
            this.lblValor.Text = "Valor";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 247);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 24);
            this.btnEditar.TabIndex = 97;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(226, 16);
            this.txtMes.Mask = "00";
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(19, 20);
            this.txtMes.TabIndex = 110;
            this.txtMes.ValidatingType = typeof(int);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(14, 246);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 24);
            this.btnSalvar.TabIndex = 98;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(16, 127);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.ReadOnly = true;
            this.txtPlano.Size = new System.Drawing.Size(133, 20);
            this.txtPlano.TabIndex = 109;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(98, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 24);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 221);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 108;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(98, 247);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(79, 24);
            this.btnDeletar.TabIndex = 100;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(85, 172);
            this.txtFim.Mask = "00:00";
            this.txtFim.Name = "txtFim";
            this.txtFim.ReadOnly = true;
            this.txtFim.Size = new System.Drawing.Size(63, 20);
            this.txtFim.TabIndex = 107;
            this.txtFim.ValidatingType = typeof(System.DateTime);
            // 
            // cmbPlano
            // 
            this.cmbPlano.Enabled = false;
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(16, 127);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(132, 21);
            this.cmbPlano.TabIndex = 101;
            this.cmbPlano.Visible = false;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(15, 172);
            this.txtInicio.Mask = "00:00";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(63, 20);
            this.txtInicio.TabIndex = 106;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 68);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 102;
            this.lblData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(17, 85);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 105;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(67, 70);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 103;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(215, 324);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(164, 20);
            this.txtValorTotal.TabIndex = 104;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBuscaPlano);
            this.tabPage2.Controls.Add(this.txtValorPlano);
            this.tabPage2.Controls.Add(this.txtNomePlano);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.mskFim);
            this.tabPage2.Controls.Add(this.mskInicio);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnNovoPlano);
            this.tabPage2.Controls.Add(this.btnEditarPlano);
            this.tabPage2.Controls.Add(this.btnDeletarPlano);
            this.tabPage2.Controls.Add(this.dtPlanos);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnCancelarPlano);
            this.tabPage2.Controls.Add(this.btnSalvarPlano);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerenciar Planos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBuscaPlano
            // 
            this.txtBuscaPlano.Location = new System.Drawing.Point(212, 24);
            this.txtBuscaPlano.Name = "txtBuscaPlano";
            this.txtBuscaPlano.Size = new System.Drawing.Size(192, 20);
            this.txtBuscaPlano.TabIndex = 111;
            this.txtBuscaPlano.TextChanged += new System.EventHandler(this.txtBuscaPlano_TextChanged);
            // 
            // txtValorPlano
            // 
            this.txtValorPlano.Location = new System.Drawing.Point(55, 217);
            this.txtValorPlano.Name = "txtValorPlano";
            this.txtValorPlano.ReadOnly = true;
            this.txtValorPlano.Size = new System.Drawing.Size(122, 20);
            this.txtValorPlano.TabIndex = 101;
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.Location = new System.Drawing.Point(55, 74);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.ReadOnly = true;
            this.txtNomePlano.Size = new System.Drawing.Size(122, 20);
            this.txtNomePlano.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 112;
            this.label12.Text = "Digite para buscar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "Saída:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Entrada:";
            // 
            // mskFim
            // 
            this.mskFim.Location = new System.Drawing.Point(55, 169);
            this.mskFim.Mask = "00:00";
            this.mskFim.Name = "mskFim";
            this.mskFim.ReadOnly = true;
            this.mskFim.Size = new System.Drawing.Size(62, 20);
            this.mskFim.TabIndex = 108;
            this.mskFim.ValidatingType = typeof(System.DateTime);
            // 
            // mskInicio
            // 
            this.mskInicio.Location = new System.Drawing.Point(54, 130);
            this.mskInicio.Mask = "00:00";
            this.mskInicio.Name = "mskInicio";
            this.mskInicio.ReadOnly = true;
            this.mskInicio.Size = new System.Drawing.Size(62, 20);
            this.mskInicio.TabIndex = 107;
            this.mskInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Horario";
            // 
            // btnNovoPlano
            // 
            this.btnNovoPlano.Location = new System.Drawing.Point(74, 24);
            this.btnNovoPlano.Name = "btnNovoPlano";
            this.btnNovoPlano.Size = new System.Drawing.Size(74, 27);
            this.btnNovoPlano.TabIndex = 105;
            this.btnNovoPlano.Text = "Novo Plano";
            this.btnNovoPlano.UseVisualStyleBackColor = true;
            this.btnNovoPlano.Click += new System.EventHandler(this.btnNovoPlano_Click);
            // 
            // btnEditarPlano
            // 
            this.btnEditarPlano.Location = new System.Drawing.Point(12, 257);
            this.btnEditarPlano.Name = "btnEditarPlano";
            this.btnEditarPlano.Size = new System.Drawing.Size(79, 27);
            this.btnEditarPlano.TabIndex = 104;
            this.btnEditarPlano.Text = "Editar";
            this.btnEditarPlano.UseVisualStyleBackColor = true;
            this.btnEditarPlano.Click += new System.EventHandler(this.btnEditarPlano_Click);
            // 
            // btnDeletarPlano
            // 
            this.btnDeletarPlano.Location = new System.Drawing.Point(108, 257);
            this.btnDeletarPlano.Name = "btnDeletarPlano";
            this.btnDeletarPlano.Size = new System.Drawing.Size(80, 28);
            this.btnDeletarPlano.TabIndex = 103;
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
            this.dtPlanos.Location = new System.Drawing.Point(212, 50);
            this.dtPlanos.MultiSelect = false;
            this.dtPlanos.Name = "dtPlanos";
            this.dtPlanos.ReadOnly = true;
            this.dtPlanos.RowHeadersVisible = false;
            this.dtPlanos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtPlanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPlanos.Size = new System.Drawing.Size(191, 281);
            this.dtPlanos.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Valor:";
            // 
            // btnCancelarPlano
            // 
            this.btnCancelarPlano.Enabled = false;
            this.btnCancelarPlano.Location = new System.Drawing.Point(109, 257);
            this.btnCancelarPlano.Name = "btnCancelarPlano";
            this.btnCancelarPlano.Size = new System.Drawing.Size(79, 27);
            this.btnCancelarPlano.TabIndex = 99;
            this.btnCancelarPlano.Text = "Cancelar";
            this.btnCancelarPlano.UseVisualStyleBackColor = true;
            this.btnCancelarPlano.Visible = false;
            this.btnCancelarPlano.Click += new System.EventHandler(this.btnCancelarPlano_Click);
            // 
            // btnSalvarPlano
            // 
            this.btnSalvarPlano.Enabled = false;
            this.btnSalvarPlano.Location = new System.Drawing.Point(12, 256);
            this.btnSalvarPlano.Name = "btnSalvarPlano";
            this.btnSalvarPlano.Size = new System.Drawing.Size(79, 27);
            this.btnSalvarPlano.TabIndex = 98;
            this.btnSalvarPlano.Text = "Salvar";
            this.btnSalvarPlano.UseVisualStyleBackColor = true;
            this.btnSalvarPlano.Visible = false;
            this.btnSalvarPlano.Click += new System.EventHandler(this.btnSalvarPlano_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Nome:";
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 439);
            this.Controls.Add(this.ControleDeAbas);
            this.Controls.Add(this.btnFechar);
            this.Name = "Gerenciamento";
            this.Text = "Detalhes do Aluno";
            this.ControleDeAbas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistorico)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPlanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabControl ControleDeAbas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtHistorico;
        private System.Windows.Forms.Button btnAgendarAlmoço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox txtMes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MaskedTextBox txtFim;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBuscaPlano;
        private System.Windows.Forms.TextBox txtValorPlano;
        private System.Windows.Forms.TextBox txtNomePlano;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskFim;
        private System.Windows.Forms.MaskedTextBox mskInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoPlano;
        private System.Windows.Forms.Button btnEditarPlano;
        private System.Windows.Forms.Button btnDeletarPlano;
        private System.Windows.Forms.DataGridView dtPlanos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarPlano;
        private System.Windows.Forms.Button btnSalvarPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscaAgendamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
    }
}