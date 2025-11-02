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

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajEvidencijomServisa : Form
    {
        public readonly string RegistarskaOznaka;
        public DTOEvidencijaServis servis;

        public FormaUpravljajEvidencijomServisa(string RegistarskaOznaka)
        {
            InitializeComponent();
            this.RegistarskaOznaka = RegistarskaOznaka;
            txtVozilo.Text = RegistarskaOznaka;
            txtVozilo.ReadOnly = true;
            txtVozilo.BackColor = Color.LightGray;
        }

        public FormaUpravljajEvidencijomServisa(DTOEvidencijaServis servis)
        {
            this.servis = servis;
            InitializeComponent();
            PopuniZaIzmenu();
            txtVozilo.ReadOnly = true;
            txtVozilo.BackColor = Color.LightGray;
        }

        public void PopuniZaIzmenu()
        {
            txtVozilo.Text = servis.RegistarskaOznakaVozila;
            txtTip.Text = servis.TipServisa;
            dateDatum.Value = servis.Datum;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            DTODodajEvidencijuServis servisi = new DTODodajEvidencijuServis();
            servisi.RegistarskaOznakaVozila = txtVozilo.Text;
            servisi.TipServisa = txtTip.Text;
            servisi.Datum = dateDatum.Value;
            if (string.IsNullOrEmpty(txtTip.Text))
            {
                MessageBox.Show("Niste uneli validnu vrednost za TipServisa");
                return;
            }
            if (servis == null)
            {
                await DTOManager.EvidencijaServisDodajj(servisi);
                MessageBox.Show("Uspesno ste dodali servis");
            }
            else
            {
                await DTOManager.ServisIzmenii(servisi, servis.Id);
                MessageBox.Show("Uspesno ste izmenili servis");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTip.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Da li si siguran da želiš da zatvoriš formu?",
        "Potvrda",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
            }
            else
            {

            }
        }

        private void FormaUpravljajEvidencijomServisa_Load(object sender, EventArgs e)
        {

        }
    }
}
