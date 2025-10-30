namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSpecijalizacijama
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
            lblJmbgKoordinatora = new Label();
            lblOblastSpecijalizacije = new Label();

            txtJmbgKoordinatora = new TextBox();
            txtOblastSpecijalizacije = new TextBox();

            btnSacuvajSpecijalizaciju = new Button();
            btnOcistiPolja = new Button();
            btnZatvoriFormu = new Button();

            SuspendLayout();

            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(380, 260);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje Specijalizacijama";

            lblNaslovForme.Text = "Specijalizacija Koordinatora";
            lblNaslovForme.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblNaslovForme.ForeColor = Color.FromArgb(40, 40, 70);
            lblNaslovForme.TextAlign = ContentAlignment.MiddleCenter;
            lblNaslovForme.Location = new Point(40, 20);
            lblNaslovForme.Size = new Size(300, 35);

            lblJmbgKoordinatora.Text = "JMBG koordinatora:";
            lblJmbgKoordinatora.Location = new Point(40, 75);
            lblJmbgKoordinatora.Size = new Size(150, 25);

            txtJmbgKoordinatora.Location = new Point(200, 72);
            txtJmbgKoordinatora.Size = new Size(140, 27);
            txtJmbgKoordinatora.BorderStyle = BorderStyle.FixedSingle;

            lblOblastSpecijalizacije.Text = "Oblast specijalizacije:";
            lblOblastSpecijalizacije.Location = new Point(40, 115);
            lblOblastSpecijalizacije.Size = new Size(150, 25);

            txtOblastSpecijalizacije.Location = new Point(200, 112);
            txtOblastSpecijalizacije.Size = new Size(140, 27);
            txtOblastSpecijalizacije.BorderStyle = BorderStyle.FixedSingle;

            btnSacuvajSpecijalizaciju.Text = "💾 Sačuvaj";
            btnSacuvajSpecijalizaciju.BackColor = Color.FromArgb(72, 156, 86);
            btnSacuvajSpecijalizaciju.ForeColor = Color.White;
            btnSacuvajSpecijalizaciju.FlatStyle = FlatStyle.Flat;
            btnSacuvajSpecijalizaciju.Location = new Point(40, 180);
            btnSacuvajSpecijalizaciju.Size = new Size(90, 35);
            btnSacuvajSpecijalizaciju.Click += btnSacuvajSpecijalizaciju_Click;

            btnOcistiPolja.Text = "↺ Očisti";
            btnOcistiPolja.BackColor = Color.FromArgb(255, 196, 66);
            btnOcistiPolja.FlatStyle = FlatStyle.Flat;
            btnOcistiPolja.Location = new Point(150, 180);
            btnOcistiPolja.Size = new Size(90, 35);
            btnOcistiPolja.Click += btnOcistiPolja_Click;

            btnZatvoriFormu.Text = "✖ Zatvori";
            btnZatvoriFormu.BackColor = Color.FromArgb(200, 60, 60);
            btnZatvoriFormu.ForeColor = Color.White;
            btnZatvoriFormu.FlatStyle = FlatStyle.Flat;
            btnZatvoriFormu.Location = new Point(260, 180);
            btnZatvoriFormu.Size = new Size(90, 35);
            btnZatvoriFormu.Click += btnZatvoriFormu_Click;

            Controls.AddRange(new Control[]
            {
                lblNaslovForme,
                lblJmbgKoordinatora, txtJmbgKoordinatora,
                lblOblastSpecijalizacije, txtOblastSpecijalizacije,
                btnSacuvajSpecijalizaciju, btnOcistiPolja, btnZatvoriFormu
            });

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNaslovForme, lblJmbgKoordinatora, lblOblastSpecijalizacije;
        private TextBox txtJmbgKoordinatora, txtOblastSpecijalizacije;
        private Button btnSacuvajSpecijalizaciju, btnOcistiPolja, btnZatvoriFormu;
    }
}