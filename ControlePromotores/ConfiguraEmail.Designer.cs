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
            this.senhaTexBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.sslComboBox = new System.Windows.Forms.ComboBox();
            this.sslLabel = new System.Windows.Forms.Label();
            this.hostEmailLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.gravarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.workTabControl = new System.Windows.Forms.TabControl();
            this.configurarTabpage = new System.Windows.Forms.TabPage();
            this.cadastrarTabPage = new System.Windows.Forms.TabPage();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.workTabControl.SuspendLayout();
            this.configurarTabpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // senhaTexBox
            // 
            this.senhaTexBox.Location = new System.Drawing.Point(211, 187);
            this.senhaTexBox.Name = "senhaTexBox";
            this.senhaTexBox.PasswordChar = '*';
            this.senhaTexBox.Size = new System.Drawing.Size(174, 20);
            this.senhaTexBox.TabIndex = 8;
            this.senhaTexBox.UseSystemPasswordChar = true;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(211, 145);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(174, 20);
            this.usuarioTextBox.TabIndex = 7;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(133, 185);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(65, 19);
            this.senhaLabel.TabIndex = 6;
            this.senhaLabel.Text = "Senha:";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(121, 143);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(77, 19);
            this.usuarioLabel.TabIndex = 5;
            this.usuarioLabel.Text = "Usuario:";
            // 
            // sslComboBox
            // 
            this.sslComboBox.FormattingEnabled = true;
            this.sslComboBox.Location = new System.Drawing.Point(211, 101);
            this.sslComboBox.Name = "sslComboBox";
            this.sslComboBox.Size = new System.Drawing.Size(174, 21);
            this.sslComboBox.TabIndex = 4;
            // 
            // sslLabel
            // 
            this.sslLabel.AutoSize = true;
            this.sslLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslLabel.Location = new System.Drawing.Point(156, 103);
            this.sslLabel.Name = "sslLabel";
            this.sslLabel.Size = new System.Drawing.Size(49, 19);
            this.sslLabel.TabIndex = 3;
            this.sslLabel.Text = "SSL: ";
            // 
            // hostEmailLabel
            // 
            this.hostEmailLabel.AutoSize = true;
            this.hostEmailLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostEmailLabel.Location = new System.Drawing.Point(146, 57);
            this.hostEmailLabel.Name = "hostEmailLabel";
            this.hostEmailLabel.Size = new System.Drawing.Size(52, 19);
            this.hostEmailLabel.TabIndex = 1;
            this.hostEmailLabel.Text = "Host:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tituloLabel.Location = new System.Drawing.Point(120, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(312, 42);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Configurar Email";
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(154, 256);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 9;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(322, 256);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 10;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // workTabControl
            // 
            this.workTabControl.Controls.Add(this.configurarTabpage);
            this.workTabControl.Controls.Add(this.cadastrarTabPage);
            this.workTabControl.Location = new System.Drawing.Point(12, 86);
            this.workTabControl.Name = "workTabControl";
            this.workTabControl.SelectedIndex = 0;
            this.workTabControl.Size = new System.Drawing.Size(558, 363);
            this.workTabControl.TabIndex = 2;
            // 
            // configurarTabpage
            // 
            this.configurarTabpage.Controls.Add(this.hostTextBox);
            this.configurarTabpage.Controls.Add(this.cancelarButton);
            this.configurarTabpage.Controls.Add(this.gravarButton);
            this.configurarTabpage.Controls.Add(this.hostEmailLabel);
            this.configurarTabpage.Controls.Add(this.senhaTexBox);
            this.configurarTabpage.Controls.Add(this.usuarioTextBox);
            this.configurarTabpage.Controls.Add(this.sslLabel);
            this.configurarTabpage.Controls.Add(this.senhaLabel);
            this.configurarTabpage.Controls.Add(this.sslComboBox);
            this.configurarTabpage.Controls.Add(this.usuarioLabel);
            this.configurarTabpage.Location = new System.Drawing.Point(4, 22);
            this.configurarTabpage.Name = "configurarTabpage";
            this.configurarTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.configurarTabpage.Size = new System.Drawing.Size(550, 337);
            this.configurarTabpage.TabIndex = 0;
            this.configurarTabpage.Text = "Configurar";
            this.configurarTabpage.UseVisualStyleBackColor = true;
            // 
            // cadastrarTabPage
            // 
            this.cadastrarTabPage.Location = new System.Drawing.Point(4, 22);
            this.cadastrarTabPage.Name = "cadastrarTabPage";
            this.cadastrarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cadastrarTabPage.Size = new System.Drawing.Size(550, 337);
            this.cadastrarTabPage.TabIndex = 1;
            this.cadastrarTabPage.Text = "Cadastrar Provedor";
            this.cadastrarTabPage.UseVisualStyleBackColor = true;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(211, 59);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(174, 20);
            this.hostTextBox.TabIndex = 11;
            // 
            // ConfiguraEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlePromotores.Properties.Resources.MenuprincipalBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 458);
            this.Controls.Add(this.workTabControl);
            this.Controls.Add(this.tituloLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ConfiguraEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguraEmail";
            this.Load += new System.EventHandler(this.ConfiguraEmail_Load);
            this.workTabControl.ResumeLayout(false);
            this.configurarTabpage.ResumeLayout(false);
            this.configurarTabpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hostEmailLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.ComboBox sslComboBox;
        private System.Windows.Forms.Label sslLabel;
        private System.Windows.Forms.TextBox senhaTexBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.TabControl workTabControl;
        private System.Windows.Forms.TabPage configurarTabpage;
        private System.Windows.Forms.TabPage cadastrarTabPage;
        private System.Windows.Forms.TextBox hostTextBox;
    }
}