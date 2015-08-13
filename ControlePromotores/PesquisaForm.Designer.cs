namespace ControlePromotores
{
    partial class PesquisaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FundoPictureBox = new System.Windows.Forms.PictureBox();
            this.TituloLabel = new DevExpress.XtraEditors.LabelControl();
            this.GridPesquisa = new System.Windows.Forms.DataGridView();
            this.FiltroTextBox = new DevExpress.XtraEditors.TextEdit();
            this.PesquisarButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkButton = new DevExpress.XtraEditors.SimpleButton();
            this.SairButton = new DevExpress.XtraEditors.SimpleButton();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FundoPictureBox
            // 
            this.FundoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FundoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FundoPictureBox.Image")));
            this.FundoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FundoPictureBox.Name = "FundoPictureBox";
            this.FundoPictureBox.Size = new System.Drawing.Size(1020, 542);
            this.FundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FundoPictureBox.TabIndex = 0;
            this.FundoPictureBox.TabStop = false;
            // 
            // TituloLabel
            // 
            this.TituloLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TituloLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.TituloLabel.Location = new System.Drawing.Point(305, 12);
            this.TituloLabel.LookAndFeel.SkinName = "VS2010";
            this.TituloLabel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(395, 40);
            this.TituloLabel.TabIndex = 1;
            this.TituloLabel.Text = "Pesquisar Fornecedores";
            // 
            // GridPesquisa
            // 
            this.GridPesquisa.AllowUserToAddRows = false;
            this.GridPesquisa.AllowUserToDeleteRows = false;
            this.GridPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridPesquisa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPesquisa.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridPesquisa.Location = new System.Drawing.Point(12, 156);
            this.GridPesquisa.MultiSelect = false;
            this.GridPesquisa.Name = "GridPesquisa";
            this.GridPesquisa.ReadOnly = true;
            this.GridPesquisa.RowTemplate.Height = 24;
            this.GridPesquisa.Size = new System.Drawing.Size(996, 344);
            this.GridPesquisa.TabIndex = 2;
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Location = new System.Drawing.Point(168, 109);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(444, 22);
            this.FiltroTextBox.TabIndex = 4;
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Location = new System.Drawing.Point(628, 106);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(126, 28);
            this.PesquisarButton.TabIndex = 5;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(750, 506);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(126, 33);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "Ok";
            // 
            // SairButton
            // 
            this.SairButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SairButton.Location = new System.Drawing.Point(882, 506);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(126, 33);
            this.SairButton.TabIndex = 7;
            this.SairButton.Text = "Sair";
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(12, 107);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(150, 24);
            this.FiltroComboBox.TabIndex = 8;
            // 
            // PesquisaForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SairButton;
            this.ClientSize = new System.Drawing.Size(1020, 542);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.GridPesquisa);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.FundoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "VS2010";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "PesquisaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaForm";
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltroTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FundoPictureBox;
        private DevExpress.XtraEditors.LabelControl TituloLabel;
        private System.Windows.Forms.DataGridView GridPesquisa;
        private DevExpress.XtraEditors.TextEdit FiltroTextBox;
        private DevExpress.XtraEditors.SimpleButton PesquisarButton;
        private DevExpress.XtraEditors.SimpleButton OkButton;
        private DevExpress.XtraEditors.SimpleButton SairButton;
        private System.Windows.Forms.ComboBox FiltroComboBox;
    }
}