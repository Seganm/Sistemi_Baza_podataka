using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajEkspertizama : Form
    {
        private DTOEkspertize _ekspertiza;
        private readonly string _jmbgAnaliticara;

        public FormaUpravljajEkspertizama()
        {
            InitializeComponent();
        }

        public FormaUpravljajEkspertizama(string jmbgAnaliticara)
        {
            InitializeComponent();
            _jmbgAnaliticara = jmbgAnaliticara;
            txtJmbgAnaliticara.Text = jmbgAnaliticara;
            txtJmbgAnaliticara.ReadOnly = true;
            txtJmbgAnaliticara.BackColor = Color.LightGray;
        }

        public FormaUpravljajEkspertizama(DTOEkspertize ekspertiza)
        {
            InitializeComponent();
            _ekspertiza = ekspertiza;
            _jmbgAnaliticara = ekspertiza.JMBGAnaliticara;
            PopuniPodacimaZaIzmenu();

            txtJmbgAnaliticara.ReadOnly = true;
            txtJmbgAnaliticara.BackColor = Color.LightGray;
        }

        private async void PopuniPodacimaZaIzmenu()
        {
            txtJmbgAnaliticara.Text = _ekspertiza.JMBGAnaliticara;
            txtOblastEkspertize.Text = _ekspertiza.Oblast;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var ekspertizaDto = new DTOEkspertizaIzmenii
            {
                JMBGAnaliticara = _jmbgAnaliticara,
                Oblast = txtOblastEkspertize.Text.Trim()
            };

            if (string.IsNullOrWhiteSpace(ekspertizaDto.Oblast))
            {
                MessageBox.Show("Unesite oblast ekspertize.", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_ekspertiza == null)
                {
                    await DTOManager.EkspertizaDodajj(ekspertizaDto);
                    MessageBox.Show("Ekspertiza je uspešno dodata.", "Uspeh",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await DTOManager.EkspertizaIzmenii(ekspertizaDto, _ekspertiza.Id);
                    MessageBox.Show("Podaci o ekspertizi su uspešno ažurirani.", "Uspeh",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom čuvanja podataka:\n{ex.Message}",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtOblastEkspertize.Clear();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "sigurno zelite da zatvorite formu bez čuvanja promena?",
                "Potvrda zatvaranja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void FormaUpravljajEkspertizama_Load(object sender, EventArgs e)
        {
        }
    }
}
