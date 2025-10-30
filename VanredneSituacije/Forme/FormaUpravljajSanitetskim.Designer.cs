namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSanitetskim
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
            unosLokacija = new TextBox();
            lblLokacija = new Label();
            unosProizvodjac = new TextBox();
            izborStatus = new ComboBox();
            unosReg = new TextBox();
            dugmeReset = new Button();
            dugmeOdustani = new Button();
            dugmeSacuvaj = new Button();
            lblStatus = new Label();
            lblProizvodjac = new Label();
            lblReg = new Label();
            SuspendLayout();

            unosLokacija.BackColor = Color.White;
            unosLokacija.BorderStyle = BorderStyle.FixedSingle;
            unosLokacija.Location = new Point(140, 116);
            unosLokacija.Name = "unosLokacija";
            unosLokacija.Size = new Size(146, 23);

            lblLokacija.Font = new Font("Segoe UI", 9.5F);
            lblLokacija.Location = new Point(36, 116);
            lblLokacija.Name = "lblLokacija";
            lblLokacija.Size = new Size(99, 15);
            lblLokacija.Text = "Lokacija";
            lblLokacija.TextAlign = ContentAlignment.MiddleLeft;

            unosProizvodjac.BackColor = Color.White;
            unosProizvodjac.BorderStyle = BorderStyle.FixedSingle;
            unosProizvodjac.Location = new Point(140, 50);
            unosProizvodjac.Name = "unosProizvodjac";
            unosProizvodjac.Size = new Size(146, 23);

            izborStatus.BackColor = Color.White;
            izborStatus.FlatStyle = FlatStyle.Flat;
            izborStatus.FormattingEnabled = true;
            izborStatus.Location = new Point(140, 78);
            izborStatus.Name = "izborStatus";
            izborStatus.Size = new Size(147, 23);

            unosReg.BackColor = Color.White;
            unosReg.BorderStyle = BorderStyle.FixedSingle;
            unosReg.Location = new Point(140, 22);
            unosReg.Name = "unosReg";
            unosReg.Size = new Size(146, 23);

            dugmeReset.Location = new Point(124, 183);
            dugmeReset.Name = "dugmeReset";
            dugmeReset.Size = new Size(90, 24);
            dugmeReset.Text = "🔄 Reset";
            dugmeReset.UseVisualStyleBackColor = false;
            dugmeReset.Click += buttonRst_Click;

            dugmeOdustani.Location = new Point(220, 183);
            dugmeOdustani.Name = "dugmeOdustani";
            dugmeOdustani.Size = new Size(82, 24);
            dugmeOdustani.Text = "❌ Odustani";
            dugmeOdustani.UseVisualStyleBackColor = false;
            dugmeOdustani.Click += buttonCnc_Click;

            dugmeSacuvaj.Location = new Point(36, 183);
            dugmeSacuvaj.Name = "dugmeSacuvaj";
            dugmeSacuvaj.Size = new Size(82, 24);
            dugmeSacuvaj.Text = "💾 Sačuvaj";
            dugmeSacuvaj.UseVisualStyleBackColor = false;
            dugmeSacuvaj.Click += buttonSv_Click;

            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.Location = new Point(36, 84);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(99, 15);
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            lblProizvodjac.Font = new Font("Segoe UI", 9.5F);
            lblProizvodjac.Location = new Point(36, 56);
            lblProizvodjac.Name = "lblProizvodjac";
            lblProizvodjac.Size = new Size(99, 15);
            lblProizvodjac.Text = "Proizvođač";
            lblProizvodjac.TextAlign = ContentAlignment.MiddleLeft;

            lblReg.Font = new Font("Segoe UI", 9.5F);
            lblReg.Location = new Point(36, 22);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(99, 23);
            lblReg.Text = "Reg. oznaka:";
            lblReg.TextAlign = ContentAlignment.MiddleLeft;

            ClientSize = new Size(315, 239);
            Controls.Add(unosLokacija);
            Controls.Add(lblLokacija);
            Controls.Add(unosProizvodjac);
            Controls.Add(izborStatus);
            Controls.Add(unosReg);
            Controls.Add(dugmeReset);
            Controls.Add(dugmeOdustani);
            Controls.Add(dugmeSacuvaj);
            Controls.Add(lblStatus);
            Controls.Add(lblProizvodjac);
            Controls.Add(lblReg);
            Name = "FormaUpravljajSanitetskim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje sanitetskim vozilom";
            Load += FormaUpravljajSanitetskim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox unosLokacija;
        private Label lblLokacija;
        private TextBox unosProizvodjac;
        private ComboBox izborStatus;
        private TextBox unosReg;
        private Button dugmeReset;
        private Button dugmeOdustani;
        private Button dugmeSacuvaj;
        private Label lblStatus;
        private Label lblProizvodjac;
        private Label lblReg;
    }
}