namespace ControlePromotores
{
    partial class SnapshotForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(12, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(556, 399);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(12, 24);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(87, 37);
            this.salvarButton.TabIndex = 1;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(114, 24);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(87, 37);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // SnapshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 491);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "SnapshotForm";
            this.Text = "SnapshotForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}