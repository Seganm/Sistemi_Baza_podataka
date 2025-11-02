namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajTehnickom
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
            txtSerijskiBroj = new TextBox();
            txtNazivOpreme = new TextBox();
            cmbStatus = new ComboBox();
            dpDatumNabavke = new DateTimePicker();
            cmbJedinica = new ComboBox();
            cmbTipOpreme = new ComboBox();
            lblSerijskiBroj = new Label();
            lblNazivOpreme = new Label();
            lblStatus = new Label();
            lblDatumNabavke = new Label();
            lblJedinica = new Label();
            lblTipOpreme = new Label();
            btnSnimi = new Button();
            btnResetuj = new Button();
            btnZatvoriFormu = new Button();
            SuspendLayout();

            txtSerijskiBroj.BackColor = Color.White;
            txtSerijskiBroj.BorderStyle = BorderStyle.FixedSingle;
            txtSerijskiBroj.Font = new Font("Segoe UI", 10.5F);
            txtSerijskiBroj.ForeColor = Color.FromArgb(25, 25, 25);
            txtSerijskiBroj.Location = new Point(183, 41);
            txtSerijskiBroj.Name = "txtSerijskiBroj";
            txtSerijskiBroj.Size = new Size(175, 26);
            txtSerijskiBroj.TabIndex = 0;

            txtNazivOpreme.BackColor = Color.White;
            txtNazivOpreme.BorderStyle = BorderStyle.FixedSingle;
            txtNazivOpreme.Font = new Font("Segoe UI", 10.5F);
            txtNazivOpreme.Location = new Point(575, 41);
            txtNazivOpreme.Name = "txtNazivOpreme";
            txtNazivOpreme.Size = new Size(175, 26);
            txtNazivOpreme.TabIndex = 1;

            cmbStatus.BackColor = Color.WhiteSmoke;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.Location = new Point(183, 111);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(176, 25);
            cmbStatus.TabIndex = 2;

            dpDatumNabavke.Font = new Font("Segoe UI", 10F);
            dpDatumNabavke.Format = DateTimePickerFormat.Short;
            dpDatumNabavke.Location = new Point(574, 115);
            dpDatumNabavke.Name = "dpDatumNabavke";
            dpDatumNabavke.Size = new Size(176, 25);
            dpDatumNabavke.TabIndex = 3;

            cmbJedinica.FlatStyle = FlatStyle.Popup;
            cmbJedinica.Font = new Font("Segoe UI", 10F);
            cmbJedinica.Location = new Point(182, 172);
            cmbJedinica.Name = "cmbJedinica";
            cmbJedinica.Size = new Size(176, 25);
            cmbJedinica.TabIndex = 4;

            cmbTipOpreme.FlatStyle = FlatStyle.Popup;
            cmbTipOpreme.Font = new Font("Segoe UI", 10F);
            cmbTipOpreme.Location = new Point(574, 177);
            cmbTipOpreme.Name = "cmbTipOpreme";
            cmbTipOpreme.Size = new Size(176, 25);
            cmbTipOpreme.TabIndex = 5;

            lblSerijskiBroj.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSerijskiBroj.ForeColor = Color.FromArgb(50, 70, 110);
            lblSerijskiBroj.Location = new Point(78, 45);
            lblSerijskiBroj.Name = "lblSerijskiBroj";
            lblSerijskiBroj.Size = new Size(88, 20);
            lblSerijskiBroj.Text = "Serijski broj:";

            lblNazivOpreme.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblNazivOpreme.ForeColor = Color.FromArgb(50, 70, 110);
            lblNazivOpreme.Location = new Point(470, 45);
            lblNazivOpreme.Name = "lblNazivOpreme";
            lblNazivOpreme.Size = new Size(120, 20);
            lblNazivOpreme.Text = "Naziv opreme:";

            lblStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(50, 70, 110);
            lblStatus.Location = new Point(78, 115);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 20);
            lblStatus.Text = "Status:";

            lblDatumNabavke.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDatumNabavke.ForeColor = Color.FromArgb(50, 70, 110);
            lblDatumNabavke.Location = new Point(469, 119);
            lblDatumNabavke.Name = "lblDatumNabavke";
            lblDatumNabavke.Size = new Size(120, 20);
            lblDatumNabavke.Text = "Datum nabavke:";

            lblJedinica.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblJedinica.ForeColor = Color.FromArgb(50, 70, 110);
            lblJedinica.Location = new Point(77, 177);
            lblJedinica.Name = "lblJedinica";
            lblJedinica.Size = new Size(88, 20);
            lblJedinica.Text = "Jedinica:";

            lblTipOpreme.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTipOpreme.ForeColor = Color.FromArgb(50, 70, 110);
            lblTipOpreme.Location = new Point(469, 181);
            lblTipOpreme.Name = "lblTipOpreme";
            lblTipOpreme.Size = new Size(88, 20);
            lblTipOpreme.Text = "Tip opreme:";

            btnSnimi.BackColor = Color.FromArgb(190, 255, 190);
            btnSnimi.FlatStyle = FlatStyle.Flat;
            btnSnimi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSnimi.Location = new Point(142, 310);
            btnSnimi.Name = "btnSnimi";
            btnSnimi.Size = new Size(128, 45);
            btnSnimi.Text = "Sačuvaj podatke";
            btnSnimi.UseVisualStyleBackColor = false;
            btnSnimi.Click += btnSacuvaj_Click;

            btnResetuj.BackColor = Color.FromArgb(255, 245, 190);
            btnResetuj.FlatStyle = FlatStyle.Flat;
            btnResetuj.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnResetuj.Location = new Point(344, 310);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(120, 45);
            btnResetuj.Text = "Očisti polja";
            btnResetuj.UseVisualStyleBackColor = false;
            btnResetuj.Click += btnReset_Click;

            btnZatvoriFormu.BackColor = Color.FromArgb(255, 200, 200);
            btnZatvoriFormu.FlatStyle = FlatStyle.Flat;
            btnZatvoriFormu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnZatvoriFormu.Location = new Point(545, 310);
            btnZatvoriFormu.Name = "btnZatvoriFormu";
            btnZatvoriFormu.Size = new Size(137, 45);
            btnZatvoriFormu.Text = "Zatvori formu";
            btnZatvoriFormu.UseVisualStyleBackColor = false;
            btnZatvoriFormu.Click += btnZatvori_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 247);
            ClientSize = new Size(797, 476);
            Controls.Add(txtSerijskiBroj);
            Controls.Add(txtNazivOpreme);
            Controls.Add(cmbStatus);
            Controls.Add(dpDatumNabavke);
            Controls.Add(cmbJedinica);
            Controls.Add(cmbTipOpreme);
            Controls.Add(lblSerijskiBroj);
            Controls.Add(lblNazivOpreme);
            Controls.Add(lblStatus);
            Controls.Add(lblDatumNabavke);
            Controls.Add(lblJedinica);
            Controls.Add(lblTipOpreme);
            Controls.Add(btnSnimi);
            Controls.Add(btnResetuj);
            Controls.Add(btnZatvoriFormu);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(35, 35, 35);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaUpravljajTehnickom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje tehničkom opremom";
            Load += FormaUpravljajTehnickom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtSerijskiBroj;
        private TextBox txtNazivOpreme;
        private ComboBox cmbStatus;
        private DateTimePicker dpDatumNabavke;
        private ComboBox cmbJedinica;
        private ComboBox cmbTipOpreme;
        private Label lblSerijskiBroj;
        private Label lblNazivOpreme;
        private Label lblStatus;
        private Label lblDatumNabavke;
        private Label lblJedinica;
        private Label lblTipOpreme;
        private Button btnSnimi;
        private Button btnResetuj;
        private Button btnZatvoriFormu;
    }
}