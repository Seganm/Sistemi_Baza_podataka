using System;
using System.Drawing;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajOpstomInterventnom : Form
    {
        DTOVratiOpstuInterventnuJedinicu opsta;

        public FormaUpravljajOpstomInterventnom()
        {
            InitializeComponent();
            PopuniPodacima();
        }

        public FormaUpravljajOpstomInterventnom(DTOVratiOpstuInterventnuJedinicu opsta)
        {
            InitializeComponent();
            this.opsta = opsta;
            PopuniPodacima();
        }

        public async void PopuniPodacima()
        {
            var operativni = await DTOManager.RadniciVratii();
            cmbKomandir.DataSource = operativni;
            cmbKomandir.DisplayMember = "PunoIme";
            cmbKomandir.ValueMember = "JMBG";

            if (opsta != null)
            {
                txtNaziv.Text = opsta.Naziv;
                txtBaza.Text = opsta.Baza;

                if (opsta.JMBGKomandira != null)
                {
                    cmbKomandir.SelectedValue = opsta.JMBGKomandira;
                    cmbKomandir.Enabled = false;
                }
                else
                {
                    cmbKomandir.SelectedIndex = -1;
                    cmbKomandir.Enabled = true;
                }
            }
        }

        private async void FormaUpravljajOpstomInterventnom_Load(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBaza.Clear();
            txtNaziv.Clear();
            cmbKomandir.SelectedIndex = -1;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li  želiš da zatvoriš formu?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                DTOOsnovnaOpstaInterventnaJedinica ops = new DTOOsnovnaOpstaInterventnaJedinica();
                ops.Naziv = txtNaziv.Text;
                ops.Baza = txtBaza.Text;
                ops.JMBGKomandira = cmbKomandir.SelectedValue.ToString();

                if (string.IsNullOrEmpty(txtBaza.Text) || string.IsNullOrEmpty(txtNaziv.Text) || cmbKomandir.SelectedIndex == -1)
                {
                    MessageBox.Show("Popunite sva polja.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (opsta == null)
                {
                    await DTOManager.OpstaInterventnaDodajj(ops);
                }
                else
                {
                    await DTOManager.OpstaInterventnaIzmenii(ops, opsta.JedinstveniBroj);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
