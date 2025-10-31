using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledSaradjivanja
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

            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            mrezaSaradnje = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolSektor = new DataGridViewTextBoxColumn();
            kolSluzba = new DataGridViewTextBoxColumn();
            kolSituacija = new DataGridViewTextBoxColumn();
            kolTip = new DataGridViewTextBoxColumn();
            kolUloga = new DataGridViewTextBoxColumn();
            bindingSaradnje = new BindingSource(components);
            oznakaNaslov = new Label();

            ((System.ComponentModel.ISupportInitialize)mrezaSaradnje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSaradnje).BeginInit();
            SuspendLayout();

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 11);
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.Text = "🗑 Obriši saradnju";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(169, 11);
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.Text = "✏ Izmeni saradnju";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(13, 11);
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.Text = "➕ Nova saradnja";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            stilAlternacija.BackColor = Color.FromArgb(250, 250, 253);
            mrezaSaradnje.AlternatingRowsDefaultCellStyle = stilAlternacija;
            mrezaSaradnje.AutoGenerateColumns = false;
            mrezaSaradnje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mrezaSaradnje.BackgroundColor = Color.White;
            stilZaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            stilZaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            stilZaglavlje.ForeColor = Color.Black;
            mrezaSaradnje.ColumnHeadersDefaultCellStyle = stilZaglavlje;
            mrezaSaradnje.Columns.AddRange(new DataGridViewColumn[]
            {
                kolId, kolSektor, kolSluzba, kolSituacija, kolTip, kolUloga
            });
            mrezaSaradnje.DataSource = bindingSaradnje;
            stilRedovi.SelectionBackColor = Color.FromArgb(200, 220, 255);
            stilRedovi.SelectionForeColor = Color.Black;
            mrezaSaradnje.DefaultCellStyle = stilRedovi;
            mrezaSaradnje.EnableHeadersVisualStyles = false;
            mrezaSaradnje.GridColor = Color.FromArgb(225, 225, 225);
            mrezaSaradnje.Location = new Point(12, 50);
            mrezaSaradnje.RowHeadersVisible = false;
            mrezaSaradnje.RowTemplate.Height = 28;
            mrezaSaradnje.Size = new Size(1160, 599);

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID saradnje";
            kolSektor.DataPropertyName = "SektorID";
            kolSektor.HeaderText = "Sektor ID";
            kolSluzba.DataPropertyName = "NazivSluzbe";
            kolSluzba.HeaderText = "Naziv službe";
            kolSituacija.DataPropertyName = "IDVanSituacije";
            kolSituacija.HeaderText = "ID vanredne situacije";
            kolTip.DataPropertyName = "TipVs";
            kolTip.HeaderText = "Tip situacije";
            kolUloga.DataPropertyName = "Uloga";
            kolUloga.HeaderText = "Uloga u saradnji";

            bindingSaradnje.DataSource = typeof(DTO.DTOSaradnjeVratiPoId);

            oznakaNaslov.AutoSize = true;
            oznakaNaslov.Font = new Font("Segoe UI Semibold", 14F);
            oznakaNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            oznakaNaslov.Location = new Point(508, 12);
            oznakaNaslov.Text = "🤝 Saradnje službi";

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(oznakaNaslov);
            Controls.Add(mrezaSaradnje);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Text = "Pregled saradnji službi";
            WindowState = FormWindowState.Maximized;
            Load += FormaPregledSaradjivanja_Load;

            ((System.ComponentModel.ISupportInitialize)mrezaSaradnje).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSaradnje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView mrezaSaradnje;
        private Label oznakaNaslov;
        private BindingSource bindingSaradnje;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolSektor;
        private DataGridViewTextBoxColumn kolSluzba;
        private DataGridViewTextBoxColumn kolSituacija;
        private DataGridViewTextBoxColumn kolTip;
        private DataGridViewTextBoxColumn kolUloga;
    }
}
