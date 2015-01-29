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
            this.filtrosGroupBox = new System.Windows.Forms.GroupBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.enviaRelatorioEmail = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.workPanel = new System.Windows.Forms.Panel();
            this.entradasGrid = new System.Windows.Forms.DataGridView();
            this.TextBoxCodigo = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.backgroundPanel.SuspendLayout();
            this.filtrosGroupBox.SuspendLayout();
            this.workPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::ControlePromotores.Properties.Resources.MenuprincipalBG;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.filtrosGroupBox);
            this.backgroundPanel.Controls.Add(this.enviaRelatorioEmail);
            this.backgroundPanel.Controls.Add(this.tituloLabel);
            this.backgroundPanel.Controls.Add(this.sairButton);
            this.backgroundPanel.Controls.Add(this.imprimirButton);
            this.backgroundPanel.Controls.Add(this.pesquisarButton);
            this.backgroundPanel.Controls.Add(this.workPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1309, 857);
            this.backgroundPanel.TabIndex = 0;
            // 
            // filtrosGroupBox
            // 
            this.filtrosGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrosGroupBox.AutoSize = true;
            this.filtrosGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.filtrosGroupBox.Controls.Add(this.TextBoxNome);
            this.filtrosGroupBox.Controls.Add(this.TextBoxCodigo);
            this.filtrosGroupBox.Controls.Add(this.LabelCodigo);
            this.filtrosGroupBox.Controls.Add(this.LabelNome);
            this.filtrosGroupBox.Location = new System.Drawing.Point(16, 102);
            this.filtrosGroupBox.Name = "filtrosGroupBox";
            this.filtrosGroupBox.Size = new System.Drawing.Size(1277, 110);
            this.filtrosGroupBox.TabIndex = 6;
            this.filtrosGroupBox.TabStop = false;
            this.filtrosGroupBox.Text = "Filtros";
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.Location = new System.Drawing.Point(17, 21);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(83, 24);
            this.LabelCodigo.TabIndex = 4;
            this.LabelCodigo.Text = "Codigo:";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(28, 57);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(72, 24);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome:";
            // 
            // enviaRelatorioEmail
            // 
            this.enviaRelatorioEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enviaRelatorioEmail.Location = new System.Drawing.Point(568, 810);
            this.enviaRelatorioEmail.Margin = new System.Windows.Forms.Padding(4);
            this.enviaRelatorioEmail.Name = "enviaRelatorioEmail";
            this.enviaRelatorioEmail.Size = new System.Drawing.Size(141, 32);
            this.enviaRelatorioEmail.TabIndex = 5;
            this.enviaRelatorioEmail.Text = "Enviar emails";
            this.enviaRelatorioEmail.UseVisualStyleBackColor = true;
            this.enviaRelatorioEmail.Click += new System.EventHandler(this.enviaRelatorioEmail_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloLabel.Location = new System.Drawing.Point(13, 22);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(646, 60);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Relatório de Entradas / Saídas";
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.Location = new System.Drawing.Point(1193, 810);
            this.sairButton.Margin = new System.Windows.Forms.Padding(4);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(100, 32);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imprimirButton.Location = new System.Drawing.Point(124, 810);
            this.imprimirButton.Margin = new System.Windows.Forms.Padding(4);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(100, 32);
            this.imprimirButton.TabIndex = 2;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pesquisarButton.Location = new System.Drawing.Point(16, 810);
            this.pesquisarButton.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(100, 32);
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
            this.workPanel.Location = new System.Drawing.Point(16, 219);
            this.workPanel.Margin = new System.Windows.Forms.Padding(4);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(1281, 571);
            this.workPanel.TabIndex = 0;
            // 
            // entradasGrid
            // 
            this.entradasGrid.AllowUserToAddRows = false;
            this.entradasGrid.AllowUserToDeleteRows = false;
            this.entradasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entradasGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.entradasGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.entradasGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entradasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entradasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entradasGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.entradasGrid.Location = new System.Drawing.Point(0, 0);
            this.entradasGrid.Margin = new System.Windows.Forms.Padding(4);
            this.entradasGrid.Name = "entradasGrid";
            this.entradasGrid.ReadOnly = true;
            this.entradasGrid.Size = new System.Drawing.Size(1281, 571);
            this.entradasGrid.TabIndex = 0;
            // 
            // TextBoxCodigo
            // 
            this.TextBoxCodigo.Location = new System.Drawing.Point(108, 23);
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.TextBoxCodigo.TabIndex = 5;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(108, 59);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(100, 22);
            this.TextBoxNome.TabIndex = 6;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1309, 857);
            this.Controls.Add(this.backgroundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.filtrosGroupBox.ResumeLayout(false);
            this.filtrosGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button enviaRelatorioEmail;
        private System.Windows.Forms.DataGridView entradasGrid;
        private System.Windows.Forms.GroupBox filtrosGroupBox;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxCodigo;
    }
}