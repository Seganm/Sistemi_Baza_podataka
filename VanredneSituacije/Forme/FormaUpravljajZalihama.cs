using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajZalihama : Form
    {
        private DTODodajZalihe trenutnaZaliha;

        public FormaUpravljajZalihama()
        {
            InitializeComponent();
            NapuniListe();
        }

        public FormaUpravljajZalihama(DTODodajZalihe z)
        {
            InitializeComponent();
            trenutnaZaliha = z;
            UcitajPodatke();
            txtSerijski.Enabled = false;
            txtSerijski.BackColor = Color.LightGray;
        }

        private async void FormaUpravljajZalihama_Load(object sender, EventArgs e) { }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DTODodajZalihe nova = new DTODodajZalihe
            {
                Serijski_Broj = txtSerijski.Text,
                Naziv = txtNaziv.Text,
                Status = (StatusOpreme)cmbStatus.SelectedValue,
                DatumNabavke = dtpDatum.Value,
                Tip = (TipZalihe)cmbTip.SelectedValue,
                JedinicaID = (int)cmbJedinica.SelectedValue,
                Kolicina = (int)numKolicina.Value
            };

            if (string.IsNullOrEmpty(txtSerijski.Text) || string.IsNullOrEmpty(txtNaziv.Text) ||
                cmbStatus.SelectedIndex == -1 || cmbTip.SelectedIndex == -1 || cmbJedinica.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo unesite sve tražene podatke.", "Greška pri unosu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (trenutnaZaliha == null)
                await DTOManager.DodajZalihe(nova);
            else
                await DTOManager.IzmeniZalihe(nova, trenutnaZaliha.Serijski_Broj);

            DialogResult = DialogResult.OK;
            Close();
        }

        private async Task NapuniListe()
        {
            var jedinice = await DTOManager.InterventneVratii();
            cmbJedinica.DataSource = jedinice;
            cmbJedinica.DisplayMember = "Naziv";
            cmbJedinica.ValueMember = "JedinstveniBroj";

            cmbTip.DataSource = Enum.GetValues(typeof(TipZalihe));
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusOpreme));
        }

        public async void UcitajPodatke()
        {
            await NapuniListe();
            txtSerijski.Text = trenutnaZaliha.Serijski_Broj;
            txtNaziv.Text = trenutnaZaliha.Naziv;
            cmbStatus.SelectedItem = trenutnaZaliha.Status;
            cmbJedinica.SelectedValue = trenutnaZaliha.JedinicaID;
            dtpDatum.Value = trenutnaZaliha.DatumNabavke;
            cmbTip.SelectedItem = trenutnaZaliha.Tip;
            numKolicina.Value = trenutnaZaliha.Kolicina;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNaziv.Clear();
            txtSerijski.Clear();
            dtpDatum.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
            cmbTip.SelectedIndex = -1;
            cmbJedinica.SelectedIndex = -1;
            numKolicina.Value = 0;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li da izađete iz ove forme?", "Zatvaranje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}