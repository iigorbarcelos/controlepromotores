namespace ControlePromotores
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.workPanel = new System.Windows.Forms.Panel();
            this.entradasGrid = new System.Windows.Forms.DataGridView();
            this.backgroundPanel.SuspendLayout();
            this.workPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ControlePromotores.Properties.Resources.MenuprincipalBG;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.tituloLabel);
            this.backgroundPanel.Controls.Add(this.sairButton);
            this.backgroundPanel.Controls.Add(this.imprimirButton);
            this.backgroundPanel.Controls.Add(this.pesquisarButton);
            this.backgroundPanel.Controls.Add(this.workPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(982, 583);
            this.backgroundPanel.TabIndex = 0;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloLabel.Location = new System.Drawing.Point(239, 19);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(485, 47);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Relatório de Entrada / Saída";
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.Location = new System.Drawing.Point(895, 545);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 26);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imprimirButton.Location = new System.Drawing.Point(102, 545);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(75, 26);
            this.imprimirButton.TabIndex = 2;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pesquisarButton.Location = new System.Drawing.Point(12, 545);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(75, 26);
            this.pesquisarButton.TabIndex = 1;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisarButton_Click);
            // 
            // workPanel
            // 
            this.workPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workPanel.AutoSize = true;
            this.workPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.workPanel.Controls.Add(this.entradasGrid);
            this.workPanel.Location = new System.Drawing.Point(12, 99);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(958, 440);
            this.workPanel.TabIndex = 0;
            // 
            // entradasGrid
            // 
            this.entradasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entradasGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.entradasGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.entradasGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entradasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entradasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entradasGrid.Location = new System.Drawing.Point(0, 0);
            this.entradasGrid.Name = "entradasGrid";
            this.entradasGrid.Size = new System.Drawing.Size(958, 440);
            this.entradasGrid.TabIndex = 0;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.backgroundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.workPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entradasGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.DataGridView entradasGrid;
        private System.Windows.Forms.Label tituloLabel;
    }
}