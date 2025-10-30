namespace VanredneSituacije.Forme
{
    partial class FormaPregledEkspertiza
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle redAlternating = new DataGridViewCellStyle();
            DataGridViewCellStyle zaglavlje = new DataGridViewCellStyle();
            DataGridViewCellStyle redovi = new DataGridViewCellStyle();
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            gridEkspertize = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolIme = new DataGridViewTextBoxColumn();
            kolPrezime = new DataGridViewTextBoxColumn();
            kolJmbg = new DataGridViewTextBoxColumn();
            kolOblast = new DataGridViewTextBoxColumn();
            bindingEkspertize = new BindingSource(components);
            naslovLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gridEkspertize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingEkspertize).BeginInit();
            SuspendLayout();

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1022, 11);
            dugmeObrisi.Margin = new Padding(3, 2, 3, 2);
            dugmeObrisi.Name = "dugmeObrisi";
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.TabIndex = 20;
            dugmeObrisi.Text = "🗑 Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(168, 9);
            dugmeIzmeni.Margin = new Padding(3, 2, 3, 2);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.TabIndex = 19;
            dugmeIzmeni.Text = "✏ Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 11);
            dugmeDodaj.Margin = new Padding(3, 2, 3, 2);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.TabIndex = 18;
            dugmeDodaj.Text = "➕ Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            redAlternating.BackColor = Color.FromArgb(250, 250, 253);
            gridEkspertize.AlternatingRowsDefaultCellStyle = redAlternating;
            gridEkspertize.AutoGenerateColumns = false;
            gridEkspertize.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridEkspertize.BackgroundColor = Color.White;
            zaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            zaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            zaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            zaglavlje.ForeColor = Color.FromArgb(30, 30, 30);
            zaglavlje.SelectionBackColor = SystemColors.Highlight;
            zaglavlje.SelectionForeColor = SystemColors.HighlightText;
            zaglavlje.WrapMode = DataGridViewTriState.True;
            gridEkspertize.ColumnHeadersDefaultCellStyle = zaglavlje;
            gridEkspertize.Columns.AddRange(new DataGridViewColumn[]
            {
                kolId, kolIme, kolPrezime, kolJmbg, kolOblast
            });
            gridEkspertize.DataSource = bindingEkspertize;
            redovi.Alignment = DataGridViewContentAlignment.MiddleLeft;
            redovi.BackColor = SystemColors.Window;
            redovi.Font = new Font("Segoe UI", 9.5F);
            redovi.ForeColor = SystemColors.ControlText;
            redovi.SelectionBackColor = SystemColors.Highlight;
            redovi.SelectionForeColor = SystemColors.HighlightText;
            redovi.WrapMode = DataGridViewTriState.False;
            gridEkspertize.DefaultCellStyle = redovi;
            gridEkspertize.EnableHeadersVisualStyles = false;
            gridEkspertize.GridColor = Color.FromArgb(225, 225, 225);
            gridEkspertize.Location = new Point(12, 45);
            gridEkspertize.Margin = new Padding(3, 2, 3, 2);
            gridEkspertize.Name = "gridEkspertize";
            gridEkspertize.RowHeadersWidth = 51;
            gridEkspertize.RowTemplate.Height = 28;
            gridEkspertize.Size = new Size(1160, 605);
            gridEkspertize.TabIndex = 21;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID";
            kolId.MinimumWidth = 6;
            kolId.Name = "kolId";

            kolIme.DataPropertyName = "ImeAnaliticara";
            kolIme.HeaderText = "Ime analitičara";
            kolIme.MinimumWidth = 6;
            kolIme.Name = "kolIme";

            kolPrezime.DataPropertyName = "PrezimeAnaliticara";
            kolPrezime.HeaderText = "Prezime analitičara";
            kolPrezime.MinimumWidth = 6;
            kolPrezime.Name = "kolPrezime";

            kolJmbg.DataPropertyName = "JMBGAnaliticara";
            kolJmbg.HeaderText = "JMBG analitičara";
            kolJmbg.MinimumWidth = 6;
            kolJmbg.Name = "kolJmbg";

            kolOblast.DataPropertyName = "Oblast";
            kolOblast.HeaderText = "Oblast";
            kolOblast.MinimumWidth = 6;
            kolOblast.Name = "kolOblast";

            bindingEkspertize.DataSource = typeof(DTO.DTOEkspertize);

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(524, 13);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(126, 25);
            naslovLabel.TabIndex = 22;
            naslovLabel.Text = "🧠 Ekspertize";

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabel);
            Controls.Add(gridEkspertize);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledEkspertiza";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled ekspertiza";
            Load += FormaPregledEkspertiza_Load;
            ((System.ComponentModel.ISupportInitialize)gridEkspertize).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingEkspertize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView gridEkspertize;
        private BindingSource bindingEkspertize;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolIme;
        private DataGridViewTextBoxColumn kolPrezime;
        private DataGridViewTextBoxColumn kolJmbg;
        private DataGridViewTextBoxColumn kolOblast;
        private Label naslovLabel;
    }
}
