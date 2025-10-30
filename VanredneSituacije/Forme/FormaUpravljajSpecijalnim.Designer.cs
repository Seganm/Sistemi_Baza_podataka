namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSpecijalnim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNaslovForme = new Label();
            lblRegistarskaOznaka = new Label();
            lblProizvodjac = new Label();
            lblLokacija = new Label();
            lblStatusVozila = new Label();
            lblNamenaVozila = new Label();

            txtRegistarskaOznaka = new TextBox();
            txtProizvodjac = new TextBox();
            txtLokacija = new TextBox();
            cmbStatusVozila = new ComboBox();
            cmbNamenaVozila = new ComboBox();

            btnSacuvajPodatke = new Button();
            btnResetujPolja = new Button();
            btnZatvoriFormu = new Button();

            SuspendLayout();

            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(420, 400);
            Font = new Font("Segoe UI", 10);
            Text = "Upravljanje Specijalnim Vozilom";
            StartPosition = FormStartPosition.CenterScreen;

            lblNaslovForme.Text = "Specijalno Vozilo - Podaci";
            lblNaslovForme.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblNaslovForme.ForeColor = Color.FromArgb(40, 40, 70);
            lblNaslovForme.Location = new Point(70, 20);
            lblNaslovForme.Size = new Size(300, 30);
            lblNaslovForme.TextAlign = ContentAlignment.MiddleCenter;

            lblRegistarskaOznaka.Text = "Registarska oznaka:";
            lblRegistarskaOznaka.Location = new Point(40, 70);
            lblRegistarskaOznaka.Size = new Size(150, 25);

            txtRegistarskaOznaka.Location = new Point(210, 68);
            txtRegistarskaOznaka.Size = new Size(170, 27);
            txtRegistarskaOznaka.BorderStyle = BorderStyle.FixedSingle;

            lblProizvodjac.Text = "Proizvođač:";
            lblProizvodjac.Location = new Point(40, 110);
            lblProizvodjac.Size = new Size(150, 25);

            txtProizvodjac.Location = new Point(210, 108);
            txtProizvodjac.Size = new Size(170, 27);
            txtProizvodjac.BorderStyle = BorderStyle.FixedSingle;

            lblLokacija.Text = "Lokacija:";
            lblLokacija.Location = new Point(40, 150);
            lblLokacija.Size = new Size(150, 25);

            txtLokacija.Location = new Point(210, 148);
            txtLokacija.Size = new Size(170, 27);
            txtLokacija.BorderStyle = BorderStyle.FixedSingle;

            lblStatusVozila.Text = "Status vozila:";
            lblStatusVozila.Location = new Point(40, 190);
            lblStatusVozila.Size = new Size(150, 25);

            cmbStatusVozila.Location = new Point(210, 188);
            cmbStatusVozila.Size = new Size(170, 28);
            cmbStatusVozila.DropDownStyle = ComboBoxStyle.DropDownList;

            lblNamenaVozila.Text = "Namena:";
            lblNamenaVozila.Location = new Point(40, 230);
            lblNamenaVozila.Size = new Size(150, 25);

            cmbNamenaVozila.Location = new Point(210, 228);
            cmbNamenaVozila.Size = new Size(170, 28);
            cmbNamenaVozila.DropDownStyle = ComboBoxStyle.DropDownList;

            btnSacuvajPodatke.Text = "💾 Sačuvaj";
            btnSacuvajPodatke.BackColor = Color.FromArgb(72, 156, 86);
            btnSacuvajPodatke.ForeColor = Color.White;
            btnSacuvajPodatke.FlatStyle = FlatStyle.Flat;
            btnSacuvajPodatke.Location = new Point(40, 300);
            btnSacuvajPodatke.Size = new Size(100, 35);
            btnSacuvajPodatke.Click += btnSacuvajPodatke_Click;

            btnResetujPolja.Text = "↺ Resetuj";
            btnResetujPolja.BackColor = Color.FromArgb(255, 196, 66);
            btnResetujPolja.FlatStyle = FlatStyle.Flat;
            btnResetujPolja.Location = new Point(160, 300);
            btnResetujPolja.Size = new Size(100, 35);
            btnResetujPolja.Click += btnResetujPolja_Click;

            btnZatvoriFormu.Text = "✖ Zatvori";
            btnZatvoriFormu.BackColor = Color.FromArgb(200, 60, 60);
            btnZatvoriFormu.ForeColor = Color.White;
            btnZatvoriFormu.FlatStyle = FlatStyle.Flat;
            btnZatvoriFormu.Location = new Point(280, 300);
            btnZatvoriFormu.Size = new Size(100, 35);
            btnZatvoriFormu.Click += btnZatvoriFormu_Click;

            Controls.AddRange(new Control[]
            {
                lblNaslovForme,
                lblRegistarskaOznaka, txtRegistarskaOznaka,
                lblProizvodjac, txtProizvodjac,
                lblLokacija, txtLokacija,
                lblStatusVozila, cmbStatusVozila,
                lblNamenaVozila, cmbNamenaVozila,
                btnSacuvajPodatke, btnResetujPolja, btnZatvoriFormu
            });

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNaslovForme, lblRegistarskaOznaka, lblProizvodjac, lblLokacija, lblStatusVozila, lblNamenaVozila;
        private TextBox txtRegistarskaOznaka, txtProizvodjac, txtLokacija;
        private ComboBox cmbStatusVozila, cmbNamenaVozila;
        private Button btnSacuvajPodatke, btnResetujPolja, btnZatvoriFormu;
    }
}