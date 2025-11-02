namespace VanredneSituacije.Forme
{
    partial class FormaVoziloDodaj
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
            lblNaslov = new Label();
            btnSanitetsko = new Button();
            btnSpecijalnoVozilo = new Button();
            btnDzipVozilo = new Button();
            btnKamionVozilo = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            lblNaslov.Dock = DockStyle.Top;
            lblNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(30, 60, 120);
            lblNaslov.Location = new Point(0, 0);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(1030, 70);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Izaberite vrstu vozila";
            lblNaslov.TextAlign = ContentAlignment.MiddleCenter;

            btnSanitetsko.BackColor = Color.LightSteelBlue;
            btnSanitetsko.FlatStyle = FlatStyle.Popup;
            btnSanitetsko.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSanitetsko.ForeColor = Color.Black;
            btnSanitetsko.Location = new Point(206, 220);
            btnSanitetsko.Name = "btnSanitetsko";
            btnSanitetsko.Size = new Size(240, 40);
            btnSanitetsko.TabIndex = 1;
            btnSanitetsko.Text = "Sanitetsko vozilo";
            btnSanitetsko.UseVisualStyleBackColor = false;
            btnSanitetsko.Click += btnSanitetsko_Click;

            btnSpecijalnoVozilo.BackColor = Color.LightSkyBlue;
            btnSpecijalnoVozilo.FlatStyle = FlatStyle.Popup;
            btnSpecijalnoVozilo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSpecijalnoVozilo.ForeColor = Color.Black;
            btnSpecijalnoVozilo.Location = new Point(206, 133);
            btnSpecijalnoVozilo.Name = "btnSpecijalnoVozilo";
            btnSpecijalnoVozilo.Size = new Size(240, 40);
            btnSpecijalnoVozilo.TabIndex = 2;
            btnSpecijalnoVozilo.Text = "Specijalno vozilo";
            btnSpecijalnoVozilo.UseVisualStyleBackColor = false;
            btnSpecijalnoVozilo.Click += btnSpecijalnoVozilo_Click;

            btnDzipVozilo.BackColor = Color.LightBlue;
            btnDzipVozilo.FlatStyle = FlatStyle.Popup;
            btnDzipVozilo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDzipVozilo.ForeColor = Color.Black;
            btnDzipVozilo.Location = new Point(560, 133);
            btnDzipVozilo.Name = "btnDzipVozilo";
            btnDzipVozilo.Size = new Size(240, 40);
            btnDzipVozilo.TabIndex = 3;
            btnDzipVozilo.Text = "Terensko vozilo";
            btnDzipVozilo.UseVisualStyleBackColor = false;
            btnDzipVozilo.Click += btnDzipVozilo_Click;

            btnKamionVozilo.BackColor = Color.LightCyan;
            btnKamionVozilo.FlatStyle = FlatStyle.Popup;
            btnKamionVozilo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKamionVozilo.ForeColor = Color.Black;
            btnKamionVozilo.Location = new Point(560, 220);
            btnKamionVozilo.Name = "btnKamionVozilo";
            btnKamionVozilo.Size = new Size(240, 40);
            btnKamionVozilo.TabIndex = 4;
            btnKamionVozilo.Text = "Kamion";
            btnKamionVozilo.UseVisualStyleBackColor = false;
            btnKamionVozilo.Click += btnKamionVozilo_Click;

            btnOdustani.BackColor = Color.LightCoral;
            btnOdustani.FlatStyle = FlatStyle.Popup;
            btnOdustani.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(379, 341);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(240, 40);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Zatvori formu";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1030, 447);
            Controls.Add(lblNaslov);
            Controls.Add(btnSanitetsko);
            Controls.Add(btnSpecijalnoVozilo);
            Controls.Add(btnDzipVozilo);
            Controls.Add(btnKamionVozilo);
            Controls.Add(btnOdustani);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaVoziloDodaj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodavanje vozila";
            Load += FormaVoziloDodaj_Load;
            ResumeLayout(false);
        }

        private Label lblNaslov;
        private Button btnSanitetsko;
        private Button btnSpecijalnoVozilo;
        private Button btnDzipVozilo;
        private Button btnKamionVozilo;
        private Button btnOdustani;
        private Panel pozadinskiPanel;
    }
}