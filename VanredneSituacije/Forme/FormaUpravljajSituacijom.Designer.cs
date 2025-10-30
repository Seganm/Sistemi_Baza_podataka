namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSituacijom
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
            cmbNivoOpasnosti = new ComboBox();
            txtOpis = new TextBox();
            txtLokacija = new TextBox();
            txtOpstina = new TextBox();
            dtpDatumDo = new DateTimePicker();
            txtTipSituacije = new TextBox();
            btnReset = new Button();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            lblPrijava = new Label();
            lblOpis = new Label();
            lblLokacija = new Label();
            lblOpstina = new Label();
            lblNivoOpasnosti = new Label();
            lblBrojUgrozenih = new Label();
            lblDatumOd = new Label();
            lblDatumDo = new Label();
            lblTip = new Label();
            dtpDatumOd = new DateTimePicker();
            cmbPrijave = new ComboBox();
            numBrojUgrozenih = new NumericUpDown();
            lblNaslov = new Label();
            ((System.ComponentModel.ISupportInitialize)numBrojUgrozenih).BeginInit();
            SuspendLayout();

            cmbNivoOpasnosti.BackColor = Color.White;
            cmbNivoOpasnosti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivoOpasnosti.FlatStyle = FlatStyle.Flat;
            cmbNivoOpasnosti.Font = new Font("Segoe UI", 9.75F);
            cmbNivoOpasnosti.Items.AddRange(new object[] { "nizak", "srednji", "visok" });
            cmbNivoOpasnosti.Location = new Point(170, 176);
            cmbNivoOpasnosti.Size = new Size(147, 25);

            txtOpis.BackColor = Color.White;
            txtOpis.BorderStyle = BorderStyle.FixedSingle;
            txtOpis.Font = new Font("Segoe UI", 9.75F);
            txtOpis.Location = new Point(170, 270);
            txtOpis.Multiline = true;
            txtOpis.Size = new Size(147, 68);

            txtLokacija.BackColor = Color.White;
            txtLokacija.BorderStyle = BorderStyle.FixedSingle;
            txtLokacija.Font = new Font("Segoe UI", 9.75F);
            txtLokacija.Location = new Point(170, 242);
            txtLokacija.Size = new Size(147, 25);

            txtOpstina.BackColor = Color.White;
            txtOpstina.BorderStyle = BorderStyle.FixedSingle;
            txtOpstina.Font = new Font("Segoe UI", 9.75F);
            txtOpstina.Location = new Point(170, 208);
            txtOpstina.Size = new Size(147, 25);

            dtpDatumDo.Font = new Font("Segoe UI", 9.75F);
            dtpDatumDo.Location = new Point(170, 90);
            dtpDatumDo.Size = new Size(147, 25);

            txtTipSituacije.BackColor = Color.White;
            txtTipSituacije.BorderStyle = BorderStyle.FixedSingle;
            txtTipSituacije.Font = new Font("Segoe UI", 9.75F);
            txtTipSituacije.Location = new Point(170, 120);
            txtTipSituacije.Size = new Size(147, 25);

            btnReset.BackColor = Color.FromArgb(255, 224, 130);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.Location = new Point(139, 386);
            btnReset.Size = new Size(90, 28);
            btnReset.Text = "🔄 Resetuj";
            btnReset.Click += btnReset_Click;

            btnOdustani.BackColor = Color.FromArgb(239, 83, 80);
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(235, 386);
            btnOdustani.Size = new Size(82, 30);
            btnOdustani.Text = "❌ Odustani";
            btnOdustani.Click += btnOdustani_Click;

            btnSacuvaj.BackColor = Color.FromArgb(76, 175, 80);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(55, 386);
            btnSacuvaj.Size = new Size(82, 30);
            btnSacuvaj.Text = "💾 Sačuvaj";
            btnSacuvaj.Click += btnSacuvaj_Click;

            lblPrijava.Text = "Prijava:";
            lblPrijava.Location = new Point(66, 352);

            lblOpis.Text = "Opis:";
            lblOpis.Location = new Point(66, 270);

            lblLokacija.Text = "Lokacija:";
            lblLokacija.Location = new Point(66, 242);

            lblOpstina.Text = "Opština:";
            lblOpstina.Location = new Point(66, 210);

            lblNivoOpasnosti.Text = "Nivo opasnosti:";
            lblNivoOpasnosti.Location = new Point(66, 182);

            lblBrojUgrozenih.Text = "Broj ugroženih:";
            lblBrojUgrozenih.Location = new Point(64, 151);

            lblDatumOd.Text = "Datum od:";
            lblDatumOd.Location = new Point(66, 66);

            lblDatumDo.Text = "Datum do:";
            lblDatumDo.Location = new Point(66, 94);

            lblTip.Text = "Tip:";
            lblTip.Location = new Point(66, 125);

            dtpDatumOd.Font = new Font("Segoe UI", 9.75F);
            dtpDatumOd.Location = new Point(170, 61);
            dtpDatumOd.Size = new Size(147, 25);

            cmbPrijave.FlatStyle = FlatStyle.Flat;
            cmbPrijave.Font = new Font("Segoe UI", 9.75F);
            cmbPrijave.Location = new Point(170, 352);
            cmbPrijave.Size = new Size(147, 25);

            numBrojUgrozenih.Font = new Font("Segoe UI", 9.75F);
            numBrojUgrozenih.Location = new Point(170, 149);
            numBrojUgrozenih.Size = new Size(147, 25);

            lblNaslov.BackColor = Color.FromArgb(224, 224, 224);
            lblNaslov.Dock = DockStyle.Top;
            lblNaslov.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(33, 33, 33);
            lblNaslov.Size = new Size(429, 37);
            lblNaslov.Text = "UPRAVLJANJE VANREDNOM SITUACIJOM";
            lblNaslov.TextAlign = ContentAlignment.MiddleCenter;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(429, 493);
            Controls.AddRange(new Control[]
            {
                lblNaslov, numBrojUgrozenih, cmbPrijave, dtpDatumOd,
                cmbNivoOpasnosti, txtOpis, txtLokacija, txtOpstina,
                dtpDatumDo, txtTipSituacije, btnReset, btnOdustani,
                btnSacuvaj, lblPrijava, lblOpis, lblLokacija, lblOpstina,
                lblNivoOpasnosti, lblBrojUgrozenih, lblDatumOd, lblDatumDo, lblTip
            });
            Name = "FormaUpravljajSituacijom";
            Text = "Upravljanje vanrednom situacijom";
            Load += FormaUpravljajVanrednomSituacijom_Load;
            ((System.ComponentModel.ISupportInitialize)numBrojUgrozenih).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cmbNivoOpasnosti, cmbPrijave;
        private TextBox txtOpis, txtLokacija, txtOpstina, txtTipSituacije;
        private DateTimePicker dtpDatumOd, dtpDatumDo;
        private Button btnSacuvaj, btnReset, btnOdustani;
        private NumericUpDown numBrojUgrozenih;
        private Label lblNaslov, lblPrijava, lblOpis, lblLokacija, lblOpstina, lblNivoOpasnosti, lblBrojUgrozenih, lblDatumOd, lblDatumDo, lblTip;
    }
}