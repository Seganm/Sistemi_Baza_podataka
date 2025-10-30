using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledVozila
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
            tabelaVozila = new DataGridView();
            izborTipaVozila = new ComboBox();
            dugmeDodajVozilo = new Button();
            dugmeIzmeniVozilo = new Button();
            dugmeObrisiVozilo = new Button();
            dugmeIntervencije = new Button();
            dugmeServisi = new Button();

            ((System.ComponentModel.ISupportInitialize)tabelaVozila).BeginInit();
            SuspendLayout();

          
            tabelaVozila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaVozila.BackgroundColor = Color.White;
            tabelaVozila.BorderStyle = BorderStyle.None;
            tabelaVozila.GridColor = Color.FromArgb(230, 230, 230);
            tabelaVozila.Location = new Point(14, 63);
            tabelaVozila.Size = new Size(1326, 804);
            tabelaVozila.RowTemplate.Height = 28;
            tabelaVozila.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaVozila.MultiSelect = false;

       
            izborTipaVozila.FormattingEnabled = true;
            izborTipaVozila.Items.AddRange(new object[] { "Sva vozila", "Sanitetska vozila", "Specijalna vozila", "Kamioni", "Džipovi" });
            izborTipaVozila.Location = new Point(14, 25);
            izborTipaVozila.Size = new Size(160, 28);
            izborTipaVozila.SelectedIndexChanged += izborTipaVozila_SelectedIndexChanged;

            dugmeDodajVozilo.Text = "➕ Dodaj vozilo";
            dugmeDodajVozilo.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodajVozilo.ForeColor = Color.White;
            dugmeDodajVozilo.FlatStyle = FlatStyle.Flat;
            dugmeDodajVozilo.Font = new Font("Segoe UI", 9F);
            dugmeDodajVozilo.Location = new Point(444, 13);
            dugmeDodajVozilo.Size = new Size(171, 40);
            dugmeDodajVozilo.Click += dugmeDodajVozilo_Click;

            dugmeIzmeniVozilo.Text = "✏ Izmeni vozilo";
            dugmeIzmeniVozilo.BackColor = Color.FromArgb(255, 193, 7);
            dugmeIzmeniVozilo.FlatStyle = FlatStyle.Flat;
            dugmeIzmeniVozilo.Font = new Font("Segoe UI", 9F);
            dugmeIzmeniVozilo.ForeColor = Color.Black;
            dugmeIzmeniVozilo.Location = new Point(622, 13);
            dugmeIzmeniVozilo.Size = new Size(171, 40);
            dugmeIzmeniVozilo.Click += dugmeIzmeniVozilo_Click;

            dugmeObrisiVozilo.Text = "🗑 Obriši vozilo";
            dugmeObrisiVozilo.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisiVozilo.FlatStyle = FlatStyle.Flat;
            dugmeObrisiVozilo.Font = new Font("Segoe UI", 9F);
            dugmeObrisiVozilo.ForeColor = Color.White;
            dugmeObrisiVozilo.Location = new Point(801, 13);
            dugmeObrisiVozilo.Size = new Size(171, 40);
            dugmeObrisiVozilo.Click += dugmeObrisiVozilo_Click;

            dugmeIntervencije.Text = "📋 Intervencije";
            dugmeIntervencije.BackColor = Color.FromArgb(90, 90, 90);
            dugmeIntervencije.ForeColor = Color.White;
            dugmeIntervencije.FlatStyle = FlatStyle.Flat;
            dugmeIntervencije.Font = new Font("Segoe UI", 9F);
            dugmeIntervencije.Location = new Point(979, 13);
            dugmeIntervencije.Size = new Size(171, 40);
            dugmeIntervencije.Click += dugmeIntervencije_Click;

            dugmeServisi.Text = "🔧 Servisi vozila";
            dugmeServisi.BackColor = Color.FromArgb(0, 122, 204);
            dugmeServisi.ForeColor = Color.White;
            dugmeServisi.FlatStyle = FlatStyle.Flat;
            dugmeServisi.Font = new Font("Segoe UI", 9F);
            dugmeServisi.Location = new Point(1156, 13);
            dugmeServisi.Size = new Size(171, 40);
            dugmeServisi.Click += dugmeServisi_Click;

            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1353, 881);
            Controls.AddRange(new Control[] { izborTipaVozila, dugmeDodajVozilo, dugmeIzmeniVozilo, dugmeObrisiVozilo, dugmeIntervencije, dugmeServisi, tabelaVozila });
            Text = "🚗 Pregled vozila";
            WindowState = FormWindowState.Maximized;
            Load += FormaPregledVozila_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaVozila).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaVozila;
        private ComboBox izborTipaVozila;
        private Button dugmeDodajVozilo;
        private Button dugmeIzmeniVozilo;
        private Button dugmeObrisiVozilo;
        private Button dugmeIntervencije;
        private Button dugmeServisi;
    }
}
