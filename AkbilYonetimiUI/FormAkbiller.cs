
using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;
using System.Data;
using System.Data.SqlClient;

namespace AkbilYonetimiUI
{
    public partial class FormAkbiller : Form
    {
        IVeritabaniIslemleri veritabaniIslemleri = new SqlVeritabaniIslemleri();
        public FormAkbiller()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // kontroller
                if (cmbBoxAkbilTipleri.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil türü seçiniz");
                    return;
                }
                if (maskedTextBoxAkbilNo.Text.Length < 16)
                {
                    MessageBox.Show("Akbil No 16 haneli olmak zorunda");
                    return;
                }
                Dictionary<string, object> yeniAkbilBilgileri = new Dictionary<string, object>();
                yeniAkbilBilgileri.Add("AkbilNo", $"'{maskedTextBoxAkbilNo.Text}'");
                yeniAkbilBilgileri.Add("Bakiye", 0);
                yeniAkbilBilgileri.Add("AkbilTipi",$"' {cmbBoxAkbilTipleri.SelectedItem}'");
                yeniAkbilBilgileri.Add("EklenmeTarihi", $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
                yeniAkbilBilgileri.Add("VizelendigiTarih", "null");
                yeniAkbilBilgileri.Add("AkbilinSahibiId", GenelIslemler.GirisYapanKullaniciID);
                string insertCumle = veritabaniIslemleri.VeriEklemeCumlesiOlustur("Akbiller", yeniAkbilBilgileri);
                int sonuc = veritabaniIslemleri.KomutIsle(insertCumle);
                if (sonuc > 0)
                {
                    MessageBox.Show("Akbil eklendi");
                    DataGridViewDoldur();
                    maskedTextBoxAkbilNo.Clear();
                    cmbBoxAkbilTipleri.SelectedIndex = -1;
                    cmbBoxAkbilTipleri.Text = "Akbil tipi seçiniz.";
                }
                veritabaniIslemleri.KomutIsle(insertCumle);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu" + hata.Message);
            }
        }

        private void FormAkbiller_Load(object sender, EventArgs e)
        {
            cmbBoxAkbilTipleri.Text = "Akbil tipi seçiniz...";
            cmbBoxAkbilTipleri.SelectedIndex = -1;
            DataGridViewDoldur();
        }

        private void DataGridViewDoldur()
        {
            try
            {
                dataGridViewAkbiller.DataSource = veritabaniIslemleri.VeriGetir("Akbiller", kosullar: $"AkbilinSahibiId = {GenelIslemler.GirisYapanKullaniciID}");
                dataGridViewAkbiller.Columns["AkbilinSahibiId"].Visible = false;
                dataGridViewAkbiller.Columns["VizelendigiTarih"].HeaderText = "Vizelendiği Tarih";

            }
            catch (Exception hata)
            {

                MessageBox.Show("Akbiller listelenemedi" + hata.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
