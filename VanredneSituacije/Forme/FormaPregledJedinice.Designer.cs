using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledJedinice
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
            mrezaJedinice = new DataGridView();
            izborTipa = new ComboBox();
            dugmeVozila = new Button();
            dugmeClanovi = new Button();
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)mrezaJedinice).BeginInit();
            SuspendLayout();

            mrezaJedinice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mrezaJedinice.BackgroundColor = Color.White;
            mrezaJedinice.BorderStyle = BorderStyle.FixedSingle;
            mrezaJedinice.GridColor = Color.LightGray;
            mrezaJedinice.RowHeadersVisible = false;
            mrezaJedinice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mrezaJedinice.EnableHeadersVisualStyles = false;
            mrezaJedinice.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            mrezaJedinice.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(200, 220, 255),
                SelectionForeColor = Color.Black
            };
            mrezaJedinice.Location = new Point(12, 45);
            mrezaJedinice.Name = "mrezaJedinice";
            mrezaJedinice.Size = new Size(1160, 605);
            mrezaJedinice.TabIndex = 20;

            izborTipa.FormattingEnabled = true;
            izborTipa.Items.AddRange(new object[] { "Sve Jedinice", "Opšte Jedinice", "Specijalne Jedinice" });
            izborTipa.Location = new Point(12, 16);
            izborTipa.Name = "izborTipa";
            izborTipa.Size = new Size(150, 23);
            izborTipa.TabIndex = 19;
            izborTipa.SelectedIndexChanged += izborTipa_SelectedIndexChanged;

            dugmeDodaj.BackColor = Color.FromArgb(0, 123, 255);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(398, 11);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 30);
            dugmeDodaj.Text = "➕ Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(554, 11);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(150, 30);
            dugmeIzmeni.Text = "✏ Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(710, 11);
            dugmeObrisi.Name = "dugmeObrisi";
            dugmeObrisi.Size = new Size(150, 30);
            dugmeObrisi.Text = "🗑 Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeVozila.BackColor = Color.FromArgb(13, 110, 253);
            dugmeVozila.FlatStyle = FlatStyle.Flat;
            dugmeVozila.FlatAppearance.BorderSize = 0;
            dugmeVozila.Font = new Font("Segoe UI Semibold", 9F);
            dugmeVozila.ForeColor = Color.White;
            dugmeVozila.Location = new Point(866, 11);
            dugmeVozila.Name = "dugmeVozila";
            dugmeVozila.Size = new Size(150, 30);
            dugmeVozila.Text = "🚗 Vozila";
            dugmeVozila.UseVisualStyleBackColor = false;
            dugmeVozila.Click += dugmeVozila_Click;

            dugmeClanovi.BackColor = Color.FromArgb(108, 117, 125);
            dugmeClanovi.FlatStyle = FlatStyle.Flat;
            dugmeClanovi.FlatAppearance.BorderSize = 0;
            dugmeClanovi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeClanovi.ForeColor = Color.White;
            dugmeClanovi.Location = new Point(1022, 11);
            dugmeClanovi.Name = "dugmeClanovi";
            dugmeClanovi.Size = new Size(150, 30);
            dugmeClanovi.Text = "👥 Članovi";
            dugmeClanovi.UseVisualStyleBackColor = false;
            dugmeClanovi.Click += dugmeClanovi_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(mrezaJedinice);
            Controls.Add(izborTipa);
            Controls.Add(dugmeClanovi);
            Controls.Add(dugmeDodaj);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeVozila);
            Name = "FormaPregledJedinice";
            Text = "Pregled jedinica";
            Load += FormaPregledJedinice_Load;
            ((System.ComponentModel.ISupportInitialize)mrezaJedinice).EndInit();
            ResumeLayout(false);
        }

        private Button dugmeVozila;
        private Button dugmeClanovi;
        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private ComboBox izborTipa;
        private DataGridView mrezaJedinice;
    }
}
