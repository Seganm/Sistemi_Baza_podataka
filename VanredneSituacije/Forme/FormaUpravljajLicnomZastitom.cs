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
using static System.Net.Mime.MediaTypeNames;

namespace VanredneSituacije.Forme
{
    public partial class FormaUpravljajLicnomZastitom : Form
    {
        DTODodajLicnuZastitu licna;
        public FormaUpravljajLicnomZastitom()
        {
            InitializeComponent();
            PopuniComboe();
        }

        public FormaUpravljajLicnomZastitom(DTODodajLicnuZastitu liz)
        {
            InitializeComponent();
            licna = liz;
            PopuniPodacima();
        }

        public async void PopuniPodacima()
        {
            await PopuniComboe();
            textSb.Text = licna.Serijski_Broj;
            textNaziv.Text = licna.Naziv;
            comboStatus.SelectedItem = licna.Status;
            comboJedinica.SelectedValue = licna.JedinicaID;
            dateNabavka.Value = licna.DatumNabavke;
            comboTip.SelectedItem = licna.Tip;
        }

        private async Task PopuniComboe()
        {

            var jedinice = await DTOManager.VratiOpstejedinice();
            comboJedinica.DataSource = jedinice;
            comboJedinica.DisplayMember = "Naziv";
            comboJedinica.ValueMember = "Jedinstveni_Broj";

            comboTip.DataSource = Enum.GetValues(typeof(TipLicneZastite));
            comboStatus.DataSource = Enum.GetValues(typeof(StatusOpreme));
            comboJedinica.SelectedIndex = -1;
            comboStatus.SelectedIndex = -1;
            comboTip.SelectedIndex = -1;
        }
        private async void FormaUpravljajLicnomZastitom_Load(object sender, EventArgs e)
        {
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            DTODodajLicnuZastitu l = new DTODodajLicnuZastitu();
            l.Serijski_Broj = textSb.Text;
            l.Naziv = textNaziv.Text;
            l.Status = (StatusOpreme)comboStatus.SelectedValue;
            l.DatumNabavke = dateNabavka.Value;
            l.Tip = (TipLicneZastite)comboTip.SelectedValue;
            l.JedinicaID = (int)comboJedinica.SelectedValue;

            if (string.IsNullOrEmpty(textSb.Text) || string.IsNullOrEmpty(textNaziv.Text) ||
                  comboTip.SelectedIndex == -1 || comboJedinica.SelectedIndex == -1 || comboStatus.SelectedIndex == -1
                )
            {
                MessageBox.Show("Popunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (licna == null)
            {
                await DTOManager.DodajLicnuZastitu(l);
            }
            else
            {
                await DTOManager.IzmeniLicnuZastitu(l, licna.Serijski_Broj);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
