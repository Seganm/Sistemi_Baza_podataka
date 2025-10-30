using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajPredstavnikomSluzbe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtJmbg = new TextBox();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtPozicija = new TextBox();
            txtKontakt = new TextBox();
            txtEmail = new TextBox();

            lblJmbg = new Label();
            lblIme = new Label();
            lblPrezime = new Label();
            lblPozicija = new Label();
            lblKontakt = new Label();
            lblEmail = new Label();

            lblNaslov = new Label();

            btnSacuvaj = new Button();
            btnReset = new Button();
            btnOdustani = new Button();

            SuspendLayout();

            txtJmbg.Location = new Point(140, 60);
            txtJmbg.MaxLength = 13;
            txtJmbg.Size = new Size(170, 25);

            txtIme.Location = new Point(140, 90);
            txtIme.Size = new Size(170, 25);

            txtPrezime.Location = new Point(140, 120);
            txtPrezime.Size = new Size(170, 25);

            txtPozicija.Location = new Point(427, 59);
            txtPozicija.Size = new Size(170, 25);

            txtKontakt.Location = new Point(427, 89);
            txtKontakt.Size = new Size(170, 25);

            txtEmail.Location = new Point(427, 119);
            txtEmail.Size = new Size(170, 25);

            lblJmbg.AutoSize = true;
            lblJmbg.Location = new Point(40, 65);
            lblJmbg.Size = new Size(48, 19);
            lblJmbg.Text = "JMBG:";

            lblIme.AutoSize = true;
            lblIme.Location = new Point(40, 95);
            lblIme.Size = new Size(35, 19);
            lblIme.Text = "Ime:";

            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(40, 125);
            lblPrezime.Size = new Size(60, 19);
            lblPrezime.Text = "Prezime:";

            lblPozicija.AutoSize = true;
            lblPozicija.Location = new Point(327, 64);
            lblPozicija.Size = new Size(55, 19);
            lblPozicija.Text = "Pozicija:";

            lblKontakt.AutoSize = true;
            lblKontakt.Location = new Point(327, 94);
            lblKontakt.Size = new Size(60, 19);
            lblKontakt.Text = "Kontakt:";

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(327, 124);
            lblEmail.Size = new Size(44, 19);
            lblEmail.Text = "Email:";

            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(41, 128, 185);
            lblNaslov.Location = new Point(193, 9);
            lblNaslov.Size = new Size(303, 28);
            lblNaslov.Text = "Podaci o predstavniku službe";

            btnSacuvaj.BackColor = Color.FromArgb(46, 204, 113);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(190, 191);
            btnSacuvaj.Size = new Size(90, 35);
            btnSacuvaj.Text = "💾 Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;

            btnReset.BackColor = Color.FromArgb(241, 196, 15);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(290, 191);
            btnReset.Size = new Size(90, 35);
            btnReset.Text = "🔄 Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;

            btnOdustani.BackColor = Color.FromArgb(231, 76, 60);
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(390, 191);
            btnOdustani.Size = new Size(90, 35);
            btnOdustani.Text = "❌ Otkaži";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;

            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(662, 273);
            Controls.Add(lblNaslov);
            Controls.Add(lblJmbg);
            Controls.Add(txtJmbg);
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(lblPrezime);
            Controls.Add(txtPrezime);
            Controls.Add(lblPozicija);
            Controls.Add(txtPozicija);
            Controls.Add(lblKontakt);
            Controls.Add(txtKontakt);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnReset);
            Controls.Add(btnOdustani);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(44, 62, 80);
            Name = "FormaUpravljajPredstavnikomSluzbe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje predstavnikom službe";
            Load += FormaUpravljajPredstavnikomSluzbe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtJmbg;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtPozicija;
        private TextBox txtKontakt;
        private TextBox txtEmail;

        private Label lblJmbg;
        private Label lblIme;
        private Label lblPrezime;
        private Label lblPozicija;
        private Label lblKontakt;
        private Label lblEmail;
        private Label lblNaslov;

        private Button btnSacuvaj;
        private Button btnReset;
        private Button btnOdustani;
    }
}