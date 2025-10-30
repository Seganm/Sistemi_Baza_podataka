namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSaradjivanjem
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
            labelNaslov = new Label();
            lblSluzba = new Label();
            lblVanrednaSituacija = new Label();
            lblUloga = new Label();
            txtUloga = new TextBox();
            cmbSluzba = new ComboBox();
            cmbVanrednaSituacija = new ComboBox();
            btnSave = new Button();
            btnReset = new Button();
            btnCancel = new Button();
            SuspendLayout();

            labelNaslov.BackColor = Color.FromArgb(63, 81, 181);
            labelNaslov.Dock = DockStyle.Top;
            labelNaslov.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNaslov.ForeColor = Color.White;
            labelNaslov.Text = "UPRAVLJANJE SARADNJOM";
            labelNaslov.TextAlign = ContentAlignment.MiddleCenter;
            labelNaslov.Size = new Size(472, 38);

            lblSluzba.Text = "Služba:";
            lblSluzba.Font = new Font("Segoe UI", 9.5F);
            lblSluzba.Location = new Point(106, 71);

            lblUloga.Text = "Uloga:";
            lblUloga.Font = new Font("Segoe UI", 9.5F);
            lblUloga.Location = new Point(106, 102);

            lblVanrednaSituacija.Text = "Vanredna situacija:";
            lblVanrednaSituacija.Font = new Font("Segoe UI", 9.5F);
            lblVanrednaSituacija.Location = new Point(86, 132);

            txtUloga.Font = new Font("Segoe UI", 9.75F);
            txtUloga.Location = new Point(206, 99);
            txtUloga.Size = new Size(145, 25);
            txtUloga.BorderStyle = BorderStyle.FixedSingle;
            txtUloga.BackColor = Color.White;

            cmbSluzba.Font = new Font("Segoe UI", 9.75F);
            cmbSluzba.Location = new Point(206, 69);
            cmbSluzba.Size = new Size(145, 25);
            cmbSluzba.BackColor = Color.White;
            cmbSluzba.FlatStyle = FlatStyle.Flat;

            cmbVanrednaSituacija.Font = new Font("Segoe UI", 9.75F);
            cmbVanrednaSituacija.Location = new Point(206, 129);
            cmbVanrednaSituacija.Size = new Size(145, 25);
            cmbVanrednaSituacija.BackColor = Color.White;
            cmbVanrednaSituacija.FlatStyle = FlatStyle.Flat;

            btnSave.Text = "💾 Sačuvaj";
            btnSave.BackColor = Color.FromArgb(76, 175, 80);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(86, 189);
            btnSave.Size = new Size(84, 30);
            btnSave.Click += btnSave_Click;

            btnReset.Text = "🔄 Reset";
            btnReset.BackColor = Color.FromArgb(255, 213, 79);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(181, 189);
            btnReset.Size = new Size(90, 30);
            btnReset.Click += btnReset_Click;

            btnCancel.Text = "❌ Odustani";
            btnCancel.BackColor = Color.FromArgb(229, 57, 53);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(277, 189);
            btnCancel.Size = new Size(84, 30);
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(472, 296);
            Controls.AddRange(new Control[] {
                labelNaslov, lblSluzba, lblUloga, lblVanrednaSituacija,
                txtUloga, cmbSluzba, cmbVanrednaSituacija,
                btnSave, btnReset, btnCancel
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaUpravljajSaradjivanjem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje saradnjom";
            Load += FormaUpravljajSaradjivanjem_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelNaslov, lblSluzba, lblVanrednaSituacija, lblUloga;
        private TextBox txtUloga;
        private ComboBox cmbSluzba, cmbVanrednaSituacija;
        private Button btnSave, btnReset, btnCancel;
    }
}