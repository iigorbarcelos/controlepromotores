namespace ControlePromotores
{
    partial class formRelOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelOptions));
            this.fundoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonAnaliticoData = new System.Windows.Forms.RadioButton();
            this.radioButtonSintetico = new System.Windows.Forms.RadioButton();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fundoPictureBox)).BeginInit();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // fundoPictureBox
            // 
            this.fundoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fundoPictureBox.Image")));
            this.fundoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fundoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fundoPictureBox.Name = "fundoPictureBox";
            this.fundoPictureBox.Size = new System.Drawing.Size(330, 144);
            this.fundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundoPictureBox.TabIndex = 0;
            this.fundoPictureBox.TabStop = false;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTipo.Controls.Add(this.radioButtonAnaliticoData);
            this.groupBoxTipo.Controls.Add(this.radioButtonSintetico);
            this.groupBoxTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxTipo.Location = new System.Drawing.Point(9, 10);
            this.groupBoxTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTipo.Size = new System.Drawing.Size(312, 92);
            this.groupBoxTipo.TabIndex = 1;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo de Relatório";
            // 
            // radioButtonAnaliticoData
            // 
            this.radioButtonAnaliticoData.AutoSize = true;
            this.radioButtonAnaliticoData.Location = new System.Drawing.Point(44, 60);
            this.radioButtonAnaliticoData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAnaliticoData.Name = "radioButtonAnaliticoData";
            this.radioButtonAnaliticoData.Size = new System.Drawing.Size(201, 17);
            this.radioButtonAnaliticoData.TabIndex = 1;
            this.radioButtonAnaliticoData.TabStop = true;
            this.radioButtonAnaliticoData.Text = "Relatório analítico agrupado por data";
            this.radioButtonAnaliticoData.UseVisualStyleBackColor = true;
            // 
            // radioButtonSintetico
            // 
            this.radioButtonSintetico.AutoSize = true;
            this.radioButtonSintetico.Location = new System.Drawing.Point(44, 29);
            this.radioButtonSintetico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSintetico.Name = "radioButtonSintetico";
            this.radioButtonSintetico.Size = new System.Drawing.Size(111, 17);
            this.radioButtonSintetico.TabIndex = 0;
            this.radioButtonSintetico.TabStop = true;
            this.radioButtonSintetico.Text = "Relatório Sintético";
            this.radioButtonSintetico.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(94, 115);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 19);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(170, 115);
            this.ButtonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(56, 19);
            this.ButtonCancelar.TabIndex = 3;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // formRelOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 144);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.fundoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "formRelOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções de Relatório";
            ((System.ComponentModel.ISupportInitialize)(this.fundoPictureBox)).EndInit();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fundoPictureBox;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonAnaliticoData;
        private System.Windows.Forms.RadioButton radioButtonSintetico;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton ButtonCancelar;
    }
}