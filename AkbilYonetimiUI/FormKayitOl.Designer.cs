namespace AkbilYonetimiUI
{
    partial class FormKayitOl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label4 = new Label();
            btnKayit = new Button();
            label5 = new Label();
            btnGiris = new Button();
            dtpDogumTarihi = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 73);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 127);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(182, 23);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(182, 77);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(182, 185);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 181);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 7;
            label4.Text = "Şifre :";
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.White;
            btnKayit.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayit.Location = new Point(182, 297);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(100, 40);
            btnKayit.TabIndex = 8;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 231);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 9;
            label5.Text = "Doğum Tarihi :";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.White;
            btnGiris.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(36, 297);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(100, 40);
            btnGiris.TabIndex = 11;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(182, 234);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(100, 23);
            dtpDogumTarihi.TabIndex = 12;
            dtpDogumTarihi.ValueChanged += dtpDogumTarihi_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnKayit);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 376);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FormKayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._00bb;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(678, 450);
            Controls.Add(groupBox1);
            Name = "FormKayitOl";
            Text = "FormKayitOl";
            FormClosed += FormKayitOl_FormClosed;
            Load += FormKayitOl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label4;
        private Button btnKayit;
        private Label label5;
        private Button btnGiris;
        private DateTimePicker dtpDogumTarihi;
        private GroupBox groupBox1;
    }
}