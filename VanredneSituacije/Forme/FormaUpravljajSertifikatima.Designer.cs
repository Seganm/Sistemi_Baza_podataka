﻿namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSertifikatima
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
            dtpDatumIzdavanja = new DateTimePicker();
            dtpDatumVazenja = new DateTimePicker();
            txtNazivSertifikata = new TextBox();
            txtInstitucijaSertifikata = new TextBox();
            txtJmbgRadnika = new TextBox();
            btnSacuvajSertifikat = new Button();
            btnPonistiUnos = new Button();
            btnZatvoriFormu = new Button();
            lblNazivSertifikata = new Label();
            lblInstitucijaSertifikata = new Label();
            lblJmbgRadnika = new Label();
            lblDatumIzdavanja = new Label();
            lblDatumVazenja = new Label();
            lblNaslovForme = new Label();
            SuspendLayout();

            dtpDatumIzdavanja.Font = new Font("Segoe UI", 9.75F);
            dtpDatumIzdavanja.Location = new Point(205, 142);
            dtpDatumIzdavanja.Size = new Size(148, 25);

            dtpDatumVazenja.Font = new Font("Segoe UI", 9.75F);
            dtpDatumVazenja.Location = new Point(206, 173);
            dtpDatumVazenja.Size = new Size(148, 25);

            txtNazivSertifikata.Font = new Font("Segoe UI", 9.75F);
            txtNazivSertifikata.Location = new Point(206, 87);
            txtNazivSertifikata.Size = new Size(147, 25);

            txtInstitucijaSertifikata.Font = new Font("Segoe UI", 9.75F);
            txtInstitucijaSertifikata.Location = new Point(206, 115);
            txtInstitucijaSertifikata.Size = new Size(147, 25);

            txtJmbgRadnika.Font = new Font("Segoe UI", 9.75F);
            txtJmbgRadnika.Location = new Point(206, 59);
            txtJmbgRadnika.Size = new Size(147, 25);

            btnSacuvajSertifikat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSacuvajSertifikat.Location = new Point(84, 206);
            btnSacuvajSertifikat.Size = new Size(82, 30);
            btnSacuvajSertifikat.Text = "💾 Sačuvaj";
            btnSacuvajSertifikat.Click += btnSacuvajSertifikat_Click;

            btnPonistiUnos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPonistiUnos.Location = new Point(181, 208);
            btnPonistiUnos.Size = new Size(90, 28);
            btnPonistiUnos.Text = "🔄 Poništi";
            btnPonistiUnos.Click += btnPonistiUnos_Click;

            btnZatvoriFormu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnZatvoriFormu.Location = new Point(277, 206);
            btnZatvoriFormu.Size = new Size(84, 30);
            btnZatvoriFormu.Text = "❌ Zatvori";
            btnZatvoriFormu.Click += btnZatvoriFormu_Click;

            lblJmbgRadnika.AutoSize = true;
            lblJmbgRadnika.Location = new Point(101, 64);
            lblJmbgRadnika.Text = "JMBG radnika:";

            lblNazivSertifikata.AutoSize = true;
            lblNazivSertifikata.Location = new Point(101, 92);
            lblNazivSertifikata.Text = "Naziv sertifikata:";

            lblInstitucijaSertifikata.AutoSize = true;
            lblInstitucijaSertifikata.Location = new Point(101, 121);
            lblInstitucijaSertifikata.Text = "Institucija:";

            lblDatumIzdavanja.AutoSize = true;
            lblDatumIzdavanja.Location = new Point(101, 145);
            lblDatumIzdavanja.Text = "Datum izdavanja:";

            lblDatumVazenja.AutoSize = true;
            lblDatumVazenja.Location = new Point(100, 170);
            lblDatumVazenja.Text = "Datum važenja:";

            lblNaslovForme.BackColor = Color.FromArgb(224, 224, 224);
            lblNaslovForme.Dock = DockStyle.Top;
            lblNaslovForme.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNaslovForme.ForeColor = Color.FromArgb(33, 33, 33);
            lblNaslovForme.Size = new Size(466, 35);
            lblNaslovForme.Text = "UPRAVLJANJE SERTIFIKATIMA";
            lblNaslovForme.TextAlign = ContentAlignment.MiddleCenter;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(466, 292);
            Controls.AddRange(new Control[]
            {
                lblNaslovForme, dtpDatumVazenja, lblDatumVazenja, txtInstitucijaSertifikata,
                dtpDatumIzdavanja, lblDatumIzdavanja, txtNazivSertifikata, txtJmbgRadnika,
                btnPonistiUnos, btnZatvoriFormu, btnSacuvajSertifikat,
                lblInstitucijaSertifikata, lblNazivSertifikata, lblJmbgRadnika
            });
            Name = "FormaUpravljajSertifikatima";
            Text = "Upravljanje sertifikatima";
            Load += FormaUpravljajSertifikatima_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private DateTimePicker dtpDatumIzdavanja, dtpDatumVazenja;
        private TextBox txtNazivSertifikata, txtInstitucijaSertifikata, txtJmbgRadnika;
        private Button btnSacuvajSertifikat, btnPonistiUnos, btnZatvoriFormu;
        private Label lblNaslovForme, lblJmbgRadnika, lblNazivSertifikata, lblInstitucijaSertifikata, lblDatumIzdavanja, lblDatumVazenja;
    }
}
