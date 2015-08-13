namespace ControlePromotores
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsuarioTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EntrarButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelarButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxFundo = new System.Windows.Forms.PictureBox();
            this.TituloPictureBox = new System.Windows.Forms.PictureBox();
            this.UsuarioLabel = new DevExpress.XtraEditors.LabelControl();
            this.SenhaLabel = new DevExpress.XtraEditors.LabelControl();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TituloPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(97, 161);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(225, 22);
            this.UsuarioTextBox.TabIndex = 0;
            this.UsuarioTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // EntrarButton
            // 
            this.EntrarButton.Location = new System.Drawing.Point(97, 285);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(99, 33);
            this.EntrarButton.TabIndex = 2;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(223, 285);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(99, 33);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // pictureBoxFundo
            // 
            this.pictureBoxFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFundo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFundo.Image")));
            this.pictureBoxFundo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFundo.Name = "pictureBoxFundo";
            this.pictureBoxFundo.Size = new System.Drawing.Size(410, 392);
            this.pictureBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFundo.TabIndex = 4;
            this.pictureBoxFundo.TabStop = false;
            // 
            // TituloPictureBox
            // 
            this.TituloPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TituloPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TituloPictureBox.Image")));
            this.TituloPictureBox.Location = new System.Drawing.Point(31, 12);
            this.TituloPictureBox.Name = "TituloPictureBox";
            this.TituloPictureBox.Size = new System.Drawing.Size(342, 110);
            this.TituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TituloPictureBox.TabIndex = 5;
            this.TituloPictureBox.TabStop = false;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(97, 134);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(84, 24);
            this.UsuarioLabel.TabIndex = 6;
            this.UsuarioLabel.Text = "Usuário:";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaLabel.Location = new System.Drawing.Point(97, 191);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(70, 24);
            this.SenhaLabel.TabIndex = 7;
            this.SenhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(97, 220);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(225, 23);
            this.senhaTextBox.TabIndex = 1;
            this.senhaTextBox.UseSystemPasswordChar = true;
            this.senhaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senhaTextBox_KeyPress);
            this.senhaTextBox.Leave += new System.EventHandler(this.senhaTextBox_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 392);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.TituloPictureBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.pictureBoxFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "VS2010";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Frequencia";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TituloPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UsuarioTextBox;
        private DevExpress.XtraEditors.SimpleButton EntrarButton;
        private DevExpress.XtraEditors.SimpleButton CancelarButton;
        private System.Windows.Forms.PictureBox pictureBoxFundo;
        private System.Windows.Forms.PictureBox TituloPictureBox;
        private DevExpress.XtraEditors.LabelControl UsuarioLabel;
        private DevExpress.XtraEditors.LabelControl SenhaLabel;
        private System.Windows.Forms.TextBox senhaTextBox;
    }
}