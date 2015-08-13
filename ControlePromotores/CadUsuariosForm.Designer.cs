namespace ControlePromotores
{
    partial class CadUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUsuariosForm));
            this.PictureBoxFundo = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new DevExpress.XtraEditors.LabelControl();
            this.TabControlCadastro = new DevExpress.XtraTab.XtraTabControl();
            this.TabPagePesquisar = new DevExpress.XtraTab.XtraTabPage();
            this.GridUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colendereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldtfim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CadastroTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.CancelarButton = new DevExpress.XtraEditors.SimpleButton();
            this.GravarButton = new DevExpress.XtraEditors.SimpleButton();
            this.SituacaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.SituacaoRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.DadosLoginGroupBox = new DevExpress.XtraEditors.GroupControl();
            this.ResetarButton = new DevExpress.XtraEditors.SimpleButton();
            this.UsuarioLabel = new DevExpress.XtraEditors.LabelControl();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new DevExpress.XtraEditors.LabelControl();
            this.UsuarioTextBox = new DevExpress.XtraEditors.TextEdit();
            this.TelefoneTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EnderecoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.NomeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.MatriculaTextBox = new DevExpress.XtraEditors.TextEdit();
            this.telefoneLabel = new DevExpress.XtraEditors.LabelControl();
            this.EnderecoLabel = new DevExpress.XtraEditors.LabelControl();
            this.NomeLabel = new DevExpress.XtraEditors.LabelControl();
            this.MatriculaLabel = new DevExpress.XtraEditors.LabelControl();
            this.PesquisarButton = new DevExpress.XtraEditors.SimpleButton();
            this.NovoButton = new DevExpress.XtraEditors.SimpleButton();
            this.SairButton = new DevExpress.XtraEditors.SimpleButton();
            this.EditarButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlCadastro)).BeginInit();
            this.TabControlCadastro.SuspendLayout();
            this.TabPagePesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.CadastroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SituacaoRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DadosLoginGroupBox)).BeginInit();
            this.DadosLoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefoneTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnderecoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriculaTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxFundo
            // 
            this.PictureBoxFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxFundo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFundo.Image")));
            this.PictureBoxFundo.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxFundo.Name = "PictureBoxFundo";
            this.PictureBoxFundo.Size = new System.Drawing.Size(1113, 518);
            this.PictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFundo.TabIndex = 0;
            this.PictureBoxFundo.TabStop = false;
            // 
            // TituloLabel
            // 
            this.TituloLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TituloLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.TituloLabel.Location = new System.Drawing.Point(319, 12);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(442, 57);
            this.TituloLabel.TabIndex = 1;
            this.TituloLabel.Text = "Cadastrar usuários";
            // 
            // TabControlCadastro
            // 
            this.TabControlCadastro.Location = new System.Drawing.Point(12, 87);
            this.TabControlCadastro.LookAndFeel.SkinName = "Sharp";
            this.TabControlCadastro.Name = "TabControlCadastro";
            this.TabControlCadastro.SelectedTabPage = this.TabPagePesquisar;
            this.TabControlCadastro.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.TabControlCadastro.Size = new System.Drawing.Size(1089, 390);
            this.TabControlCadastro.TabIndex = 2;
            this.TabControlCadastro.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPagePesquisar,
            this.CadastroTabPage});
            // 
            // TabPagePesquisar
            // 
            this.TabPagePesquisar.Controls.Add(this.GridUsuarios);
            this.TabPagePesquisar.Name = "TabPagePesquisar";
            this.TabPagePesquisar.Size = new System.Drawing.Size(1087, 380);
            this.TabPagePesquisar.Text = "Pesquisar";
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUsuarios.Location = new System.Drawing.Point(0, 0);
            this.GridUsuarios.MainView = this.gridView1;
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.Size = new System.Drawing.Size(1087, 380);
            this.GridUsuarios.TabIndex = 0;
            this.GridUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmatricula,
            this.colnome,
            this.colendereco,
            this.coltelefone,
            this.colsenha,
            this.coldtfim,
            this.colnome_usuario});
            this.gridView1.GridControl = this.GridUsuarios;
            this.gridView1.Name = "gridView1";
            // 
            // colmatricula
            // 
            this.colmatricula.FieldName = "matricula";
            this.colmatricula.Name = "colmatricula";
            this.colmatricula.OptionsColumn.ReadOnly = true;
            this.colmatricula.Visible = true;
            this.colmatricula.VisibleIndex = 0;
            this.colmatricula.Width = 79;
            // 
            // colnome
            // 
            this.colnome.FieldName = "nome";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            this.colnome.Width = 238;
            // 
            // colendereco
            // 
            this.colendereco.FieldName = "endereco";
            this.colendereco.Name = "colendereco";
            this.colendereco.Visible = true;
            this.colendereco.VisibleIndex = 2;
            this.colendereco.Width = 260;
            // 
            // coltelefone
            // 
            this.coltelefone.FieldName = "telefone";
            this.coltelefone.Name = "coltelefone";
            this.coltelefone.Visible = true;
            this.coltelefone.VisibleIndex = 3;
            this.coltelefone.Width = 161;
            // 
            // colsenha
            // 
            this.colsenha.FieldName = "senha";
            this.colsenha.Name = "colsenha";
            // 
            // coldtfim
            // 
            this.coldtfim.FieldName = "dtfim";
            this.coldtfim.Name = "coldtfim";
            this.coldtfim.Visible = true;
            this.coldtfim.VisibleIndex = 4;
            this.coldtfim.Width = 161;
            // 
            // colnome_usuario
            // 
            this.colnome_usuario.FieldName = "nome_usuario";
            this.colnome_usuario.Name = "colnome_usuario";
            this.colnome_usuario.Visible = true;
            this.colnome_usuario.VisibleIndex = 5;
            this.colnome_usuario.Width = 170;
            // 
            // CadastroTabPage
            // 
            this.CadastroTabPage.Controls.Add(this.CancelarButton);
            this.CadastroTabPage.Controls.Add(this.GravarButton);
            this.CadastroTabPage.Controls.Add(this.SituacaoLabel);
            this.CadastroTabPage.Controls.Add(this.SituacaoRadioGroup);
            this.CadastroTabPage.Controls.Add(this.DadosLoginGroupBox);
            this.CadastroTabPage.Controls.Add(this.TelefoneTextBox);
            this.CadastroTabPage.Controls.Add(this.EnderecoTextBox);
            this.CadastroTabPage.Controls.Add(this.NomeTextBox);
            this.CadastroTabPage.Controls.Add(this.MatriculaTextBox);
            this.CadastroTabPage.Controls.Add(this.telefoneLabel);
            this.CadastroTabPage.Controls.Add(this.EnderecoLabel);
            this.CadastroTabPage.Controls.Add(this.NomeLabel);
            this.CadastroTabPage.Controls.Add(this.MatriculaLabel);
            this.CadastroTabPage.Name = "CadastroTabPage";
            this.CadastroTabPage.Size = new System.Drawing.Size(1087, 380);
            this.CadastroTabPage.Text = "Cadastrar";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.Location = new System.Drawing.Point(567, 328);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(142, 35);
            this.CancelarButton.TabIndex = 15;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GravarButton
            // 
            this.GravarButton.Image = ((System.Drawing.Image)(resources.GetObject("GravarButton.Image")));
            this.GravarButton.Location = new System.Drawing.Point(399, 328);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(139, 35);
            this.GravarButton.TabIndex = 6;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.Click += new System.EventHandler(this.GravarButton_Click);
            // 
            // SituacaoLabel
            // 
            this.SituacaoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituacaoLabel.Location = new System.Drawing.Point(797, 24);
            this.SituacaoLabel.Name = "SituacaoLabel";
            this.SituacaoLabel.Size = new System.Drawing.Size(70, 18);
            this.SituacaoLabel.TabIndex = 14;
            this.SituacaoLabel.Text = "Situação:";
            // 
            // SituacaoRadioGroup
            // 
            this.SituacaoRadioGroup.Location = new System.Drawing.Point(797, 48);
            this.SituacaoRadioGroup.Name = "SituacaoRadioGroup";
            this.SituacaoRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.SituacaoRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.SituacaoRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('A', "Ativo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('I', "Inativo")});
            this.SituacaoRadioGroup.Size = new System.Drawing.Size(95, 108);
            this.SituacaoRadioGroup.TabIndex = 13;
            // 
            // DadosLoginGroupBox
            // 
            this.DadosLoginGroupBox.Controls.Add(this.ResetarButton);
            this.DadosLoginGroupBox.Controls.Add(this.UsuarioLabel);
            this.DadosLoginGroupBox.Controls.Add(this.senhaTextBox);
            this.DadosLoginGroupBox.Controls.Add(this.senhaLabel);
            this.DadosLoginGroupBox.Controls.Add(this.UsuarioTextBox);
            this.DadosLoginGroupBox.Location = new System.Drawing.Point(81, 124);
            this.DadosLoginGroupBox.Name = "DadosLoginGroupBox";
            this.DadosLoginGroupBox.Size = new System.Drawing.Size(282, 171);
            this.DadosLoginGroupBox.TabIndex = 12;
            this.DadosLoginGroupBox.Text = "Dados de Login";
            // 
            // ResetarButton
            // 
            this.ResetarButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetarButton.Image")));
            this.ResetarButton.Location = new System.Drawing.Point(55, 122);
            this.ResetarButton.Name = "ResetarButton";
            this.ResetarButton.Size = new System.Drawing.Size(166, 35);
            this.ResetarButton.TabIndex = 6;
            this.ResetarButton.Text = "Resetar Senha";
            this.ResetarButton.Click += new System.EventHandler(this.ResetarButton_Click);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(23, 45);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(63, 18);
            this.UsuarioLabel.TabIndex = 5;
            this.UsuarioLabel.Text = "Usuário:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(92, 83);
            this.senhaTextBox.MaxLength = 20;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.ReadOnly = true;
            this.senhaTextBox.Size = new System.Drawing.Size(145, 23);
            this.senhaTextBox.TabIndex = 11;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // senhaLabel
            // 
            this.senhaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(23, 84);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(51, 18);
            this.senhaLabel.TabIndex = 4;
            this.senhaLabel.Text = "Senha:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(92, 44);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Properties.Mask.EditMask = "[a-zA-Z .]+";
            this.UsuarioTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.UsuarioTextBox.Properties.Mask.ShowPlaceHolders = false;
            this.UsuarioTextBox.Size = new System.Drawing.Size(145, 22);
            this.UsuarioTextBox.TabIndex = 10;
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(479, 24);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Properties.Mask.EditMask = "(\\d?\\d?)\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.TelefoneTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TelefoneTextBox.Size = new System.Drawing.Size(96, 22);
            this.TelefoneTextBox.TabIndex = 9;
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.Location = new System.Drawing.Point(479, 70);
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(239, 22);
            this.EnderecoTextBox.TabIndex = 8;
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(136, 70);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.NomeTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.NomeTextBox.Properties.Mask.ShowPlaceHolders = false;
            this.NomeTextBox.Size = new System.Drawing.Size(220, 22);
            this.NomeTextBox.TabIndex = 7;
            // 
            // MatriculaTextBox
            // 
            this.MatriculaTextBox.Enabled = false;
            this.MatriculaTextBox.Location = new System.Drawing.Point(175, 24);
            this.MatriculaTextBox.Name = "MatriculaTextBox";
            this.MatriculaTextBox.Size = new System.Drawing.Size(82, 22);
            this.MatriculaTextBox.TabIndex = 6;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLabel.Location = new System.Drawing.Point(399, 25);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(70, 18);
            this.telefoneLabel.TabIndex = 3;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // EnderecoLabel
            // 
            this.EnderecoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoLabel.Location = new System.Drawing.Point(399, 71);
            this.EnderecoLabel.Name = "EnderecoLabel";
            this.EnderecoLabel.Size = new System.Drawing.Size(74, 18);
            this.EnderecoLabel.TabIndex = 2;
            this.EnderecoLabel.Text = "Endereco:";
            // 
            // NomeLabel
            // 
            this.NomeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.Location = new System.Drawing.Point(82, 71);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(48, 18);
            this.NomeLabel.TabIndex = 1;
            this.NomeLabel.Text = "Nome:";
            // 
            // MatriculaLabel
            // 
            this.MatriculaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaLabel.Location = new System.Drawing.Point(81, 24);
            this.MatriculaLabel.Name = "MatriculaLabel";
            this.MatriculaLabel.Size = new System.Drawing.Size(76, 18);
            this.MatriculaLabel.TabIndex = 0;
            this.MatriculaLabel.Text = "Matricula:";
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Image = ((System.Drawing.Image)(resources.GetObject("PesquisarButton.Image")));
            this.PesquisarButton.Location = new System.Drawing.Point(13, 478);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(115, 35);
            this.PesquisarButton.TabIndex = 3;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // NovoButton
            // 
            this.NovoButton.Image = ((System.Drawing.Image)(resources.GetObject("NovoButton.Image")));
            this.NovoButton.Location = new System.Drawing.Point(134, 478);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(113, 35);
            this.NovoButton.TabIndex = 4;
            this.NovoButton.Text = "Novo";
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // SairButton
            // 
            this.SairButton.Image = ((System.Drawing.Image)(resources.GetObject("SairButton.Image")));
            this.SairButton.Location = new System.Drawing.Point(999, 478);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(102, 35);
            this.SairButton.TabIndex = 5;
            this.SairButton.Text = "Sair";
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarButton.Image")));
            this.EditarButton.Location = new System.Drawing.Point(253, 478);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(113, 35);
            this.EditarButton.TabIndex = 6;
            this.EditarButton.Text = "Editar";
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // CadUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 518);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.NovoButton);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.TabControlCadastro);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.PictureBoxFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "VS2010";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "CadUsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar usuário";
            this.Load += new System.EventHandler(this.CadUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlCadastro)).EndInit();
            this.TabControlCadastro.ResumeLayout(false);
            this.TabPagePesquisar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.CadastroTabPage.ResumeLayout(false);
            this.CadastroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SituacaoRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DadosLoginGroupBox)).EndInit();
            this.DadosLoginGroupBox.ResumeLayout(false);
            this.DadosLoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefoneTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnderecoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriculaTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxFundo;
        private DevExpress.XtraEditors.LabelControl TituloLabel;
        private DevExpress.XtraTab.XtraTabControl TabControlCadastro;
        private DevExpress.XtraTab.XtraTabPage TabPagePesquisar;
        private DevExpress.XtraTab.XtraTabPage CadastroTabPage;
        private DevExpress.XtraGrid.GridControl GridUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraGrid.Columns.GridColumn colendereco;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefone;
        private DevExpress.XtraGrid.Columns.GridColumn colsenha;
        private DevExpress.XtraGrid.Columns.GridColumn coldtfim;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_usuario;
        private DevExpress.XtraEditors.SimpleButton PesquisarButton;
        private DevExpress.XtraEditors.SimpleButton NovoButton;
        private DevExpress.XtraEditors.SimpleButton SairButton;
        private DevExpress.XtraEditors.LabelControl SituacaoLabel;
        private DevExpress.XtraEditors.RadioGroup SituacaoRadioGroup;
        private DevExpress.XtraEditors.GroupControl DadosLoginGroupBox;
        private DevExpress.XtraEditors.SimpleButton ResetarButton;
        private DevExpress.XtraEditors.LabelControl UsuarioLabel;
        private System.Windows.Forms.TextBox senhaTextBox;
        private DevExpress.XtraEditors.LabelControl senhaLabel;
        private DevExpress.XtraEditors.TextEdit UsuarioTextBox;
        private DevExpress.XtraEditors.TextEdit TelefoneTextBox;
        private DevExpress.XtraEditors.TextEdit EnderecoTextBox;
        private DevExpress.XtraEditors.TextEdit NomeTextBox;
        private DevExpress.XtraEditors.TextEdit MatriculaTextBox;
        private DevExpress.XtraEditors.LabelControl telefoneLabel;
        private DevExpress.XtraEditors.LabelControl EnderecoLabel;
        private DevExpress.XtraEditors.LabelControl NomeLabel;
        private DevExpress.XtraEditors.LabelControl MatriculaLabel;
        private DevExpress.XtraEditors.SimpleButton CancelarButton;
        private DevExpress.XtraEditors.SimpleButton GravarButton;
        private DevExpress.XtraEditors.SimpleButton EditarButton;
    }
}