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
    public partial class FormaUpravljajIntervencijama : Form
    {
        DTOIntervencija intervencijaa;

        public FormaUpravljajIntervencijama()
        {
            InitializeComponent();
        }


        public FormaUpravljajIntervencijama(DTOIntervencija intervencija)
        {
            InitializeComponent();
            this.intervencijaa = intervencija;
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            dateDatumVreme.Value = intervencijaa.DatumVremee;
            textLokacija.Text = intervencijaa.Lokacija;
            comboStatus.Text = intervencijaa.Status;
            textResursi.Text = intervencijaa.Resursi;
            numericSpaseni.Value = intervencijaa.BrSpasenih;
            numericPovredjeni.Value = intervencijaa.BrPovredjenih;
            numericUspesnost.Value = intervencijaa.Uspesnost;
        }

        private void FormaUpravljajIntervencijama_Load(object sender, EventArgs e)
        {
        }

        private void buttonRst_Click(object sender, EventArgs e)
        {
            dateDatumVreme.Value = DateTime.Now;
            textLokacija.Clear();
            comboStatus.SelectedIndex = -1;
            textResursi.Clear();
            numericSpaseni.Value = 0;
            numericPovredjeni.Value = 0;
            numericUspesnost.Value = 0;
        }

        private async void buttonSave_Click_1(object sender, EventArgs e)
        {
            DTOOsnovnaIntervencija intervencija = new DTOOsnovnaIntervencija();
            intervencija.DatumVremee = dateDatumVreme.Value;
            intervencija.Lokacija = textLokacija.Text; ;
            intervencija.Status = (Status)Enum.Parse(typeof(Status), comboStatus.Text);
            intervencija.Resursi = textResursi.Text;
            intervencija.BrSpasenih = (int)numericSpaseni.Value;
            intervencija.BrPovredjenih = (int)numericPovredjeni.Value;
            intervencija.Uspesnost = (int)numericUspesnost.Value;

            if (comboStatus.SelectedIndex == -1 || string.IsNullOrEmpty(textLokacija.Text) || string.IsNullOrEmpty(textResursi.Text))
            {
                MessageBox.Show("Popunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (intervencijaa == null)
            {
                await DTOManager.IntervencijaDodajj(intervencija);
                MessageBox.Show("Uspesno ste dodali Intervenciju!", "Uspeh", MessageBoxButtons.OK);
            }
            else
            {
                await DTOManager.IntervencijaIzmenii(intervencija, intervencijaa.Id);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
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
    }
}
