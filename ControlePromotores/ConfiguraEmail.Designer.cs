namespace ControlePromotores
{
    partial class ConfiguraEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguraEmail));
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.sslComboBox = new System.Windows.Forms.ComboBox();
            this.sslLabel = new System.Windows.Forms.Label();
            this.hostEmailLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.workTabControl = new System.Windows.Forms.TabControl();
            this.configurarTabpage = new System.Windows.Forms.TabPage();
            this.devCancelarButton = new DevExpress.XtraEditors.SimpleButton();
            this.devGravarButton = new DevExpress.XtraEditors.SimpleButton();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.workTabControl.SuspendLayout();
            this.configurarTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(281, 223);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(231, 22);
            this.senhaTextBox.TabIndex = 4;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(281, 178);
            this.usuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(231, 22);
            this.usuarioTextBox.TabIndex = 3;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(177, 221);
            this.senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(80, 24);
            this.senhaLabel.TabIndex = 6;
            this.senhaLabel.Text = "Senha:";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(161, 176);
            this.usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(94, 24);
            this.usuarioLabel.TabIndex = 5;
            this.usuarioLabel.Text = "Usuario:";
            // 
            // sslComboBox
            // 
            this.sslComboBox.FormattingEnabled = true;
            this.sslComboBox.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.sslComboBox.Location = new System.Drawing.Point(281, 87);
            this.sslComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sslComboBox.Name = "sslComboBox";
            this.sslComboBox.Size = new System.Drawing.Size(231, 24);
            this.sslComboBox.TabIndex = 1;
            // 
            // sslLabel
            // 
            this.sslLabel.AutoSize = true;
            this.sslLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslLabel.Location = new System.Drawing.Point(202, 87);
            this.sslLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sslLabel.Name = "sslLabel";
            this.sslLabel.Size = new System.Drawing.Size(60, 24);
            this.sslLabel.TabIndex = 3;
            this.sslLabel.Text = "SSL: ";
            // 
            // hostEmailLabel
            // 
            this.hostEmailLabel.AutoSize = true;
            this.hostEmailLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostEmailLabel.Location = new System.Drawing.Point(195, 43);
            this.hostEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostEmailLabel.Name = "hostEmailLabel";
            this.hostEmailLabel.Size = new System.Drawing.Size(62, 24);
            this.hostEmailLabel.TabIndex = 1;
            this.hostEmailLabel.Text = "Host:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloLabel.Location = new System.Drawing.Point(176, 19);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(391, 53);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Configurar Email";
            // 
            // workTabControl
            // 
            this.workTabControl.Controls.Add(this.configurarTabpage);
            this.workTabControl.Location = new System.Drawing.Point(16, 106);
            this.workTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.workTabControl.Name = "workTabControl";
            this.workTabControl.SelectedIndex = 0;
            this.workTabControl.Size = new System.Drawing.Size(744, 447);
            this.workTabControl.TabIndex = 2;
            // 
            // configurarTabpage
            // 
            this.configurarTabpage.Controls.Add(this.devCancelarButton);
            this.configurarTabpage.Controls.Add(this.devGravarButton);
            this.configurarTabpage.Controls.Add(this.EmailTextBox);
            this.configurarTabpage.Controls.Add(this.EmailLabel);
            this.configurarTabpage.Controls.Add(this.hostTextBox);
            this.configurarTabpage.Controls.Add(this.hostEmailLabel);
            this.configurarTabpage.Controls.Add(this.senhaTextBox);
            this.configurarTabpage.Controls.Add(this.usuarioTextBox);
            this.configurarTabpage.Controls.Add(this.sslLabel);
            this.configurarTabpage.Controls.Add(this.senhaLabel);
            this.configurarTabpage.Controls.Add(this.sslComboBox);
            this.configurarTabpage.Controls.Add(this.usuarioLabel);
            this.configurarTabpage.Location = new System.Drawing.Point(4, 25);
            this.configurarTabpage.Margin = new System.Windows.Forms.Padding(4);
            this.configurarTabpage.Name = "configurarTabpage";
            this.configurarTabpage.Padding = new System.Windows.Forms.Padding(4);
            this.configurarTabpage.Size = new System.Drawing.Size(736, 418);
            this.configurarTabpage.TabIndex = 0;
            this.configurarTabpage.Text = "Configurar";
            this.configurarTabpage.UseVisualStyleBackColor = true;
            this.configurarTabpage.Click += new System.EventHandler(this.configurarTabpage_Click);
            // 
            // devCancelarButton
            // 
            this.devCancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("devCancelarButton.Image")));
            this.devCancelarButton.Location = new System.Drawing.Point(389, 307);
            this.devCancelarButton.LookAndFeel.SkinName = "VS2010";
            this.devCancelarButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.devCancelarButton.Name = "devCancelarButton";
            this.devCancelarButton.Size = new System.Drawing.Size(134, 38);
            this.devCancelarButton.TabIndex = 14;
            this.devCancelarButton.Text = "Cancelar";
            this.devCancelarButton.Click += new System.EventHandler(this.devCancelarButton_Click);
            // 
            // devGravarButton
            // 
            this.devGravarButton.Image = ((System.Drawing.Image)(resources.GetObject("devGravarButton.Image")));
            this.devGravarButton.Location = new System.Drawing.Point(189, 307);
            this.devGravarButton.LookAndFeel.SkinName = "VS2010";
            this.devGravarButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.devGravarButton.Name = "devGravarButton";
            this.devGravarButton.Size = new System.Drawing.Size(134, 38);
            this.devGravarButton.TabIndex = 13;
            this.devGravarButton.Text = "Gravar";
            this.devGravarButton.Click += new System.EventHandler(this.devGravarButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(281, 133);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(231, 22);
            this.EmailTextBox.TabIndex = 2;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(185, 133);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(72, 24);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email:";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(281, 46);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(231, 22);
            this.hostTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // versionLabel
            // 
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.versionLabel.Location = new System.Drawing.Point(574, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.versionLabel.Size = new System.Drawing.Size(206, 23);
            this.versionLabel.TabIndex = 4;
            // 
            // ConfiguraEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 564);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.workTabControl);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConfiguraEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguraEmail";
            this.Load += new System.EventHandler(this.ConfiguraEmail_Load);
            this.workTabControl.ResumeLayout(false);
            this.configurarTabpage.ResumeLayout(false);
            this.configurarTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hostEmailLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.ComboBox sslComboBox;
        private System.Windows.Forms.Label sslLabel;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TabControl workTabControl;
        private System.Windows.Forms.TabPage configurarTabpage;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label versionLabel;
        private DevExpress.XtraEditors.SimpleButton devCancelarButton;
        private DevExpress.XtraEditors.SimpleButton devGravarButton;
    }
}