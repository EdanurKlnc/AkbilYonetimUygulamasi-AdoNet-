namespace AkbilYonetimiUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkBoxHatirla = new CheckBox();
            txtEmail = new TextBox();
            btnGiris = new Button();
            label1 = new Label();
            btnKayit = new Button();
            label2 = new Label();
            txtSifre = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(checkBoxHatirla);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnKayit);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Location = new Point(23, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 335);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(142, 117);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(96, 19);
            checkBoxHatirla.TabIndex = 7;
            checkBoxHatirla.Text = "Beni hatırla !";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(147, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.White;
            btnGiris.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(191, 175);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(105, 39);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 1;
            label1.Text = "Email :";
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.White;
            btnKayit.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayit.Location = new Point(70, 175);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(105, 39);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 69);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(126, 77);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(147, 23);
            txtSifre.TabIndex = 4;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.galata_kulesi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxHatirla;
        private TextBox txtEmail;
        private Button btnGiris;
        private Label label1;
        private Button btnKayit;
        private Label label2;
        private TextBox txtSifre;
    }
}