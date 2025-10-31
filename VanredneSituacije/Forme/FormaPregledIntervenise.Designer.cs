using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledIntervenise
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
            DataGridViewCellStyle redAlternating = new DataGridViewCellStyle();
            DataGridViewCellStyle zaglavlje = new DataGridViewCellStyle();
            DataGridViewCellStyle redovi = new DataGridViewCellStyle();
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            gridUcestvovanja = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolJedinica = new DataGridViewTextBoxColumn();
            kolSituacija = new DataGridViewTextBoxColumn();
            kolIntervencija = new DataGridViewTextBoxColumn();
            bindingUcestvovanja = new BindingSource(components);
            naslovLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gridUcestvovanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingUcestvovanja).BeginInit();
            SuspendLayout();

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1020, 12);
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.Text = "🗑 Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(170, 12);
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.Text = "✏ Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 12);
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.Text = "➕ Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            redAlternating.BackColor = Color.FromArgb(250, 250, 253);
            gridUcestvovanja.AlternatingRowsDefaultCellStyle = redAlternating;
            gridUcestvovanja.AutoGenerateColumns = false;
            gridUcestvovanja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUcestvovanja.BackgroundColor = Color.White;
            zaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            zaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            zaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            zaglavlje.ForeColor = Color.FromArgb(30, 30, 30);
            zaglavlje.SelectionBackColor = SystemColors.Highlight;
            zaglavlje.SelectionForeColor = SystemColors.HighlightText;
            zaglavlje.WrapMode = DataGridViewTriState.True;
            gridUcestvovanja.ColumnHeadersDefaultCellStyle = zaglavlje;
            gridUcestvovanja.Columns.AddRange(new DataGridViewColumn[] { kolId, kolJedinica, kolSituacija, kolIntervencija });
            gridUcestvovanja.DataSource = bindingUcestvovanja;
            redovi.Font = new Font("Segoe UI", 9.5F);
            gridUcestvovanja.DefaultCellStyle = redovi;
            gridUcestvovanja.EnableHeadersVisualStyles = false;
            gridUcestvovanja.GridColor = Color.FromArgb(225, 225, 225);
            gridUcestvovanja.Location = new Point(12, 52);
            gridUcestvovanja.Size = new Size(1160, 595);
            gridUcestvovanja.RowTemplate.Height = 28;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID";
            kolId.Name = "kolId";

            kolJedinica.DataPropertyName = "IdInterventnee";
            kolJedinica.HeaderText = "Interventna jedinica";
            kolJedinica.Name = "kolJedinica";

            kolSituacija.DataPropertyName = "IdVanredneSituacije";
            kolSituacija.HeaderText = "Vanredna situacija";
            kolSituacija.Name = "kolSituacija";

            kolIntervencija.DataPropertyName = "IdIntervencijee";
            kolIntervencija.HeaderText = "Intervencija";
            kolIntervencija.Name = "kolIntervencija";

            bindingUcestvovanja.DataSource = typeof(DTO.DTOVratiIntervenise);

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(370, 15);
            naslovLabel.Text = "🚒 Učešća interventnih jedinica";

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabel);
            Controls.Add(gridUcestvovanja);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledIntervenise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled učešća jedinica";
            Load += FormaPregledIntervenise_Load;
            ((System.ComponentModel.ISupportInitialize)gridUcestvovanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingUcestvovanja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView gridUcestvovanja;
        private Label naslovLabel;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolJedinica;
        private DataGridViewTextBoxColumn kolSituacija;
        private DataGridViewTextBoxColumn kolIntervencija;
        private BindingSource bindingUcestvovanja;
    }
}
