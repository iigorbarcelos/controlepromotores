namespace ControlePromotores
{
    partial class CadastraDigitalForm
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
            this.digitalTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.recadastrarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelarButton);
            this.panel1.Controls.Add(this.recadastrarButton);
            this.panel1.Controls.Add(this.ConfirmarButton);
            this.panel1.Controls.Add(this.digitalTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 444);
            this.panel1.TabIndex = 0;
            // 
            // digitalTextBox
            // 
            this.digitalTextBox.Location = new System.Drawing.Point(30, 177);
            this.digitalTextBox.Name = "digitalTextBox";
            this.digitalTextBox.ReadOnly = true;
            this.digitalTextBox.Size = new System.Drawing.Size(495, 20);
            this.digitalTextBox.TabIndex = 0;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(30, 305);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(140, 23);
            this.ConfirmarButton.TabIndex = 1;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // recadastrarButton
            // 
            this.recadastrarButton.Location = new System.Drawing.Point(202, 305);
            this.recadastrarButton.Name = "recadastrarButton";
            this.recadastrarButton.Size = new System.Drawing.Size(140, 23);
            this.recadastrarButton.TabIndex = 2;
            this.recadastrarButton.Text = "Recadastrar";
            this.recadastrarButton.UseVisualStyleBackColor = true;
            this.recadastrarButton.Click += new System.EventHandler(this.recadastrarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(375, 305);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(140, 23);
            this.cancelarButton.TabIndex = 3;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // CadastraDigitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 444);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CadastraDigitalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Digital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox digitalTextBox;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button recadastrarButton;
        private System.Windows.Forms.Button ConfirmarButton;
    }
}