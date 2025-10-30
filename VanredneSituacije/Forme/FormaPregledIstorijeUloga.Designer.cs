using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledIstorijeUloga
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
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            gridIstorija = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolJMBG = new DataGridViewTextBoxColumn();
            kolUloga = new DataGridViewTextBoxColumn();
            kolOd = new DataGridViewTextBoxColumn();
            kolDo = new DataGridViewTextBoxColumn();
            bindingIstorija = new BindingSource(components);
            naslovLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gridIstorija).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingIstorija).BeginInit();
            SuspendLayout();

            dugmeDodaj.BackColor = Color.FromArgb(0, 123, 255);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(710, 11);
            dugmeDodaj.Size = new Size(150, 30);
            dugmeDodaj.Text = "➕ Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(866, 11);
            dugmeIzmeni.Size = new Size(150, 30);
            dugmeIzmeni.Text = "✏ Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 11);
            dugmeObrisi.Size = new Size(150, 30);
            dugmeObrisi.Text = "🗑 Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            gridIstorija.AutoGenerateColumns = false;
            gridIstorija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridIstorija.BackgroundColor = Color.White;
            gridIstorija.BorderStyle = BorderStyle.FixedSingle;
            gridIstorija.EnableHeadersVisualStyles = false;
            gridIstorija.GridColor = Color.LightGray;
            gridIstorija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridIstorija.Columns.AddRange(new DataGridViewColumn[] { kolId, kolJMBG, kolUloga, kolOd, kolDo });
            gridIstorija.DataSource = bindingIstorija;
            gridIstorija.Location = new Point(12, 46);
            gridIstorija.Size = new Size(1160, 603);
            gridIstorija.RowHeadersVisible = false;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID";
            kolId.MinimumWidth = 6;
            kolId.Name = "kolId";

            kolJMBG.DataPropertyName = "JMBGZaposlenog";
            kolJMBG.HeaderText = "JMBG zaposlenog";
            kolJMBG.MinimumWidth = 6;
            kolJMBG.Name = "kolJMBG";

            kolUloga.DataPropertyName = "Uloga";
            kolUloga.HeaderText = "Uloga";
            kolUloga.MinimumWidth = 6;
            kolUloga.Name = "kolUloga";

            kolOd.DataPropertyName = "Datum_Od";
            kolOd.HeaderText = "Datum od";
            kolOd.MinimumWidth = 6;
            kolOd.Name = "kolOd";

            kolDo.DataPropertyName = "Datum_Do";
            kolDo.HeaderText = "Datum do";
            kolDo.MinimumWidth = 6;
            kolDo.Name = "kolDo";

            bindingIstorija.DataSource = typeof(DTO.DTOIstorijaUloga);

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(12, 14);
            naslovLabel.Text = "📜 Istorija uloga zaposlenih";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabel);
            Controls.Add(gridIstorija);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Name = "FormaPregledIstorijeUloga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled istorije uloga";
            Load += FormaPregledIstorijeUloga_Load;
            ((System.ComponentModel.ISupportInitialize)gridIstorija).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingIstorija).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView gridIstorija;
        private Label naslovLabel;
        private BindingSource bindingIstorija;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolJMBG;
        private DataGridViewTextBoxColumn kolUloga;
        private DataGridViewTextBoxColumn kolOd;
        private DataGridViewTextBoxColumn kolDo;
    }
}
