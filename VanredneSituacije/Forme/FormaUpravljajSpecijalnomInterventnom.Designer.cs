namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajSpecijalnomInterventnom
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
            txtNaziv = new TextBox();
            txtBaza = new TextBox();
            txtTip = new TextBox();
            cmbKomandir = new ComboBox();
            lblNaziv = new Label();
            lblBaza = new Label();
            lblTip = new Label();
            lblKomandir = new Label();
            btnSacuvaj = new Button();
            btnResetuj = new Button();
            btnZatvori = new Button();
            SuspendLayout();

            txtNaziv.BackColor = Color.White;
            txtNaziv.BorderStyle = BorderStyle.FixedSingle;
            txtNaziv.Font = new Font("Segoe UI", 10.2F);
            txtNaziv.Location = new Point(160, 30);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(185, 26);
            txtNaziv.TabIndex = 0;

            txtBaza.BackColor = Color.White;
            txtBaza.BorderStyle = BorderStyle.FixedSingle;
            txtBaza.Font = new Font("Segoe UI", 10.2F);
            txtBaza.Location = new Point(502, 30);
            txtBaza.Name = "txtBaza";
            txtBaza.Size = new Size(185, 26);
            txtBaza.TabIndex = 1;

            txtTip.BackColor = Color.White;
            txtTip.BorderStyle = BorderStyle.FixedSingle;
            txtTip.Font = new Font("Segoe UI", 10.2F);
            txtTip.Location = new Point(502, 97);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(185, 26);
            txtTip.TabIndex = 3;

            cmbKomandir.BackColor = Color.White;
            cmbKomandir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKomandir.Font = new Font("Segoe UI", 10.2F);
            cmbKomandir.Location = new Point(160, 98);
            cmbKomandir.Name = "cmbKomandir";
            cmbKomandir.Size = new Size(185, 27);
            cmbKomandir.TabIndex = 2;

            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNaziv.ForeColor = Color.FromArgb(40, 55, 80);
            lblNaziv.Location = new Point(35, 35);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(101, 19);
            lblNaziv.Text = "Naziv jedinice:";

            lblBaza.AutoSize = true;
            lblBaza.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBaza.ForeColor = Color.FromArgb(40, 55, 80);
            lblBaza.Location = new Point(377, 35);
            lblBaza.Name = "lblBaza";
            lblBaza.Size = new Size(41, 19);
            lblBaza.Text = "Baza:";

            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTip.ForeColor = Color.FromArgb(40, 55, 80);
            lblTip.Location = new Point(377, 102);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(85, 19);
            lblTip.Text = "Tip jedinice:";

            lblKomandir.AutoSize = true;
            lblKomandir.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblKomandir.ForeColor = Color.FromArgb(40, 55, 80);
            lblKomandir.Location = new Point(35, 102);
            lblKomandir.Name = "lblKomandir";
            lblKomandir.Size = new Size(74, 19);
            lblKomandir.Text = "Komandir:";

            btnSacuvaj.BackColor = Color.FromArgb(190, 255, 190);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            btnSacuvaj.Location = new Point(122, 212);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(101, 47);
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;

            btnResetuj.BackColor = Color.FromArgb(255, 245, 190);
            btnResetuj.FlatStyle = FlatStyle.Flat;
            btnResetuj.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            btnResetuj.Location = new Point(322, 212);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(104, 47);
            btnResetuj.Text = "Očisti";
            btnResetuj.UseVisualStyleBackColor = false;
            btnResetuj.Click += btnResetuj_Click;

            btnZatvori.BackColor = Color.FromArgb(255, 210, 210);
            btnZatvori.FlatStyle = FlatStyle.Flat;
            btnZatvori.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            btnZatvori.Location = new Point(539, 212);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(103, 47);
            btnZatvori.Text = "Zatvori";
            btnZatvori.UseVisualStyleBackColor = false;
            btnZatvori.Click += btnZatvori_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 243, 247);
            ClientSize = new Size(699, 301);
            Controls.Add(txtNaziv);
            Controls.Add(txtBaza);
            Controls.Add(txtTip);
            Controls.Add(cmbKomandir);
            Controls.Add(lblNaziv);
            Controls.Add(lblBaza);
            Controls.Add(lblTip);
            Controls.Add(lblKomandir);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnResetuj);
            Controls.Add(btnZatvori);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaUpravljajSpecijalnomInterventnom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje specijalnom interventnom jedinicom";
            Load += FormaUpravljajSpecijalnomInterventnom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNaziv;
        private TextBox txtBaza;
        private TextBox txtTip;
        private ComboBox cmbKomandir;
        private Label lblNaziv;
        private Label lblBaza;
        private Label lblTip;
        private Label lblKomandir;
        private Button btnSacuvaj;
        private Button btnResetuj;
        private Button btnZatvori;
    }
}