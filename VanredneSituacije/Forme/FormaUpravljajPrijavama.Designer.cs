using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajPrijavama
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
            tbIme = new TextBox();
            dtDatumVreme = new DateTimePicker();
            tbOpis = new TextBox();
            tbLokacija = new TextBox();
            tbTip = new TextBox();
            btnReset = new Button();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            lblDispecer = new Label();
            lblOpis = new Label();
            lblLokacija = new Label();
            lblKontakt = new Label();
            lblIme = new Label();
            lblDatum = new Label();
            lblTip = new Label();
            tbKontakt = new TextBox();
            tbDispecer = new TextBox();
            numPrioritet = new NumericUpDown();
            lblPrioritet = new Label();
            lblNaslov = new Label();
            pnlGlavni = new Panel();
            ((System.ComponentModel.ISupportInitialize)numPrioritet).BeginInit();
            pnlGlavni.SuspendLayout();
            SuspendLayout();

            tbIme.Font = new Font("Segoe UI", 10F);
            tbIme.Location = new Point(167, 173);
            tbIme.Size = new Size(180, 25);

            dtDatumVreme.Font = new Font("Segoe UI", 10F);
            dtDatumVreme.Location = new Point(167, 103);
            dtDatumVreme.Size = new Size(180, 25);

            tbOpis.Font = new Font("Segoe UI", 10F);
            tbOpis.Location = new Point(167, 217);
            tbOpis.Multiline = true;
            tbOpis.Size = new Size(180, 70);

            tbLokacija.Font = new Font("Segoe UI", 10F);
            tbLokacija.Location = new Point(482, 172);
            tbLokacija.Size = new Size(180, 25);

            tbTip.Font = new Font("Segoe UI", 10F);
            tbTip.Location = new Point(167, 138);
            tbTip.Size = new Size(180, 25);

            btnReset.BackColor = Color.FromArgb(255, 190, 80);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 10F);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(467, 257);
            btnReset.Size = new Size(90, 30);
            btnReset.Text = "🔄 Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;

            btnOdustani.BackColor = Color.FromArgb(220, 70, 70);
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI Semibold", 10F);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(567, 257);
            btnOdustani.Size = new Size(104, 30);
            btnOdustani.Text = "✖ Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;

            btnSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI Semibold", 10F);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(367, 257);
            btnSacuvaj.Size = new Size(90, 30);
            btnSacuvaj.Text = "💾 Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;

            lblDispecer.Font = new Font("Segoe UI", 10F);
            lblDispecer.Location = new Point(367, 104);
            lblDispecer.Size = new Size(100, 23);
            lblDispecer.Text = "JMBG Dispečera:";

            lblOpis.Font = new Font("Segoe UI", 10F);
            lblOpis.Location = new Point(61, 242);
            lblOpis.Size = new Size(100, 23);
            lblOpis.Text = "Opis:";

            lblLokacija.Font = new Font("Segoe UI", 10F);
            lblLokacija.Location = new Point(367, 174);
            lblLokacija.Size = new Size(100, 23);
            lblLokacija.Text = "Lokacija:";

            lblKontakt.Font = new Font("Segoe UI", 10F);
            lblKontakt.Location = new Point(367, 139);
            lblKontakt.Size = new Size(100, 23);
            lblKontakt.Text = "Kontakt:";

            lblIme.Font = new Font("Segoe UI", 10F);
            lblIme.Location = new Point(52, 175);
            lblIme.Size = new Size(100, 23);
            lblIme.Text = "Ime prijavioca:";

            lblDatum.Font = new Font("Segoe UI", 10F);
            lblDatum.Location = new Point(39, 105);
            lblDatum.Size = new Size(112, 23);
            lblDatum.Text = "Datum i vreme:";

            lblTip.Font = new Font("Segoe UI", 10F);
            lblTip.Location = new Point(52, 140);
            lblTip.Size = new Size(100, 23);
            lblTip.Text = "Tip:";

            tbKontakt.Font = new Font("Segoe UI", 10F);
            tbKontakt.Location = new Point(482, 137);
            tbKontakt.Size = new Size(180, 25);

            tbDispecer.Font = new Font("Segoe UI", 10F);
            tbDispecer.Location = new Point(482, 102);
            tbDispecer.MaxLength = 13;
            tbDispecer.Size = new Size(180, 25);

            numPrioritet.Font = new Font("Segoe UI", 10F);
            numPrioritet.Location = new Point(482, 203);
            numPrioritet.Size = new Size(180, 25);

            lblPrioritet.Font = new Font("Segoe UI", 10F);
            lblPrioritet.Location = new Point(367, 205);
            lblPrioritet.Size = new Size(100, 23);
            lblPrioritet.Text = "Prioritet:";

            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Semibold", 14F);
            lblNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            lblNaslov.Location = new Point(268, 28);
            lblNaslov.Size = new Size(225, 25);
            lblNaslov.Text = "📝 Upravljanje prijavama";

            pnlGlavni.BackColor = Color.FromArgb(245, 247, 250);
            pnlGlavni.Controls.Add(lblNaslov);
            pnlGlavni.Controls.Add(lblDatum);
            pnlGlavni.Controls.Add(dtDatumVreme);
            pnlGlavni.Controls.Add(lblTip);
            pnlGlavni.Controls.Add(tbTip);
            pnlGlavni.Controls.Add(lblIme);
            pnlGlavni.Controls.Add(tbIme);
            pnlGlavni.Controls.Add(lblKontakt);
            pnlGlavni.Controls.Add(tbKontakt);
            pnlGlavni.Controls.Add(lblLokacija);
            pnlGlavni.Controls.Add(tbLokacija);
            pnlGlavni.Controls.Add(lblOpis);
            pnlGlavni.Controls.Add(tbOpis);
            pnlGlavni.Controls.Add(lblDispecer);
            pnlGlavni.Controls.Add(tbDispecer);
            pnlGlavni.Controls.Add(lblPrioritet);
            pnlGlavni.Controls.Add(numPrioritet);
            pnlGlavni.Controls.Add(btnSacuvaj);
            pnlGlavni.Controls.Add(btnReset);
            pnlGlavni.Controls.Add(btnOdustani);
            pnlGlavni.Dock = DockStyle.Fill;
            pnlGlavni.Padding = new Padding(10);
            pnlGlavni.Size = new Size(728, 346);

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 346);
            Controls.Add(pnlGlavni);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje prijavama";
            Load += FormaUpravljajPrijavama_Load;

            ((System.ComponentModel.ISupportInitialize)numPrioritet).EndInit();
            pnlGlavni.ResumeLayout(false);
            pnlGlavni.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlGlavni;
        private Label lblNaslov;
        private TextBox tbIme;
        private DateTimePicker dtDatumVreme;
        private TextBox tbOpis;
        private TextBox tbLokacija;
        private TextBox tbTip;
        private Button btnReset;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private Label lblDispecer;
        private Label lblOpis;
        private Label lblLokacija;
        private Label lblKontakt;
        private Label lblIme;
        private Label lblDatum;
        private Label lblTip;
        private TextBox tbKontakt;
        private TextBox tbDispecer;
        private NumericUpDown numPrioritet;
        private Label lblPrioritet;
    }
}
