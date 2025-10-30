using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajSaradjivanjem : Form
    {
        private DTOSaradnja trenutnaSaradnja;

        public FormaUpravljajSaradjivanjem()
        {
            InitializeComponent();
        }

        public FormaUpravljajSaradjivanjem(DTOSaradnja saradnja)
        {
            InitializeComponent();
            trenutnaSaradnja = saradnja;
            PopuniPodacima();
        }

        private async void FormaUpravljajSaradjivanjem_Load(object sender, EventArgs e)
        {
            var sluzbe = await DTOManager.VratiSluzbe();
            var vanredneSituacije = await DTOManager.VratiVanredneSituacije();

            cmbSluzba.DataSource = sluzbe;
            cmbVanrednaSituacija.DataSource = vanredneSituacije;

            cmbSluzba.DisplayMember = "Id_Sektora";
            cmbSluzba.ValueMember = "Id_Sektora";

            cmbVanrednaSituacija.DisplayMember = "Id";
            cmbVanrednaSituacija.ValueMember = "Id";

            cmbSluzba.SelectedIndex = -1;
            cmbVanrednaSituacija.SelectedIndex = -1;

            PopuniPodacima();
        }

        private void PopuniPodacima()
        {
            if (trenutnaSaradnja != null)
            {
                cmbVanrednaSituacija.SelectedValue = trenutnaSaradnja.VandrednaSituacija.Id;
                cmbSluzba.SelectedValue = trenutnaSaradnja.Sektor.Id_Sektora;
                txtUloga.Text = trenutnaSaradnja.Uloga;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSluzba.SelectedIndex == -1 || cmbVanrednaSituacija.SelectedIndex == -1 || string.IsNullOrEmpty(txtUloga.Text))
            {
                MessageBox.Show("Popunite sva polja.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DTODodajSaradnju novaSaradnja = new DTODodajSaradnju
            {
                SektorID = (int)cmbSluzba.SelectedValue,
                VanrednaSituacijaID = (int)cmbVanrednaSituacija.SelectedValue,
                Uloga = txtUloga.Text.Trim()
            };

            if (trenutnaSaradnja == null)
                await DTOManager.DodajSaradnju(novaSaradnja);
            else
                await DTOManager.IzmeniSaradnju(novaSaradnja, trenutnaSaradnja.Id);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbSluzba.SelectedIndex = -1;
            cmbVanrednaSituacija.SelectedIndex = -1;
            txtUloga.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Da li  želite da zatvorite formu ?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
