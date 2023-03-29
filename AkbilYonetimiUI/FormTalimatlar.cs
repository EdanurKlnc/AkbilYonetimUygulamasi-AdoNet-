using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;


namespace AkbilYonetimiUI
{
    public partial class FormTalimatlar : Form
    {
        IVeritabaniIslemleri veriTabaniIslemleri = new SqlVeritabaniIslemleri(GenelIslemler.SinifSQLBaglantiCumlesi);

        public FormTalimatlar()
        {

            InitializeComponent();
        }
        private void FormTalimatlar_Load(object sender, EventArgs e)
        {
            //Comboxa akbilleri getir
            ComboBoxaKullanicininAkbilleriniGetir();
            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil seçiniz...";
            // cmbBoxAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBoxYukleme.Enabled = false;

            dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TalimatlariDataGrideGetir();
            dataGridViewTalimatlar.ContextMenuStrip = contextMenuStrip1;

            checkBoxTumunuGoster.Checked = false;
            BekleyenTalimatSayisiniGetir();
            timerBekleyenTalimat.Interval = 1000;
            timerBekleyenTalimat.Enabled = true;
        }

        private void BekleyenTalimatSayisiniGetir()
        {
            try
            {
                lblBekleyenTalimat.Text = veriTabaniIslemleri.VeriGetir("KullanicininTalimatlari", kosullar: $"KullaniciId ={GenelIslemler.GirisYapanKullaniciID} and YuklendiMi = 0").Rows.Count.ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu" + hata.Message);

            }
        }

        private void TalimatlariDataGrideGetir(bool tumunuGoster = false)
        {
            try
            {
                if (tumunuGoster)
                {
                    dataGridViewTalimatlar.DataSource = veriTabaniIslemleri.VeriGetir("KullanicininTalimatlari", kosullar: $"KullaniciId={GenelIslemler.GirisYapanKullaniciID}");
                }
                else
                {
                    dataGridViewTalimatlar.DataSource = veriTabaniIslemleri.VeriGetir("KullanicininTalimatlari", kosullar: $"KullaniciId={GenelIslemler.GirisYapanKullaniciID} and YuklendiMi=0");
                }
                dataGridViewTalimatlar.Columns["Id"].Visible = false;
                dataGridViewTalimatlar.Columns["Akbil"].Width = 200;
                dataGridViewTalimatlar.Columns["YuklendiMi"].Width = 150;
                dataGridViewTalimatlar.Columns["YuklendiMi"].HeaderText = "Talimat Yüklendi mi ?";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimatlar getirilirken hata oluştu! " + hata.Message);
            }
        }

        private void ComboBoxaKullanicininAkbilleriniGetir()
        {
            try
            {
                cmbBoxAkbiller.DataSource = veriTabaniIslemleri.VeriGetir("Akbiller",
                    kosullar: $"AkbilinSahibiId={GenelIslemler.GirisYapanKullaniciID}");
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo"; //Genellikle benzersiz bilgi atanır. ÖRN :Primary key kolunu

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }

        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil seçmeden talimat kaydedilemez! ");
                    return;
                }
                if (string.IsNullOrEmpty(txtYuklenecekTutar.Text))
                {
                    MessageBox.Show("Yükleme miktarı girişi zorunludur! ");
                    return;
                }
                if (!decimal.TryParse(txtYuklenecekTutar.Text.Trim(), out decimal tutar))
                {
                    MessageBox.Show("Yükleme miktarı girişi uygun formatta olmalıdır! ");
                    return;
                }
                Dictionary<string, object> kolonlar = new Dictionary<string, object>();
                kolonlar.Add("EklenmeTarihi", $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
                kolonlar.Add("AkbilID", $"'{cmbBoxAkbiller.SelectedValue}'");
                kolonlar.Add("YuklenecekTutar", tutar);
                kolonlar.Add("YuklendiMi", "0");
                kolonlar.Add("YuklenmeTarihi", "null");
                string talimatinsert = veriTabaniIslemleri.VeriEklemeCumlesiOlustur(
                    "Talimatlar", kolonlar);
                int sonuc = veriTabaniIslemleri.KomutIsle(talimatinsert);
                if (sonuc > 0)
                {
                    MessageBox.Show("Talimat Kaydedildi...");
                    txtYuklenecekTutar.Clear();
                    cmbBoxAkbiller.SelectedIndex = -1;
                    cmbBoxAkbiller.Text = "Akbil Seçiniz...";
                    groupBoxYukleme.Enabled = false;
                    TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                    BekleyenTalimatSayisiniGetir();
                }
                else
                {
                    MessageBox.Show("Talimat kaydedilemedi !");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimat kaydedilemedi! " + hata.Message);
            }
        }

        private void checkBoxTumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);

        }

        private void cmbBoxAkbiller_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBoxAkbiller.SelectedIndex >= 0)
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = true;
            }
            else
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = false;
            }
        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnasayfa formaA = new FormAnasayfa();
            this.Hide();
            formaA.Show();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle güle çıkış yapıldı");
            GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapanKullaniciID = 0;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name != "Form1")
                {
                    item.Hide();
                }
            }
            Application.OpenForms["Form1"].Show();
        }

        private void lblBekleyenTalimat_Click(object sender, EventArgs e)
        {

        }

        private void timerBekleyenTalimat_Tick(object sender, EventArgs e)
        {
            if (lblBekleyenTalimat.Text != "0")
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI Black", 40);
                    lblBekleyenTalimat.ForeColor = Color.Red;
                }
                else
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI Black", 25);
                    lblBekleyenTalimat.ForeColor = Color.Black;
                }
            }
        }

        private void talimatıiptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
            {
                if ((bool)item.Cells["YuklendiMi"].Value)
                {
                    MessageBox.Show($"Dikkat {item.Cells["AkbilNo"]} akbilin {item.Cells["YuklenecekTutar"]} liralık yüklemesi yapılmıştır. Yüklenen talimat iptal edilemez/silinemez. \nİşlemlerinize devam etmek için tamama basınız.");
                    continue;
                }
                sayac += veriTabaniIslemleri.VeriSil("Talimatlar",$"Id = {item.Cells["Id"].Value}");
            }
            MessageBox.Show($"{sayac} adet talimat iptal edilmiştir");
            TalimatlariDataGrideGetir();
            BekleyenTalimatSayisiniGetir();
        }
    }
}
