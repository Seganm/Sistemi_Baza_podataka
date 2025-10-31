using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSituacijom : Form
    {
        private DTOVanrednaSituacija vanrednaSituacija;

        public FormaUpravljajSituacijom()
        {
            InitializeComponent();
            UcitajPrijave();
            cmbNivoOpasnosti.SelectedIndexChanged += cmbNivoOpasnosti_SelectedIndexChanged;
        }

        public FormaUpravljajSituacijom(DTOVanrednaSituacija vanrednaSituacija)
        {
            InitializeComponent();
            this.vanrednaSituacija = vanrednaSituacija;
            PopuniPodacima();
            cmbNivoOpasnosti.SelectedIndexChanged += cmbNivoOpasnosti_SelectedIndexChanged;
        }

        public async Task UcitajPrijave()
        {
            cmbPrijave.DataSource = await DTOManager.VratiPrijave();
            cmbPrijave.DisplayMember = "Id";
            cmbPrijave.ValueMember = "Id";
            cmbPrijave.SelectedValue = vanrednaSituacija?.Prijava.Id;
        }

        public async void PopuniPodacima()
        {
            await UcitajPrijave();

            dtpDatumOd.Value = vanrednaSituacija.DatumPoc;
            if (vanrednaSituacija.DatumKraj != null)
                dtpDatumDo.Value = (DateTime)vanrednaSituacija.DatumKraj;

            txtTipSituacije.Text = vanrednaSituacija.Tip;
            numBrojUgrozenih.Value = vanrednaSituacija.Broj_Ugrozenih_Osoba ?? 0;
            cmbNivoOpasnosti.Text = vanrednaSituacija.Nivo_Opasnosti.ToString();
            txtOpstina.Text = vanrednaSituacija.Opstina;
            txtLokacija.Text = vanrednaSituacija.Lokacija;
            txtOpis.Text = vanrednaSituacija.Opis;

            PromeniBojuPozadine(cmbNivoOpasnosti.Text);
        }

        private void FormaUpravljajVanrednomSituacijom_Load(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value;
            dtpDatumOd.ValueChanged += (s, ev) =>
            {
                dtpDatumDo.MinDate = dtpDatumOd.Value;
            };
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li sigurno želiš da zatvoriš formu bez čuvanja promena?",
                "Potvrda izlaska",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (vanrednaSituacija != null)
                PopuniPodacima();
            else
            {
                dtpDatumOd.Value = DateTime.Now;
                dtpDatumDo.Value = DateTime.Now;
                txtTipSituacije.Clear();
                numBrojUgrozenih.Value = 0;
                cmbNivoOpasnosti.SelectedIndex = -1;
                txtOpstina.Clear();
                txtLokacija.Clear();
                txtOpis.Clear();
                cmbPrijave.SelectedIndex = -1;
                BackColor = Color.WhiteSmoke;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            bool imaGresku = false;

            if (string.IsNullOrWhiteSpace(txtTipSituacije.Text)) imaGresku = true;
            if (string.IsNullOrWhiteSpace(txtOpstina.Text)) imaGresku = true;
            if (cmbPrijave.SelectedIndex < 0) imaGresku = true;

            if (imaGresku)
            {
                MessageBox.Show("Popuni sva  polja.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novaSituacija = new DTODodajVanrednuSituaciju
            {
                DatumPoc = dtpDatumOd.Value,
                DatumKraj = dtpDatumDo.Value,
                Tip = txtTipSituacije.Text,
                Broj_Ugrozenih_Osoba = (int)numBrojUgrozenih.Value,
                IdPrijave = (int)cmbPrijave.SelectedValue,
                Lokacija = txtLokacija.Text,
                Opstina = txtOpstina.Text,
                Opis = txtOpis.Text
            };

            switch (cmbNivoOpasnosti.Text)
            {
                case "nizak":
                    novaSituacija.Nivo_Opasnosti = Entitet.NivoOpasnosti.nizak;
                    break;
                case "srednji":
                    novaSituacija.Nivo_Opasnosti = Entitet.NivoOpasnosti.srednji;
                    break;
                case "visok":
                    novaSituacija.Nivo_Opasnosti = Entitet.NivoOpasnosti.visok;
                    break;
            }

            if (vanrednaSituacija != null)
                await DTOManager.IzmeniVanrednuSituaciju(novaSituacija, vanrednaSituacija.Id);
            else
                await DTOManager.DodajVanrednuSituaciju(novaSituacija);

            MessageBox.Show("Dodato!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbNivoOpasnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            PromeniBojuPozadine(cmbNivoOpasnosti.Text);
        }

        private void PromeniBojuPozadine(string nivo)
        {
            switch (nivo)
            {
                case "nizak":
                    BackColor = Color.FromArgb(220, 255, 220);
                    break;
                case "srednji":
                    BackColor = Color.FromArgb(255, 255, 200);
                    break;
                case "visok":
                    BackColor = Color.FromArgb(255, 220, 220);
                    break;
                default:
                    BackColor = Color.WhiteSmoke;
                    break;
            }
        }
    }
}