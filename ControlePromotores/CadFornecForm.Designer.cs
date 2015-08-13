namespace ControlePromotores
{
    partial class CadFornecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFornecForm));
            this.FundoPictureBox = new System.Windows.Forms.PictureBox();
            this.GridFornecedores = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodfornec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxPesquisa = new DevExpress.XtraEditors.GroupControl();
            this.PesquisarButton = new DevExpress.XtraEditors.SimpleButton();
            this.pesqNomeLabel = new DevExpress.XtraEditors.LabelControl();
            this.pesqCodigoLabel = new DevExpress.XtraEditors.LabelControl();
            this.pesqNomeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.pesqCodigoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.TituloLabel = new DevExpress.XtraEditors.LabelControl();
            this.SairButton = new DevExpress.XtraEditors.SimpleButton();
            this.colCNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPesquisa)).BeginInit();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesqNomeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesqCodigoTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FundoPictureBox
            // 
            this.FundoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FundoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FundoPictureBox.Image")));
            this.FundoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FundoPictureBox.Name = "FundoPictureBox";
            this.FundoPictureBox.Size = new System.Drawing.Size(1012, 557);
            this.FundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FundoPictureBox.TabIndex = 0;
            this.FundoPictureBox.TabStop = false;
            // 
            // GridFornecedores
            // 
            this.GridFornecedores.Location = new System.Drawing.Point(12, 231);
            this.GridFornecedores.MainView = this.gridView1;
            this.GridFornecedores.Name = "GridFornecedores";
            this.GridFornecedores.Size = new System.Drawing.Size(988, 267);
            this.GridFornecedores.TabIndex = 1;
            this.GridFornecedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodfornec,
            this.colnome,
            this.colCNPJ});
            this.gridView1.GridControl = this.GridFornecedores;
            this.gridView1.Name = "gridView1";
            // 
            // colcodfornec
            // 
            this.colcodfornec.Caption = "CÓDIGO";
            this.colcodfornec.FieldName = "CODFORNEC";
            this.colcodfornec.Name = "colcodfornec";
            this.colcodfornec.OptionsColumn.ReadOnly = true;
            this.colcodfornec.Visible = true;
            this.colcodfornec.VisibleIndex = 0;
            this.colcodfornec.Width = 141;
            // 
            // colnome
            // 
            this.colnome.Caption = "EMPRESA";
            this.colnome.FieldName = "FORNECEDOR";
            this.colnome.Name = "colnome";
            this.colnome.Visible = true;
            this.colnome.VisibleIndex = 1;
            this.colnome.Width = 424;
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.PesquisarButton);
            this.groupBoxPesquisa.Controls.Add(this.pesqNomeLabel);
            this.groupBoxPesquisa.Controls.Add(this.pesqCodigoLabel);
            this.groupBoxPesquisa.Controls.Add(this.pesqNomeTextBox);
            this.groupBoxPesquisa.Controls.Add(this.pesqCodigoTextBox);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(12, 81);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(476, 144);
            this.groupBoxPesquisa.TabIndex = 2;
            this.groupBoxPesquisa.Text = "Pesquisa";
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Image = ((System.Drawing.Image)(resources.GetObject("PesquisarButton.Image")));
            this.PesquisarButton.Location = new System.Drawing.Point(330, 38);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(107, 59);
            this.PesquisarButton.TabIndex = 6;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // pesqNomeLabel
            // 
            this.pesqNomeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesqNomeLabel.Location = new System.Drawing.Point(15, 76);
            this.pesqNomeLabel.Name = "pesqNomeLabel";
            this.pesqNomeLabel.Size = new System.Drawing.Size(48, 18);
            this.pesqNomeLabel.TabIndex = 5;
            this.pesqNomeLabel.Text = "Nome:";
            // 
            // pesqCodigoLabel
            // 
            this.pesqCodigoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesqCodigoLabel.Location = new System.Drawing.Point(15, 38);
            this.pesqCodigoLabel.Name = "pesqCodigoLabel";
            this.pesqCodigoLabel.Size = new System.Drawing.Size(56, 18);
            this.pesqCodigoLabel.TabIndex = 4;
            this.pesqCodigoLabel.Text = "Código:";
            // 
            // pesqNomeTextBox
            // 
            this.pesqNomeTextBox.Location = new System.Drawing.Point(106, 75);
            this.pesqNomeTextBox.Name = "pesqNomeTextBox";
            this.pesqNomeTextBox.Size = new System.Drawing.Size(187, 22);
            this.pesqNomeTextBox.TabIndex = 3;
            // 
            // pesqCodigoTextBox
            // 
            this.pesqCodigoTextBox.Location = new System.Drawing.Point(106, 35);
            this.pesqCodigoTextBox.Name = "pesqCodigoTextBox";
            this.pesqCodigoTextBox.Size = new System.Drawing.Size(95, 22);
            this.pesqCodigoTextBox.TabIndex = 2;
            // 
            // TituloLabel
            // 
            this.TituloLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TituloLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.TituloLabel.Location = new System.Drawing.Point(342, 23);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(324, 33);
            this.TituloLabel.TabIndex = 4;
            this.TituloLabel.Text = "Cadastro de Fornecedor";
            // 
            // SairButton
            // 
            this.SairButton.Image = ((System.Drawing.Image)(resources.GetObject("SairButton.Image")));
            this.SairButton.Location = new System.Drawing.Point(894, 501);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(106, 44);
            this.SairButton.TabIndex = 12;
            this.SairButton.Text = "Sair";
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // colCNPJ
            // 
            this.colCNPJ.Caption = "CNPJ";
            this.colCNPJ.FieldName = "CGC";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.Visible = true;
            this.colCNPJ.VisibleIndex = 2;
            this.colCNPJ.Width = 405;
            // 
            // CadFornecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 557);
            this.Controls.Add(this.GridFornecedores);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.FundoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "VS2010";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "CadFornecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.CadFornecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPesquisa)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesqNomeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesqCodigoTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FundoPictureBox;
        private DevExpress.XtraGrid.GridControl GridFornecedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupBoxPesquisa;
        private DevExpress.XtraGrid.Columns.GridColumn colcodfornec;
        private DevExpress.XtraGrid.Columns.GridColumn colnome;
        private DevExpress.XtraEditors.SimpleButton PesquisarButton;
        private DevExpress.XtraEditors.LabelControl pesqNomeLabel;
        private DevExpress.XtraEditors.LabelControl pesqCodigoLabel;
        private DevExpress.XtraEditors.TextEdit pesqNomeTextBox;
        private DevExpress.XtraEditors.TextEdit pesqCodigoTextBox;
        private DevExpress.XtraEditors.LabelControl TituloLabel;
        private DevExpress.XtraEditors.SimpleButton SairButton;
        private DevExpress.XtraGrid.Columns.GridColumn colCNPJ;
    }
}