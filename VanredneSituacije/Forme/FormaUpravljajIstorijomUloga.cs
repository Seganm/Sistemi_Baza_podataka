﻿using System;
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
        public FormaUpravljajIstorijomUloga(string jmbgZaposlenog)
        {
            InitializeComponent();
            textJmbg.Text = jmbgZaposlenog;
            textJmbg.ReadOnly = true;
            textJmbg.BackColor = Color.LightGray;
        }
        public void PopuniPodacima()
        {
            textJmbg.Text = istorija.JMBGZaposlenog;
            comboBox1.Text = istorija.Uloga;
            dateDatumOf.Value = istorija.Datum_Od;
            if (istorija.Datum_Do == null)
            {
                dateDatumDo.Value = DateTime.Now;
            }
            else
            {
                dateDatumDo.Value = (DateTime)istorija.Datum_Do;
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
            DTODodajIstorijuUloga istorijaa = new DTODodajIstorijuUloga();
            istorijaa.JMBGZaposlenog = textJmbg.Text;
            istorijaa.Uloga = comboBox1.SelectedItem.ToString();

            if (dateDatumOf.Value == DateTime.MinValue || dateDatumOf.Value == DateTime.MinValue)
            {
                dateDatumOf.Value = DateTime.Now;
                dateDatumDo.Value = DateTime.Now;
            }

            istorijaa.Datum_Od = dateDatumOf.Value;
            istorijaa.Datum_Do = dateDatumDo.Value;

            if (string.IsNullOrEmpty(textJmbg.Text) || comboBox1.SelectedIndex == -1 || (!dateDatumOf.Checked))
            {
                MessageBox.Show("Popunite sva polja.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (istorija != null)
            {
                await DTOManager.IzmeniIstorijuUloga(istorijaa, istorija.Id);
            }
            else
            {
                await DTOManager.DodajIstorijuUloga(istorijaa);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormaUpravljajIstorijomUloga_Load(object sender, EventArgs e)
        {

        }
    }
}
