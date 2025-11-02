using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledSertifikata
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

            mrezaSertifikati = new DataGridView();
            bindingSertifikati = new BindingSource(components);
            bindingIdSertifikata = new BindingSource(components);
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            oznakaNaslov = new Label();

            ((System.ComponentModel.ISupportInitialize)mrezaSertifikati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSertifikati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingIdSertifikata).BeginInit();
            SuspendLayout();

            mrezaSertifikati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mrezaSertifikati.BackgroundColor = SystemColors.ControlLightLight;
            mrezaSertifikati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mrezaSertifikati.Location = new Point(12, 45);
            mrezaSertifikati.Name = "mrezaSertifikati";
            mrezaSertifikati.RowHeadersWidth = 51;
            mrezaSertifikati.Size = new Size(1160, 605);
            mrezaSertifikati.TabIndex = 17;

            bindingSertifikati.DataSource = typeof(DTO.DTOSertifikat);
            bindingIdSertifikata.DataSource = typeof(DTO.DTODodajIdSertifikata);

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 11);
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.Text = "Obriši sertifikat";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(169, 11);
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.Text = "Izmeni podatke";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(13, 11);
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.Text = "Novi sertifikat";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            oznakaNaslov.AutoSize = true;
            oznakaNaslov.Font = new Font("Segoe UI Semibold", 14F);
            oznakaNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            oznakaNaslov.Location = new Point(563, 12);
            oznakaNaslov.Text = "Sertifikati";

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(oznakaNaslov);
            Controls.Add(mrezaSertifikati);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledSertifikata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled sertifikata zaposlenih";
            WindowState = FormWindowState.Maximized;
            Load += FormaPregledSertifikata_Load;

            ((System.ComponentModel.ISupportInitialize)mrezaSertifikati).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSertifikati).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingIdSertifikata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView mrezaSertifikati;
        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private Label oznakaNaslov;
        private BindingSource bindingSertifikati;
        private BindingSource bindingIdSertifikata;
    }
}
