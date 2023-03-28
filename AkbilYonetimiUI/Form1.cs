using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;
using System.Data.SqlClient;
using System.Text;

namespace AkbilYonetimiUI
{
    public partial class Form1 : Form
    {
        public string Email { get; set; } //ka�t ol formuna t�kland���nda kay�t olan kullan�c�n�n emaili buraya gelsin
        public Form1()
        {
            InitializeComponent();
        }

        IVeritabaniIslemleri veritabaniIslemleri = new SqlVeritabaniIslemleri();


        private void btnKayit_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyece�iz
            //Kay�t ol formunu acaca��z
            this.Hide();
            FormKayitOl frm = new FormKayitOl();
            frm.Show();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }
        private void GirisYap()
        {
            try
            {
                // 1) email ve sifre textleri dolu mu?
                // 2) Girdi�i email ve sifre veritaban�nda mevcut mu?
                // 3) beni hat�rlaya t�klad�ysa bilgiler hat�rlanacak
                // 4) E�er email ve sifre do�ru ise ho�geldiniz yazcak ve anasayfa formuna y�nlendirilecek, de�ilse yanl�� giri� mesaj� ver


                // 1) email ve sifre textleri dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // 2) Girdi�i email ve sifre veritaban�nda mevcut mu?
                string[] istedigimizKolonlar = new string[] {"Id", "Ad", "Soyad" };

                string kosullar = string.Empty;
                StringBuilder sb = new StringBuilder();
                sb.Append($"Email ='{txtEmail.Text.Trim()}'");
                sb.Append($" and ");
                sb.Append($"Parola ='{GenelIslemler.MD5Encryption(txtSifre.Text.Trim())}'");
                kosullar = sb.ToString();
                var sonuc = veritabaniIslemleri.VeriOku("Kullanicilar", istedigimizKolonlar, kosullar);

                if(sonuc.Count ==0)
                {
                    MessageBox.Show("Email yada �ifre hatal�");
                }
                else
                {
                    GenelIslemler.GirisYapanKullaniciID = (int)sonuc["Id"];
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{sonuc["Ad"]},{sonuc["Soyad"]}";
                    MessageBox.Show($"Ho�geldiniz  {GenelIslemler.GirisYapanKullaniciAdSoyad}");
                    this.Hide();
                    FormAnasayfa formA = new FormAnasayfa();
                    formA.Show();
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedi bir sorun olu�tu tekrar deneyiniz." + hata.Message);
            }
        }

        private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
        {
            BeniHatirla();
        }

        private void BeniHatirla()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Email != null)

            {
                txtEmail.Text = Email;
            }
            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGiris.TabIndex = 4;
            btnKayit.TabIndex = 5;

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //bas�lan tu� enter ise giri� yap
            {
                GirisYap();
            }
        }
    }
}