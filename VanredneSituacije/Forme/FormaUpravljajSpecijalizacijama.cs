using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSpecijalizacijama : Form
    {
        private DTOSpecijalizacije _postojecaSpecijalizacija;
        private readonly string _jmbgKoordinatora;

        public FormaUpravljajSpecijalizacijama(string jmbg)
        {
            InitializeComponent();
            _jmbgKoordinatora = jmbg;
            txtJmbgKoordinatora.Text = jmbg;
            txtJmbgKoordinatora.ReadOnly = true;
            txtJmbgKoordinatora.BackColor = Color.Gainsboro;
        }

        public FormaUpravljajSpecijalizacijama(DTOSpecijalizacije specijalizacija)
        {
            _postojecaSpecijalizacija = specijalizacija;
            InitializeComponent();
            PopuniPoljaZaIzmenu();
            txtJmbgKoordinatora.ReadOnly = true;
            txtJmbgKoordinatora.BackColor = Color.Gainsboro;
        }

        private async void PopuniPoljaZaIzmenu()
        {
            txtJmbgKoordinatora.Text = _postojecaSpecijalizacija.JMBG_Kordinatora;
            txtOblastSpecijalizacije.Text = _postojecaSpecijalizacija.Tip;
        }

        private async void btnSacuvajSpecijalizaciju_Click(object sender, EventArgs e)
        {
            DTODodajSpecijalizaciju novaSpecijalizacija = new DTODodajSpecijalizaciju
            {
                JMBG_Kordinator = txtJmbgKoordinatora.Text,
                Tip = txtOblastSpecijalizacije.Text
            };

            if (string.IsNullOrWhiteSpace(novaSpecijalizacija.Tip))
            {
                MessageBox.Show("Unesite naziv oblasti specijalizacije.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_postojecaSpecijalizacija == null)
            {
                await DTOManager.DodajSpecijalizaciju(novaSpecijalizacija);
                MessageBox.Show("Specijalizacija je  dodata.");
            }
            else
            {
                await DTOManager.IzmeniSpecijalizaciju(novaSpecijalizacija, _postojecaSpecijalizacija.Id);
                MessageBox.Show("Specijalizacija je  izmenjena.");
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOcistiPolja_Click(object sender, EventArgs e)
        {
            txtOblastSpecijalizacije.Clear();
        }

        private void btnZatvoriFormu_Click(object sender, EventArgs e)
        {
            DialogResult potvrda = MessageBox.Show(
                "Da li ste sigurni da želite da zatvorite ovu formu?",
                "Potvrda izlaska",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.Yes)
                Close();
        }
    }
}
