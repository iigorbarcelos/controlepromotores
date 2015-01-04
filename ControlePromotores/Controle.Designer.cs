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
            this.painelControle = new System.Windows.Forms.Panel();
            this.ativaButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.painelControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // painelControle
            // 
            this.painelControle.AutoSize = true;
            this.painelControle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.painelControle.Controls.Add(this.ativaButton);
            this.painelControle.Controls.Add(this.sairButton);
            this.painelControle.Controls.Add(this.fotoPictureBox);
            this.painelControle.Controls.Add(this.empresaLabel);
            this.painelControle.Controls.Add(this.nomeLabel);
            this.painelControle.Controls.Add(this.codigoLabel);
            this.painelControle.Controls.Add(this.empresaTextBox);
            this.painelControle.Controls.Add(this.codigoTextBox);
            this.painelControle.Controls.Add(this.nomeTextBox);
            this.painelControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelControle.Location = new System.Drawing.Point(0, 0);
            this.painelControle.Name = "painelControle";
            this.painelControle.Size = new System.Drawing.Size(892, 505);
            this.painelControle.TabIndex = 1;
            // 
            // ativaButton
            // 
            this.ativaButton.Location = new System.Drawing.Point(26, 452);
            this.ativaButton.Name = "ativaButton";
            this.ativaButton.Size = new System.Drawing.Size(95, 36);
            this.ativaButton.TabIndex = 8;
            this.ativaButton.Text = "Ativar";
            this.ativaButton.UseVisualStyleBackColor = true;
            this.ativaButton.Click += new System.EventHandler(this.ativaButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.Location = new System.Drawing.Point(762, 452);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(95, 36);
            this.sairButton.TabIndex = 7;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fotoPictureBox.Image = global::ControlePromotores.Properties.Resources.indigente;
            this.fotoPictureBox.Location = new System.Drawing.Point(511, 25);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(346, 218);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 6;
            this.fotoPictureBox.TabStop = false;
            // 
            // empresaLabel
            // 
            this.empresaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaLabel.Location = new System.Drawing.Point(23, 140);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(93, 18);
            this.empresaLabel.TabIndex = 5;
            this.empresaLabel.Text = "EMPRESA:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(53, 114);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(63, 18);
            this.nomeLabel.TabIndex = 4;
            this.nomeLabel.Text = "NOME:";
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(36, 85);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(80, 18);
            this.codigoLabel.TabIndex = 3;
            this.codigoLabel.Text = "CÓDIGO:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empresaTextBox.Location = new System.Drawing.Point(143, 138);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.ReadOnly = true;
            this.empresaTextBox.Size = new System.Drawing.Size(320, 20);
            this.empresaTextBox.TabIndex = 2;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codigoTextBox.Location = new System.Drawing.Point(143, 86);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(320, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeTextBox.Location = new System.Drawing.Point(143, 112);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(320, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 505);
            this.Controls.Add(this.painelControle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Controle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.painelControle.ResumeLayout(false);
            this.painelControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelControle;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button ativaButton;
    }
}