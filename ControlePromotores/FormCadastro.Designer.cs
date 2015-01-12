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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.promotoresGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.promotorGroupBox = new System.Windows.Forms.GroupBox();
            this.emailSupervisorInvalidoLabel = new System.Windows.Forms.Label();
            this.emailInvalidoLabel = new System.Windows.Forms.Label();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.fotoButton = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.validaCPFLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.CelularTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.calendarioPictureBox = new System.Windows.Forms.PictureBox();
            this.SupervisorGroupBox = new System.Windows.Forms.GroupBox();
            this.contatoSupervisorTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailSupervisorTextBox = new System.Windows.Forms.TextBox();
            this.emailSupervisorLabel = new System.Windows.Forms.Label();
            this.contatoSupervisorLabel = new System.Windows.Forms.Label();
            this.digitalTextBox = new System.Windows.Forms.TextBox();
            this.NascimentoTextBox = new System.Windows.Forms.TextBox();
            this.NascimentoLabel = new System.Windows.Forms.Label();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.digitalPictureBox = new System.Windows.Forms.PictureBox();
            this.cadastraDigitalButton = new System.Windows.Forms.Button();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.EmpresaTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.calularLabel = new System.Windows.Forms.Label();
            this.GravarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.jornadaGroupBox = new System.Windows.Forms.GroupBox();
            this.cargaLabel = new System.Windows.Forms.Label();
            this.enviaRelatorioCheckBox = new System.Windows.Forms.CheckBox();
            this.cargaHorariaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotoresGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.promotorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioPictureBox)).BeginInit();
            this.SupervisorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPictureBox)).BeginInit();
            this.jornadaGroupBox.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 527F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 527);
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
            this.tabControl1.Size = new System.Drawing.Size(958, 521);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.promotoresGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 495);
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
            this.promotoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.promotoresGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.promotoresGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.promotoresGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.promotoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotoresGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.promotoresGrid.Location = new System.Drawing.Point(7, 6);
            this.promotoresGrid.MultiSelect = false;
            this.promotoresGrid.Name = "promotoresGrid";
            this.promotoresGrid.ReadOnly = true;
            this.promotoresGrid.Size = new System.Drawing.Size(937, 483);
            this.promotoresGrid.TabIndex = 1;
            this.promotoresGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.promotoresGrid_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.promotorGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Novo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // promotorGroupBox
            // 
            this.promotorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotorGroupBox.Controls.Add(this.jornadaGroupBox);
            this.promotorGroupBox.Controls.Add(this.emailSupervisorInvalidoLabel);
            this.promotorGroupBox.Controls.Add(this.emailInvalidoLabel);
            this.promotorGroupBox.Controls.Add(this.fotoTextBox);
            this.promotorGroupBox.Controls.Add(this.fotoButton);
            this.promotorGroupBox.Controls.Add(this.fotoPictureBox);
            this.promotorGroupBox.Controls.Add(this.validaCPFLabel);
            this.promotorGroupBox.Controls.Add(this.nomeTextBox);
            this.promotorGroupBox.Controls.Add(this.cpfTextBox);
            this.promotorGroupBox.Controls.Add(this.cpfLabel);
            this.promotorGroupBox.Controls.Add(this.CelularTextBox);
            this.promotorGroupBox.Controls.Add(this.telefoneTextBox);
            this.promotorGroupBox.Controls.Add(this.monthCalendar1);
            this.promotorGroupBox.Controls.Add(this.calendarioPictureBox);
            this.promotorGroupBox.Controls.Add(this.SupervisorGroupBox);
            this.promotorGroupBox.Controls.Add(this.digitalTextBox);
            this.promotorGroupBox.Controls.Add(this.NascimentoTextBox);
            this.promotorGroupBox.Controls.Add(this.NascimentoLabel);
            this.promotorGroupBox.Controls.Add(this.TelefoneLabel);
            this.promotorGroupBox.Controls.Add(this.emailTextBox);
            this.promotorGroupBox.Controls.Add(this.emailLabel);
            this.promotorGroupBox.Controls.Add(this.digitalPictureBox);
            this.promotorGroupBox.Controls.Add(this.cadastraDigitalButton);
            this.promotorGroupBox.Controls.Add(this.nomeLabel);
            this.promotorGroupBox.Controls.Add(this.EmpresaTextBox);
            this.promotorGroupBox.Controls.Add(this.enderecoLabel);
            this.promotorGroupBox.Controls.Add(this.EnderecoTextBox);
            this.promotorGroupBox.Controls.Add(this.empresaLabel);
            this.promotorGroupBox.Controls.Add(this.calularLabel);
            this.promotorGroupBox.Location = new System.Drawing.Point(6, 3);
            this.promotorGroupBox.Name = "promotorGroupBox";
            this.promotorGroupBox.Size = new System.Drawing.Size(938, 496);
            this.promotorGroupBox.TabIndex = 12;
            this.promotorGroupBox.TabStop = false;
            this.promotorGroupBox.Text = "Dados do Promotor";
            // 
            // emailSupervisorInvalidoLabel
            // 
            this.emailSupervisorInvalidoLabel.AutoSize = true;
            this.emailSupervisorInvalidoLabel.ForeColor = System.Drawing.Color.Red;
            this.emailSupervisorInvalidoLabel.Location = new System.Drawing.Point(329, 436);
            this.emailSupervisorInvalidoLabel.Name = "emailSupervisorInvalidoLabel";
            this.emailSupervisorInvalidoLabel.Size = new System.Drawing.Size(128, 13);
            this.emailSupervisorInvalidoLabel.TabIndex = 31;
            this.emailSupervisorInvalidoLabel.Text = "Email Digitado é inválido !";
            this.emailSupervisorInvalidoLabel.Visible = false;
            // 
            // emailInvalidoLabel
            // 
            this.emailInvalidoLabel.AutoSize = true;
            this.emailInvalidoLabel.ForeColor = System.Drawing.Color.Red;
            this.emailInvalidoLabel.Location = new System.Drawing.Point(329, 172);
            this.emailInvalidoLabel.Name = "emailInvalidoLabel";
            this.emailInvalidoLabel.Size = new System.Drawing.Size(128, 13);
            this.emailInvalidoLabel.TabIndex = 30;
            this.emailInvalidoLabel.Text = "Email Digitado é inválido !";
            this.emailInvalidoLabel.Visible = false;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoTextBox.Location = new System.Drawing.Point(467, 191);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.ReadOnly = true;
            this.fotoTextBox.Size = new System.Drawing.Size(219, 20);
            this.fotoTextBox.TabIndex = 29;
            // 
            // fotoButton
            // 
            this.fotoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoButton.Location = new System.Drawing.Point(524, 162);
            this.fotoButton.Name = "fotoButton";
            this.fotoButton.Size = new System.Drawing.Size(98, 23);
            this.fotoButton.TabIndex = 28;
            this.fotoButton.Text = "Cadastrar Foto";
            this.fotoButton.UseVisualStyleBackColor = true;
            this.fotoButton.Click += new System.EventHandler(this.fotoButton_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoPictureBox.Image = global::ControlePromotores.Properties.Resources.indigente;
            this.fotoPictureBox.Location = new System.Drawing.Point(490, 42);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(164, 114);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 27;
            this.fotoPictureBox.TabStop = false;
            // 
            // validaCPFLabel
            // 
            this.validaCPFLabel.AutoSize = true;
            this.validaCPFLabel.ForeColor = System.Drawing.Color.Red;
            this.validaCPFLabel.Location = new System.Drawing.Point(329, 57);
            this.validaCPFLabel.Name = "validaCPFLabel";
            this.validaCPFLabel.Size = new System.Drawing.Size(121, 13);
            this.validaCPFLabel.TabIndex = 26;
            this.validaCPFLabel.Text = "CPF digitado é inválido !";
            this.validaCPFLabel.Visible = false;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.Location = new System.Drawing.Point(103, 21);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(219, 20);
            this.nomeTextBox.TabIndex = 25;
            this.nomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeTextBox_KeyPress);
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(103, 51);
            this.cpfTextBox.Mask = "000.000.000-00";
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(219, 20);
            this.cpfTextBox.TabIndex = 24;
            this.cpfTextBox.Leave += new System.EventHandler(this.cpfTextBox_Leave);
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.Location = new System.Drawing.Point(21, 52);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(37, 16);
            this.cpfLabel.TabIndex = 23;
            this.cpfLabel.Text = "CPF:";
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.Location = new System.Drawing.Point(103, 139);
            this.CelularTextBox.Mask = "(99)0000-0000";
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(219, 20);
            this.CelularTextBox.TabIndex = 22;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(103, 199);
            this.telefoneTextBox.Mask = "(99)0000-0000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(219, 20);
            this.telefoneTextBox.TabIndex = 21;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2014, 12, 10, 0, 0, 0, 0)};
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(355, 253);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // calendarioPictureBox
            // 
            this.calendarioPictureBox.Image = global::ControlePromotores.Properties.Resources.calendario;
            this.calendarioPictureBox.Location = new System.Drawing.Point(328, 227);
            this.calendarioPictureBox.Name = "calendarioPictureBox";
            this.calendarioPictureBox.Size = new System.Drawing.Size(28, 27);
            this.calendarioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calendarioPictureBox.TabIndex = 19;
            this.calendarioPictureBox.TabStop = false;
            this.calendarioPictureBox.Click += new System.EventHandler(this.calendarioPictureBox_Click);
            // 
            // SupervisorGroupBox
            // 
            this.SupervisorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SupervisorGroupBox.Controls.Add(this.contatoSupervisorTextBox);
            this.SupervisorGroupBox.Controls.Add(this.emailSupervisorTextBox);
            this.SupervisorGroupBox.Controls.Add(this.emailSupervisorLabel);
            this.SupervisorGroupBox.Controls.Add(this.contatoSupervisorLabel);
            this.SupervisorGroupBox.Location = new System.Drawing.Point(8, 376);
            this.SupervisorGroupBox.Name = "SupervisorGroupBox";
            this.SupervisorGroupBox.Size = new System.Drawing.Size(371, 98);
            this.SupervisorGroupBox.TabIndex = 13;
            this.SupervisorGroupBox.TabStop = false;
            this.SupervisorGroupBox.Text = "Dados do Supervisor";
            // 
            // contatoSupervisorTextBox
            // 
            this.contatoSupervisorTextBox.Location = new System.Drawing.Point(95, 27);
            this.contatoSupervisorTextBox.Mask = "(99)0000-0000";
            this.contatoSupervisorTextBox.Name = "contatoSupervisorTextBox";
            this.contatoSupervisorTextBox.Size = new System.Drawing.Size(219, 20);
            this.contatoSupervisorTextBox.TabIndex = 23;
            // 
            // emailSupervisorTextBox
            // 
            this.emailSupervisorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailSupervisorTextBox.Location = new System.Drawing.Point(95, 56);
            this.emailSupervisorTextBox.Name = "emailSupervisorTextBox";
            this.emailSupervisorTextBox.Size = new System.Drawing.Size(219, 20);
            this.emailSupervisorTextBox.TabIndex = 13;
            this.emailSupervisorTextBox.Leave += new System.EventHandler(this.emailSupervisorTextBox_Leave);
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
            // contatoSupervisorLabel
            // 
            this.contatoSupervisorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contatoSupervisorLabel.AutoSize = true;
            this.contatoSupervisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatoSupervisorLabel.Location = new System.Drawing.Point(13, 28);
            this.contatoSupervisorLabel.Name = "contatoSupervisorLabel";
            this.contatoSupervisorLabel.Size = new System.Drawing.Size(65, 16);
            this.contatoSupervisorLabel.TabIndex = 4;
            this.contatoSupervisorLabel.Text = "Telefone:";
            // 
            // digitalTextBox
            // 
            this.digitalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.digitalTextBox.Location = new System.Drawing.Point(692, 191);
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
            this.NascimentoTextBox.Location = new System.Drawing.Point(103, 230);
            this.NascimentoTextBox.Name = "NascimentoTextBox";
            this.NascimentoTextBox.ReadOnly = true;
            this.NascimentoTextBox.Size = new System.Drawing.Size(219, 20);
            this.NascimentoTextBox.TabIndex = 17;
            // 
            // NascimentoLabel
            // 
            this.NascimentoLabel.AutoSize = true;
            this.NascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NascimentoLabel.Location = new System.Drawing.Point(21, 231);
            this.NascimentoLabel.Name = "NascimentoLabel";
            this.NascimentoLabel.Size = new System.Drawing.Size(83, 16);
            this.NascimentoLabel.TabIndex = 16;
            this.NascimentoLabel.Text = "Nascimento:";
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.AutoSize = true;
            this.TelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLabel.Location = new System.Drawing.Point(21, 200);
            this.TelefoneLabel.Name = "TelefoneLabel";
            this.TelefoneLabel.Size = new System.Drawing.Size(65, 16);
            this.TelefoneLabel.TabIndex = 14;
            this.TelefoneLabel.Text = "Telefone:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.Location = new System.Drawing.Point(103, 169);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(219, 20);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave_1);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(21, 170);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // digitalPictureBox
            // 
            this.digitalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.digitalPictureBox.Image = global::ControlePromotores.Properties.Resources.digital;
            this.digitalPictureBox.Location = new System.Drawing.Point(721, 42);
            this.digitalPictureBox.Name = "digitalPictureBox";
            this.digitalPictureBox.Size = new System.Drawing.Size(164, 114);
            this.digitalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.digitalPictureBox.TabIndex = 11;
            this.digitalPictureBox.TabStop = false;
            // 
            // cadastraDigitalButton
            // 
            this.cadastraDigitalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastraDigitalButton.Location = new System.Drawing.Point(754, 162);
            this.cadastraDigitalButton.Name = "cadastraDigitalButton";
            this.cadastraDigitalButton.Size = new System.Drawing.Size(98, 23);
            this.cadastraDigitalButton.TabIndex = 10;
            this.cadastraDigitalButton.Text = "Cadastrar Digital";
            this.cadastraDigitalButton.UseVisualStyleBackColor = true;
            this.cadastraDigitalButton.Click += new System.EventHandler(this.cadastraDigitalButton_Click);
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
            // EmpresaTextBox
            // 
            this.EmpresaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EmpresaTextBox.Location = new System.Drawing.Point(103, 108);
            this.EmpresaTextBox.Name = "EmpresaTextBox";
            this.EmpresaTextBox.Size = new System.Drawing.Size(219, 20);
            this.EmpresaTextBox.TabIndex = 8;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoLabel.Location = new System.Drawing.Point(21, 83);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(70, 16);
            this.enderecoLabel.TabIndex = 2;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EnderecoTextBox.Location = new System.Drawing.Point(103, 80);
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(219, 20);
            this.EnderecoTextBox.TabIndex = 7;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLabel.Location = new System.Drawing.Point(21, 109);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(66, 16);
            this.empresaLabel.TabIndex = 3;
            this.empresaLabel.Text = "Empresa:";
            // 
            // calularLabel
            // 
            this.calularLabel.AutoSize = true;
            this.calularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calularLabel.Location = new System.Drawing.Point(21, 140);
            this.calularLabel.Name = "calularLabel";
            this.calularLabel.Size = new System.Drawing.Size(56, 16);
            this.calularLabel.TabIndex = 6;
            this.calularLabel.Text = "Celular: ";
            // 
            // GravarButton
            // 
            this.GravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GravarButton.Enabled = false;
            this.GravarButton.Location = new System.Drawing.Point(256, 624);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(75, 26);
            this.GravarButton.TabIndex = 4;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.UseVisualStyleBackColor = true;
            this.GravarButton.Click += new System.EventHandler(this.GravarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.Location = new System.Drawing.Point(901, 624);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 26);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editarButton.Location = new System.Drawing.Point(175, 624);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 26);
            this.editarButton.TabIndex = 2;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.novoButton.Location = new System.Drawing.Point(94, 624);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 26);
            this.novoButton.TabIndex = 1;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pesquisarButton.Location = new System.Drawing.Point(12, 624);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(75, 26);
            this.pesquisarButton.TabIndex = 0;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisaButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloLabel.Location = new System.Drawing.Point(287, 20);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(420, 47);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Cadastro de Promotores";
            // 
            // jornadaGroupBox
            // 
            this.jornadaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.jornadaGroupBox.Controls.Add(this.cargaHorariaTextBox);
            this.jornadaGroupBox.Controls.Add(this.enviaRelatorioCheckBox);
            this.jornadaGroupBox.Controls.Add(this.cargaLabel);
            this.jornadaGroupBox.Location = new System.Drawing.Point(8, 270);
            this.jornadaGroupBox.Name = "jornadaGroupBox";
            this.jornadaGroupBox.Size = new System.Drawing.Size(335, 100);
            this.jornadaGroupBox.TabIndex = 32;
            this.jornadaGroupBox.TabStop = false;
            this.jornadaGroupBox.Text = "Carga Horária";
            // 
            // cargaLabel
            // 
            this.cargaLabel.AutoSize = true;
            this.cargaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargaLabel.Location = new System.Drawing.Point(13, 28);
            this.cargaLabel.Name = "cargaLabel";
            this.cargaLabel.Size = new System.Drawing.Size(115, 16);
            this.cargaLabel.TabIndex = 33;
            this.cargaLabel.Text = "Horas Semanais: ";
            // 
            // enviaRelatorioCheckBox
            // 
            this.enviaRelatorioCheckBox.AutoSize = true;
            this.enviaRelatorioCheckBox.Location = new System.Drawing.Point(16, 64);
            this.enviaRelatorioCheckBox.Name = "enviaRelatorioCheckBox";
            this.enviaRelatorioCheckBox.Size = new System.Drawing.Size(144, 17);
            this.enviaRelatorioCheckBox.TabIndex = 34;
            this.enviaRelatorioCheckBox.Text = "Envia relatorio semanal ?";
            this.enviaRelatorioCheckBox.UseVisualStyleBackColor = true;
            // 
            // cargaHorariaTextBox
            // 
            this.cargaHorariaTextBox.Location = new System.Drawing.Point(129, 27);
            this.cargaHorariaTextBox.Mask = "00";
            this.cargaHorariaTextBox.Name = "cargaHorariaTextBox";
            this.cargaHorariaTextBox.Size = new System.Drawing.Size(52, 20);
            this.cargaHorariaTextBox.TabIndex = 33;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ControlePromotores.Properties.Resources.MenuprincipalBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 667);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.GravarButton);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.pesquisarButton);
            this.Controls.Add(this.novoButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Promotores";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promotoresGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.promotorGroupBox.ResumeLayout(false);
            this.promotorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioPictureBox)).EndInit();
            this.SupervisorGroupBox.ResumeLayout(false);
            this.SupervisorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalPictureBox)).EndInit();
            this.jornadaGroupBox.ResumeLayout(false);
            this.jornadaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Label contatoSupervisorLabel;
        private System.Windows.Forms.Label nomeLabel;
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
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.TextBox NascimentoTextBox;
        private System.Windows.Forms.Label NascimentoLabel;
        private System.Windows.Forms.TextBox digitalTextBox;
        private System.Windows.Forms.PictureBox calendarioPictureBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
        private System.Windows.Forms.MaskedTextBox CelularTextBox;
        private System.Windows.Forms.MaskedTextBox contatoSupervisorTextBox;
        private System.Windows.Forms.MaskedTextBox cpfTextBox;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label validaCPFLabel;
        private System.Windows.Forms.Button fotoButton;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox fotoTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label emailInvalidoLabel;
        private System.Windows.Forms.Label emailSupervisorInvalidoLabel;
        private System.Windows.Forms.GroupBox jornadaGroupBox;
        private System.Windows.Forms.CheckBox enviaRelatorioCheckBox;
        private System.Windows.Forms.Label cargaLabel;
        private System.Windows.Forms.MaskedTextBox cargaHorariaTextBox;
    }
}

