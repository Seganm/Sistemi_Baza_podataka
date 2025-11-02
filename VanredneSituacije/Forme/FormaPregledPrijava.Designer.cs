using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledPrijava
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
            DataGridViewCellStyle stilAlternacija = new DataGridViewCellStyle();
            DataGridViewCellStyle stilZaglavlje = new DataGridViewCellStyle();
            DataGridViewCellStyle stilRedovi = new DataGridViewCellStyle();

            oznakaNaslov = new Label();
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            mrezaPrijave = new DataGridView();

            kolId = new DataGridViewTextBoxColumn();
            kolDatum = new DataGridViewTextBoxColumn();
            kolTip = new DataGridViewTextBoxColumn();
            kolIme = new DataGridViewTextBoxColumn();
            kolKontakt = new DataGridViewTextBoxColumn();
            kolLokacija = new DataGridViewTextBoxColumn();
            kolOpis = new DataGridViewTextBoxColumn();
            kolDispecer = new DataGridViewTextBoxColumn();
            kolPrioritet = new DataGridViewTextBoxColumn();

            bindingPrijave = new BindingSource(components);
            bindingDodavanje = new BindingSource(components);

            ((System.ComponentModel.ISupportInitialize)mrezaPrijave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingPrijave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingDodavanje).BeginInit();
            SuspendLayout();

    
            oznakaNaslov.AutoSize = true;
            oznakaNaslov.Font = new Font("Segoe UI Semibold", 14F);
            oznakaNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            oznakaNaslov.Location = new Point(516, 13);
            oznakaNaslov.Text = "Lista prijava";

      
            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 12);
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.Text = "Obriši prijavu";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

 
            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(168, 13);
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.Text = "Izmeni podatke";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 12);
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.Text = "Nova prijava";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

           
            stilAlternacija.BackColor = Color.FromArgb(250, 250, 253);
            mrezaPrijave.AlternatingRowsDefaultCellStyle = stilAlternacija;
            mrezaPrijave.AutoGenerateColumns = false;
            mrezaPrijave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mrezaPrijave.BackgroundColor = Color.White;

            stilZaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            stilZaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            stilZaglavlje.ForeColor = Color.Black;
            mrezaPrijave.ColumnHeadersDefaultCellStyle = stilZaglavlje;

            mrezaPrijave.Columns.AddRange(new DataGridViewColumn[]
            {
                kolId, kolDatum, kolTip, kolIme, kolKontakt,
                kolLokacija, kolOpis, kolDispecer, kolPrioritet
            });

            mrezaPrijave.DataSource = bindingPrijave;
            mrezaPrijave.EnableHeadersVisualStyles = false;
            mrezaPrijave.GridColor = Color.FromArgb(225, 225, 225);
            mrezaPrijave.Location = new Point(12, 50);
            mrezaPrijave.RowHeadersVisible = false;
            mrezaPrijave.RowTemplate.Height = 28;
            mrezaPrijave.Size = new Size(1160, 599);
            mrezaPrijave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mrezaPrijave.MultiSelect = false;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID prijave";

            kolDatum.DataPropertyName = "DatumVremee";
            kolDatum.HeaderText = "Datum i vreme";

            kolTip.DataPropertyName = "Tip";
            kolTip.HeaderText = "Tip prijave";

            kolIme.DataPropertyName = "PrijavilacIme";
            kolIme.HeaderText = "Prijavio";

            kolKontakt.DataPropertyName = "Kontakt";
            kolKontakt.HeaderText = "Kontakt telefon";

            kolLokacija.DataPropertyName = "Lokacija";
            kolLokacija.HeaderText = "Lokacija";

            kolOpis.DataPropertyName = "Opis";
            kolOpis.HeaderText = "Opis situacije";

            kolDispecer.DataPropertyName = "DispecerJMBG";
            kolDispecer.HeaderText = "JMBG dispečera";

            kolPrioritet.DataPropertyName = "Prioritet";
            kolPrioritet.HeaderText = "Prioritet";

       
            bindingPrijave.DataSource = typeof(DTO.DTOPrijava);
            bindingDodavanje.DataSource = typeof(DTO.DTOPrijavaDodajj);

          
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(oznakaNaslov);
            Controls.Add(mrezaPrijave);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Text = "Pregled prijava vanrednih situacija";
            Load += FormaPregledPrijava_Load;

            ((System.ComponentModel.ISupportInitialize)mrezaPrijave).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingPrijave).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingDodavanje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label oznakaNaslov;
        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView mrezaPrijave;
        private BindingSource bindingPrijave;
        private BindingSource bindingDodavanje;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolDatum;
        private DataGridViewTextBoxColumn kolTip;
        private DataGridViewTextBoxColumn kolIme;
        private DataGridViewTextBoxColumn kolKontakt;
        private DataGridViewTextBoxColumn kolLokacija;
        private DataGridViewTextBoxColumn kolOpis;
        private DataGridViewTextBoxColumn kolDispecer;
        private DataGridViewTextBoxColumn kolPrioritet;
    }
}
