namespace AkbilYonetimiUI
{
    partial class FormAkbiller
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cmbBoxAkbilTipleri = new ComboBox();
            maskedTextBoxAkbilNo = new MaskedTextBox();
            btnKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridViewAkbiller = new DataGridView();
            menuStrip1 = new MenuStrip();
            anasayfaToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem1 = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Violet;
            groupBox1.Controls.Add(cmbBoxAkbilTipleri);
            groupBox1.Controls.Add(maskedTextBoxAkbilNo);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cmbBoxAkbilTipleri
            // 
            cmbBoxAkbilTipleri.FormattingEnabled = true;
            cmbBoxAkbilTipleri.Items.AddRange(new object[] { "Öğrenci Akbili", "Tam Akbil ", "Anne Kartı", "65+ Kartı", "Öğretmen Kart" });
            cmbBoxAkbilTipleri.Location = new Point(173, 91);
            cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            cmbBoxAkbilTipleri.Size = new Size(151, 23);
            cmbBoxAkbilTipleri.TabIndex = 5;
            // 
            // maskedTextBoxAkbilNo
            // 
            maskedTextBoxAkbilNo.Location = new Point(173, 30);
            maskedTextBoxAkbilNo.Mask = "0000000000000000";
            maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            maskedTextBoxAkbilNo.Size = new Size(151, 23);
            maskedTextBoxAkbilNo.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Thistle;
            btnKaydet.Location = new Point(453, 76);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(119, 41);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 89);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Akbil Tipi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Akbil No :";
            // 
            // dataGridViewAkbiller
            // 
            dataGridViewAkbiller.AllowUserToAddRows = false;
            dataGridViewAkbiller.AllowUserToDeleteRows = false;
            dataGridViewAkbiller.AllowUserToOrderColumns = true;
            dataGridViewAkbiller.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewAkbiller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAkbiller.Location = new Point(42, 197);
            dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            dataGridViewAkbiller.ReadOnly = true;
            dataGridViewAkbiller.RowTemplate.Height = 25;
            dataGridViewAkbiller.Size = new Size(651, 170);
            dataGridViewAkbiller.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { anasayfaToolStripMenuItem, çıkışYapToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(741, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // anasayfaToolStripMenuItem
            // 
            anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            anasayfaToolStripMenuItem.Size = new Size(67, 20);
            anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // çıkışYapToolStripMenuItem1
            // 
            çıkışYapToolStripMenuItem1.Name = "çıkışYapToolStripMenuItem1";
            çıkışYapToolStripMenuItem1.Size = new Size(66, 20);
            çıkışYapToolStripMenuItem1.Text = "Çıkış Yap";
            // 
            // FormAkbiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(dataGridViewAkbiller);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAkbiller";
            Text = "FormAkbiller";
            Load += FormAkbiller_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbBoxAkbilTipleri;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Button btnKaydet;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem anasayfaToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem1;
        private BindingSource bindingSource1;
    }
}