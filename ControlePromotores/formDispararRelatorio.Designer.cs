namespace ControlePromotores
{
    partial class formDispararRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDispararRelatorio));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.quantidade = new DevExpress.XtraEditors.TextEdit();
            this.cxTotal = new DevExpress.XtraEditors.TextEdit();
            this.lbRegistro = new DevExpress.XtraEditors.LabelControl();
            this.lbDe = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ControlePromotores.Properties.Resources.FundoPrincipal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(110, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(434, 31);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Disparar Relatório de Pendências";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(15, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Inicio:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(216, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Final:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateTimePickerFinal);
            this.groupControl1.Controls.Add(this.dateTimePickerInicio);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 121);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Período";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(72, 47);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(116, 23);
            this.dateTimePickerInicio.TabIndex = 4;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(267, 47);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(116, 23);
            this.dateTimePickerFinal.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(448, 136);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 52);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Gerar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 194);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(615, 196);
            this.listBox1.TabIndex = 6;
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(252, 397);
            this.quantidade.Name = "quantidade";
            this.quantidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.8F);
            this.quantidade.Properties.Appearance.Options.UseFont = true;
            this.quantidade.Size = new System.Drawing.Size(60, 24);
            this.quantidade.TabIndex = 7;
            // 
            // cxTotal
            // 
            this.cxTotal.Location = new System.Drawing.Point(349, 396);
            this.cxTotal.Name = "cxTotal";
            this.cxTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.8F);
            this.cxTotal.Properties.Appearance.Options.UseFont = true;
            this.cxTotal.Size = new System.Drawing.Size(62, 24);
            this.cxTotal.TabIndex = 8;
            // 
            // lbRegistro
            // 
            this.lbRegistro.Appearance.Font = new System.Drawing.Font("Tahoma", 8.8F);
            this.lbRegistro.Location = new System.Drawing.Point(189, 399);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(57, 18);
            this.lbRegistro.TabIndex = 9;
            this.lbRegistro.Text = "Registro:";
            // 
            // lbDe
            // 
            this.lbDe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.lbDe.Location = new System.Drawing.Point(318, 399);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(25, 19);
            this.lbDe.TabIndex = 10;
            this.lbDe.Text = "De:";
            // 
            // formDispararRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 434);
            this.Controls.Add(this.lbDe);
            this.Controls.Add(this.lbRegistro);
            this.Controls.Add(this.cxTotal);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formDispararRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disparar Relatórios";
            this.Load += new System.EventHandler(this.formDispararRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.TextEdit quantidade;
        private DevExpress.XtraEditors.TextEdit cxTotal;
        private DevExpress.XtraEditors.LabelControl lbRegistro;
        private DevExpress.XtraEditors.LabelControl lbDe;


    }
}