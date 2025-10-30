namespace VanredneSituacije.Forme
{
    partial class FormaPregledDodeljenih
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
            dugmeDodaj = new Button();
            gridDodeljivanja = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolReg = new DataGridViewTextBoxColumn();
            kolJMBG = new DataGridViewTextBoxColumn();
            kolIme = new DataGridViewTextBoxColumn();
            kolJedinicaId = new DataGridViewTextBoxColumn();
            kolNazivJedinice = new DataGridViewTextBoxColumn();
            kolDatumOd = new DataGridViewTextBoxColumn();
            kolDatumDo = new DataGridViewTextBoxColumn();
            bindingDodeljivanja = new BindingSource(components);
            naslovLabel = new Label();
            dugmeIzmeni = new Button();
            ((System.ComponentModel.ISupportInitialize)gridDodeljivanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingDodeljivanja).BeginInit();
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
            dugmeObrisi.TabIndex = 29;
            dugmeObrisi.Text = "🗑 Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 8);
            dugmeDodaj.Margin = new Padding(3, 2, 3, 2);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.TabIndex = 27;
            dugmeDodaj.Text = "➕ Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            redAlternating.BackColor = Color.FromArgb(250, 250, 253);
            gridDodeljivanja.AlternatingRowsDefaultCellStyle = redAlternating;
            gridDodeljivanja.AutoGenerateColumns = false;
            gridDodeljivanja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDodeljivanja.BackgroundColor = Color.White;
            zaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            zaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            zaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            zaglavlje.ForeColor = Color.FromArgb(30, 30, 30);
            zaglavlje.SelectionBackColor = SystemColors.Highlight;
            zaglavlje.SelectionForeColor = SystemColors.HighlightText;
            zaglavlje.WrapMode = DataGridViewTriState.True;
            gridDodeljivanja.ColumnHeadersDefaultCellStyle = zaglavlje;
            gridDodeljivanja.Columns.AddRange(new DataGridViewColumn[]
            {
                kolId, kolReg, kolJMBG, kolIme, kolJedinicaId, kolNazivJedinice, kolDatumOd, kolDatumDo
            });
            gridDodeljivanja.DataSource = bindingDodeljivanja;
            redovi.Alignment = DataGridViewContentAlignment.MiddleLeft;
            redovi.BackColor = SystemColors.Window;
            redovi.Font = new Font("Segoe UI", 9.5F);
            redovi.ForeColor = SystemColors.ControlText;
            redovi.SelectionBackColor = SystemColors.Highlight;
            redovi.SelectionForeColor = SystemColors.HighlightText;
            redovi.WrapMode = DataGridViewTriState.False;
            gridDodeljivanja.DefaultCellStyle = redovi;
            gridDodeljivanja.EnableHeadersVisualStyles = false;
            gridDodeljivanja.GridColor = Color.FromArgb(225, 225, 225);
            gridDodeljivanja.Location = new Point(12, 45);
            gridDodeljivanja.Margin = new Padding(3, 2, 3, 2);
            gridDodeljivanja.Name = "gridDodeljivanja";
            gridDodeljivanja.RowHeadersWidth = 51;
            gridDodeljivanja.RowTemplate.Height = 28;
            gridDodeljivanja.Size = new Size(1160, 605);
            gridDodeljivanja.TabIndex = 30;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID";
            kolId.MinimumWidth = 6;
            kolId.Name = "kolId";

            kolReg.DataPropertyName = "RegVozilo";
            kolReg.HeaderText = "Registarska oznaka";
            kolReg.MinimumWidth = 6;
            kolReg.Name = "kolReg";

            kolJMBG.DataPropertyName = "JMBGRadnik";
            kolJMBG.HeaderText = "JMBG Radnika";
            kolJMBG.MinimumWidth = 6;
            kolJMBG.Name = "kolJMBG";

            kolIme.DataPropertyName = "PunoIme";
            kolIme.HeaderText = "Puno ime";
            kolIme.MinimumWidth = 6;
            kolIme.Name = "kolIme";
            kolIme.ReadOnly = true;

            kolJedinicaId.DataPropertyName = "IdJedinica";
            kolJedinicaId.HeaderText = "ID jedinice";
            kolJedinicaId.MinimumWidth = 6;
            kolJedinicaId.Name = "kolJedinicaId";

            kolNazivJedinice.DataPropertyName = "NazivJedinice";
            kolNazivJedinice.HeaderText = "Naziv jedinice";
            kolNazivJedinice.MinimumWidth = 6;
            kolNazivJedinice.Name = "kolNazivJedinice";

            kolDatumOd.DataPropertyName = "DatumOd";
            kolDatumOd.HeaderText = "Datum od";
            kolDatumOd.MinimumWidth = 6;
            kolDatumOd.Name = "kolDatumOd";

            kolDatumDo.DataPropertyName = "DatumDo";
            kolDatumDo.HeaderText = "Datum do";
            kolDatumDo.MinimumWidth = 6;
            kolDatumDo.Name = "kolDatumDo";

            bindingDodeljivanja.DataSource = typeof(DTO.DTOVratiDodeljen);

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(553, 9);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(145, 25);
            naslovLabel.TabIndex = 31;
            naslovLabel.Text = "🚚 Dodeljivanja";

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(168, 8);
            dugmeIzmeni.Margin = new Padding(3, 2, 3, 2);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.TabIndex = 32;
            dugmeIzmeni.Text = "✏ Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(dugmeIzmeni);
            Controls.Add(naslovLabel);
            Controls.Add(gridDodeljivanja);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledDodeljenih";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled dodeljenih";
            Load += FormaPregledDodeljenih_Load;
            ((System.ComponentModel.ISupportInitialize)gridDodeljivanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingDodeljivanja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeDodaj;
        private Button dugmeIzmeni;
        private DataGridView gridDodeljivanja;
        private Label naslovLabel;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolReg;
        private DataGridViewTextBoxColumn kolJMBG;
        private DataGridViewTextBoxColumn kolIme;
        private DataGridViewTextBoxColumn kolJedinicaId;
        private DataGridViewTextBoxColumn kolNazivJedinice;
        private DataGridViewTextBoxColumn kolDatumOd;
        private DataGridViewTextBoxColumn kolDatumDo;
        private BindingSource bindingDodeljivanja;
    }
}
