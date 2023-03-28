
using System.Data.SqlClient;

namespace AkbilYonetimiUI
{
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }

        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            txtYeniSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1); //min girilen yaş
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1); //ilk görüntü
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            KullanicininBilgileriniGetir();
        }

        private void KullanicininBilgileriniGetir()
        {
            try
            {
                
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu" + hata.Message);
            }
        }

        private void btnGucelle_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata");
            }
        }
    }
}
