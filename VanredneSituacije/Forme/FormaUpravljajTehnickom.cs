using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajTehnickom : Form
    {
        private DTODodajTehnicku tehnicka;

        public FormaUpravljajTehnickom()
        {
            InitializeComponent();
            PopuniComboe();
        }

        public FormaUpravljajTehnickom(DTODodajTehnicku t)
        {
            InitializeComponent();
            this.tehnicka = t;
            PopuniPodacima();
            txtSerijskiBroj.Enabled = false;
            txtSerijskiBroj.BackColor = Color.Gainsboro;
        }

        public async void PopuniPodacima()
        {
            await PopuniComboe();
            txtSerijskiBroj.Text = tehnicka.Serijski_Broj;
            txtNazivOpreme.Text = tehnicka.Naziv;
            cmbStatus.SelectedItem = tehnicka.Status;
            cmbJedinica.SelectedValue = tehnicka.JedinicaID;
            dpDatumNabavke.Value = tehnicka.DatumNabavke;
            cmbTipOpreme.SelectedItem = tehnicka.Tip;
        }

        private async Task PopuniComboe()
        {
            var jedinice = await DTOManager.VratiSpecijalneJedinice();
            cmbJedinica.DataSource = jedinice;
            cmbJedinica.DisplayMember = "Naziv";
            cmbJedinica.ValueMember = "Jedinstveni_Broj";

            cmbStatus.DataSource = Enum.GetValues(typeof(StatusOpreme));
            cmbTipOpreme.DataSource = Enum.GetValues(typeof(TipTehnicke));

            cmbJedinica.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbTipOpreme.SelectedIndex = -1;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSerijskiBroj.Text) || string.IsNullOrEmpty(txtNazivOpreme.Text) ||
                cmbStatus.SelectedIndex == -1 || cmbJedinica.SelectedIndex == -1 || cmbTipOpreme.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo popunite sva obavezna polja pre čuvanja podataka.", "Nedovoljno podataka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DTODodajTehnicku novaTehnicka = new DTODodajTehnicku
            {
                Serijski_Broj = txtSerijskiBroj.Text,
                Naziv = txtNazivOpreme.Text,
                Status = (StatusOpreme)cmbStatus.SelectedValue,
                DatumNabavke = dpDatumNabavke.Value,
                Tip = (TipTehnicke)cmbTipOpreme.SelectedValue,
                JedinicaID = (int)cmbJedinica.SelectedValue
            };

            if (tehnicka == null)
                await DTOManager.DodajTehnickuOpremu(novaTehnicka);
            else
                await DTOManager.IzmeniTehnickuOpremu(novaTehnicka, tehnicka.Serijski_Broj);

            MessageBox.Show("Tehnička oprema je uspešno sačuvana.", "Uspešno čuvanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNazivOpreme.Clear();
            dpDatumNabavke.Value = DateTime.Now;
            cmbJedinica.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbTipOpreme.SelectedIndex = -1;
            MessageBox.Show("Sva polja su resetovana.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Da li ste sigurni da želite da zatvorite ovu formu?", "Potvrda zatvaranja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
                Close();
        }

        private void FormaUpravljajTehnickom_Load(object sender, EventArgs e)
        {
        }
    }
}