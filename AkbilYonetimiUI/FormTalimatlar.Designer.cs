namespace AkbilYonetimiUI
{
    partial class FormTalimatlar
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
            groupBoxYukleme = new GroupBox();
            label1 = new Label();
            txtYuklenecekTutar = new TextBox();
            btnKaydet = new Button();
            dataGridViewTalimatlar = new DataGridView();
            checkBoxTumunuGoster = new CheckBox();
            label3 = new Label();
            lblBekleyenTalimat = new Label();
            cmbBoxAkbiller = new ComboBox();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            anaMenuToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatıiptalEtToolStripMenuItem = new ToolStripMenuItem();
            groupBoxYukleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.Controls.Add(label1);
            groupBoxYukleme.Controls.Add(txtYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnKaydet);
            groupBoxYukleme.Location = new Point(33, 103);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(364, 65);
            groupBoxYukleme.TabIndex = 15;
            groupBoxYukleme.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Yüklenecek Tutar :";
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Location = new Point(115, 28);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(106, 23);
            txtYuklenecekTutar.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(241, 28);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(81, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(33, 210);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowTemplate.Height = 25;
            dataGridViewTalimatlar.Size = new Size(485, 134);
            dataGridViewTalimatlar.TabIndex = 14;
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.Location = new Point(39, 185);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(108, 19);
            checkBoxTumunuGoster.TabIndex = 13;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(436, 74);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 12;
            label3.Text = "Bekleyen Talimat :";
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Segoe UI Black", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBekleyenTalimat.Location = new Point(478, 111);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(40, 46);
            lblBekleyenTalimat.TabIndex = 11;
            lblBekleyenTalimat.Text = "0";
            lblBekleyenTalimat.Click += lblBekleyenTalimat_Click;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(33, 74);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(315, 23);
            cmbBoxAkbiller.TabIndex = 10;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged_1;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenuToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(709, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            anaMenuToolStripMenuItem.Size = new Size(74, 20);
            anaMenuToolStripMenuItem.Text = "Ana Menü";
            anaMenuToolStripMenuItem.Click += anaMenuToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(66, 20);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatıiptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(180, 22);
            talimatiYukleToolStripMenuItem.Text = "Talimatı yükle";
            // 
            // talimatıiptalEtToolStripMenuItem
            // 
            talimatıiptalEtToolStripMenuItem.Image = Properties.Resources.sil;
            talimatıiptalEtToolStripMenuItem.Name = "talimatıiptalEtToolStripMenuItem";
            talimatıiptalEtToolStripMenuItem.Size = new Size(180, 22);
            talimatıiptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatıiptalEtToolStripMenuItem.Click += talimatıiptalEtToolStripMenuItem_Click;
            // 
            // FormTalimatlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(groupBoxYukleme);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(label3);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTalimatlar";
            Text = "FormTalimatlar";
            Load += FormTalimatlar_Load;
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxYukleme;
        private Label label1;
        private TextBox txtYuklenecekTutar;
        private Button btnKaydet;
        private DataGridView dataGridViewTalimatlar;
        private CheckBox checkBoxTumunuGoster;
        private Label label3;
        private Label lblBekleyenTalimat;
        private ComboBox cmbBoxAkbiller;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem anaMenuToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private ToolStripMenuItem talimatıiptalEtToolStripMenuItem;
    }
}