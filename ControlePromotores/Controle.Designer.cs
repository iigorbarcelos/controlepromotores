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
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ativaButton
            // 
            this.ativaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ativaButton.Location = new System.Drawing.Point(12, 467);
            this.ativaButton.Name = "ativaButton";
            this.ativaButton.Size = new System.Drawing.Size(75, 26);
            this.ativaButton.TabIndex = 8;
            this.ativaButton.Text = "Ativar";
            this.ativaButton.UseVisualStyleBackColor = true;
            this.ativaButton.Click += new System.EventHandler(this.ativaButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sairButton.Location = new System.Drawing.Point(805, 467);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 26);
            this.sairButton.TabIndex = 7;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoPictureBox.Image = global::ControlePromotores.Properties.Resources.indigente;
            this.fotoPictureBox.Location = new System.Drawing.Point(525, 12);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(346, 218);
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
            this.codigoLabel.Location = new System.Drawing.Point(35, 13);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(80, 18);
            this.codigoLabel.TabIndex = 3;
            this.codigoLabel.Text = "CÓDIGO:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Location = new System.Drawing.Point(142, 66);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.ReadOnly = true;
            this.empresaTextBox.Size = new System.Drawing.Size(320, 20);
            this.empresaTextBox.TabIndex = 2;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(142, 14);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(320, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.BackColor = System.Drawing.Color.Transparent;
            this.empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.empresaLabel.Location = new System.Drawing.Point(22, 68);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(93, 18);
            this.empresaLabel.TabIndex = 5;
            this.empresaLabel.Text = "EMPRESA:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(142, 40);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(320, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nomeLabel.Location = new System.Drawing.Point(52, 42);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(63, 18);
            this.nomeLabel.TabIndex = 4;
            this.nomeLabel.Text = "NOME:";
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlePromotores.Properties.Resources.MenuprincipalBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 505);
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
            this.MaximizeBox = false;
            this.Name = "Controle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
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
    }
}