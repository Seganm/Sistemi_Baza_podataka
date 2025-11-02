using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajOperativnim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtpZaposlenje = new DateTimePicker();
            txtAdresa = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            dtpRodjenje = new DateTimePicker();
            chkZensko = new CheckBox();
            chkMusko = new CheckBox();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            txtJmbg = new TextBox();
            btnReset = new Button();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            lblDatumZaposlenja = new Label();
            lblAdresa = new Label();
            lblEmail = new Label();
            lblTelefon = new Label();
            lblPol = new Label();
            lblRodjenje = new Label();
            lblJmbg = new Label();
            lblIme = new Label();
            lblPrezime = new Label();
            lblJedinica = new Label();
            cmbJedinica = new ComboBox();
            lblSati = new Label();
            lblSpremnost = new Label();
            numSati = new NumericUpDown();
            cmbSpremnost = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numSati).BeginInit();
            SuspendLayout();

            dtpZaposlenje.Location = new Point(437, 113);
            dtpZaposlenje.Size = new Size(147, 23);

            txtAdresa.Location = new Point(437, 85);
            txtAdresa.Size = new Size(147, 23);

            txtEmail.Location = new Point(437, 56);
            txtEmail.Size = new Size(147, 23);

            txtTelefon.Location = new Point(437, 22);
            txtTelefon.Size = new Size(147, 23);

            dtpRodjenje.Location = new Point(140, 112);
            dtpRodjenje.Size = new Size(147, 23);

            chkZensko.Location = new Point(250, 143);
            chkZensko.Text = "Z";

            chkMusko.Location = new Point(140, 141);
            chkMusko.Text = "M";

            txtPrezime.Location = new Point(140, 82);
            txtPrezime.Size = new Size(147, 23);

            txtIme.Location = new Point(140, 50);
            txtIme.Size = new Size(147, 23);

            txtJmbg.Location = new Point(140, 20);
            txtJmbg.MaxLength = 13;
            txtJmbg.Size = new Size(147, 23);

            btnReset.BackColor = Color.FromArgb(255, 190, 80);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(265, 239);
            btnReset.Size = new Size(90, 28);
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;

            btnOdustani.BackColor = Color.FromArgb(220, 70, 70);
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(390, 239);
            btnOdustani.Size = new Size(82, 28);
            btnOdustani.Text = "Odustani";
            btnOdustani.Click += btnOdustani_Click;

            btnSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(149, 239);
            btnSacuvaj.Size = new Size(82, 28);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.Click += btnSacuvaj_Click;

            lblDatumZaposlenja.Location = new Point(319, 113);
            lblDatumZaposlenja.Text = "Datum zaposlenja";

            lblAdresa.Location = new Point(333, 85);
            lblAdresa.Text = "Adresa";

            lblEmail.Location = new Point(333, 56);
            lblEmail.Text = "Email";

            lblTelefon.Location = new Point(333, 25);
            lblTelefon.Text = "Kontakt";

            lblPol.Location = new Point(36, 143);
            lblPol.Text = "Pol";

            lblRodjenje.Location = new Point(36, 112);
            lblRodjenje.Text = "Datum rođenja";

            lblJmbg.Location = new Point(36, 25);
            lblJmbg.Text = "JMBG";

            lblIme.Location = new Point(36, 53);
            lblIme.Text = "Ime";

            lblPrezime.Location = new Point(36, 84);
            lblPrezime.Text = "Prezime";

            lblJedinica.Location = new Point(307, 141);
            lblJedinica.Text = "Interventna jedinica";

            cmbJedinica.Location = new Point(437, 142);
            cmbJedinica.Size = new Size(147, 23);

            lblSati.Location = new Point(36, 175);
            lblSati.Text = "Broj sati";

            lblSpremnost.Location = new Point(307, 175);
            lblSpremnost.Text = "Fizička spremnost";

            numSati.Location = new Point(140, 173);
            numSati.Size = new Size(146, 23);

            cmbSpremnost.Location = new Point(437, 175);
            cmbSpremnost.Size = new Size(147, 23);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(643, 296);
            Controls.AddRange(new Control[]
            {
                cmbSpremnost, numSati, lblSpremnost, lblSati, cmbJedinica, lblJedinica,
                dtpZaposlenje, txtAdresa, txtEmail, txtTelefon, dtpRodjenje, chkZensko, chkMusko,
                txtPrezime, txtIme, txtJmbg, btnReset, btnOdustani, btnSacuvaj,
                lblDatumZaposlenja, lblAdresa, lblEmail, lblTelefon, lblPol,
                lblRodjenje, lblJmbg, lblIme, lblPrezime
            });

            Font = new Font("Segoe UI", 9F);
            Name = "FormaUpravljajOperativnim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje operativnim osobljem";
            Load += FormaUpravljajOperativnim_Load;
            ((System.ComponentModel.ISupportInitialize)numSati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DateTimePicker dtpZaposlenje;
        private TextBox txtAdresa;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private DateTimePicker dtpRodjenje;
        private CheckBox chkZensko;
        private CheckBox chkMusko;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private TextBox txtJmbg;
        private Button btnReset;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private Label lblDatumZaposlenja;
        private Label lblAdresa;
        private Label lblEmail;
        private Label lblTelefon;
        private Label lblPol;
        private Label lblRodjenje;
        private Label lblJmbg;
        private Label lblIme;
        private Label lblPrezime;
        private Label lblJedinica;
        private ComboBox cmbJedinica;
        private Label lblSati;
        private Label lblSpremnost;
        private NumericUpDown numSati;
        private ComboBox cmbSpremnost;
    }
}