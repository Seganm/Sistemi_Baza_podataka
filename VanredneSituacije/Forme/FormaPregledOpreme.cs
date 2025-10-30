using System;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledOpreme : Form
    {
        public FormaPregledOpreme()
        {
            InitializeComponent();
        }

        public async void PopuniPodacima()
        {
            string tip = komboTip.SelectedItem?.ToString();

            if (tip == "Sve")
                mrezaOprema.DataSource = await DTOManager.VratiSvuOpremu();
            else if (tip == "Lična zaštita")
                mrezaOprema.DataSource = await DTOManager.VratiOpremuLicneZastite();
            else if (tip == "Medicinska")
                mrezaOprema.DataSource = await DTOManager.VratiMedicinskuZastitu();
            else if (tip == "Tehnička")
                mrezaOprema.DataSource = await DTOManager.VratiTehnickuZastitu();
            else if (tip == "Zalihe")
                mrezaOprema.DataSource = await DTOManager.VratiZalihe();
            else
                mrezaOprema.DataSource = await DTOManager.VratiSvuOpremu();

            mrezaOprema.Refresh();
            mrezaOprema.ClearSelection();
        }

        private async void FormaPregledOpreme_Load(object sender, EventArgs e)
        {
            komboTip.SelectedText = "Sve";
            mrezaOprema.DataSource = await DTOManager.VratiSvuOpremu();
            PopuniPodacima();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (mrezaOprema.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju opremu brišemo?", "Info");
                return;
            }

            var potvrda = MessageBox.Show("Brisanje ove opreme?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                var oprema = mrezaOprema.CurrentRow.DataBoundItem as DTODodajOpremu;

                if (oprema is DTODodajZalihe zalihe)
                    await DTOManager.ObrisiZalihe(zalihe.Serijski_Broj);
                else if (oprema is DTODodajMedicinsku med)
                    await DTOManager.ObrisiMedicinskuOpremu(med.Serijski_Broj);
                else if (oprema is DTODodajTehnicku teh)
                    await DTOManager.ObrisiTehnickuOpremu(teh.Serijski_Broj);
                else if (oprema is DTODodajLicnuZastitu licna)
                    await DTOManager.ObrisiLicnuZastitu(licna.Serijski_Broj);
                else
                    throw new Exception("Nepoznat tip opreme!");

                MessageBox.Show("Oprema uspešno obrisana.", "Info");
                PopuniPodacima();
            }
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaOpremaDodaj();
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (mrezaOprema.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju opremu menjamo?", "Info");
                return;
            }

            var oprema = mrezaOprema.CurrentRow.DataBoundItem as DTODodajOpremu;
            Form forma;

            if (oprema is DTODodajZalihe zalihe)
                forma = new FormaUpravljajZalihama(zalihe);
            else if (oprema is DTODodajMedicinsku med)
                forma = new FormaUpravljajMedicinskom(med);
            else if (oprema is DTODodajTehnicku teh)
                forma = new FormaUpravljajTehnickom(teh);
            else if (oprema is DTODodajLicnuZastitu licna)
                forma = new FormaUpravljajLicnomZastitom(licna);
            else
                throw new Exception("Nepoznat tip opreme!");

            forma.ShowDialog();
            PopuniPodacima();
        }

        private void mrezaOprema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void komboTip_DropDownStyleChanged(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void komboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
