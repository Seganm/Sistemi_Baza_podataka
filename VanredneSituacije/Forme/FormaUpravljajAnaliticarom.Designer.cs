using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajAnaliticarom
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
            labelNaslov = new Label();
            labelJmbg = new Label();
            labelIme = new Label();
            labelPrezime = new Label();
            labelRodjenje = new Label();
            labelPol = new Label();
            labelKontakt = new Label();
            labelEmail = new Label();
            labelAdresa = new Label();
            labelZaposlenje = new Label();

            textJmbg = new TextBox();
            textIme = new TextBox();
            textPrezime = new TextBox();
            dateRodjenja = new DateTimePicker();
            checkMusko = new CheckBox();
            checkZensko = new CheckBox();
            textKontakt = new TextBox();
            textEmail = new TextBox();
            textAdresa = new TextBox();
            dateZaposlenje = new DateTimePicker();

            buttonSave = new Button();
            buttonReset = new Button();
            buttonCancel = new Button();

            SuspendLayout();

            labelNaslov.AutoSize = true;
            labelNaslov.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            labelNaslov.ForeColor = Color.FromArgb(41, 128, 185);
            labelNaslov.Location = new Point(150, 15);
            labelNaslov.Text = "🧠 Upravljanje analitičarem";

    
            Font labelFont = new Font("Segoe UI Semibold", 10F);
            int xLeft = 40, xRight = 340, yStart = 70, yStep = 35;

            labelJmbg.Location = new Point(xLeft, yStart);
            labelJmbg.Text = "JMBG:";
            labelJmbg.Font = labelFont;

            labelIme.Location = new Point(xLeft, yStart + yStep);
            labelIme.Text = "Ime:";
            labelIme.Font = labelFont;

            labelPrezime.Location = new Point(xLeft, yStart + 2 * yStep);
            labelPrezime.Text = "Prezime:";
            labelPrezime.Font = labelFont;

            labelRodjenje.Location = new Point(xLeft, yStart + 3 * yStep);
            labelRodjenje.Text = "Datum rođenja:";
            labelRodjenje.Font = labelFont;

            labelPol.Location = new Point(xLeft, yStart + 4 * yStep);
            labelPol.Text = "Pol:";
            labelPol.Font = labelFont;

            labelKontakt.Location = new Point(xRight, yStart);
            labelKontakt.Text = "Telefon:";
            labelKontakt.Font = labelFont;

            labelEmail.Location = new Point(xRight, yStart + yStep);
            labelEmail.Text = "E-mail:";
            labelEmail.Font = labelFont;

            labelAdresa.Location = new Point(xRight, yStart + 2 * yStep);
            labelAdresa.Text = "Adresa:";
            labelAdresa.Font = labelFont;

            labelZaposlenje.Location = new Point(xRight, yStart + 3 * yStep);
            labelZaposlenje.Text = "Datum zaposlenja:";
            labelZaposlenje.Font = labelFont;


            int textWidth = 150;
            textJmbg.Location = new Point(xLeft + 130, yStart - 3);
            textJmbg.Size = new Size(textWidth, 25);
            textJmbg.MaxLength = 13;

            textIme.Location = new Point(xLeft + 130, yStart + yStep - 3);
            textIme.Size = new Size(textWidth, 25);

            textPrezime.Location = new Point(xLeft + 130, yStart + 2 * yStep - 3);
            textPrezime.Size = new Size(textWidth, 25);

            dateRodjenja.Format = DateTimePickerFormat.Short;
            dateRodjenja.Location = new Point(xLeft + 130, yStart + 3 * yStep - 3);
            dateRodjenja.Size = new Size(textWidth, 25);

            checkMusko.Text = "Muško";
            checkMusko.Location = new Point(xLeft + 130, yStart + 4 * yStep - 3);
            checkMusko.AutoSize = true;

            checkZensko.Text = "Žensko";
            checkZensko.Location = new Point(xLeft + 210, yStart + 4 * yStep - 3);
            checkZensko.AutoSize = true;

            textKontakt.Location = new Point(xRight + 130, yStart - 3);
            textKontakt.Size = new Size(textWidth, 25);

            textEmail.Location = new Point(xRight + 130, yStart + yStep - 3);
            textEmail.Size = new Size(textWidth, 25);

            textAdresa.Location = new Point(xRight + 130, yStart + 2 * yStep - 3);
            textAdresa.Size = new Size(textWidth, 25);

            dateZaposlenje.Format = DateTimePickerFormat.Short;
            dateZaposlenje.Location = new Point(xRight + 130, yStart + 3 * yStep - 3);
            dateZaposlenje.Size = new Size(textWidth, 25);

    
            buttonSave.Text = "💾 Sačuvaj";
            buttonSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonSave.BackColor = Color.FromArgb(0, 122, 204);
            buttonSave.ForeColor = Color.White;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Size = new Size(140, 45);
            buttonSave.Location = new Point(60, 280);
            buttonSave.Click += buttonSave_Click;

            buttonReset.Text = "🔄 Resetuj";
            buttonReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonReset.BackColor = Color.FromArgb(255, 190, 80);
            buttonReset.ForeColor = Color.Black;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.Size = new Size(140, 45);
            buttonReset.Location = new Point(230, 280);
            buttonReset.Click += buttonReset_Click;

            buttonCancel.Text = "❌ Otkaži";
            buttonCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonCancel.BackColor = Color.FromArgb(220, 70, 70);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.Size = new Size(140, 45);
            buttonCancel.Location = new Point(400, 280);
            buttonCancel.Click += buttonCancel_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(630, 360);
            Font = new Font("Segoe UI", 10F);
            Controls.AddRange(new Control[]
            {
                labelNaslov, labelJmbg, labelIme, labelPrezime, labelRodjenje,
                labelPol, labelKontakt, labelEmail, labelAdresa, labelZaposlenje,
                textJmbg, textIme, textPrezime, dateRodjenja, checkMusko, checkZensko,
                textKontakt, textEmail, textAdresa, dateZaposlenje,
                buttonSave, buttonReset, buttonCancel
            });
            Name = "FormaUpravljajAnaliticarom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje Analitičarem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNaslov;
        private Label labelJmbg;
        private Label labelIme;
        private Label labelPrezime;
        private Label labelRodjenje;
        private Label labelPol;
        private Label labelKontakt;
        private Label labelEmail;
        private Label labelAdresa;
        private Label labelZaposlenje;

        private TextBox textJmbg;
        private TextBox textIme;
        private TextBox textPrezime;
        private DateTimePicker dateRodjenja;
        private CheckBox checkMusko;
        private CheckBox checkZensko;
        private TextBox textKontakt;
        private TextBox textEmail;
        private TextBox textAdresa;
        private DateTimePicker dateZaposlenje;

        private Button buttonSave;
        private Button buttonReset;
        private Button buttonCancel;
    }
}
