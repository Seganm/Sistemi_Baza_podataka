namespace VanredneSituacije.Forme
{
    partial class FormaPregledSituacije
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            dugmeDodajSituaciju = new Button();
            dugmeIzmeniSituaciju = new Button();
            dugmeObrisiSituaciju = new Button();
            dugmePrikaziUcesce = new Button();
            tabelaSituacije = new DataGridView();
            datumOdKolona = new DataGridViewTextBoxColumn();
            datumDoKolona = new DataGridViewTextBoxColumn();
            tipKolona = new DataGridViewTextBoxColumn();
            brojUgrozenihKolona = new DataGridViewTextBoxColumn();
            nivoOpasnostiKolona = new DataGridViewTextBoxColumn();
            opstinaKolona = new DataGridViewTextBoxColumn();
            lokacijaKolona = new DataGridViewTextBoxColumn();
            opisKolona = new DataGridViewTextBoxColumn();
            idPrijaveKolona = new DataGridViewTextBoxColumn();
            vanrednaSituacijaBinding = new BindingSource(components);
            naslovLabela = new Label();

            ((System.ComponentModel.ISupportInitialize)tabelaSituacije).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vanrednaSituacijaBinding).BeginInit();
            SuspendLayout();
            dugmeDodajSituaciju.BackColor = Color.FromArgb(0, 123, 255);
            dugmeDodajSituaciju.FlatAppearance.BorderSize = 0;
            dugmeDodajSituaciju.FlatStyle = FlatStyle.Flat;
            dugmeDodajSituaciju.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmeDodajSituaciju.ForeColor = Color.White;
            dugmeDodajSituaciju.Location = new Point(485, 8);
            dugmeDodajSituaciju.Name = "dugmeDodajSituaciju";
            dugmeDodajSituaciju.Size = new Size(131, 26);
            dugmeDodajSituaciju.Text = "Dodaj situaciju";
            dugmeDodajSituaciju.UseVisualStyleBackColor = false;
            dugmeDodajSituaciju.Click += dugmeDodajSituaciju_Click;

            dugmeIzmeniSituaciju.BackColor = Color.FromArgb(255, 193, 7);
            dugmeIzmeniSituaciju.FlatAppearance.BorderSize = 0;
            dugmeIzmeniSituaciju.FlatStyle = FlatStyle.Flat;
            dugmeIzmeniSituaciju.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmeIzmeniSituaciju.ForeColor = Color.White;
            dugmeIzmeniSituaciju.Location = new Point(621, 8);
            dugmeIzmeniSituaciju.Name = "dugmeIzmeniSituaciju";
            dugmeIzmeniSituaciju.Size = new Size(131, 26);
            dugmeIzmeniSituaciju.Text = "Izmeni situaciju";
            dugmeIzmeniSituaciju.UseVisualStyleBackColor = false;
            dugmeIzmeniSituaciju.Click += dugmeIzmeniSituaciju_Click;


            dugmeObrisiSituaciju.BackColor = Color.FromArgb(220, 53, 69);
            dugmeObrisiSituaciju.FlatAppearance.BorderSize = 0;
            dugmeObrisiSituaciju.FlatStyle = FlatStyle.Flat;
            dugmeObrisiSituaciju.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmeObrisiSituaciju.ForeColor = Color.White;
            dugmeObrisiSituaciju.Location = new Point(758, 8);
            dugmeObrisiSituaciju.Name = "dugmeObrisiSituaciju";
            dugmeObrisiSituaciju.Size = new Size(131, 26);
            dugmeObrisiSituaciju.Text = "Obriši situaciju";
            dugmeObrisiSituaciju.UseVisualStyleBackColor = false;
            dugmeObrisiSituaciju.Click += dugmeObrisiSituaciju_Click;

 
            dugmePrikaziUcesce.BackColor = Color.FromArgb(108, 117, 125);
            dugmePrikaziUcesce.FlatAppearance.BorderSize = 0;
            dugmePrikaziUcesce.FlatStyle = FlatStyle.Flat;
            dugmePrikaziUcesce.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmePrikaziUcesce.ForeColor = Color.White;
            dugmePrikaziUcesce.Location = new Point(894, 8);
            dugmePrikaziUcesce.Name = "dugmePrikaziUcesce";
            dugmePrikaziUcesce.Size = new Size(131, 26);
            dugmePrikaziUcesce.Text = "Prikaži učestvovanja";
            dugmePrikaziUcesce.UseVisualStyleBackColor = false;
            dugmePrikaziUcesce.Click += dugmePrikaziUcesce_Click;

            tabelaSituacije.AutoGenerateColumns = false;
            tabelaSituacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaSituacije.BackgroundColor = Color.White;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(240, 240, 240);
            headerStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            headerStyle.ForeColor = Color.Black;
            headerStyle.WrapMode = DataGridViewTriState.True;
            tabelaSituacije.ColumnHeadersDefaultCellStyle = headerStyle;
            tabelaSituacije.Columns.AddRange(new DataGridViewColumn[] {
        datumOdKolona, datumDoKolona, tipKolona, brojUgrozenihKolona,
        nivoOpasnostiKolona, opstinaKolona, lokacijaKolona, opisKolona, idPrijaveKolona
    });
            tabelaSituacije.DataSource = vanrednaSituacijaBinding;
            cellStyle.SelectionBackColor = Color.FromArgb(200, 220, 255);
            cellStyle.SelectionForeColor = Color.Black;
            tabelaSituacije.DefaultCellStyle = cellStyle;
            tabelaSituacije.EnableHeadersVisualStyles = false;
            tabelaSituacije.GridColor = Color.LightGray;
            tabelaSituacije.Location = new Point(10, 41);
            tabelaSituacije.Name = "tabelaSituacije";
            tabelaSituacije.RowHeadersVisible = false;
            tabelaSituacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaSituacije.Size = new Size(1147, 523);


            datumOdKolona.DataPropertyName = "Datum_Od";
            datumOdKolona.HeaderText = "Datum početka";

            datumDoKolona.DataPropertyName = "Datum_Do";
            datumDoKolona.HeaderText = "Datum završetka";

            tipKolona.DataPropertyName = "Tip";
            tipKolona.HeaderText = "Tip situacije";

            brojUgrozenihKolona.DataPropertyName = "Broj_Ugrozenih_Osoba";
            brojUgrozenihKolona.HeaderText = "Broj ugroženih osoba";

            nivoOpasnostiKolona.DataPropertyName = "Nivo_Opasnosti";
            nivoOpasnostiKolona.HeaderText = "Nivo opasnosti";

            opstinaKolona.DataPropertyName = "Opstina";
            opstinaKolona.HeaderText = "Opština";

            lokacijaKolona.DataPropertyName = "Lokacija";
            lokacijaKolona.HeaderText = "Lokacija";

            opisKolona.DataPropertyName = "Opis";
            opisKolona.HeaderText = "Opis";

            idPrijaveKolona.DataPropertyName = "IdPrijave";
            idPrijaveKolona.HeaderText = "ID prijave";

            naslovLabela.AutoSize = true;
            naslovLabela.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            naslovLabela.Location = new Point(10, 9);
            naslovLabela.Name = "naslovLabela";
            naslovLabela.Size = new Size(194, 25);
            naslovLabela.Text = "Pregled svih situacija";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1261, 575);
            Controls.Add(naslovLabela);
            Controls.Add(tabelaSituacije);
            Controls.Add(dugmePrikaziUcesce);
            Controls.Add(dugmeObrisiSituaciju);
            Controls.Add(dugmeIzmeniSituaciju);
            Controls.Add(dugmeDodajSituaciju);
            Name = "FormaPregledSituacije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled vanrednih situacija";
            Load += FormaPregledSituacije_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaSituacije).EndInit();
            ((System.ComponentModel.ISupportInitialize)vanrednaSituacijaBinding).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dugmeDodajSituaciju;
        private Button dugmeIzmeniSituaciju;
        private Button dugmeObrisiSituaciju;
        private Button dugmePrikaziUcesce;
        private DataGridView tabelaSituacije;
        private BindingSource vanrednaSituacijaBinding;
        private Label naslovLabela;


        private DataGridViewTextBoxColumn datumOdKolona;
        private DataGridViewTextBoxColumn datumDoKolona;
        private DataGridViewTextBoxColumn tipKolona;
        private DataGridViewTextBoxColumn brojUgrozenihKolona;
        private DataGridViewTextBoxColumn nivoOpasnostiKolona;
        private DataGridViewTextBoxColumn opstinaKolona;
        private DataGridViewTextBoxColumn lokacijaKolona;
        private DataGridViewTextBoxColumn opisKolona;
        private DataGridViewTextBoxColumn idPrijaveKolona;

        #endregion

    }
}


