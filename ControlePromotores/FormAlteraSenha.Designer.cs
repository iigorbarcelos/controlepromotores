namespace ControlePromotores
{
    partial class FormAlteraSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlteraSenha));
            this.FundoPictureBox = new System.Windows.Forms.PictureBox();
            this.ConfirmarButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelarButton = new DevExpress.XtraEditors.SimpleButton();
            this.SenhaLabel = new DevExpress.XtraEditors.LabelControl();
            this.SenhaConfirmarLabel = new DevExpress.XtraEditors.LabelControl();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.SenhaConfirmarTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FundoPictureBox
            // 
            this.FundoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FundoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FundoPictureBox.Image")));
            this.FundoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FundoPictureBox.Name = "FundoPictureBox";
            this.FundoPictureBox.Size = new System.Drawing.Size(603, 253);
            this.FundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FundoPictureBox.TabIndex = 0;
            this.FundoPictureBox.TabStop = false;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmarButton.Enabled = false;
            this.ConfirmarButton.Location = new System.Drawing.Point(159, 192);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(92, 38);
            this.ConfirmarButton.TabIndex = 2;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(326, 192);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(92, 38);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.SenhaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaLabel.Location = new System.Drawing.Point(118, 52);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(151, 18);
            this.SenhaLabel.TabIndex = 50;
            this.SenhaLabel.Text = "Digite a nova senha:";
            // 
            // SenhaConfirmarLabel
            // 
            this.SenhaConfirmarLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.SenhaConfirmarLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaConfirmarLabel.Location = new System.Drawing.Point(118, 104);
            this.SenhaConfirmarLabel.Name = "SenhaConfirmarLabel";
            this.SenhaConfirmarLabel.Size = new System.Drawing.Size(174, 18);
            this.SenhaConfirmarLabel.TabIndex = 51;
            this.SenhaConfirmarLabel.Text = "Confirme a nova senha:";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(118, 75);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.PasswordChar = '*';
            this.SenhaTextBox.Size = new System.Drawing.Size(356, 23);
            this.SenhaTextBox.TabIndex = 0;
            this.SenhaTextBox.UseSystemPasswordChar = true;
            // 
            // SenhaConfirmarTextBox
            // 
            this.SenhaConfirmarTextBox.Location = new System.Drawing.Point(118, 128);
            this.SenhaConfirmarTextBox.Name = "SenhaConfirmarTextBox";
            this.SenhaConfirmarTextBox.PasswordChar = '*';
            this.SenhaConfirmarTextBox.Size = new System.Drawing.Size(356, 23);
            this.SenhaConfirmarTextBox.TabIndex = 1;
            this.SenhaConfirmarTextBox.UseSystemPasswordChar = true;
            this.SenhaConfirmarTextBox.Leave += new System.EventHandler(this.SenhaConfirmarTextBox_Leave);
            // 
            // FormAlteraSenha
            // 
            this.AcceptButton = this.ConfirmarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(603, 253);
            this.Controls.Add(this.SenhaConfirmarTextBox);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.SenhaConfirmarLabel);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.FundoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAlteraSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlteraSenha";
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FundoPictureBox;
        private DevExpress.XtraEditors.SimpleButton ConfirmarButton;
        private DevExpress.XtraEditors.SimpleButton CancelarButton;
        private DevExpress.XtraEditors.LabelControl SenhaLabel;
        private DevExpress.XtraEditors.LabelControl SenhaConfirmarLabel;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.TextBox SenhaConfirmarTextBox;
    }
}