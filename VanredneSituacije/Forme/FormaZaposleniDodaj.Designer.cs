namespace VanredneSituacije.Forme
{
    partial class FormaZaposleniDodaj
    {
        private System.ComponentModel.IContainer komponente = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (komponente != null))
                komponente.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNaslov = new Label();
            btnOperativni = new Button();
            btnKoordinator = new Button();
            btnAnaliticar = new Button();
            btnZatvori = new Button();
            SuspendLayout();

            lblNaslov.Dock = DockStyle.Top;
            lblNaslov.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(30, 60, 120);
            lblNaslov.Location = new Point(0, 0);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(358, 60);
            lblNaslov.TabIndex = 1;
            lblNaslov.Text = "Izaberite tip zaposlenog";
            lblNaslov.TextAlign = ContentAlignment.MiddleCenter;

            btnOperativni.BackColor = Color.LightSteelBlue;
            btnOperativni.FlatStyle = FlatStyle.Popup;
            btnOperativni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOperativni.ForeColor = Color.Black;
            btnOperativni.Location = new Point(45, 75);
            btnOperativni.Name = "btnOperativni";
            btnOperativni.Size = new Size(250, 35);
            btnOperativni.TabIndex = 2;
            btnOperativni.Text = "👷 Operativni radnik";
            btnOperativni.UseVisualStyleBackColor = false;
            btnOperativni.Click += btnOperativni_Click;

            btnKoordinator.BackColor = Color.LightSkyBlue;
            btnKoordinator.FlatStyle = FlatStyle.Popup;
            btnKoordinator.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKoordinator.ForeColor = Color.Black;
            btnKoordinator.Location = new Point(45, 125);
            btnKoordinator.Name = "btnKoordinator";
            btnKoordinator.Size = new Size(250, 35);
            btnKoordinator.TabIndex = 3;
            btnKoordinator.Text = "🧭 Koordinator";
            btnKoordinator.UseVisualStyleBackColor = false;
            btnKoordinator.Click += btnKoordinator_Click;

            btnAnaliticar.BackColor = Color.LightBlue;
            btnAnaliticar.FlatStyle = FlatStyle.Popup;
            btnAnaliticar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnaliticar.ForeColor = Color.Black;
            btnAnaliticar.Location = new Point(45, 175);
            btnAnaliticar.Name = "btnAnaliticar";
            btnAnaliticar.Size = new Size(250, 35);
            btnAnaliticar.TabIndex = 4;
            btnAnaliticar.Text = "📊 Analitičar";
            btnAnaliticar.UseVisualStyleBackColor = false;
            btnAnaliticar.Click += btnAnaliticar_Click;

            btnZatvori.BackColor = Color.LightCoral;
            btnZatvori.FlatStyle = FlatStyle.Popup;
            btnZatvori.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZatvori.ForeColor = Color.White;
            btnZatvori.Location = new Point(45, 225);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(250, 35);
            btnZatvori.TabIndex = 5;
            btnZatvori.Text = "❌ Zatvori";
            btnZatvori.UseVisualStyleBackColor = false;
            btnZatvori.Click += btnZatvori_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(358, 310);
            Controls.Add(lblNaslov);
            Controls.Add(btnOperativni);
            Controls.Add(btnKoordinator);
            Controls.Add(btnAnaliticar);
            Controls.Add(btnZatvori);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaZaposleniDodaj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodavanje zaposlenog";
            Load += FormaZaposleniDodaj_Load;
            ResumeLayout(false);
        }

        private Label lblNaslov;
        private Button btnOperativni;
        private Button btnKoordinator;
        private Button btnAnaliticar;
        private Button btnZatvori;
    }
}