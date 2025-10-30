using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSoftverom : Form
    {
        private readonly DTOSoftveri _trenutniSoftver;
        private readonly string _analiticarJmbg;

        public FormaUpravljajSoftverom()
        {
            InitializeComponent();
        }

        public FormaUpravljajSoftverom(string jmbg)
        {
            InitializeComponent();
            _analiticarJmbg = jmbg;
            txtJmbgAnaliticara.Text = jmbg;
            txtJmbgAnaliticara.ReadOnly = true;
            txtJmbgAnaliticara.BackColor = Color.Gainsboro;
        }

        public FormaUpravljajSoftverom(DTOSoftveri softver)
        {
            InitializeComponent();
            _trenutniSoftver = softver;
            PopuniPoljaIzmene();
            txtJmbgAnaliticara.ReadOnly = true;
            txtJmbgAnaliticara.BackColor = Color.Gainsboro;
        }

        private async void PopuniPoljaIzmene()
        {
            txtJmbgAnaliticara.Text = _trenutniSoftver.JMBGAnaliticara;
            txtNazivSoftvera.Text = _trenutniSoftver.Naziv;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DTODodajSoftver s = new DTODodajSoftver
            {
                JMBG_Analiticar = txtJmbgAnaliticara.Text,
                Naziv = txtNazivSoftvera.Text
            };

            if (string.IsNullOrWhiteSpace(s.Naziv))
            {
                MessageBox.Show("Unesi naziv softvera.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_trenutniSoftver == null)
            {
                await DTOManager.DodajSoftver(s);
                MessageBox.Show("Softver je  dodat.", "");
            }
            else
            {
                if (int.TryParse(_trenutniSoftver.Id.ToString(), out int idSoftvera))
                {
                    await DTOManager.IzmeniSoftver(s, idSoftvera);
                    MessageBox.Show("Podaci o softveru su ažurirani.", "Uspešno");
                }
                else
                {
                    MessageBox.Show("Nevažeći ID softvera.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtNazivSoftvera.Clear();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            var potvrda = MessageBox.Show("Da li želite da zatvorite prozor?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (potvrda == DialogResult.Yes)
                Close();
        }
    }
}