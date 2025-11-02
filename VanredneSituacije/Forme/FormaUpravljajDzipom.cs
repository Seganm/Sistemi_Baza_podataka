using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajDzipom : Form
    {
        public readonly string Reg_Oznaka;

        public FormaUpravljajDzipom()
        {
            InitializeComponent();
            PopuniPodacima();
        }

        public FormaUpravljajDzipom(string regOznaka)
        {
            InitializeComponent();
            Reg_Oznaka = regOznaka;
            PopuniPodacima();
            textReg.Enabled = false;
            textReg.BackColor = Color.LightGray;
        }

        public async void PopuniPodacima()
        {
            comboStatus.DataSource = Enum.GetValues(typeof(StatusVozila));

            if (!string.IsNullOrEmpty(Reg_Oznaka))
            {
                var dzip = await DTOManager.DzipVratii(Reg_Oznaka);

                textReg.Text = dzip.Registracijaa;
                textProizvodjac.Text = dzip.Proizvodjac;
                textLok.Text = dzip.Lokacija;
                comboStatus.SelectedItem = dzip.Status;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textProizvodjac.Clear();
            textLok.Clear();
            comboStatus.SelectedIndex = -1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "sigurno zelite da zatvorite formu bez cuvanja promena?",
                "Potvrda zatvaranja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            // Osnovna validacija
            if (string.IsNullOrWhiteSpace(textReg.Text) ||
                string.IsNullOrWhiteSpace(textProizvodjac.Text) ||
                string.IsNullOrWhiteSpace(textLok.Text) ||
                comboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Popunite sva polja i izaberite status vozila.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DTODzipDodajj dzip = new DTODzipDodajj
            {
                Registracijaa = textReg.Text.Trim(),
                Proizvodjac = textProizvodjac.Text.Trim(),
                Lokacija = textLok.Text.Trim(),
                Status = (StatusVozila)comboStatus.SelectedItem
            };

            try
            {
                if (string.IsNullOrEmpty(Reg_Oznaka))
                {
                    await DTOManager.DzipDodajj(dzip);
                    MessageBox.Show("Novi džip je uspešno dodat.",
                        "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await DTOManager.DzipIzmenii(dzip, Reg_Oznaka);
                    MessageBox.Show("Podaci o džipu su uspešno ažurirani.",
                        "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom čuvanja podataka:\n{ex.Message}",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormaUpravljajDzipom_Load(object sender, EventArgs e)
        {
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
