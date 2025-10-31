using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanredneSituacije.DTO;

namespace VanredneSituacije.Forme
{
    public partial class FormaPregledZaposlenih : Form
    {
        public FormaPregledZaposlenih()
        {
            InitializeComponent();
        }

        private void izborTipaZaposlenog_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsveziPrikazZaposlenih();
        }

        public async void OsveziPrikazZaposlenih()
        {
            string tip = izborTipaZaposlenog.SelectedItem?.ToString();

            if (tip == "Svi zaposleni")
            {
                tabelaZaposleni.DataSource = await DTOManager.ZaposleniVratii();
                dugmeSertifikati.Visible = false;
                dugmeEkspertize.Visible = false;
                dugmeSoftver.Visible = false;
                dugmeSpecijalizacije.Visible = false;
            }
            else if (tip == "Operativni radnici")
            {
                tabelaZaposleni.DataSource = await DTOManager.VratiOperativneRadnike();
                dugmeSertifikati.Visible = true;
                dugmeEkspertize.Visible = false;
                dugmeSoftver.Visible = false;
                dugmeSpecijalizacije.Visible = false;
            }
            else if (tip == "Koordinatori")
            {
                tabelaZaposleni.DataSource = await DTOManager.KoordinatorVratii();
                dugmeSertifikati.Visible = false;
                dugmeEkspertize.Visible = false;
                dugmeSoftver.Visible = false;
                dugmeSpecijalizacije.Visible = true;
            }
            else if (tip == "Analitičari")
            {
                tabelaZaposleni.DataSource = await DTOManager.AnaliticariVratii();
                dugmeSertifikati.Visible = false;
                dugmeEkspertize.Visible = true;
                dugmeSoftver.Visible = true;
                dugmeSpecijalizacije.Visible = false;
            }
            else
            {
                tabelaZaposleni.DataSource = await DTOManager.ZaposleniVratii();
                dugmeSertifikati.Visible = false;
                dugmeEkspertize.Visible = false;
                dugmeSoftver.Visible = false;
                dugmeSpecijalizacije.Visible = false;
            }

            tabelaZaposleni.Refresh();
            tabelaZaposleni.ClearSelection();
        }

        private async void dugmeObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi zaposlenog kog želiš da obrišeš.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                "Da obrišem izabranog zaposlenog?",
                "Info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (potvrda == DialogResult.OK)
            {
                var zaposleni = tabelaZaposleni.CurrentRow.DataBoundItem as DTOZaposleni;

                if (zaposleni is DTOOperativniRadnik op)
                    await DTOManager.ObrisiOperativnogRadnika(op.JMBG);
                else if (zaposleni is DTOKoordinator kor)
                    await DTOManager.KoordinatorObrisii(kor.JMBG);
                else if (zaposleni is DTOAnaliticar an)
                    await DTOManager.AnaliticarObrisii(an.JMBG);
                else
                    throw new Exception("Nepoznat tip zaposlenog.");

                MessageBox.Show("Zaposleni je obrisan.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OsveziPrikazZaposlenih();
            }
        }

        private void dugmeIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi zaposlenog kog želiš da izmeniš.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var zaposleni = tabelaZaposleni.CurrentRow.DataBoundItem as DTOZaposleni;
            Form forma;

            if (zaposleni is DTOOperativniRadnik op)
                forma = new FormaUpravljajOperativnim(op);
            else if (zaposleni is DTOKoordinator kor)
                forma = new FormaUpravljajKoordinatorom(kor);
            else if (zaposleni is DTOAnaliticar an)
                forma = new FormaUpravljajAnaliticarom(an);
            else
                throw new Exception("Nepoznat tip zaposlenog.");

            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private void dugmeDodajZaposlenog_Click(object sender, EventArgs e)
        {
            var forma = new FormaZaposleniDodaj();
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private async void FormaPregledZaposlenih_Load(object sender, EventArgs e)
        {
            izborTipaZaposlenog.SelectedIndex = 0;
            tabelaZaposleni.DataSource = await DTOManager.ZaposleniVratii();
            OsveziPrikazZaposlenih();
        }

        private void dugmeIstorijaUloga_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi zaposlenog da vidiš istoriju uloga.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var zaposleni = tabelaZaposleni.CurrentRow.DataBoundItem as DTOZaposleni;
            var forma = new FormaPregledIstorijeUloga(zaposleni.JMBG);
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private void dugmeSertifikati_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi radnika da vidiš njegove sertifikate.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var radnik = tabelaZaposleni.CurrentRow.DataBoundItem as DTOOperativniRadnik;
            var forma = new FormaPregledSertifikata(radnik);
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private void dugmeEkspertize_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi analitičara da vidiš njegove ekspertize.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var analiticar = tabelaZaposleni.CurrentRow.DataBoundItem as DTOAnaliticar;
            var forma = new FormaPregledEkspertiza(analiticar);
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private void dugmeSpecijalizacije_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi koordinatora da vidiš njegove specijalizacije.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kord = tabelaZaposleni.CurrentRow.DataBoundItem as DTOKoordinator;
            var forma = new FormaPregledSpecijalizacija(kord);
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private void dugmeSoftver_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi analitičara da vidiš njegov softver.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var analiticar = tabelaZaposleni.CurrentRow.DataBoundItem as DTOAnaliticar;
            var forma = new FormaPregledSoftvera(analiticar);
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }

        private void dugmeDodelaVozila_Click(object sender, EventArgs e)
        {
            if (tabelaZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi radnika da vidiš istoriju dodele vozila.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var zaposleni = tabelaZaposleni.CurrentRow.DataBoundItem as DTOZaposleni;
            var forma = new FormaJedinicaVozila(zaposleni.JMBG);
            forma.ShowDialog();
            OsveziPrikazZaposlenih();
        }
    }
}
