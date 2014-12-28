namespace ControlePromotores
{
    partial class FormCadastro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.promotoresGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.promotorGroupBox = new System.Windows.Forms.GroupBox();
            this.SupervisorGroupBox = new System.Windows.Forms.GroupBox();
            this.emailSupervisorTextBox = new System.Windows.Forms.TextBox();
            this.emailSupervisorLabel = new System.Windows.Forms.Label();
            this.contatoSupervisorTextBox = new System.Windows.Forms.TextBox();
            this.contatoSupervisorLabel = new System.Windows.Forms.Label();
            this.digitalTextBox = new System.Windows.Forms.TextBox();
            this.NascimentoTextBox = new System.Windows.Forms.TextBox();
            this.NascimentoLabel = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cadastraDigitalButton = new System.Windows.Forms.Button();
            this.CelularTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.EmpresaTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.calularLabel = new System.Windows.Forms.Label();
            this.painelInferior = new System.Windows.Forms.Panel();
            this.GravarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.calendarioPictureBox = new System.Windows.Forms.PictureBox();
            this.digitalPictureBox = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotoresGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.promotorGroupBox.SuspendLayout();
            this.SupervisorGroupBox.SuspendLayout();
            this.painelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.painelInferior, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 453);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.promotoresGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // promotoresGrid
            // 
            this.promotoresGrid.AllowUserToAddRows = false;
            this.promotoresGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.promotoresGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.promotoresGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.promotoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotoresGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.promotoresGrid.Location = new System.Drawing.Point(7, 28);
            this.promotoresGrid.Name = "promotoresGrid";
            this.promotoresGrid.ReadOnly = true;
            this.promotoresGrid.Size = new System.Drawing.Size(856, 393);
            this.promotoresGrid.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.promotorGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Novo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // promotorGroupBox
            // 
            this.promotorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotorGroupBox.Controls.Add(this.button1);
            this.promotorGroupBox.Controls.Add(this.monthCalendar1);
            this.promotorGroupBox.Controls.Add(this.calendarioPictureBox);
            this.promotorGroupBox.Controls.Add(this.SupervisorGroupBox);
            this.promotorGroupBox.Controls.Add(this.digitalTextBox);
            this.promotorGroupBox.Controls.Add(this.NascimentoTextBox);
            this.promotorGroupBox.Controls.Add(this.NascimentoLabel);
            this.promotorGroupBox.Controls.Add(this.telefoneTextBox);
            this.promotorGroupBox.Controls.Add(this.TelefoneLabel);
            this.promotorGroupBox.Controls.Add(this.emailTextBox);
            this.promotorGroupBox.Controls.Add(this.emailLabel);
            this.promotorGroupBox.Controls.Add(this.digitalPictureBox);
            this.promotorGroupBox.Controls.Add(this.cadastraDigitalButton);
            this.promotorGroupBox.Controls.Add(this.CelularTextBox);
            this.promotorGroupBox.Controls.Add(this.nomeLabel);
            this.promotorGroupBox.Controls.Add(this.nomeTextBox);
            this.promotorGroupBox.Controls.Add(this.EmpresaTextBox);
            this.promotorGroupBox.Controls.Add(this.enderecoLabel);
            this.promotorGroupBox.Controls.Add(this.EnderecoTextBox);
            this.promotorGroupBox.Controls.Add(this.empresaLabel);
            this.promotorGroupBox.Controls.Add(this.calularLabel);
            this.promotorGroupBox.Location = new System.Drawing.Point(6, 3);
            this.promotorGroupBox.Name = "promotorGroupBox";
            this.promotorGroupBox.Size = new System.Drawing.Size(864, 428);
            this.promotorGroupBox.TabIndex = 12;
            this.promotorGroupBox.TabStop = false;
            this.promotorGroupBox.Text = "Dados do Promotor";
            // 
            // SupervisorGroupBox
            // 
            this.SupervisorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SupervisorGroupBox.Controls.Add(this.emailSupervisorTextBox);
            this.SupervisorGroupBox.Controls.Add(this.emailSupervisorLabel);
            this.SupervisorGroupBox.Controls.Add(this.contatoSupervisorTextBox);
            this.SupervisorGroupBox.Controls.Add(this.contatoSupervisorLabel);
            this.SupervisorGroupBox.Location = new System.Drawing.Point(8, 308);
            this.SupervisorGroupBox.Name = "SupervisorGroupBox";
            this.SupervisorGroupBox.Size = new System.Drawing.Size(371, 98);
            this.SupervisorGroupBox.TabIndex = 13;
            this.SupervisorGroupBox.TabStop = false;
            this.SupervisorGroupBox.Text = "Dados do Supervisor";
            // 
            // emailSupervisorTextBox
            // 
            this.emailSupervisorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailSupervisorTextBox.Location = new System.Drawing.Point(95, 56);
            this.emailSupervisorTextBox.Name = "emailSupervisorTextBox";
            this.emailSupervisorTextBox.Size = new System.Drawing.Size(219, 20);
            this.emailSupervisorTextBox.TabIndex = 13;
            // 
            // emailSupervisorLabel
            // 
            this.emailSupervisorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSupervisorLabel.AutoSize = true;
            this.emailSupervisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSupervisorLabel.Location = new System.Drawing.Point(13, 57);
            this.emailSupervisorLabel.Name = "emailSupervisorLabel";
            this.emailSupervisorLabel.Size = new System.Drawing.Size(45, 16);
            this.emailSupervisorLabel.TabIndex = 12;
            this.emailSupervisorLabel.Text = "Email:";
            // 
            // contatoSupervisorTextBox
            // 
            this.contatoSupervisorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contatoSupervisorTextBox.Location = new System.Drawing.Point(95, 27);
            this.contatoSupervisorTextBox.Name = "contatoSupervisorTextBox";
            this.contatoSupervisorTextBox.Size = new System.Drawing.Size(219, 20);
            this.contatoSupervisorTextBox.TabIndex = 11;
            // 
            // contatoSupervisorLabel
            // 
            this.contatoSupervisorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contatoSupervisorLabel.AutoSize = true;
            this.contatoSupervisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatoSupervisorLabel.Location = new System.Drawing.Point(13, 28);
            this.contatoSupervisorLabel.Name = "contatoSupervisorLabel";
            this.contatoSupervisorLabel.Size = new System.Drawing.Size(57, 16);
            this.contatoSupervisorLabel.TabIndex = 4;
            this.contatoSupervisorLabel.Text = "Contato:";
            // 
            // digitalTextBox
            // 
            this.digitalTextBox.Location = new System.Drawing.Point(387, 179);
            this.digitalTextBox.Name = "digitalTextBox";
            this.digitalTextBox.PasswordChar = '*';
            this.digitalTextBox.ReadOnly = true;
            this.digitalTextBox.Size = new System.Drawing.Size(219, 20);
            this.digitalTextBox.TabIndex = 18;
            this.digitalTextBox.UseSystemPasswordChar = true;
            // 
            // NascimentoTextBox
            // 
            this.NascimentoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NascimentoTextBox.Location = new System.Drawing.Point(103, 212);
            this.NascimentoTextBox.Name = "NascimentoTextBox";
            this.NascimentoTextBox.ReadOnly = true;
            this.NascimentoTextBox.Size = new System.Drawing.Size(219, 20);
            this.NascimentoTextBox.TabIndex = 17;
            // 
            // NascimentoLabel
            // 
            this.NascimentoLabel.AutoSize = true;
            this.NascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NascimentoLabel.Location = new System.Drawing.Point(21, 213);
            this.NascimentoLabel.Name = "NascimentoLabel";
            this.NascimentoLabel.Size = new System.Drawing.Size(83, 16);
            this.NascimentoLabel.TabIndex = 16;
            this.NascimentoLabel.Text = "Nascimento:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefoneTextBox.Location = new System.Drawing.Point(103, 185);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(219, 20);
            this.telefoneTextBox.TabIndex = 15;
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.AutoSize = true;
            this.TelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLabel.Location = new System.Drawing.Point(21, 186);
            this.TelefoneLabel.Name = "TelefoneLabel";
            this.TelefoneLabel.Size = new System.Drawing.Size(65, 16);
            this.TelefoneLabel.TabIndex = 14;
            this.TelefoneLabel.Text = "Telefone:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.Location = new System.Drawing.Point(103, 155);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(219, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(21, 156);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // cadastraDigitalButton
            // 
            this.cadastraDigitalButton.Location = new System.Drawing.Point(449, 150);
            this.cadastraDigitalButton.Name = "cadastraDigitalButton";
            this.cadastraDigitalButton.Size = new System.Drawing.Size(98, 23);
            this.cadastraDigitalButton.TabIndex = 10;
            this.cadastraDigitalButton.Text = "Cadastrar Digital";
            this.cadastraDigitalButton.UseVisualStyleBackColor = true;
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CelularTextBox.Location = new System.Drawing.Point(103, 124);
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(219, 20);
            this.CelularTextBox.TabIndex = 9;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(21, 22);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(48, 16);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.Location = new System.Drawing.Point(103, 22);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(219, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // EmpresaTextBox
            // 
            this.EmpresaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EmpresaTextBox.Location = new System.Drawing.Point(103, 89);
            this.EmpresaTextBox.Name = "EmpresaTextBox";
            this.EmpresaTextBox.Size = new System.Drawing.Size(219, 20);
            this.EmpresaTextBox.TabIndex = 8;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoLabel.Location = new System.Drawing.Point(21, 59);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(70, 16);
            this.enderecoLabel.TabIndex = 2;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EnderecoTextBox.Location = new System.Drawing.Point(103, 56);
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(219, 20);
            this.EnderecoTextBox.TabIndex = 7;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLabel.Location = new System.Drawing.Point(21, 92);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(66, 16);
            this.empresaLabel.TabIndex = 3;
            this.empresaLabel.Text = "Empresa:";
            // 
            // calularLabel
            // 
            this.calularLabel.AutoSize = true;
            this.calularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calularLabel.Location = new System.Drawing.Point(21, 127);
            this.calularLabel.Name = "calularLabel";
            this.calularLabel.Size = new System.Drawing.Size(56, 16);
            this.calularLabel.TabIndex = 6;
            this.calularLabel.Text = "Celular: ";
            // 
            // painelInferior
            // 
            this.painelInferior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelInferior.AutoSize = true;
            this.painelInferior.Controls.Add(this.GravarButton);
            this.painelInferior.Controls.Add(this.sairButton);
            this.painelInferior.Controls.Add(this.editarButton);
            this.painelInferior.Controls.Add(this.novoButton);
            this.painelInferior.Controls.Add(this.pesquisarButton);
            this.painelInferior.Location = new System.Drawing.Point(3, 462);
            this.painelInferior.Name = "painelInferior";
            this.painelInferior.Size = new System.Drawing.Size(881, 66);
            this.painelInferior.TabIndex = 0;
            // 
            // GravarButton
            // 
            this.GravarButton.Location = new System.Drawing.Point(300, 13);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(75, 23);
            this.GravarButton.TabIndex = 4;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.UseVisualStyleBackColor = true;
            this.GravarButton.Click += new System.EventHandler(this.GravarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.Location = new System.Drawing.Point(782, 13);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(206, 13);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 2;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(113, 13);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 1;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Location = new System.Drawing.Point(18, 13);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(75, 23);
            this.pesquisarButton.TabIndex = 0;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisaButton_Click);
            // 
            // calendarioPictureBox
            // 
            this.calendarioPictureBox.Image = global::ControlePromotores.Properties.Resources.calendario;
            this.calendarioPictureBox.Location = new System.Drawing.Point(328, 211);
            this.calendarioPictureBox.Name = "calendarioPictureBox";
            this.calendarioPictureBox.Size = new System.Drawing.Size(28, 27);
            this.calendarioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calendarioPictureBox.TabIndex = 19;
            this.calendarioPictureBox.TabStop = false;
            this.calendarioPictureBox.Click += new System.EventHandler(this.calendarioPictureBox_Click);
            // 
            // digitalPictureBox
            // 
            this.digitalPictureBox.Image = global::ControlePromotores.Properties.Resources.digital;
            this.digitalPictureBox.Location = new System.Drawing.Point(430, 39);
            this.digitalPictureBox.Name = "digitalPictureBox";
            this.digitalPictureBox.Size = new System.Drawing.Size(133, 105);
            this.digitalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.digitalPictureBox.TabIndex = 11;
            this.digitalPictureBox.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2014, 12, 10, 0, 0, 0, 0)};
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(103, 238);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(883, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Promotores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promotoresGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.promotorGroupBox.ResumeLayout(false);
            this.promotorGroupBox.PerformLayout();
            this.SupervisorGroupBox.ResumeLayout(false);
            this.SupervisorGroupBox.PerformLayout();
            this.painelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel painelInferior;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView promotoresGrid;
        private System.Windows.Forms.GroupBox SupervisorGroupBox;
        private System.Windows.Forms.GroupBox promotorGroupBox;
        private System.Windows.Forms.TextBox CelularTextBox;
        private System.Windows.Forms.TextBox contatoSupervisorTextBox;
        private System.Windows.Forms.Label contatoSupervisorLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox EmpresaTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.TextBox EnderecoTextBox;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label calularLabel;
        private System.Windows.Forms.PictureBox digitalPictureBox;
        private System.Windows.Forms.Button cadastraDigitalButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button GravarButton;
        private System.Windows.Forms.TextBox emailSupervisorTextBox;
        private System.Windows.Forms.Label emailSupervisorLabel;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.TextBox NascimentoTextBox;
        private System.Windows.Forms.Label NascimentoLabel;
        private System.Windows.Forms.TextBox digitalTextBox;
        private System.Windows.Forms.PictureBox calendarioPictureBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}

