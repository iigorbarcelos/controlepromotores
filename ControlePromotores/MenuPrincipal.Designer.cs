namespace ControlePromotores
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPainel = new System.Windows.Forms.Panel();
            this.configuracoesLabel = new System.Windows.Forms.Label();
            this.configuracoesPictureBox = new System.Windows.Forms.PictureBox();
            this.relatorioLabel = new System.Windows.Forms.Label();
            this.relatorioPictureBox = new System.Windows.Forms.PictureBox();
            this.CadastrarPromotorLabel = new System.Windows.Forms.Label();
            this.CadastrarPromotorPicture = new System.Windows.Forms.PictureBox();
            this.sairButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.MenuPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configuracoesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastrarPromotorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ControlePromotores.Properties.Resources.menuprincipal;
            this.panel1.Controls.Add(this.MenuPainel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 635);
            this.panel1.TabIndex = 0;
            // 
            // MenuPainel
            // 
            this.MenuPainel.AutoSize = true;
            this.MenuPainel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPainel.Controls.Add(this.configuracoesLabel);
            this.MenuPainel.Controls.Add(this.configuracoesPictureBox);
            this.MenuPainel.Controls.Add(this.relatorioLabel);
            this.MenuPainel.Controls.Add(this.relatorioPictureBox);
            this.MenuPainel.Controls.Add(this.CadastrarPromotorLabel);
            this.MenuPainel.Controls.Add(this.CadastrarPromotorPicture);
            this.MenuPainel.Controls.Add(this.sairButton);
            this.MenuPainel.Controls.Add(this.tituloLabel);
            this.MenuPainel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPainel.Location = new System.Drawing.Point(0, 0);
            this.MenuPainel.Name = "MenuPainel";
            this.MenuPainel.Size = new System.Drawing.Size(929, 635);
            this.MenuPainel.TabIndex = 1;
            // 
            // configuracoesLabel
            // 
            this.configuracoesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.configuracoesLabel.AutoSize = true;
            this.configuracoesLabel.BackColor = System.Drawing.Color.Transparent;
            this.configuracoesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configuracoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracoesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.configuracoesLabel.Location = new System.Drawing.Point(620, 382);
            this.configuracoesLabel.Name = "configuracoesLabel";
            this.configuracoesLabel.Size = new System.Drawing.Size(145, 24);
            this.configuracoesLabel.TabIndex = 6;
            this.configuracoesLabel.Text = "Configurações";
            // 
            // configuracoesPictureBox
            // 
            this.configuracoesPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.configuracoesPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.configuracoesPictureBox.Image = global::ControlePromotores.Properties.Resources.configuracoes;
            this.configuracoesPictureBox.Location = new System.Drawing.Point(620, 229);
            this.configuracoesPictureBox.Name = "configuracoesPictureBox";
            this.configuracoesPictureBox.Size = new System.Drawing.Size(145, 136);
            this.configuracoesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.configuracoesPictureBox.TabIndex = 5;
            this.configuracoesPictureBox.TabStop = false;
            // 
            // relatorioLabel
            // 
            this.relatorioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relatorioLabel.AutoSize = true;
            this.relatorioLabel.BackColor = System.Drawing.Color.Transparent;
            this.relatorioLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.relatorioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.relatorioLabel.Location = new System.Drawing.Point(403, 382);
            this.relatorioLabel.Name = "relatorioLabel";
            this.relatorioLabel.Size = new System.Drawing.Size(103, 24);
            this.relatorioLabel.TabIndex = 4;
            this.relatorioLabel.Text = "Relatórios";
            // 
            // relatorioPictureBox
            // 
            this.relatorioPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relatorioPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.relatorioPictureBox.Image = global::ControlePromotores.Properties.Resources.relatorios;
            this.relatorioPictureBox.Location = new System.Drawing.Point(383, 229);
            this.relatorioPictureBox.Name = "relatorioPictureBox";
            this.relatorioPictureBox.Size = new System.Drawing.Size(145, 136);
            this.relatorioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.relatorioPictureBox.TabIndex = 3;
            this.relatorioPictureBox.TabStop = false;
            // 
            // CadastrarPromotorLabel
            // 
            this.CadastrarPromotorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CadastrarPromotorLabel.AutoSize = true;
            this.CadastrarPromotorLabel.BackColor = System.Drawing.Color.Transparent;
            this.CadastrarPromotorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarPromotorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarPromotorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CadastrarPromotorLabel.Location = new System.Drawing.Point(148, 382);
            this.CadastrarPromotorLabel.Name = "CadastrarPromotorLabel";
            this.CadastrarPromotorLabel.Size = new System.Drawing.Size(117, 24);
            this.CadastrarPromotorLabel.TabIndex = 1;
            this.CadastrarPromotorLabel.Text = "Promotores";
            this.CadastrarPromotorLabel.Click += new System.EventHandler(this.CadastrarPromotorLabel_Click);
            // 
            // CadastrarPromotorPicture
            // 
            this.CadastrarPromotorPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CadastrarPromotorPicture.BackColor = System.Drawing.Color.Transparent;
            this.CadastrarPromotorPicture.Image = global::ControlePromotores.Properties.Resources.imagemCadastrarPromotor;
            this.CadastrarPromotorPicture.Location = new System.Drawing.Point(135, 229);
            this.CadastrarPromotorPicture.Name = "CadastrarPromotorPicture";
            this.CadastrarPromotorPicture.Size = new System.Drawing.Size(145, 136);
            this.CadastrarPromotorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CadastrarPromotorPicture.TabIndex = 0;
            this.CadastrarPromotorPicture.TabStop = false;
            this.CadastrarPromotorPicture.Click += new System.EventHandler(this.CadastrarPromotorPicture_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.sairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.Location = new System.Drawing.Point(785, 563);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(104, 36);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloLabel.Location = new System.Drawing.Point(196, 53);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(539, 60);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Controle de Frequência\r\n";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(929, 635);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuPainel.ResumeLayout(false);
            this.MenuPainel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configuracoesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastrarPromotorPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel MenuPainel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.PictureBox CadastrarPromotorPicture;
        private System.Windows.Forms.Label CadastrarPromotorLabel;
        private System.Windows.Forms.PictureBox relatorioPictureBox;
        private System.Windows.Forms.Label relatorioLabel;
        private System.Windows.Forms.PictureBox configuracoesPictureBox;
        private System.Windows.Forms.Label configuracoesLabel;
    }
}