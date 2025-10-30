namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSluzbom
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
            lblTipSektora = new Label();
            lblPredstavnik = new Label();

            txtTipSektora = new TextBox();
            cmbPredstavnici = new ComboBox();

            btnSnimi = new Button();
            btnResetuj = new Button();
            btnZatvori = new Button();

            SuspendLayout();

            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(400, 260);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje Službom";

            lblNaslovForme.Text = "Podaci o službi";
            lblNaslovForme.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblNaslovForme.ForeColor = Color.FromArgb(40, 40, 70);
            lblNaslovForme.TextAlign = ContentAlignment.MiddleCenter;
            lblNaslovForme.Location = new Point(50, 20);
            lblNaslovForme.Size = new Size(300, 35);

            lblTipSektora.Text = "Tip sektora:";
            lblTipSektora.Location = new Point(50, 80);
            lblTipSektora.Size = new Size(120, 25);

            txtTipSektora.Location = new Point(180, 78);
            txtTipSektora.Size = new Size(160, 27);
            txtTipSektora.BorderStyle = BorderStyle.FixedSingle;

            lblPredstavnik.Text = "Predstavnik:";
            lblPredstavnik.Location = new Point(50, 120);
            lblPredstavnik.Size = new Size(120, 25);

            cmbPredstavnici.Location = new Point(180, 118);
            cmbPredstavnici.Size = new Size(160, 28);
            cmbPredstavnici.DropDownStyle = ComboBoxStyle.DropDownList;

            btnSnimi.Text = "💾 Sačuvaj";
            btnSnimi.BackColor = Color.FromArgb(72, 156, 86);
            btnSnimi.ForeColor = Color.White;
            btnSnimi.FlatStyle = FlatStyle.Flat;
            btnSnimi.Location = new Point(50, 180);
            btnSnimi.Size = new Size(90, 35);
            btnSnimi.Click += btnSnimi_Click;

            btnResetuj.Text = "↺ Očisti";
            btnResetuj.BackColor = Color.FromArgb(255, 196, 66);
            btnResetuj.FlatStyle = FlatStyle.Flat;
            btnResetuj.Location = new Point(160, 180);
            btnResetuj.Size = new Size(90, 35);
            btnResetuj.Click += btnResetuj_Click;

            btnZatvori.Text = "✖ Zatvori";
            btnZatvori.BackColor = Color.FromArgb(200, 60, 60);
            btnZatvori.ForeColor = Color.White;
            btnZatvori.FlatStyle = FlatStyle.Flat;
            btnZatvori.Location = new Point(270, 180);
            btnZatvori.Size = new Size(90, 35);
            btnZatvori.Click += btnZatvori_Click;

            Controls.AddRange(new Control[]
            {
                lblNaslovForme,
                lblTipSektora, txtTipSektora,
                lblPredstavnik, cmbPredstavnici,
                btnSnimi, btnResetuj, btnZatvori
            });

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNaslovForme, lblTipSektora, lblPredstavnik;
        private TextBox txtTipSektora;
        private ComboBox cmbPredstavnici;
        private Button btnSnimi, btnResetuj, btnZatvori;
    }
}