using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledPredstavnikaSluzbe
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle stilZaglavlje = new DataGridViewCellStyle();
            DataGridViewCellStyle stilAlternacija = new DataGridViewCellStyle();
            DataGridViewCellStyle stilRedovi = new DataGridViewCellStyle();

            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            tabelaPredstavnici = new DataGridView();
            kolJMBG = new DataGridViewTextBoxColumn();
            kolIme = new DataGridViewTextBoxColumn();
            kolPrezime = new DataGridViewTextBoxColumn();
            kolPozicija = new DataGridViewTextBoxColumn();
            kolTelefon = new DataGridViewTextBoxColumn();
            kolEmail = new DataGridViewTextBoxColumn();
            bindingPredstavnici = new BindingSource(components);
            oznakaNaslov = new Label();

            ((System.ComponentModel.ISupportInitialize)tabelaPredstavnici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingPredstavnici).BeginInit();
            SuspendLayout();
 
            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 7);
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.Text = "Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(168, 11);
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.Text = "Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;
 
            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 11);
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.Text = "Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            stilAlternacija.BackColor = Color.FromArgb(250, 250, 253);
            tabelaPredstavnici.AlternatingRowsDefaultCellStyle = stilAlternacija;
            tabelaPredstavnici.AutoGenerateColumns = false;
            tabelaPredstavnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaPredstavnici.BackgroundColor = Color.White;

            stilZaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            stilZaglavlje.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            stilZaglavlje.ForeColor = Color.Black;
            stilZaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabelaPredstavnici.ColumnHeadersDefaultCellStyle = stilZaglavlje;

            tabelaPredstavnici.Columns.AddRange(new DataGridViewColumn[]
            {
                kolJMBG, kolIme, kolPrezime, kolPozicija, kolTelefon, kolEmail
            });

            tabelaPredstavnici.DataSource = bindingPredstavnici;
            stilRedovi.SelectionBackColor = Color.FromArgb(200, 220, 255);
            stilRedovi.SelectionForeColor = Color.Black;
            tabelaPredstavnici.DefaultCellStyle = stilRedovi;
            tabelaPredstavnici.EnableHeadersVisualStyles = false;
            tabelaPredstavnici.GridColor = Color.FromArgb(225, 225, 225);
            tabelaPredstavnici.Location = new Point(12, 50);
            tabelaPredstavnici.RowHeadersVisible = false;
            tabelaPredstavnici.RowTemplate.Height = 26;
            tabelaPredstavnici.Size = new Size(1160, 599);
			tabelaPredstavnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			tabelaPredstavnici.MultiSelect = false;

			kolJMBG.DataPropertyName = "JMBG";
            kolJMBG.HeaderText = "JMBG";

            kolIme.DataPropertyName = "Ime";
            kolIme.HeaderText = "Ime";

            kolPrezime.DataPropertyName = "Prezime";
            kolPrezime.HeaderText = "Prezime";

            kolPozicija.DataPropertyName = "Pozicija";
            kolPozicija.HeaderText = "Pozicija";

            kolTelefon.DataPropertyName = "Telefon";
            kolTelefon.HeaderText = "Telefon";

            kolEmail.DataPropertyName = "Email";
            kolEmail.HeaderText = "Email adresa";

         
            bindingPredstavnici.DataSource = typeof(DTO.DTOPredstavnikSluzbe);

          
            oznakaNaslov.AutoSize = true;
            oznakaNaslov.Font = new Font("Segoe UI Semibold", 14F);
            oznakaNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            oznakaNaslov.Location = new Point(512, 14);
            oznakaNaslov.Text = "Predstavnici službi";

      
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(oznakaNaslov);
            Controls.Add(tabelaPredstavnici);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled predstavnika službi";
            Load += FormaPregledPredstavnikaSluzbe_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaPredstavnici).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingPredstavnici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView tabelaPredstavnici;
        private Label oznakaNaslov;
        private BindingSource bindingPredstavnici;
        private DataGridViewTextBoxColumn kolJMBG;
        private DataGridViewTextBoxColumn kolIme;
        private DataGridViewTextBoxColumn kolPrezime;
        private DataGridViewTextBoxColumn kolPozicija;
        private DataGridViewTextBoxColumn kolTelefon;
        private DataGridViewTextBoxColumn kolEmail;
    }
}
