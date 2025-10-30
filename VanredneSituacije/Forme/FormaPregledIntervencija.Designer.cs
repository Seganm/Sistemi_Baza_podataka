namespace VanredneSituacije.Forme
{
    partial class FormaPregledIntervencija
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
            DataGridViewCellStyle redAlternating = new DataGridViewCellStyle();
            DataGridViewCellStyle zaglavlje = new DataGridViewCellStyle();
            DataGridViewCellStyle redovi = new DataGridViewCellStyle();
            naslovLabel = new Label();
            dugmeDodaj = new Button();
            dugmeIzmeni = new Button();
            dugmeObrisi = new Button();
            gridIntervencije = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridIntervencije).BeginInit();
            SuspendLayout();

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(495, 14);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(203, 25);
            naslovLabel.TabIndex = 0;
            naslovLabel.Text = "🚒 Istorija intervencija";

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 14);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.TabIndex = 1;
            dugmeDodaj.Text = "➕ Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(168, 14);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.TabIndex = 2;
            dugmeIzmeni.Text = "✏ Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 12);
            dugmeObrisi.Name = "dugmeObrisi";
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.TabIndex = 3;
            dugmeObrisi.Text = "🗑 Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            redAlternating.BackColor = Color.FromArgb(250, 250, 253);
            gridIntervencije.AlternatingRowsDefaultCellStyle = redAlternating;
            gridIntervencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridIntervencije.BackgroundColor = Color.White;
            zaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            zaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            zaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            zaglavlje.ForeColor = Color.FromArgb(30, 30, 30);
            zaglavlje.SelectionBackColor = SystemColors.Highlight;
            zaglavlje.SelectionForeColor = SystemColors.HighlightText;
            zaglavlje.WrapMode = DataGridViewTriState.True;
            gridIntervencije.ColumnHeadersDefaultCellStyle = zaglavlje;
            gridIntervencije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            redovi.Alignment = DataGridViewContentAlignment.MiddleLeft;
            redovi.BackColor = SystemColors.Window;
            redovi.Font = new Font("Segoe UI", 9.5F);
            redovi.ForeColor = SystemColors.ControlText;
            redovi.SelectionBackColor = SystemColors.Highlight;
            redovi.SelectionForeColor = SystemColors.HighlightText;
            redovi.WrapMode = DataGridViewTriState.False;
            gridIntervencije.DefaultCellStyle = redovi;
            gridIntervencije.EnableHeadersVisualStyles = false;
            gridIntervencije.GridColor = Color.FromArgb(225, 225, 225);
            gridIntervencije.Location = new Point(12, 50);
            gridIntervencije.Margin = new Padding(3, 2, 3, 2);
            gridIntervencije.Name = "gridIntervencije";
            gridIntervencije.RowHeadersWidth = 51;
            gridIntervencije.RowTemplate.Height = 28;
            gridIntervencije.Size = new Size(1160, 599);
            gridIntervencije.TabIndex = 4;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(gridIntervencije);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Controls.Add(naslovLabel);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledIntervencija";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled intervencija";
            Load += FormaPregledIntervencija_Load;
            ((System.ComponentModel.ISupportInitialize)gridIntervencije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label naslovLabel;
        private Button dugmeDodaj;
        private Button dugmeIzmeni;
        private Button dugmeObrisi;
        private DataGridView gridIntervencije;
    }
}
