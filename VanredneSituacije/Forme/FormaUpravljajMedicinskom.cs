using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajMedicinskom : Form
    {
        DTODodajMedicinsku medicinska;

        public FormaUpravljajMedicinskom()
        {
            InitializeComponent();
            PopuniComboe();
        }

        public FormaUpravljajMedicinskom(DTODodajMedicinsku medi)
        {
            InitializeComponent();
            medicinska = medi;
            PopuniPodacima();
            txtSerijskiBroj.Enabled = false;
            txtSerijskiBroj.BackColor = Color.LightGray;
        }

        private async void PopuniPodacima()
        {
            await PopuniComboe();
            txtSerijskiBroj.Text = medicinska.Serijski_Broj;
            txtNazivOpreme.Text = medicinska.Naziv;
            cmbStatus.SelectedItem = medicinska.Status;
            cmbJedinica.SelectedValue = medicinska.JedinicaID;
            dtpDatumNabavke.Value = medicinska.DatumNabavke;
            cmbTip.SelectedItem = medicinska.Tip;
        }

        private async Task PopuniComboe()
        {
            var jedinice = await DTOManager.VratiOpstejedinice();
            cmbJedinica.DataSource = jedinice;
            cmbJedinica.DisplayMember = "Naziv";
            cmbJedinica.ValueMember = "Jedinstveni_Broj";

            cmbTip.DataSource = Enum.GetValues(typeof(TipMedicinske));
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusOpreme));
            cmbJedinica.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbTip.SelectedIndex = -1;
        }

        private async void FormaUpravljajMedicinskom_Load(object sender, EventArgs e)
        {
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DTODodajMedicinsku med = new DTODodajMedicinsku();
            med.Serijski_Broj = txtSerijskiBroj.Text;
            med.Naziv = txtNazivOpreme.Text;
            med.Status = (StatusOpreme)cmbStatus.SelectedValue;
            med.DatumNabavke = dtpDatumNabavke.Value;
            med.Tip = (TipMedicinske)cmbTip.SelectedValue;
            med.JedinicaID = (int)cmbJedinica.SelectedValue;

            if (string.IsNullOrEmpty(txtSerijskiBroj.Text) || string.IsNullOrEmpty(txtNazivOpreme.Text) ||
                cmbTip.SelectedIndex == -1 || cmbJedinica.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Popunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (medicinska == null)
                await DTOManager.DodajMedicinskuOpremu(med);
            else
                await DTOManager.IzmeniMedicinskuOpremu(medicinska.Serijski_Broj, med);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li želiš da zatvoriš formu?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            txtNazivOpreme.Clear();
            dtpDatumNabavke.Value = DateTime.Now;
            cmbJedinica.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbTip.SelectedIndex = -1;
        }
    }
}