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
            this.filtrosGroupBox = new System.Windows.Forms.GroupBox();
            this.FornecedorTextBox = new System.Windows.Forms.TextBox();
            this.CodFornecTextBox = new System.Windows.Forms.TextBox();
            this.FilialComboBox = new System.Windows.Forms.ComboBox();
            this.FilialLabel = new System.Windows.Forms.Label();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.dtPickerFim = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.dtFimLabel = new System.Windows.Forms.Label();
            this.TextBoxCodigo = new System.Windows.Forms.TextBox();
            this.dtInicioLabel = new System.Windows.Forms.Label();
            this.dtPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.entradasGrid = new System.Windows.Forms.DataGridView();
            this.qtRegistrosTextBox = new System.Windows.Forms.TextBox();
            this.qtRegistrosLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SairButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimirButton = new DevExpress.XtraEditors.SimpleButton();
            this.PesquisarButton = new DevExpress.XtraEditors.SimpleButton();
            this.procuraButton = new DevExpress.XtraEditors.SimpleButton();
            this.FundoPictureBox = new System.Windows.Forms.PictureBox();
            this.filtrosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrosGroupBox
            // 
            this.filtrosGroupBox.AutoSize = true;
            this.filtrosGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.filtrosGroupBox.Controls.Add(this.procuraButton);
            this.filtrosGroupBox.Controls.Add(this.FornecedorTextBox);
            this.filtrosGroupBox.Controls.Add(this.CodFornecTextBox);
            this.filtrosGroupBox.Controls.Add(this.FilialComboBox);
            this.filtrosGroupBox.Controls.Add(this.FilialLabel);
            this.filtrosGroupBox.Controls.Add(this.empresaLabel);
            this.filtrosGroupBox.Controls.Add(this.dtPickerFim);
            this.filtrosGroupBox.Controls.Add(this.TextBoxNome);
            this.filtrosGroupBox.Controls.Add(this.dtFimLabel);
            this.filtrosGroupBox.Controls.Add(this.TextBoxCodigo);
            this.filtrosGroupBox.Controls.Add(this.dtInicioLabel);
            this.filtrosGroupBox.Controls.Add(this.dtPickerInicio);
            this.filtrosGroupBox.Controls.Add(this.LabelCodigo);
            this.filtrosGroupBox.Controls.Add(this.LabelNome);
            this.filtrosGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtrosGroupBox.Location = new System.Drawing.Point(10, 69);
            this.filtrosGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtrosGroupBox.Name = "filtrosGroupBox";
            this.filtrosGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtrosGroupBox.Size = new System.Drawing.Size(753, 96);
            this.filtrosGroupBox.TabIndex = 6;
            this.filtrosGroupBox.TabStop = false;
            this.filtrosGroupBox.Text = "Filtros";
            // 
            // FornecedorTextBox
            // 
            this.FornecedorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FornecedorTextBox.Location = new System.Drawing.Point(530, 28);
            this.FornecedorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FornecedorTextBox.Name = "FornecedorTextBox";
            this.FornecedorTextBox.ReadOnly = true;
            this.FornecedorTextBox.Size = new System.Drawing.Size(211, 20);
            this.FornecedorTextBox.TabIndex = 12;
            // 
            // CodFornecTextBox
            // 
            this.CodFornecTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CodFornecTextBox.Location = new System.Drawing.Point(446, 28);
            this.CodFornecTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodFornecTextBox.Name = "CodFornecTextBox";
            this.CodFornecTextBox.Size = new System.Drawing.Size(53, 20);
            this.CodFornecTextBox.TabIndex = 11;
            // 
            // FilialComboBox
            // 
            this.FilialComboBox.FormattingEnabled = true;
            this.FilialComboBox.Location = new System.Drawing.Point(509, 58);
            this.FilialComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilialComboBox.Name = "FilialComboBox";
            this.FilialComboBox.Size = new System.Drawing.Size(190, 21);
            this.FilialComboBox.TabIndex = 10;
            // 
            // FilialLabel
            // 
            this.FilialLabel.AutoSize = true;
            this.FilialLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.8F, System.Drawing.FontStyle.Bold);
            this.FilialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilialLabel.Location = new System.Drawing.Point(454, 54);
            this.FilialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilialLabel.Name = "FilialLabel";
            this.FilialLabel.Size = new System.Drawing.Size(52, 23);
            this.FilialLabel.TabIndex = 9;
            this.FilialLabel.Text = "Filial:";
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.8F, System.Drawing.FontStyle.Bold);
            this.empresaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.empresaLabel.Location = new System.Drawing.Point(344, 22);
            this.empresaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(102, 23);
            this.empresaLabel.TabIndex = 7;
            this.empresaLabel.Text = "Fornecedor:";
            // 
            // dtPickerFim
            // 
            this.dtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFim.Location = new System.Drawing.Point(98, 58);
            this.dtPickerFim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPickerFim.Name = "dtPickerFim";
            this.dtPickerFim.Size = new System.Drawing.Size(87, 20);
            this.dtPickerFim.TabIndex = 3;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxNome.Location = new System.Drawing.Point(271, 58);
            this.TextBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(162, 20);
            this.TextBoxNome.TabIndex = 6;
            // 
            // dtFimLabel
            // 
            this.dtFimLabel.AutoSize = true;
            this.dtFimLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFimLabel.Location = new System.Drawing.Point(37, 55);
            this.dtFimLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtFimLabel.Name = "dtFimLabel";
            this.dtFimLabel.Size = new System.Drawing.Size(59, 21);
            this.dtFimLabel.TabIndex = 2;
            this.dtFimLabel.Text = "Dtfim:";
            // 
            // TextBoxCodigo
            // 
            this.TextBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxCodigo.Location = new System.Drawing.Point(256, 28);
            this.TextBoxCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.Size = new System.Drawing.Size(76, 20);
            this.TextBoxCodigo.TabIndex = 5;
            // 
            // dtInicioLabel
            // 
            this.dtInicioLabel.AutoSize = true;
            this.dtInicioLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioLabel.Location = new System.Drawing.Point(27, 25);
            this.dtInicioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtInicioLabel.Name = "dtInicioLabel";
            this.dtInicioLabel.Size = new System.Drawing.Size(71, 21);
            this.dtInicioLabel.TabIndex = 1;
            this.dtInicioLabel.Text = "Dtinicio:";
            // 
            // dtPickerInicio
            // 
            this.dtPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerInicio.Location = new System.Drawing.Point(98, 26);
            this.dtPickerInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPickerInicio.Name = "dtPickerInicio";
            this.dtPickerInicio.Size = new System.Drawing.Size(87, 20);
            this.dtPickerInicio.TabIndex = 0;
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Comic Sans MS", 11.8F, System.Drawing.FontStyle.Bold);
            this.LabelCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelCodigo.Location = new System.Drawing.Point(196, 22);
            this.LabelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(65, 23);
            this.LabelCodigo.TabIndex = 4;
            this.LabelCodigo.Text = "Codigo:";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Comic Sans MS", 11.8F, System.Drawing.FontStyle.Bold);
            this.LabelNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelNome.Location = new System.Drawing.Point(202, 52);
            this.LabelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(59, 23);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloLabel.Location = new System.Drawing.Point(137, 7);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(515, 47);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Relatório de Entradas / Saídas";
            // 
            // entradasGrid
            // 
            this.entradasGrid.AllowUserToAddRows = false;
            this.entradasGrid.AllowUserToDeleteRows = false;
            this.entradasGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entradasGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.entradasGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.entradasGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entradasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entradasGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.entradasGrid.Location = new System.Drawing.Point(10, 169);
            this.entradasGrid.Name = "entradasGrid";
            this.entradasGrid.ReadOnly = true;
            this.entradasGrid.Size = new System.Drawing.Size(753, 332);
            this.entradasGrid.TabIndex = 0;
            this.entradasGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.entradasGrid_CellEndEdit);
            this.entradasGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.entradasGrid_CellFormatting);
            // 
            // qtRegistrosTextBox
            // 
            this.qtRegistrosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qtRegistrosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.qtRegistrosTextBox.Location = new System.Drawing.Point(61, 507);
            this.qtRegistrosTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qtRegistrosTextBox.Name = "qtRegistrosTextBox";
            this.qtRegistrosTextBox.Size = new System.Drawing.Size(76, 24);
            this.qtRegistrosTextBox.TabIndex = 7;
            // 
            // qtRegistrosLabel
            // 
            this.qtRegistrosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qtRegistrosLabel.AutoSize = true;
            this.qtRegistrosLabel.BackColor = System.Drawing.Color.Transparent;
            this.qtRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.qtRegistrosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtRegistrosLabel.Location = new System.Drawing.Point(10, 508);
            this.qtRegistrosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qtRegistrosLabel.Name = "qtRegistrosLabel";
            this.qtRegistrosLabel.Size = new System.Drawing.Size(48, 20);
            this.qtRegistrosLabel.TabIndex = 8;
            this.qtRegistrosLabel.Text = "Total:";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.versionLabel.Location = new System.Drawing.Point(634, 1);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.versionLabel.Size = new System.Drawing.Size(139, 19);
            this.versionLabel.TabIndex = 16;
            // 
            // SairButton
            // 
            this.SairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SairButton.Image = ((System.Drawing.Image)(resources.GetObject("SairButton.Image")));
            this.SairButton.Location = new System.Drawing.Point(697, 541);
            this.SairButton.Margin = new System.Windows.Forms.Padding(2);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(66, 30);
            this.SairButton.TabIndex = 19;
            this.SairButton.Text = "Sair";
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.Location = new System.Drawing.Point(107, 541);
            this.ImprimirButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(91, 30);
            this.ImprimirButton.TabIndex = 18;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PesquisarButton.Image = ((System.Drawing.Image)(resources.GetObject("PesquisarButton.Image")));
            this.PesquisarButton.Location = new System.Drawing.Point(10, 541);
            this.PesquisarButton.Margin = new System.Windows.Forms.Padding(2);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(93, 30);
            this.PesquisarButton.TabIndex = 17;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click_1);
            // 
            // procuraButton
            // 
            this.procuraButton.Image = ((System.Drawing.Image)(resources.GetObject("procuraButton.Image")));
            this.procuraButton.Location = new System.Drawing.Point(500, 27);
            this.procuraButton.Margin = new System.Windows.Forms.Padding(2);
            this.procuraButton.Name = "procuraButton";
            this.procuraButton.Size = new System.Drawing.Size(25, 19);
            this.procuraButton.TabIndex = 13;
            this.procuraButton.Click += new System.EventHandler(this.procuraButton_Click);
            // 
            // FundoPictureBox
            // 
            this.FundoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FundoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FundoPictureBox.Image")));
            this.FundoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FundoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.FundoPictureBox.Name = "FundoPictureBox";
            this.FundoPictureBox.Size = new System.Drawing.Size(775, 585);
            this.FundoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FundoPictureBox.TabIndex = 1;
            this.FundoPictureBox.TabStop = false;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 585);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.qtRegistrosLabel);
            this.Controls.Add(this.qtRegistrosTextBox);
            this.Controls.Add(this.entradasGrid);
            this.Controls.Add(this.filtrosGroupBox);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.FundoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.filtrosGroupBox.ResumeLayout(false);
            this.filtrosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.DataGridView entradasGrid;
        private System.Windows.Forms.GroupBox filtrosGroupBox;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxCodigo;
        private System.Windows.Forms.PictureBox FundoPictureBox;
        private System.Windows.Forms.DateTimePicker dtPickerFim;
        private System.Windows.Forms.Label dtFimLabel;
        private System.Windows.Forms.Label dtInicioLabel;
        private System.Windows.Forms.DateTimePicker dtPickerInicio;
        private System.Windows.Forms.TextBox qtRegistrosTextBox;
        private System.Windows.Forms.Label qtRegistrosLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label empresaLabel;
        private DevExpress.XtraEditors.SimpleButton PesquisarButton;
        private DevExpress.XtraEditors.SimpleButton ImprimirButton;
        private DevExpress.XtraEditors.SimpleButton SairButton;
        private System.Windows.Forms.ComboBox FilialComboBox;
        private System.Windows.Forms.Label FilialLabel;
        private DevExpress.XtraEditors.SimpleButton procuraButton;
        private System.Windows.Forms.TextBox FornecedorTextBox;
        private System.Windows.Forms.TextBox CodFornecTextBox;
    }
}