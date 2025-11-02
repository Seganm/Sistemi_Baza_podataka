using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledOpreme
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
            komboTip = new ComboBox();
            bindingOprema = new BindingSource();
            dugmeDodaj = new Button();
            dugmeIzmeni = new Button();
            dugmeObrisi = new Button();
            mrezaOprema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingOprema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mrezaOprema).BeginInit();
            SuspendLayout();

            komboTip.FormattingEnabled = true;
            komboTip.Items.AddRange(new object[] { "Sve", "Lična zaštita", "Medicinska", "Tehnička", "Zalihe" });
            komboTip.Location = new Point(12, 19);
            komboTip.Name = "komboTip";
            komboTip.Size = new Size(150, 23);
            komboTip.SelectedIndexChanged += komboTip_SelectedIndexChanged;
            komboTip.DropDownStyleChanged += komboTip_DropDownStyleChanged;

            bindingOprema.DataSource = typeof(DTO.DTODodajOpremu);

            dugmeDodaj.BackColor = Color.FromArgb(0, 123, 255);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(710, 12);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 30);
            dugmeDodaj.Text = "Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(866, 12);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(150, 30);
            dugmeIzmeni.Text = "Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 12);
            dugmeObrisi.Name = "dugmeObrisi";
            dugmeObrisi.Size = new Size(150, 30);
            dugmeObrisi.Text = "Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            mrezaOprema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mrezaOprema.BackgroundColor = Color.White;
            mrezaOprema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mrezaOprema.Location = new Point(12, 48);
            mrezaOprema.Name = "mrezaOprema";
            mrezaOprema.RowHeadersVisible = false;
            mrezaOprema.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mrezaOprema.EnableHeadersVisualStyles = false;
            mrezaOprema.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            mrezaOprema.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(200, 220, 255),
                SelectionForeColor = Color.Black
            };
            mrezaOprema.GridColor = Color.LightGray;
            mrezaOprema.Size = new Size(1160, 601);
            mrezaOprema.CellContentClick += mrezaOprema_CellContentClick;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(mrezaOprema);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Controls.Add(komboTip);
            Name = "FormaPregledOpreme";
            Text = "Pregled opreme";
            Load += FormaPregledOpreme_Load;
            ((System.ComponentModel.ISupportInitialize)bindingOprema).EndInit();
            ((System.ComponentModel.ISupportInitialize)mrezaOprema).EndInit();
            ResumeLayout(false);
        }

        private ComboBox komboTip;
        private BindingSource bindingOprema;
        private Button dugmeDodaj;
        private Button dugmeIzmeni;
        private Button dugmeObrisi;
        private DataGridView mrezaOprema;
    }
}
