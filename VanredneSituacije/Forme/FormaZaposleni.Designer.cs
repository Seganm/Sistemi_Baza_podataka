namespace VanredneSituacije.Forme
{
    partial class FormaZaposleni
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
            tblIstorija = new DataGridView();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            lblNaslov = new Label();
            pnlDugmici = new Panel();
            ((System.ComponentModel.ISupportInitialize)tblIstorija).BeginInit();
            pnlDugmici.SuspendLayout();
            SuspendLayout();

            tblIstorija.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblIstorija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblIstorija.BackgroundColor = Color.White;
            tblIstorija.Location = new Point(25, 65);
            tblIstorija.Name = "tblIstorija";
            tblIstorija.ReadOnly = true;
            tblIstorija.RowHeadersVisible = false;
            tblIstorija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblIstorija.Size = new Size(950, 440);
            tblIstorija.TabIndex = 2;

            btnIzmeni.BackColor = Color.SteelBlue;
            btnIzmeni.FlatStyle = FlatStyle.Popup;
            btnIzmeni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(3, 3);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(145, 35);
            btnIzmeni.TabIndex = 0;
            btnIzmeni.Text = "✏️ Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;

            btnObrisi.BackColor = Color.IndianRed;
            btnObrisi.FlatStyle = FlatStyle.Popup;
            btnObrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnObrisi.ForeColor = Color.White;
            btnObrisi.Location = new Point(172, 3);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(145, 35);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "🗑️ Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;

            lblNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(30, 60, 120);
            lblNaslov.Location = new Point(382, 9);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(400, 35);
            lblNaslov.TabIndex = 1;
            lblNaslov.Text = "Istorija uloga zaposlenog";
            lblNaslov.TextAlign = ContentAlignment.MiddleLeft;

            pnlDugmici.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlDugmici.Controls.Add(btnIzmeni);
            pnlDugmici.Controls.Add(btnObrisi);
            pnlDugmici.Location = new Point(331, 521);
            pnlDugmici.Name = "pnlDugmici";
            pnlDugmici.Size = new Size(320, 50);
            pnlDugmici.TabIndex = 0;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlDugmici);
            Controls.Add(lblNaslov);
            Controls.Add(tblIstorija);
            Name = "FormaZaposleni";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Istorija zaposlenog";
            Load += FormaZaposleni_Load;
            ((System.ComponentModel.ISupportInitialize)tblIstorija).EndInit();
            pnlDugmici.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView tblIstorija;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Label lblNaslov;
        private Panel pnlDugmici;
    }
}