namespace VanredneSituacije.Forme
{
    partial class FormaOpremaDodaj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            naslovLabel = new Label();
            dugmeTehnicka = new Button();
            dugmeMedicinska = new Button();
            dugmeZalihe = new Button();
            dugmeOdustani = new Button();
            dugmeLicna = new Button();
            SuspendLayout();

            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(310, 340);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Text = "Dodavanje opreme";
            Load += FormaOpremaDodaj_Load;

            naslovLabel.Font = new Font("Segoe UI Semibold", 10.5F);
            naslovLabel.ForeColor = Color.FromArgb(40, 40, 40);
            naslovLabel.Location = new Point(45, 10);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(220, 55);
            naslovLabel.TabIndex = 7;
            naslovLabel.Text = "Odaberite tip opreme koji želite da dodate";
            naslovLabel.TextAlign = ContentAlignment.MiddleCenter;

            dugmeZalihe.BackColor = Color.FromArgb(0, 122, 204);
            dugmeZalihe.ForeColor = Color.White;
            dugmeZalihe.FlatStyle = FlatStyle.Flat;
            dugmeZalihe.FlatAppearance.BorderSize = 0;
            dugmeZalihe.Location = new Point(55, 70);
            dugmeZalihe.Name = "dugmeZalihe";
            dugmeZalihe.Size = new Size(200, 40);
            dugmeZalihe.TabIndex = 4;
            dugmeZalihe.Text = "Zalihe";
            dugmeZalihe.UseVisualStyleBackColor = false;
            dugmeZalihe.Click += buttonOpsta_Click;

            dugmeMedicinska.BackColor = Color.FromArgb(60, 180, 75);
            dugmeMedicinska.ForeColor = Color.White;
            dugmeMedicinska.FlatStyle = FlatStyle.Flat;
            dugmeMedicinska.FlatAppearance.BorderSize = 0;
            dugmeMedicinska.Location = new Point(55, 115);
            dugmeMedicinska.Name = "dugmeMedicinska";
            dugmeMedicinska.Size = new Size(200, 40);
            dugmeMedicinska.TabIndex = 5;
            dugmeMedicinska.Text = "Medicinska oprema";
            dugmeMedicinska.UseVisualStyleBackColor = false;
            dugmeMedicinska.Click += buttonSpec_Click;

            dugmeTehnicka.BackColor = Color.FromArgb(255, 190, 80);
            dugmeTehnicka.ForeColor = Color.Black;
            dugmeTehnicka.FlatStyle = FlatStyle.Flat;
            dugmeTehnicka.FlatAppearance.BorderSize = 0;
            dugmeTehnicka.Location = new Point(55, 160);
            dugmeTehnicka.Name = "dugmeTehnicka";
            dugmeTehnicka.Size = new Size(200, 40);
            dugmeTehnicka.TabIndex = 6;
            dugmeTehnicka.Text = "Tehnička oprema";
            dugmeTehnicka.UseVisualStyleBackColor = false;
            dugmeTehnicka.Click += buttonOdustani_Click;

            dugmeLicna.BackColor = Color.FromArgb(85, 85, 230);
            dugmeLicna.ForeColor = Color.White;
            dugmeLicna.FlatStyle = FlatStyle.Flat;
            dugmeLicna.FlatAppearance.BorderSize = 0;
            dugmeLicna.Location = new Point(55, 205);
            dugmeLicna.Name = "dugmeLicna";
            dugmeLicna.Size = new Size(200, 40);
            dugmeLicna.TabIndex = 8;
            dugmeLicna.Text = "Lična zaštita";
            dugmeLicna.UseVisualStyleBackColor = false;
            dugmeLicna.Click += button2_Click;

            dugmeOdustani.BackColor = Color.FromArgb(220, 70, 70);
            dugmeOdustani.ForeColor = Color.White;
            dugmeOdustani.FlatStyle = FlatStyle.Flat;
            dugmeOdustani.FlatAppearance.BorderSize = 0;
            dugmeOdustani.Location = new Point(55, 250);
            dugmeOdustani.Name = "dugmeOdustani";
            dugmeOdustani.Size = new Size(200, 40);
            dugmeOdustani.TabIndex = 9;
            dugmeOdustani.Text = "Zatvori";
            dugmeOdustani.UseVisualStyleBackColor = false;
            dugmeOdustani.Click += button1_Click;

            Controls.Add(dugmeOdustani);
            Controls.Add(dugmeLicna);
            Controls.Add(naslovLabel);
            Controls.Add(dugmeTehnicka);
            Controls.Add(dugmeMedicinska);
            Controls.Add(dugmeZalihe);
            ResumeLayout(false);
        }

        private Label naslovLabel;
        private Button dugmeTehnicka;
        private Button dugmeMedicinska;
        private Button dugmeZalihe;
        private Button dugmeOdustani;
        private Button dugmeLicna;
    }
}
