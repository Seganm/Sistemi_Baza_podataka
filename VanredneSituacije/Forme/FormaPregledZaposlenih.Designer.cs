using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledZaposlenih
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            izborTipaZaposlenog = new ComboBox();
            dugmeDodajZaposlenog = new Button();
            dugmeIzmeniZaposlenog = new Button();
            dugmeObrisiZaposlenog = new Button();
            tabelaZaposleni = new DataGridView();
            jmbgKolona = new DataGridViewTextBoxColumn();
            imeKolona = new DataGridViewTextBoxColumn();
            prezimeKolona = new DataGridViewTextBoxColumn();
            datumRodjenjaKolona = new DataGridViewTextBoxColumn();
            polKolona = new DataGridViewTextBoxColumn();
            kontaktKolona = new DataGridViewTextBoxColumn();
            emailKolona = new DataGridViewTextBoxColumn();
            adresaKolona = new DataGridViewTextBoxColumn();
            datumZaposlenjaKolona = new DataGridViewTextBoxColumn();
            zaposleniBindingSource = new BindingSource(components);
            dugmeIstorijaUloga = new Button();
            dugmeSertifikati = new Button();
            dugmeDodelaVozila = new Button();
            dugmeSoftver = new Button();
            dugmeEkspertize = new Button();
            dugmeSpecijalizacije = new Button();

            ((System.ComponentModel.ISupportInitialize)tabelaZaposleni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zaposleniBindingSource).BeginInit();
            SuspendLayout();

        
            izborTipaZaposlenog.FormattingEnabled = true;
            izborTipaZaposlenog.Items.AddRange(new object[]
            {
                "Svi zaposleni",
                "Operativni radnici",
                "Koordinatori",
                "Analitičari"
            });
            izborTipaZaposlenog.Location = new Point(12, 18);
            izborTipaZaposlenog.Name = "izborTipaZaposlenog";
            izborTipaZaposlenog.Size = new Size(150, 28);
            izborTipaZaposlenog.TabIndex = 0;
            izborTipaZaposlenog.SelectedIndexChanged += izborTipaZaposlenog_SelectedIndexChanged;

        
            dugmeDodajZaposlenog.Location = new Point(300, 12);
            dugmeDodajZaposlenog.Name = "dugmeDodajZaposlenog";
            dugmeDodajZaposlenog.Size = new Size(130, 32);
            dugmeDodajZaposlenog.Text = "Dodaj";
            dugmeDodajZaposlenog.FlatStyle = FlatStyle.Flat;
            dugmeDodajZaposlenog.FlatAppearance.BorderSize = 0;
            dugmeDodajZaposlenog.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodajZaposlenog.ForeColor = Color.White;
            dugmeDodajZaposlenog.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodajZaposlenog.UseVisualStyleBackColor = false;
            dugmeDodajZaposlenog.Click += dugmeDodajZaposlenog_Click;

            dugmeIzmeniZaposlenog.Location = new Point(440, 12);
            dugmeIzmeniZaposlenog.Name = "dugmeIzmeniZaposlenog";
            dugmeIzmeniZaposlenog.Size = new Size(130, 32);
            dugmeIzmeniZaposlenog.Text = "Izmeni";
            dugmeIzmeniZaposlenog.FlatStyle = FlatStyle.Flat;
            dugmeIzmeniZaposlenog.FlatAppearance.BorderSize = 0;
            dugmeIzmeniZaposlenog.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeniZaposlenog.ForeColor = Color.Black;
            dugmeIzmeniZaposlenog.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeniZaposlenog.UseVisualStyleBackColor = false;
            dugmeIzmeniZaposlenog.Click += dugmeIzmeniZaposlenog_Click;

            dugmeObrisiZaposlenog.Location = new Point(580, 12);
            dugmeObrisiZaposlenog.Name = "dugmeObrisiZaposlenog";
            dugmeObrisiZaposlenog.Size = new Size(130, 32);
            dugmeObrisiZaposlenog.Text = "Obriši";
            dugmeObrisiZaposlenog.FlatStyle = FlatStyle.Flat;
            dugmeObrisiZaposlenog.FlatAppearance.BorderSize = 0;
            dugmeObrisiZaposlenog.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisiZaposlenog.ForeColor = Color.White;
            dugmeObrisiZaposlenog.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisiZaposlenog.UseVisualStyleBackColor = false;
            dugmeObrisiZaposlenog.Click += dugmeObrisiZaposlenog_Click;

            dugmeSoftver.Location = new Point(720, 12);
            dugmeSoftver.Size = new Size(130, 32);
            dugmeSoftver.Text = "Softver";
            dugmeSoftver.BackColor = Color.FromArgb(0, 122, 204);
            dugmeSoftver.FlatStyle = FlatStyle.Flat;
            dugmeSoftver.FlatAppearance.BorderSize = 0;
            dugmeSoftver.ForeColor = Color.White;
            dugmeSoftver.Font = new Font("Segoe UI Semibold", 9F);
            dugmeSoftver.Visible = false;
            dugmeSoftver.Click += dugmeSoftver_Click;

            dugmeEkspertize.Location = new Point(860, 12);
            dugmeEkspertize.Size = new Size(130, 32);
            dugmeEkspertize.Text = "Ekspertize";
            dugmeEkspertize.BackColor = Color.FromArgb(0, 122, 204);
            dugmeEkspertize.FlatStyle = FlatStyle.Flat;
            dugmeEkspertize.FlatAppearance.BorderSize = 0;
            dugmeEkspertize.ForeColor = Color.White;
            dugmeEkspertize.Font = new Font("Segoe UI Semibold", 9F);
            dugmeEkspertize.Visible = false;
            dugmeEkspertize.Click += dugmeEkspertize_Click;

            dugmeSertifikati.Location = new Point(860, 12);
            dugmeSertifikati.Size = new Size(130, 32);
            dugmeSertifikati.Text = "Sertifikati";
            dugmeSertifikati.BackColor = Color.FromArgb(0, 122, 204);
            dugmeSertifikati.FlatStyle = FlatStyle.Flat;
            dugmeSertifikati.FlatAppearance.BorderSize = 0;
            dugmeSertifikati.ForeColor = Color.White;
            dugmeSertifikati.Font = new Font("Segoe UI Semibold", 9F);
            dugmeSertifikati.Visible = false;
            dugmeSertifikati.Click += dugmeSertifikati_Click;

            dugmeSpecijalizacije.Location = new Point(860, 12);
            dugmeSpecijalizacije.Size = new Size(130, 32);
            dugmeSpecijalizacije.Text = "Specijalizacije";
            dugmeSpecijalizacije.BackColor = Color.FromArgb(0, 122, 204);
            dugmeSpecijalizacije.FlatStyle = FlatStyle.Flat;
            dugmeSpecijalizacije.FlatAppearance.BorderSize = 0;
            dugmeSpecijalizacije.ForeColor = Color.White;
            dugmeSpecijalizacije.Font = new Font("Segoe UI Semibold", 9F);
            dugmeSpecijalizacije.Visible = false;
            dugmeSpecijalizacije.Click += dugmeSpecijalizacije_Click;

            dugmeDodelaVozila.Location = new Point(1000, 12);
            dugmeDodelaVozila.Size = new Size(130, 32);
            dugmeDodelaVozila.Text = "Vozila";
            dugmeDodelaVozila.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodelaVozila.FlatStyle = FlatStyle.Flat;
            dugmeDodelaVozila.FlatAppearance.BorderSize = 0;
            dugmeDodelaVozila.ForeColor = Color.White;
            dugmeDodelaVozila.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodelaVozila.Click += dugmeDodelaVozila_Click;

            dugmeIstorijaUloga.Location = new Point(1140, 12);
            dugmeIstorijaUloga.Size = new Size(130, 32);
            dugmeIstorijaUloga.Text = "Istorija uloga";
            dugmeIstorijaUloga.BackColor = Color.FromArgb(90, 90, 90);
            dugmeIstorijaUloga.FlatStyle = FlatStyle.Flat;
            dugmeIstorijaUloga.FlatAppearance.BorderSize = 0;
            dugmeIstorijaUloga.ForeColor = Color.White;
            dugmeIstorijaUloga.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIstorijaUloga.Click += dugmeIstorijaUloga_Click;

       
            tabelaZaposleni.AutoGenerateColumns = false;
            tabelaZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaZaposleni.BackgroundColor = Color.White;
            tabelaZaposleni.BorderStyle = BorderStyle.None;
            tabelaZaposleni.EnableHeadersVisualStyles = false;
            tabelaZaposleni.GridColor = Color.FromArgb(225, 225, 225);
            tabelaZaposleni.Location = new Point(12, 60);
            tabelaZaposleni.Name = "tabelaZaposleni";
            tabelaZaposleni.RowHeadersVisible = false;
            tabelaZaposleni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaZaposleni.Size = new Size(1260, 650);
            tabelaZaposleni.DataSource = zaposleniBindingSource;

            tabelaZaposleni.Columns.AddRange(new DataGridViewColumn[]
            {
                jmbgKolona, imeKolona, prezimeKolona, datumRodjenjaKolona,
                polKolona, kontaktKolona, emailKolona, adresaKolona, datumZaposlenjaKolona
            });

 
            jmbgKolona.DataPropertyName = "JMBG";
            jmbgKolona.HeaderText = "JMBG";

            imeKolona.DataPropertyName = "Ime";
            imeKolona.HeaderText = "Ime";

            prezimeKolona.DataPropertyName = "Prezime";
            prezimeKolona.HeaderText = "Prezime";

            datumRodjenjaKolona.DataPropertyName = "DatumRodj";
            datumRodjenjaKolona.HeaderText = "Datum rođenja";

            polKolona.DataPropertyName = "Pol";
            polKolona.HeaderText = "Pol";

            kontaktKolona.DataPropertyName = "BrojTelefona";
            kontaktKolona.HeaderText = "Telefon";

            emailKolona.DataPropertyName = "Email";
            emailKolona.HeaderText = "Email";

            adresaKolona.DataPropertyName = "AdresaStan";
            adresaKolona.HeaderText = "Adresa";

            datumZaposlenjaKolona.DataPropertyName = "DatumZap";
            datumZaposlenjaKolona.HeaderText = "Datum zaposlenja";
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1284, 740);
            Controls.Add(dugmeSpecijalizacije);
            Controls.Add(dugmeEkspertize);
            Controls.Add(dugmeSoftver);
            Controls.Add(dugmeDodelaVozila);
            Controls.Add(dugmeSertifikati);
            Controls.Add(dugmeIstorijaUloga);
            Controls.Add(tabelaZaposleni);
            Controls.Add(dugmeObrisiZaposlenog);
            Controls.Add(dugmeIzmeniZaposlenog);
            Controls.Add(dugmeDodajZaposlenog);
            Controls.Add(izborTipaZaposlenog);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledZaposlenih";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled zaposlenih";
            WindowState = FormWindowState.Maximized;
            Load += FormaPregledZaposlenih_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaZaposleni).EndInit();
            ((System.ComponentModel.ISupportInitialize)zaposleniBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox izborTipaZaposlenog;
        private DataGridView tabelaZaposleni;
        private Button dugmeDodajZaposlenog;
        private Button dugmeIzmeniZaposlenog;
        private Button dugmeObrisiZaposlenog;
        private Button dugmeSoftver;
        private Button dugmeEkspertize;
        private Button dugmeSertifikati;
        private Button dugmeSpecijalizacije;
        private Button dugmeDodelaVozila;
        private Button dugmeIstorijaUloga;
        private BindingSource zaposleniBindingSource;
        private DataGridViewTextBoxColumn jmbgKolona;
        private DataGridViewTextBoxColumn imeKolona;
        private DataGridViewTextBoxColumn prezimeKolona;
        private DataGridViewTextBoxColumn datumRodjenjaKolona;
        private DataGridViewTextBoxColumn polKolona;
        private DataGridViewTextBoxColumn kontaktKolona;
        private DataGridViewTextBoxColumn emailKolona;
        private DataGridViewTextBoxColumn adresaKolona;
        private DataGridViewTextBoxColumn datumZaposlenjaKolona;
    }
}
