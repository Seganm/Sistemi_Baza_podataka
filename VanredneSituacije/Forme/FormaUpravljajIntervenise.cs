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
    public partial class FormaUpravljajIntervenise : Form
    {
        DTOVratiIntervenise ucestvuje;
        public FormaUpravljajIntervenise()
        {
            InitializeComponent();
        }

        public FormaUpravljajIntervenise(DTOVratiIntervenise ucestvuje)
        {
            InitializeComponent();
            this.ucestvuje = ucestvuje;
        }

        public async void PopuniPodacima()
        {
            var jedinice = await DTOManager.VratiSveJedinice();
            comboJedinica.DataSource = jedinice;

            comboJedinica.DisplayMember = "Naziv";
            comboJedinica.ValueMember = "Jedinstveni_Broj";


            var intervencije = await DTOManager.VratiIntervencije();
            comboIntervencija.DataSource = intervencije;
            comboIntervencija.DisplayMember = "Id";
            comboIntervencija.ValueMember = "Id";


            var vanredne = await DTOManager.VratiVanredneSituacije();
            comboVs.DataSource = vanredne;
            comboVs.DisplayMember = "Id";
            comboVs.ValueMember = "Id";
            if (ucestvuje != null)
            {
                comboVs.SelectedValue = ucestvuje.IdVanredneSituacije;
                comboJedinica.SelectedValue = ucestvuje.IdInterventnee;
                comboIntervencija.SelectedValue = ucestvuje.IdIntervencijee;
            }
        }

        private void comboJedinica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboIntervencija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboVs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var add = new DTODodajIntervenise();
            add.IdInterventnee = (int)comboJedinica.SelectedValue;
            add.IdIntervencijee = (int)comboIntervencija.SelectedValue;
            add.IdVanredneSituacije = (int)comboVs.SelectedValue;

            if (ucestvuje != null)
            {
                await DTOManager.InterveniseIzmenii(add, ucestvuje.Id);
            }
            else
            {
                await DTOManager.InterveniseDodajj(add);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopuniPodacima();
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
        }

        private void FormaUpravljajIntervenise_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
