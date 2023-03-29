namespace AkbilYonetimiUI
{
    partial class FormAnasayfa
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
            btnAkbil = new Button();
            button2 = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = Color.DodgerBlue;
            btnAkbil.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAkbil.Location = new Point(187, 93);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(198, 55);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "Akbil İşlemleri";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(187, 171);
            button2.Name = "button2";
            button2.Size = new Size(198, 55);
            button2.TabIndex = 1;
            button2.Text = "Talimat İşlemleri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.LimeGreen;
            btnAyarlar.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyarlar.Location = new Point(187, 249);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(198, 55);
            btnAyarlar.TabIndex = 2;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // FormAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(btnAyarlar);
            Controls.Add(button2);
            Controls.Add(btnAkbil);
            Name = "FormAnasayfa";
            Text = "FormAnasayfa";
            Load += FormAnasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button button2;
        private Button btnAyarlar;
    }
}