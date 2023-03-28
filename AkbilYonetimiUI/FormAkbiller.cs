
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
                dataGridViewAkbiller.DataSource = veritabaniIslemleri.VeriGetir("Akbiller", kosullar: $"AkbilinSahiniId = {GenelIslemler.GirisYapanKullaniciID}");
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
