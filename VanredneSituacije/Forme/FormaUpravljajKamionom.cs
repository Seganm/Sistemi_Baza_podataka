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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajKamionom : Form
    {
        private readonly string Reg_oznaka;
        public FormaUpravljajKamionom()
        {
            InitializeComponent();
            PopuniPodacima();
        }

        public FormaUpravljajKamionom(string Reg_oznaka)
        {
            InitializeComponent();
            this.Reg_oznaka = Reg_oznaka;
            PopuniPodacima();
            textReg.Enabled = false;
            textReg.BackColor = Color.LightGray;
        }

        public async void PopuniPodacima()
        {
            comboStatus.DataSource = Enum.GetValues(typeof(StatusVozila));
            if (Reg_oznaka != null)
            {
                var kamion = await DTOManager.KamionVratii(Reg_oznaka);
                textReg.Text = kamion.Registracijaa;
                textPro.Text = kamion.Proizvodjac;

                comboStatus.SelectedItem = kamion.Status;
                textLok.Text = kamion.Lokacija;
            }

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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textLok.Clear();
            textPro.Clear();
            comboStatus.SelectedIndex = -1;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            DTOKamionDodajj ka = new DTOKamionDodajj();
            ka.Registracijaa = textReg.Text;
            ka.Proizvodjac = textPro.Text;
            ka.Lokacija = textLok.Text;

            if (string.IsNullOrEmpty(textReg.Text) || string.IsNullOrEmpty(textPro.Text) || string.IsNullOrEmpty(textLok.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboStatus.SelectedItem is StatusVozila statusEnum)
            {
                ka.Status = statusEnum;
            }

            if (Reg_oznaka == null)
            {
                await DTOManager.KamionDodajj(ka);
            }
            else
            {
                await DTOManager.KamionIzmenii(ka, Reg_oznaka);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormaUpravljajKamionom_Load(object sender, EventArgs e)
        {

        }
    }
}
