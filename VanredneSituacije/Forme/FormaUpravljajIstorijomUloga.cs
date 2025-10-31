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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajIstorijomUloga : Form
    {
        public DTOIstorijaUloga istorija;

        public FormaUpravljajIstorijomUloga()
        {
            InitializeComponent();
        }

        public FormaUpravljajIstorijomUloga(DTOIstorijaUloga istorija)
        {
            InitializeComponent();
            this.istorija = istorija;
            PopuniPodacima();
            textJmbg.ReadOnly = true;
            textJmbg.BackColor = Color.LightGray;
        }
        public FormaUpravljajIstorijomUloga(string JMBGZap)
        {
            InitializeComponent();
            textJmbg.Text = JMBGZap;
            textJmbg.ReadOnly = true;
            textJmbg.BackColor = Color.LightGray;
        }
        public void PopuniPodacima()
        {
            textJmbg.Text = istorija.JMBGZap;
            comboBox1.Text = istorija.Uloga;
            dateDatumOf.Value = istorija.DatumPoc;
            if (istorija.DatumKraj == null)
            {
                dateDatumDo.Value = DateTime.Now;
            }
            else
            {
                dateDatumDo.Value = (DateTime)istorija.DatumKraj;
            }
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dateDatumOf.Value = DateTime.Now;
            dateDatumDo.Value = DateTime.Now;
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            DTOIstorijaDodajj istorijaa = new DTOIstorijaDodajj();
            istorijaa.JMBGZap = textJmbg.Text;
            istorijaa.Uloga = comboBox1.SelectedItem.ToString();

            if (dateDatumOf.Value == DateTime.MinValue || dateDatumOf.Value == DateTime.MinValue)
            {
                dateDatumOf.Value = DateTime.Now;
                dateDatumDo.Value = DateTime.Now;
            }

            istorijaa.DatumPoc = dateDatumOf.Value;
            istorijaa.DatumKraj = dateDatumDo.Value;

            if (string.IsNullOrEmpty(textJmbg.Text) || comboBox1.SelectedIndex == -1 || (!dateDatumOf.Checked))
            {
                MessageBox.Show("Popunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (istorija != null)
            {
                await DTOManager.IstorijaIzmenii(istorijaa, istorija.Id);
            }
            else
            {
                await DTOManager.IstorijaDodajj(istorijaa);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormaUpravljajIstorijomUloga_Load(object sender, EventArgs e)
        {

        }
    }
}
