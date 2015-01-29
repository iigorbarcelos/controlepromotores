namespace ControlePromotores
{
    partial class Controle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle));
            this.ativaButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.desativaButton = new System.Windows.Forms.Button();
            this.emailSupervisorTextBox = new System.Windows.Forms.TextBox();
            this.emailSupervisorLabel = new System.Windows.Forms.Label();
            this.ImgDigital = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImgLuz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLuz)).BeginInit();
            this.SuspendLayout();
            // 
            // ativaButton
            // 
            this.ativaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ativaButton.Location = new System.Drawing.Point(16, 575);
            this.ativaButton.Margin = new System.Windows.Forms.Padding(4);
            this.ativaButton.Name = "ativaButton";
            this.ativaButton.Size = new System.Drawing.Size(100, 32);
            this.ativaButton.TabIndex = 8;
            this.ativaButton.Text = "Ativar";
            this.ativaButton.UseVisualStyleBackColor = true;
            this.ativaButton.Click += new System.EventHandler(this.ativaButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sairButton.Location = new System.Drawing.Point(1073, 575);
            this.sairButton.Margin = new System.Windows.Forms.Padding(4);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(100, 32);
            this.sairButton.TabIndex = 7;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoPictureBox.Location = new System.Drawing.Point(700, 15);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(461, 268);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 6;
            this.fotoPictureBox.TabStop = false;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.BackColor = System.Drawing.Color.Transparent;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.codigoLabel.Location = new System.Drawing.Point(91, 16);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(96, 24);
            this.codigoLabel.TabIndex = 3;
            this.codigoLabel.Text = "CÓDIGO:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Location = new System.Drawing.Point(233, 81);
            this.empresaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.ReadOnly = true;
            this.empresaTextBox.Size = new System.Drawing.Size(425, 22);
            this.empresaTextBox.TabIndex = 2;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(233, 17);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(425, 22);
            this.codigoTextBox.TabIndex = 1;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.BackColor = System.Drawing.Color.Transparent;
            this.empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.empresaLabel.Location = new System.Drawing.Point(73, 84);
            this.empresaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(115, 24);
            this.empresaLabel.TabIndex = 5;
            this.empresaLabel.Text = "EMPRESA:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(233, 49);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(425, 22);
            this.nomeTextBox.TabIndex = 0;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nomeLabel.Location = new System.Drawing.Point(110, 49);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(78, 24);
            this.nomeLabel.TabIndex = 4;
            this.nomeLabel.Text = "NOME:";
            // 
            // desativaButton
            // 
            this.desativaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.desativaButton.Location = new System.Drawing.Point(139, 575);
            this.desativaButton.Margin = new System.Windows.Forms.Padding(4);
            this.desativaButton.Name = "desativaButton";
            this.desativaButton.Size = new System.Drawing.Size(100, 32);
            this.desativaButton.TabIndex = 9;
            this.desativaButton.Text = "Desativar";
            this.desativaButton.UseVisualStyleBackColor = true;
            this.desativaButton.Click += new System.EventHandler(this.desativaButton_Click);
            // 
            // emailSupervisorTextBox
            // 
            this.emailSupervisorTextBox.Location = new System.Drawing.Point(233, 113);
            this.emailSupervisorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailSupervisorTextBox.Name = "emailSupervisorTextBox";
            this.emailSupervisorTextBox.ReadOnly = true;
            this.emailSupervisorTextBox.Size = new System.Drawing.Size(425, 22);
            this.emailSupervisorTextBox.TabIndex = 10;
            this.emailSupervisorTextBox.Visible = false;
            // 
            // emailSupervisorLabel
            // 
            this.emailSupervisorLabel.AutoSize = true;
            this.emailSupervisorLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailSupervisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSupervisorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.emailSupervisorLabel.Location = new System.Drawing.Point(42, 113);
            this.emailSupervisorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailSupervisorLabel.Name = "emailSupervisorLabel";
            this.emailSupervisorLabel.Size = new System.Drawing.Size(146, 24);
            this.emailSupervisorLabel.TabIndex = 11;
            this.emailSupervisorLabel.Text = "SUPERVISOR:";
            this.emailSupervisorLabel.Visible = false;
            // 
            // ImgDigital
            // 
            this.ImgDigital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgDigital.Image = global::ControlePromotores.Properties.Resources._91m;
            this.ImgDigital.Location = new System.Drawing.Point(832, 17);
            this.ImgDigital.Name = "ImgDigital";
            this.ImgDigital.Size = new System.Drawing.Size(199, 240);
            this.ImgDigital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgDigital.TabIndex = 12;
            this.ImgDigital.TabStop = false;
            this.ImgDigital.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImgLuz
            // 
            this.ImgLuz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgLuz.Image = global::ControlePromotores.Properties.Resources.Luz;
            this.ImgLuz.Location = new System.Drawing.Point(832, 12);
            this.ImgLuz.Name = "ImgLuz";
            this.ImgLuz.Size = new System.Drawing.Size(199, 3);
            this.ImgLuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgLuz.TabIndex = 13;
            this.ImgLuz.TabStop = false;
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlePromotores.Properties.Resources.MenuprincipalBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 622);
            this.Controls.Add(this.ImgLuz);
            this.Controls.Add(this.ImgDigital);
            this.Controls.Add(this.emailSupervisorLabel);
            this.Controls.Add(this.emailSupervisorTextBox);
            this.Controls.Add(this.desativaButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.ativaButton);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.empresaLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(this.codigoLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Controle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLuz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button ativaButton;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button desativaButton;
        private System.Windows.Forms.TextBox emailSupervisorTextBox;
        private System.Windows.Forms.Label emailSupervisorLabel;
        private System.Windows.Forms.PictureBox ImgDigital;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ImgLuz;
    }
}