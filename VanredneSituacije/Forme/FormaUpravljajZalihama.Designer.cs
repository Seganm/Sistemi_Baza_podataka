namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajZalihama
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
            txtSerijski = new TextBox();
            txtNaziv = new TextBox();
            cmbStatus = new ComboBox();
            dtpDatum = new DateTimePicker();
            cmbJedinica = new ComboBox();
            cmbTip = new ComboBox();
            numKolicina = new NumericUpDown();
            btnSacuvaj = new Button();
            btnReset = new Button();
            btnZatvori = new Button();
            lblSerijski = new Label();
            lblNaziv = new Label();
            lblStatus = new Label();
            lblDatum = new Label();
            lblJedinica = new Label();
            lblTip = new Label();
            lblKolicina = new Label();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            SuspendLayout();
            // 
            // lblNaslov
            // 
            lblNaslov.Dock = DockStyle.Top;
            lblNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(20, 40, 80);
            lblNaslov.Location = new Point(0, 0);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(635, 45);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "📦 Upravljanje zalihama";
            lblNaslov.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSerijski
            // 
            txtSerijski.Location = new Point(135, 119);
            txtSerijski.Name = "txtSerijski";
            txtSerijski.Size = new Size(149, 23);
            txtSerijski.TabIndex = 3;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(423, 119);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(149, 23);
            txtNaziv.TabIndex = 5;
            // 
            // cmbStatus
            // 
            cmbStatus.Location = new Point(423, 163);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(149, 23);
            cmbStatus.TabIndex = 7;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(135, 166);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(149, 23);
            dtpDatum.TabIndex = 9;
            // 
            // cmbJedinica
            // 
            cmbJedinica.Location = new Point(135, 213);
            cmbJedinica.Name = "cmbJedinica";
            cmbJedinica.Size = new Size(149, 23);
            cmbJedinica.TabIndex = 11;
            // 
            // cmbTip
            // 
            cmbTip.Location = new Point(423, 213);
            cmbTip.Name = "cmbTip";
            cmbTip.Size = new Size(149, 23);
            cmbTip.TabIndex = 13;
            // 
            // numKolicina
            // 
            numKolicina.Location = new Point(301, 273);
            numKolicina.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(149, 23);
            numKolicina.TabIndex = 15;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.SteelBlue;
            btnSacuvaj.FlatStyle = FlatStyle.Popup;
            btnSacuvaj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(117, 341);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(96, 26);
            btnSacuvaj.TabIndex = 16;
            btnSacuvaj.Text = "💾 Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightSteelBlue;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(277, 341);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 26);
            btnReset.TabIndex = 17;
            btnReset.Text = "🔄 Očisti";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnZatvori
            // 
            btnZatvori.BackColor = Color.LightCoral;
            btnZatvori.FlatStyle = FlatStyle.Popup;
            btnZatvori.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnZatvori.ForeColor = Color.White;
            btnZatvori.Location = new Point(442, 341);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(96, 26);
            btnZatvori.TabIndex = 18;
            btnZatvori.Text = "❌ Izlaz";
            btnZatvori.UseVisualStyleBackColor = false;
            btnZatvori.Click += btnZatvori_Click;
            // 
            // lblSerijski
            // 
            lblSerijski.Location = new Point(41, 119);
            lblSerijski.Name = "lblSerijski";
            lblSerijski.Size = new Size(88, 17);
            lblSerijski.TabIndex = 2;
            lblSerijski.Text = "Broj serije:";
            // 
            // lblNaziv
            // 
            lblNaziv.Location = new Point(329, 119);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(88, 17);
            lblNaziv.TabIndex = 4;
            lblNaziv.Text = "Naziv stavke:";
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(329, 169);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 17);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Trenutno stanje:";
            // 
            // lblDatum
            // 
            lblDatum.Location = new Point(41, 169);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(88, 17);
            lblDatum.TabIndex = 8;
            lblDatum.Text = "Datum nabavke:";
            // 
            // lblJedinica
            // 
            lblJedinica.Location = new Point(41, 219);
            lblJedinica.Name = "lblJedinica";
            lblJedinica.Size = new Size(88, 17);
            lblJedinica.TabIndex = 10;
            lblJedinica.Text = "Tip jedinice:";
            // 
            // lblTip
            // 
            lblTip.Location = new Point(329, 213);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(88, 17);
            lblTip.TabIndex = 12;
            lblTip.Text = "Kategorija:";
            // 
            // lblKolicina
            // 
            lblKolicina.Location = new Point(207, 279);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(88, 17);
            lblKolicina.TabIndex = 14;
            lblKolicina.Text = "Količina:";
            // 
            // FormaUpravljajZalihama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(635, 523);
            Controls.Add(lblNaslov);
            Controls.Add(lblSerijski);
            Controls.Add(txtSerijski);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblDatum);
            Controls.Add(dtpDatum);
            Controls.Add(lblJedinica);
            Controls.Add(cmbJedinica);
            Controls.Add(lblTip);
            Controls.Add(cmbTip);
            Controls.Add(lblKolicina);
            Controls.Add(numKolicina);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnReset);
            Controls.Add(btnZatvori);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaUpravljajZalihama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje zalihama";
            Load += FormaUpravljajZalihama_Load;
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNaslov;
        private Label lblSerijski, lblNaziv, lblStatus, lblDatum, lblJedinica, lblTip, lblKolicina;
        private TextBox txtSerijski, txtNaziv;
        private ComboBox cmbStatus, cmbJedinica, cmbTip;
        private DateTimePicker dtpDatum;
        private NumericUpDown numKolicina;
        private Button btnSacuvaj, btnReset, btnZatvori;
    }
}