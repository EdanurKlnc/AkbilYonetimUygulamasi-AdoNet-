namespace AkbilYonetimiUI
{
    partial class FormAyarlar
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
            dtpDogumTarihi = new DateTimePicker();
            txtYeniSifre = new TextBox();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            btnGucelle = new Button();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(519, 95);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(159, 23);
            dtpDogumTarihi.TabIndex = 22;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(519, 148);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(159, 23);
            txtYeniSifre.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(182, 148);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(141, 23);
            txtSoyad.TabIndex = 19;
            // 
            // btnGucelle
            // 
            btnGucelle.Location = new Point(322, 307);
            btnGucelle.Name = "btnGucelle";
            btnGucelle.Size = new Size(151, 49);
            btnGucelle.TabIndex = 18;
            btnGucelle.Text = "Güncelle";
            btnGucelle.UseVisualStyleBackColor = true;
            btnGucelle.Click += btnGucelle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(182, 95);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(141, 23);
            txtAd.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 148);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 16;
            label5.Text = "Yeni Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 101);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 15;
            label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 206);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 14;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 152);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 13;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 98);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 12;
            label1.Text = "Ad :";
            // 
            // FormAyarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(btnGucelle);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAyarlar";
            Text = "FormAyarlar";
            Load += FormAyarlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDogumTarihi;
        private TextBox txtYeniSifre;
        private TextBox txtEmail;
        private TextBox txtSoyad;
        private Button btnGucelle;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}