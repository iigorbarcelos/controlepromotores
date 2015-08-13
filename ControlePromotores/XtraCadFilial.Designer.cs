namespace ControlePromotores
{
    partial class XtraCadFilial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCadFilial));
            this.fundoPictureBox = new System.Windows.Forms.PictureBox();
            this.tituloLabel = new DevExpress.XtraEditors.LabelControl();
            this.SairButton = new DevExpress.XtraEditors.SimpleButton();
            this.FiliaisTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.FiliaisGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodfilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazaoSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldtinativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cadFiliaisTabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fundoPictureBox)).BeginInit();
            this.FiliaisTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiliaisGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFiliaisTabControl)).BeginInit();
            this.cadFiliaisTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // fundoPictureBox
            // 
            this.fundoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fundoPictureBox.Image")));
            this.fundoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fundoPictureBox.Name = "fundoPictureBox";
            this.fundoPictureBox.Size = new System.Drawing.Size(1047, 564);
            this.fundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundoPictureBox.TabIndex = 0;
            this.fundoPictureBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.tituloLabel.Location = new System.Drawing.Point(354, 33);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(305, 40);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Cadastro de Filiais";
            // 
            // SairButton
            // 
            this.SairButton.Image = ((System.Drawing.Image)(resources.GetObject("SairButton.Image")));
            this.SairButton.Location = new System.Drawing.Point(936, 516);
            this.SairButton.LookAndFeel.SkinName = "VS2010";
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(99, 36);
            this.SairButton.TabIndex = 5;
            this.SairButton.Text = "Sair";
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // FiliaisTabPage
            // 
            this.FiliaisTabPage.Controls.Add(this.FiliaisGridControl);
            this.FiliaisTabPage.Name = "FiliaisTabPage";
            this.FiliaisTabPage.Size = new System.Drawing.Size(1021, 384);
            this.FiliaisTabPage.Text = "Filiais";
            // 
            // FiliaisGridControl
            // 
            this.FiliaisGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiliaisGridControl.Location = new System.Drawing.Point(0, 0);
            this.FiliaisGridControl.MainView = this.gridView1;
            this.FiliaisGridControl.Name = "FiliaisGridControl";
            this.FiliaisGridControl.Size = new System.Drawing.Size(1021, 384);
            this.FiliaisGridControl.TabIndex = 0;
            this.FiliaisGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodfilial,
            this.coldescricao,
            this.colRazaoSocial,
            this.ColCnpj,
            this.coldtinativo});
            this.gridView1.GridControl = this.FiliaisGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colcodfilial
            // 
            this.colcodfilial.Caption = "CODIGO";
            this.colcodfilial.FieldName = "CODIGO";
            this.colcodfilial.Name = "colcodfilial";
            this.colcodfilial.OptionsColumn.AllowEdit = false;
            this.colcodfilial.OptionsColumn.ReadOnly = true;
            this.colcodfilial.Visible = true;
            this.colcodfilial.VisibleIndex = 0;
            this.colcodfilial.Width = 54;
            // 
            // coldescricao
            // 
            this.coldescricao.Caption = "DESCRIÇÃO";
            this.coldescricao.FieldName = "FANTASIA";
            this.coldescricao.Name = "coldescricao";
            this.coldescricao.OptionsColumn.AllowEdit = false;
            this.coldescricao.OptionsColumn.ReadOnly = true;
            this.coldescricao.Visible = true;
            this.coldescricao.VisibleIndex = 1;
            this.coldescricao.Width = 284;
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.Caption = "Razão Social";
            this.colRazaoSocial.FieldName = "RAZAOSOCIAL";
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.Visible = true;
            this.colRazaoSocial.VisibleIndex = 2;
            this.colRazaoSocial.Width = 263;
            // 
            // ColCnpj
            // 
            this.ColCnpj.Caption = "CNPJ";
            this.ColCnpj.FieldName = "CGC";
            this.ColCnpj.Name = "ColCnpj";
            this.ColCnpj.Visible = true;
            this.ColCnpj.VisibleIndex = 3;
            this.ColCnpj.Width = 184;
            // 
            // coldtinativo
            // 
            this.coldtinativo.Caption = "DATA DE INATIVAÇÃO";
            this.coldtinativo.FieldName = "DTEXCLUSAO";
            this.coldtinativo.Name = "coldtinativo";
            this.coldtinativo.OptionsColumn.AllowEdit = false;
            this.coldtinativo.OptionsColumn.ReadOnly = true;
            this.coldtinativo.Visible = true;
            this.coldtinativo.VisibleIndex = 4;
            this.coldtinativo.Width = 218;
            // 
            // cadFiliaisTabControl
            // 
            this.cadFiliaisTabControl.Location = new System.Drawing.Point(12, 90);
            this.cadFiliaisTabControl.Name = "cadFiliaisTabControl";
            this.cadFiliaisTabControl.SelectedTabPage = this.FiliaisTabPage;
            this.cadFiliaisTabControl.Size = new System.Drawing.Size(1023, 420);
            this.cadFiliaisTabControl.TabIndex = 2;
            this.cadFiliaisTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.FiliaisTabPage});
            // 
            // XtraCadFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 564);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.cadFiliaisTabControl);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.fundoPictureBox);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "VS2010";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "XtraCadFilial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Filial";
            this.Load += new System.EventHandler(this.XtraCadFilial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fundoPictureBox)).EndInit();
            this.FiliaisTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FiliaisGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFiliaisTabControl)).EndInit();
            this.cadFiliaisTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fundoPictureBox;
        private DevExpress.XtraEditors.LabelControl tituloLabel;
        private DevExpress.XtraEditors.SimpleButton SairButton;
        private DevExpress.XtraTab.XtraTabPage FiliaisTabPage;
        private DevExpress.XtraGrid.GridControl FiliaisGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodfilial;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colRazaoSocial;
        private DevExpress.XtraGrid.Columns.GridColumn ColCnpj;
        private DevExpress.XtraGrid.Columns.GridColumn coldtinativo;
        private DevExpress.XtraTab.XtraTabControl cadFiliaisTabControl;
    }
}