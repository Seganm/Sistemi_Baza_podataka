using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSluzbom : Form
    {
        private DTOSluzba _postojecaSluzba;

        public FormaUpravljajSluzbom()
        {
            InitializeComponent();
            UcitajPredstavnike();
        }

        public FormaUpravljajSluzbom(DTOSluzba sluzba)
        {
            InitializeComponent();
            _postojecaSluzba = sluzba;
            PopuniPostojecePodatke();
        }

        private async Task UcitajPredstavnike()
        {
            cmbPredstavnici.DataSource = await DTOManager.VratiPredstavnike();
            cmbPredstavnici.DisplayMember = "PunoIme";
            cmbPredstavnici.ValueMember = "JMBG";
            cmbPredstavnici.SelectedIndex = -1;
        }

        private async void PopuniPostojecePodatke()
        {
            await UcitajPredstavnike();
            txtTipSektora.Text = _postojecaSluzba.TipSektora;
            cmbPredstavnici.SelectedValue = _postojecaSluzba.Predstavnik;
            cmbPredstavnici.Text = _postojecaSluzba.Predstavnik.PunoIme;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            DTODodajSluzbu nova = new DTODodajSluzbu
            {
                TipSektora = txtTipSektora.Text,
                JMBG_Predstavnik = (string)cmbPredstavnici.SelectedValue
            };

            if (string.IsNullOrWhiteSpace(txtTipSektora.Text) || cmbPredstavnici.SelectedIndex == -1)
            {
                MessageBox.Show("Popunite sva polja.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_postojecaSluzba == null)
                await DTOManager.DodajSluzbu(nova);
            else
                await DTOManager.IzmeniSluzbu(nova, _postojecaSluzba.Id_Sektora);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtTipSektora.Clear();
            cmbPredstavnici.SelectedIndex = -1;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            var potvrda = MessageBox.Show("Da li  želite da zatvorite formu?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (potvrda == DialogResult.Yes)
                Close();
        }
    }
}
