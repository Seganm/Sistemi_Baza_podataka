using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormaUpravljajSanitetskim : Form
    {
        DTOSanitetsko pocetno;

        public FormaUpravljajSanitetskim()
        {
            InitializeComponent();
            StilizujFormu();
            PopuniPodacima();
        }

        public FormaUpravljajSanitetskim(DTOSanitetsko sanitetsko)
        {
            pocetno = sanitetsko;
            InitializeComponent();
            StilizujFormu();
            PopuniPodacima();
            unosReg.Enabled = false;
            unosReg.BackColor = Color.LightGray;
        }

        private void StilizujFormu()
        {
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            Text = "Upravljanje sanitetskim vozilom";

            var naslovLbl = new Label()
            {
                Text = "UPRAVLJANJE SANITETSKIM VOZILOM",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(63, 81, 181),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 40
            };
            Controls.Add(naslovLbl);
            naslovLbl.BringToFront();

            var dugmici = new[] { dugmeSacuvaj, dugmeReset, dugmeOdustani };
            foreach (var b in dugmici)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
            }

            dugmeSacuvaj.BackColor = Color.FromArgb(76, 175, 80);
            dugmeSacuvaj.ForeColor = Color.White;
            dugmeReset.BackColor = Color.FromArgb(255, 213, 79);
            dugmeReset.ForeColor = Color.Black;
            dugmeOdustani.BackColor = Color.FromArgb(229, 57, 53);
            dugmeOdustani.ForeColor = Color.White;

            dugmeSacuvaj.MouseEnter += (s, e) => dugmeSacuvaj.BackColor = Color.FromArgb(56, 142, 60);
            dugmeSacuvaj.MouseLeave += (s, e) => dugmeSacuvaj.BackColor = Color.FromArgb(76, 175, 80);
            dugmeReset.MouseEnter += (s, e) => dugmeReset.BackColor = Color.FromArgb(255, 241, 118);
            dugmeReset.MouseLeave += (s, e) => dugmeReset.BackColor = Color.FromArgb(255, 213, 79);
            dugmeOdustani.MouseEnter += (s, e) => dugmeOdustani.BackColor = Color.FromArgb(198, 40, 40);
            dugmeOdustani.MouseLeave += (s, e) => dugmeOdustani.BackColor = Color.FromArgb(229, 57, 53);
        }

        private async void PopuniPodacima()
        {
            izborStatus.DataSource = Enum.GetValues(typeof(StatusVozila));
            if (pocetno != null)
            {
                unosReg.Text = pocetno.Registarska_Oznaka;
                unosLokacija.Text = pocetno.Lokacija;
                unosProizvodjac.Text = pocetno.Proizvodjac;
                izborStatus.SelectedItem = pocetno.Status;
            }
        }

        private void buttonRst_Click(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void buttonCnc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Da li si siguran da želiš da zatvoriš formu?",
              "Potvrda",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private async void buttonSv_Click(object sender, EventArgs e)
        {
            var uKvaru = izborStatus.Text == "U_kvaru";

            var novo = new DTODodajSanitetsko
            {
                Status = uKvaru ? StatusVozila.U_kvaru : StatusVozila.Operativno,
                Registarska_Oznaka = unosReg.Text,
                Lokacija = unosLokacija.Text,
                Proizvodjac = unosProizvodjac.Text
            };

            var izmena = new DTOIzmeniSanitetsko
            {
                Status = uKvaru ? StatusVozila.U_kvaru : StatusVozila.Operativno,
                Lokacija = unosLokacija.Text,
                Proizvodjac = unosProizvodjac.Text
            };

            if (string.IsNullOrWhiteSpace(unosReg.Text) ||
                string.IsNullOrWhiteSpace(unosLokacija.Text) ||
                string.IsNullOrWhiteSpace(unosProizvodjac.Text))
            {
                MessageBox.Show("Popunite sva polja.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pocetno == null)
                await DTOManager.DodajSanitetskaVozilo(novo);
            else
                await DTOManager.IzmeniSanitetskoVozilo(izmena, pocetno.Registarska_Oznaka);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormaUpravljajSanitetskim_Load(object sender, EventArgs e)
        {
        }
    }
}