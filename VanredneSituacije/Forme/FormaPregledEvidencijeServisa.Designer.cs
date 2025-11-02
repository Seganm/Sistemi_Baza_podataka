namespace VanredneSituacije.Forme
{
    partial class FormaPregledEvidencijeServisa
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
            naslovLabel = new Label();
            dugmeObrisi = new Button();
            gridServisi = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolReg = new DataGridViewTextBoxColumn();
            kolStatus = new DataGridViewTextBoxColumn();
            kolTip = new DataGridViewTextBoxColumn();
            kolDatum = new DataGridViewTextBoxColumn();
            bindingServisi = new BindingSource(components);
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)gridServisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingServisi).BeginInit();
            SuspendLayout();

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(528, 9);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(94, 25);
            naslovLabel.TabIndex = 5;
            naslovLabel.Text = "Servisi";

            dugmeObrisi.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisi.FlatAppearance.BorderSize = 0;
            dugmeObrisi.FlatStyle = FlatStyle.Flat;
            dugmeObrisi.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisi.ForeColor = Color.White;
            dugmeObrisi.Location = new Point(1020, 2);
            dugmeObrisi.Margin = new Padding(3, 2, 3, 2);
            dugmeObrisi.Name = "dugmeObrisi";
            dugmeObrisi.Size = new Size(150, 32);
            dugmeObrisi.TabIndex = 4;
            dugmeObrisi.Text = "Obriši";
            dugmeObrisi.UseVisualStyleBackColor = false;
            dugmeObrisi.Click += dugmeObrisi_Click;

            redAlternating.BackColor = Color.FromArgb(250, 250, 253);
            gridServisi.AlternatingRowsDefaultCellStyle = redAlternating;
            gridServisi.AutoGenerateColumns = false;
            gridServisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridServisi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridServisi.BackgroundColor = Color.White;
            zaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            zaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            zaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            zaglavlje.ForeColor = Color.FromArgb(30, 30, 30);
            zaglavlje.SelectionBackColor = SystemColors.Highlight;
            zaglavlje.SelectionForeColor = SystemColors.HighlightText;
            zaglavlje.WrapMode = DataGridViewTriState.True;
            gridServisi.ColumnHeadersDefaultCellStyle = zaglavlje;
            gridServisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServisi.Columns.AddRange(new DataGridViewColumn[]
            {
                kolId, kolReg, kolStatus, kolTip, kolDatum
            });
            gridServisi.DataSource = bindingServisi;
            redovi.Alignment = DataGridViewContentAlignment.MiddleLeft;
            redovi.BackColor = SystemColors.Window;
            redovi.Font = new Font("Segoe UI", 9.5F);
            redovi.ForeColor = SystemColors.ControlText;
            redovi.SelectionBackColor = SystemColors.Highlight;
            redovi.SelectionForeColor = SystemColors.HighlightText;
            redovi.WrapMode = DataGridViewTriState.False;
            gridServisi.DefaultCellStyle = redovi;
            gridServisi.EnableHeadersVisualStyles = false;
            gridServisi.GridColor = Color.FromArgb(225, 225, 225);
            gridServisi.Location = new Point(10, 40);
            gridServisi.Margin = new Padding(3, 2, 3, 2);
            gridServisi.Name = "gridServisi";
            gridServisi.RowHeadersWidth = 51;
            gridServisi.RowTemplate.Height = 28;
            gridServisi.Size = new Size(1160, 438);
            gridServisi.TabIndex = 3;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID";
            kolId.MinimumWidth = 6;
            kolId.Name = "kolId";

            kolReg.DataPropertyName = "RegistarskaOznakaVozila";
            kolReg.HeaderText = "Registarska oznaka";
            kolReg.MinimumWidth = 6;
            kolReg.Name = "kolReg";

            kolStatus.DataPropertyName = "Status";
            kolStatus.HeaderText = "Status";
            kolStatus.MinimumWidth = 6;
            kolStatus.Name = "kolStatus";

            kolTip.DataPropertyName = "TipServisa";
            kolTip.HeaderText = "Tip servisa";
            kolTip.MinimumWidth = 6;
            kolTip.Name = "kolTip";

            kolDatum.DataPropertyName = "Datum";
            kolDatum.HeaderText = "Datum";
            kolDatum.MinimumWidth = 6;
            kolDatum.Name = "kolDatum";

            bindingServisi.DataSource = typeof(DTO.DTOEvidencijaServis);

            dugmeIzmeni.BackColor = Color.FromArgb(255, 190, 80);
            dugmeIzmeni.FlatAppearance.BorderSize = 0;
            dugmeIzmeni.FlatStyle = FlatStyle.Flat;
            dugmeIzmeni.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeni.ForeColor = Color.Black;
            dugmeIzmeni.Location = new Point(168, 2);
            dugmeIzmeni.Margin = new Padding(3, 2, 3, 2);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(150, 32);
            dugmeIzmeni.TabIndex = 6;
            dugmeIzmeni.Text = "Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 2);
            dugmeDodaj.Margin = new Padding(3, 2, 3, 2);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.TabIndex = 7;
            dugmeDodaj.Text = "Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 490);
            Controls.Add(dugmeDodaj);
            Controls.Add(dugmeIzmeni);
            Controls.Add(naslovLabel);
            Controls.Add(dugmeObrisi);
            Controls.Add(gridServisi);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledEvidencijeServisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled evidencije servisa";
            Load += FormaPregledEvidencijeServisa_Load;
            ((System.ComponentModel.ISupportInitialize)gridServisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingServisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label naslovLabel;
        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView gridServisi;
        private BindingSource bindingServisi;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolReg;
        private DataGridViewTextBoxColumn kolStatus;
        private DataGridViewTextBoxColumn kolTip;
        private DataGridViewTextBoxColumn kolDatum;
    }
}
