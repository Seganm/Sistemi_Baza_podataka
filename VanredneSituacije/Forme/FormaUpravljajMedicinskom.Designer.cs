using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajMedicinskom
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
            dtpDatumNabavke = new DateTimePicker();
            cmbTip = new ComboBox();
            lblTip = new Label();
            cmbJedinica = new ComboBox();
            lblJedinica = new Label();
            lblDatum = new Label();
            txtNazivOpreme = new TextBox();
            cmbStatus = new ComboBox();
            txtSerijskiBroj = new TextBox();
            btnResetuj = new Button();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            lblStatus = new Label();
            lblNaziv = new Label();
            lblSerijskiBroj = new Label();
            SuspendLayout();

            dtpDatumNabavke.CalendarMonthBackground = Color.White;
            dtpDatumNabavke.Location = new Point(420, 39);
            dtpDatumNabavke.Name = "dtpDatumNabavke";
            dtpDatumNabavke.Size = new Size(168, 25);

            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.Location = new Point(420, 122);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(167, 25);

            lblTip.ForeColor = Color.FromArgb(40, 40, 40);
            lblTip.Location = new Point(302, 125);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(113, 20);
            lblTip.Text = "Tip:";
            lblTip.TextAlign = ContentAlignment.MiddleLeft;

            cmbJedinica.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJedinica.Location = new Point(420, 79);
            cmbJedinica.Name = "cmbJedinica";
            cmbJedinica.Size = new Size(167, 25);

            lblJedinica.ForeColor = Color.FromArgb(40, 40, 40);
            lblJedinica.Location = new Point(302, 82);
            lblJedinica.Name = "lblJedinica";
            lblJedinica.Size = new Size(113, 20);
            lblJedinica.Text = "Jedinica:";
            lblJedinica.TextAlign = ContentAlignment.MiddleLeft;

            lblDatum.ForeColor = Color.FromArgb(40, 40, 40);
            lblDatum.Location = new Point(302, 44);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(113, 20);
            lblDatum.Text = "Datum nabavke:";
            lblDatum.TextAlign = ContentAlignment.MiddleLeft;

            txtNazivOpreme.BackColor = Color.White;
            txtNazivOpreme.Location = new Point(127, 80);
            txtNazivOpreme.Name = "txtNazivOpreme";
            txtNazivOpreme.Size = new Size(167, 25);

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(127, 117);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(167, 25);

            txtSerijskiBroj.BackColor = Color.White;
            txtSerijskiBroj.Location = new Point(127, 42);
            txtSerijskiBroj.Name = "txtSerijskiBroj";
            txtSerijskiBroj.Size = new Size(167, 25);

            btnResetuj.BackColor = Color.FromArgb(255, 190, 80);
            btnResetuj.FlatStyle = FlatStyle.Flat;
            btnResetuj.Font = new Font("Segoe UI Semibold", 10F);
            btnResetuj.Location = new Point(258, 190);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(103, 30);
            btnResetuj.Text = "Resetuj";
            btnResetuj.UseVisualStyleBackColor = false;
            btnResetuj.Click += btnResetuj_Click;

            btnOdustani.BackColor = Color.FromArgb(220, 70, 70);
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI Semibold", 10F);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(367, 190);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(102, 30);
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;

            btnSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI Semibold", 10F);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(158, 190);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 30);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;

            lblStatus.ForeColor = Color.FromArgb(40, 40, 40);
            lblStatus.Location = new Point(8, 125);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(113, 20);
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            lblNaziv.ForeColor = Color.FromArgb(40, 40, 40);
            lblNaziv.Location = new Point(8, 87);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(113, 20);
            lblNaziv.Text = "Naziv:";
            lblNaziv.TextAlign = ContentAlignment.MiddleLeft;

            lblSerijskiBroj.ForeColor = Color.FromArgb(40, 40, 40);
            lblSerijskiBroj.Location = new Point(8, 49);
            lblSerijskiBroj.Name = "lblSerijskiBroj";
            lblSerijskiBroj.Size = new Size(113, 20);
            lblSerijskiBroj.Text = "Serijski broj:";
            lblSerijskiBroj.TextAlign = ContentAlignment.MiddleLeft;

            BackColor = Color.FromArgb(248, 250, 253);
            ClientSize = new Size(613, 251);
            Controls.AddRange(new Control[]
            {
                dtpDatumNabavke, cmbTip, lblTip, cmbJedinica, lblJedinica, lblDatum,
                txtNazivOpreme, cmbStatus, txtSerijskiBroj, btnResetuj, btnOdustani,
                btnSacuvaj, lblStatus, lblNaziv, lblSerijskiBroj
            });
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajMedicinskom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje medicinskom opremom";
            Load += FormaUpravljajMedicinskom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private DateTimePicker dtpDatumNabavke;
        private ComboBox cmbTip;
        private Label lblTip;
        private ComboBox cmbJedinica;
        private Label lblJedinica;
        private Label lblDatum;
        private TextBox txtNazivOpreme;
        private ComboBox cmbStatus;
        private TextBox txtSerijskiBroj;
        private Button btnResetuj;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private Label lblStatus;
        private Label lblNaziv;
        private Label lblSerijskiBroj;
    }
}