
namespace AkbilYonetimiUI
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAyarlar formAyar = new FormAyarlar();
            formAyar.Show();
        }

        private void btnAkbil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAkbiller formAkbiller = new FormAkbiller();
            formAkbiller.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTalimatlar formTalimat = new FormTalimatlar();
            formTalimat.Show();
        }
    }
}
