namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSoftverom
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
            lblAnaliticar = new Label();
            lblSoftver = new Label();

            txtJmbgAnaliticara = new TextBox();
            txtNazivSoftvera = new TextBox();

            btnSacuvaj = new Button();
            btnOcisti = new Button();
            btnIzlaz = new Button();

            SuspendLayout();

            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(370, 240);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje Softverom";

            lblNaslovForme.Text = "Podaci o Softveru";
            lblNaslovForme.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblNaslovForme.ForeColor = Color.FromArgb(40, 40, 70);
            lblNaslovForme.TextAlign = ContentAlignment.MiddleCenter;
            lblNaslovForme.Location = new Point(35, 20);
            lblNaslovForme.Size = new Size(300, 35);

            lblAnaliticar.Text = "JMBG analitičara:";
            lblAnaliticar.Location = new Point(40, 75);
            lblAnaliticar.Size = new Size(140, 25);

            txtJmbgAnaliticara.Location = new Point(185, 73);
            txtJmbgAnaliticara.Size = new Size(140, 27);
            txtJmbgAnaliticara.BorderStyle = BorderStyle.FixedSingle;

            lblSoftver.Text = "Naziv softvera:";
            lblSoftver.Location = new Point(40, 115);
            lblSoftver.Size = new Size(140, 25);

            txtNazivSoftvera.Location = new Point(185, 113);
            txtNazivSoftvera.Size = new Size(140, 27);
            txtNazivSoftvera.BorderStyle = BorderStyle.FixedSingle;

            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.BackColor = Color.FromArgb(72, 156, 86);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Location = new Point(35, 170);
            btnSacuvaj.Size = new Size(90, 35);
            btnSacuvaj.Click += btnSacuvaj_Click;

            btnOcisti.Text = "Očisti";
            btnOcisti.BackColor = Color.FromArgb(255, 196, 66);
            btnOcisti.FlatStyle = FlatStyle.Flat;
            btnOcisti.Location = new Point(140, 170);
            btnOcisti.Size = new Size(90, 35);
            btnOcisti.Click += btnOcisti_Click;

            btnIzlaz.Text = "Zatvori";
            btnIzlaz.BackColor = Color.FromArgb(200, 60, 60);
            btnIzlaz.ForeColor = Color.White;
            btnIzlaz.FlatStyle = FlatStyle.Flat;
            btnIzlaz.Location = new Point(245, 170);
            btnIzlaz.Size = new Size(90, 35);
            btnIzlaz.Click += btnIzlaz_Click;

            Controls.AddRange(new Control[]
            {
                lblNaslovForme,
                lblAnaliticar, txtJmbgAnaliticara,
                lblSoftver, txtNazivSoftvera,
                btnSacuvaj, btnOcisti, btnIzlaz
            });

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNaslovForme, lblAnaliticar, lblSoftver;
        private TextBox txtJmbgAnaliticara, txtNazivSoftvera;
        private Button btnSacuvaj, btnOcisti, btnIzlaz;
    }
}