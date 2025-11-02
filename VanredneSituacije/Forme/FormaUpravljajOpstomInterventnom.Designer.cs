using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajOpstomInterventnom
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
            txtBaza = new TextBox();
            txtNaziv = new TextBox();
            cmbKomandir = new ComboBox();

            btnReset = new Button();
            btnOdustani = new Button();
            btnSacuvaj = new Button();

            lblBaza = new Label();
            lblNaziv = new Label();
            lblKomandir = new Label();
            lblNaslov = new Label();

            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();

            txtBaza.Font = new Font("Segoe UI", 10F);
            txtBaza.Location = new Point(151, 100);
            txtBaza.Size = new Size(167, 25);

            txtNaziv.Font = new Font("Segoe UI", 10F);
            txtNaziv.Location = new Point(151, 65);
            txtNaziv.Size = new Size(167, 25);

            cmbKomandir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKomandir.Font = new Font("Segoe UI", 10F);
            cmbKomandir.Location = new Point(151, 140);
            cmbKomandir.Size = new Size(167, 25);

            btnReset.BackColor = Color.FromArgb(255, 190, 80);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 10F);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(396, 93);
            btnReset.Size = new Size(103, 32);
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;

            btnOdustani.BackColor = Color.FromArgb(220, 70, 70);
            btnOdustani.FlatAppearance.BorderSize = 0;
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI Semibold", 10F);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(396, 131);
            btnOdustani.Size = new Size(103, 32);
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;

            btnSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            btnSacuvaj.FlatAppearance.BorderSize = 0;
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI Semibold", 10F);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(396, 58);
            btnSacuvaj.Size = new Size(103, 32);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;

            lblNaziv.Font = new Font("Segoe UI", 10F);
            lblNaziv.Location = new Point(32, 70);
            lblNaziv.Size = new Size(113, 20);
            lblNaziv.Text = "Naziv:";
            lblNaziv.TextAlign = ContentAlignment.MiddleLeft;

            lblBaza.Font = new Font("Segoe UI", 10F);
            lblBaza.Location = new Point(32, 105);
            lblBaza.Size = new Size(113, 20);
            lblBaza.Text = "Baza:";
            lblBaza.TextAlign = ContentAlignment.MiddleLeft;

            lblKomandir.Font = new Font("Segoe UI", 10F);
            lblKomandir.Location = new Point(32, 145);
            lblKomandir.Size = new Size(113, 20);
            lblKomandir.Text = "Komandir:";
            lblKomandir.TextAlign = ContentAlignment.MiddleLeft;

            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Semibold", 14F);
            lblNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            lblNaslov.Location = new Point(60, 15);
            lblNaslov.Size = new Size(396, 25);
            lblNaslov.Text = "Upravljaj opštom interventnom jedinicom";

            pnlMain.BackColor = Color.FromArgb(245, 247, 250);
            pnlMain.Controls.Add(lblNaslov);
            pnlMain.Controls.Add(lblNaziv);
            pnlMain.Controls.Add(txtNaziv);
            pnlMain.Controls.Add(lblBaza);
            pnlMain.Controls.Add(txtBaza);
            pnlMain.Controls.Add(lblKomandir);
            pnlMain.Controls.Add(cmbKomandir);
            pnlMain.Controls.Add(btnSacuvaj);
            pnlMain.Controls.Add(btnReset);
            pnlMain.Controls.Add(btnOdustani);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Padding = new Padding(10);
            pnlMain.Size = new Size(549, 209);

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 209);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaUpravljajOpstomInterventnom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje opštom interventnom";
            Load += FormaUpravljajOpstomInterventnom_Load;

            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlMain;
        private Label lblNaslov;
        private Label lblNaziv;
        private Label lblBaza;
        private Label lblKomandir;

        private TextBox txtBaza;
        private TextBox txtNaziv;
        private ComboBox cmbKomandir;

        private Button btnReset;
        private Button btnOdustani;
        private Button btnSacuvaj;
    }
}