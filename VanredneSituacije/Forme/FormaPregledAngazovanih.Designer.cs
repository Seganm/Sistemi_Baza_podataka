namespace VanredneSituacije.Forme
{
    partial class FormaPregledAngazovanih
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
            DataGridViewCellStyle stilRed1 = new DataGridViewCellStyle();
            DataGridViewCellStyle stilZaglavlje = new DataGridViewCellStyle();
            DataGridViewCellStyle stilRed2 = new DataGridViewCellStyle();
            dugmeObrisi = new Button();
            dugmeIzmeni = new Button();
            dugmeDodaj = new Button();
            gridAngazovanja = new DataGridView();
            kolId = new DataGridViewTextBoxColumn();
            kolVozilo = new DataGridViewTextBoxColumn();
            kolIntervencija = new DataGridViewTextBoxColumn();
            kolDatumOd = new DataGridViewTextBoxColumn();
            kolDatumDo = new DataGridViewTextBoxColumn();
            bindingAngazovanja = new BindingSource(components);
            naslovLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gridAngazovanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingAngazovanja).BeginInit();
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
            dugmeObrisi.Text = "Obriši";
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
            dugmeIzmeni.TabIndex = 28;
            dugmeIzmeni.Text = "Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = false;
            dugmeIzmeni.Click += dugmeIzmeni_Click;

            dugmeDodaj.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodaj.FlatAppearance.BorderSize = 0;
            dugmeDodaj.FlatStyle = FlatStyle.Flat;
            dugmeDodaj.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodaj.ForeColor = Color.White;
            dugmeDodaj.Location = new Point(12, 9);
            dugmeDodaj.Margin = new Padding(3, 2, 3, 2);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(150, 32);
            dugmeDodaj.TabIndex = 27;
            dugmeDodaj.Text = "Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = false;
            dugmeDodaj.Click += dugmeDodaj_Click;

            stilRed1.BackColor = Color.FromArgb(250, 250, 253);
            gridAngazovanja.AlternatingRowsDefaultCellStyle = stilRed1;
            gridAngazovanja.AutoGenerateColumns = false;
            gridAngazovanja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAngazovanja.BackgroundColor = Color.White;
            stilZaglavlje.Alignment = DataGridViewContentAlignment.MiddleLeft;
            stilZaglavlje.BackColor = Color.FromArgb(230, 235, 245);
            stilZaglavlje.Font = new Font("Segoe UI Semibold", 10F);
            stilZaglavlje.ForeColor = Color.FromArgb(30, 30, 30);
            stilZaglavlje.SelectionBackColor = SystemColors.Highlight;
            stilZaglavlje.SelectionForeColor = SystemColors.HighlightText;
            stilZaglavlje.WrapMode = DataGridViewTriState.True;
            gridAngazovanja.ColumnHeadersDefaultCellStyle = stilZaglavlje;
            gridAngazovanja.Columns.AddRange(new DataGridViewColumn[] { kolId, kolVozilo, kolIntervencija, kolDatumOd, kolDatumDo });
            gridAngazovanja.DataSource = bindingAngazovanja;
            stilRed2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            stilRed2.BackColor = SystemColors.Window;
            stilRed2.Font = new Font("Segoe UI", 9.5F);
            stilRed2.ForeColor = SystemColors.ControlText;
            stilRed2.SelectionBackColor = SystemColors.Highlight;
            stilRed2.SelectionForeColor = SystemColors.HighlightText;
            stilRed2.WrapMode = DataGridViewTriState.False;
            gridAngazovanja.DefaultCellStyle = stilRed2;
            gridAngazovanja.EnableHeadersVisualStyles = false;
            gridAngazovanja.GridColor = Color.FromArgb(225, 225, 225);
            gridAngazovanja.Location = new Point(12, 46);
            gridAngazovanja.Name = "gridAngazovanja";
            gridAngazovanja.RowHeadersWidth = 51;
            gridAngazovanja.RowTemplate.Height = 28;
            gridAngazovanja.Size = new Size(1160, 603);
            gridAngazovanja.TabIndex = 30;

            kolId.DataPropertyName = "Id";
            kolId.HeaderText = "ID";
            kolId.MinimumWidth = 6;
            kolId.Name = "kolId";

            kolVozilo.DataPropertyName = "VoziloReg";
            kolVozilo.HeaderText = "Registarska oznaka";
            kolVozilo.MinimumWidth = 6;
            kolVozilo.Name = "kolVozilo";

            kolIntervencija.DataPropertyName = "IntervencijaID";
            kolIntervencija.HeaderText = "ID Intervencije";
            kolIntervencija.MinimumWidth = 6;
            kolIntervencija.Name = "kolIntervencija";

            kolDatumOd.DataPropertyName = "DatumPoc";
            kolDatumOd.HeaderText = "Datum početka";
            kolDatumOd.MinimumWidth = 6;
            kolDatumOd.Name = "kolDatumOd";

            kolDatumDo.DataPropertyName = "DatumKraj";
            kolDatumDo.HeaderText = "Datum završetka";
            kolDatumDo.MinimumWidth = 6;
            kolDatumDo.Name = "kolDatumDo";

            bindingAngazovanja.DataSource = typeof(DTO.DTOVratiAngazovano);

            naslovLabel.AutoSize = true;
            naslovLabel.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabel.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabel.Location = new Point(474, 9);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(265, 25);
            naslovLabel.TabIndex = 31;
            naslovLabel.Text = "Istorija učestvovanja vozila";
            naslovLabel.Click += naslovLabel_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabel);
            Controls.Add(gridAngazovanja);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledAngazovanih";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled angažovanih";
            Load += FormaPregledAngazovanih_Load;
            ((System.ComponentModel.ISupportInitialize)gridAngazovanja).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingAngazovanja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeObrisi;
        private Button dugmeIzmeni;
        private Button dugmeDodaj;
        private DataGridView gridAngazovanja;
        private Label naslovLabel;
        private DataGridViewTextBoxColumn kolId;
        private DataGridViewTextBoxColumn kolVozilo;
        private DataGridViewTextBoxColumn kolIntervencija;
        private DataGridViewTextBoxColumn kolDatumOd;
        private DataGridViewTextBoxColumn kolDatumDo;
        private BindingSource bindingAngazovanja;
    }
}
