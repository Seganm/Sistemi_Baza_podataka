using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledJedinice : Form
    {
        public FormaPregledJedinice()
        {
            InitializeComponent();
        }

        public async void PopuniPodacima()
        {
            string tip = izborTipa.SelectedItem?.ToString();

            if (tip == "Opšte Jedinice")
                mrezaJedinice.DataSource = await DTOManager.VratiOpstejedinice();
            else if (tip == "Specijalne Jedinice")
                mrezaJedinice.DataSource = await DTOManager.VratiSpecijalneJedinice();
            else
                mrezaJedinice.DataSource = await DTOManager.VratiSveJedinice();

            mrezaJedinice.Refresh();
            mrezaJedinice.ClearSelection();
        }

        private void izborTipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void dugmeDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaDodajInterventnu();
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (mrezaJedinice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju jedinicu menjamo?", "Info");
                return;
            }

            var jedinica = mrezaJedinice.CurrentRow.DataBoundItem as DTOVratiInterventnuJedinicu;
            Form forma;

            if (jedinica is DTOVratiSpecijalnuInterventnuJedinicu spec)
                forma = new FormaUpravljajSpecijalnomInterventnom(spec);
            else if (jedinica is DTOVratiOpstuInterventnuJedinicu opsta)
                forma = new FormaUpravljajOpstomInterventnom(opsta);
            else
                throw new Exception("Nepoznat tip jedinice!");

            forma.ShowDialog();
            PopuniPodacima();
        }

        private async void dugmeObrisi_Click(object sender, EventArgs e)
        {
            if (mrezaJedinice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Koju jedinicu brišemo?", "Info");
                return;
            }

            var potvrda = MessageBox.Show("Brisanje ove jedinice?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (potvrda == DialogResult.OK)
            {
                var jedinica = mrezaJedinice.CurrentRow.DataBoundItem as DTOVratiInterventnuJedinicu;

                if (jedinica is DTOVratiOpstuInterventnuJedinicu opsta)
                    await DTOManager.ObrisiOpstuInterventnuJedinicu(opsta.Jedinstveni_Broj);
                else if (jedinica is DTOVratiSpecijalnuInterventnuJedinicu spec)
                    await DTOManager.ObrisiSpecijalnuInterventnuJedinicu(spec.Jedinstveni_Broj);

                MessageBox.Show("Jedinica uspešno obrisana.", "Info");
                PopuniPodacima();
            }
        }

        private void dugmeVozila_Click(object sender, EventArgs e)
        {
            if (mrezaJedinice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Za koju jedinicu prikazujemo vozila?", "Info");
                return;
            }

            var jedinica = mrezaJedinice.CurrentRow.DataBoundItem as DTOVratiInterventnuJedinicu;
            Form forma;

            if (jedinica is DTOVratiSpecijalnuInterventnuJedinicu spec)
                forma = new FormaJedinicaVozila(spec.Jedinstveni_Broj);
            else if (jedinica is DTOVratiOpstuInterventnuJedinicu opsta)
                forma = new FormaJedinicaVozila(opsta.Jedinstveni_Broj);
            else
                throw new Exception("Nepoznat tip jedinice!");

            forma.ShowDialog();
            PopuniPodacima();
        }

        private void dugmeClanovi_Click(object sender, EventArgs e)
        {
            if (mrezaJedinice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Za koju jedinicu prikazujemo članove?", "Info");
                return;
            }

            var jedinica = mrezaJedinice.CurrentRow.DataBoundItem as DTOVratiInterventnuJedinicu;
            Form forma;

            if (jedinica is DTOVratiSpecijalnuInterventnuJedinicu spec)
                forma = new FormaOperativciJedinice(spec.Jedinstveni_Broj);
            else if (jedinica is DTOVratiOpstuInterventnuJedinicu opsta)
                forma = new FormaOperativciJedinice(opsta.Jedinstveni_Broj);
            else
                throw new Exception("Nepoznat tip jedinice!");

            forma.ShowDialog();
            PopuniPodacima();
        }

        private async void FormaPregledJedinice_Load(object sender, EventArgs e)
        {
            izborTipa.SelectedText = "Sve Jedinice";
            mrezaJedinice.DataSource = await DTOManager.VratiSveJedinice();
            PopuniPodacima();
        }
    }
}
