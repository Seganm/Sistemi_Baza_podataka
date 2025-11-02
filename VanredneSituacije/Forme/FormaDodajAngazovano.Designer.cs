namespace VanredneSituacije.Forme
{
    partial class FormaDodajAngazovano
    {
        private System.ComponentModel.IContainer komponenta = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (komponenta != null))
                komponenta.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listaIntervencija = new ComboBox();
            listaVozila = new ComboBox();
            lblIntervencija = new Label();
            lblVozilo = new Label();
            lblDatumOd = new Label();
            lblDatumDo = new Label();
            datumOdPicker = new DateTimePicker();
            datumDoPicker = new DateTimePicker();
            dugmeSacuvaj = new Button();
            dugmePonisti = new Button();
            dugmeZatvori = new Button();
            SuspendLayout();
  
            listaIntervencija.DropDownStyle = ComboBoxStyle.DropDownList;
            listaIntervencija.Location = new Point(120, 30);
            listaIntervencija.Name = "listaIntervencija";
            listaIntervencija.Size = new Size(230, 23);
            listaIntervencija.TabIndex = 0;
            listaIntervencija.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
   
            listaVozila.DropDownStyle = ComboBoxStyle.DropDownList;
            listaVozila.Location = new Point(420, 30);
            listaVozila.Name = "listaVozila";
            listaVozila.Size = new Size(230, 23);
            listaVozila.TabIndex = 1;
     
            lblIntervencija.AutoSize = true;
            lblIntervencija.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIntervencija.Location = new Point(40, 35);
            lblIntervencija.Name = "lblIntervencija";
            lblIntervencija.Size = new Size(77, 15);
            lblIntervencija.TabIndex = 7;
            lblIntervencija.Text = "Intervencija:";
    
            lblVozilo.AutoSize = true;
            lblVozilo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVozilo.Location = new Point(360, 35);
            lblVozilo.Name = "lblVozilo";
            lblVozilo.Size = new Size(43, 15);
            lblVozilo.TabIndex = 8;
            lblVozilo.Text = "Vozilo:";
   
            lblDatumOd.AutoSize = true;
            lblDatumOd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDatumOd.Location = new Point(120, 90);
            lblDatumOd.Name = "lblDatumOd";
            lblDatumOd.Size = new Size(72, 15);
            lblDatumOd.TabIndex = 9;
            lblDatumOd.Text = "Početak od:";
  
            lblDatumDo.AutoSize = true;
            lblDatumDo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDatumDo.Location = new Point(400, 90);
            lblDatumDo.Name = "lblDatumDo";
            lblDatumDo.Size = new Size(54, 15);
            lblDatumDo.TabIndex = 10;
            lblDatumDo.Text = "Traje do:";

            datumOdPicker.Format = DateTimePickerFormat.Short;
            datumOdPicker.Location = new Point(200, 85);
            datumOdPicker.Name = "datumOdPicker";
            datumOdPicker.Size = new Size(130, 23);
            datumOdPicker.TabIndex = 2;
 
            datumDoPicker.Format = DateTimePickerFormat.Short;
            datumDoPicker.Location = new Point(470, 85);
            datumDoPicker.Name = "datumDoPicker";
            datumDoPicker.Size = new Size(130, 23);
            datumDoPicker.TabIndex = 3;
  
            dugmeSacuvaj.BackColor = Color.MediumSeaGreen;
            dugmeSacuvaj.FlatStyle = FlatStyle.Flat;
            dugmeSacuvaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmeSacuvaj.ForeColor = Color.White;
            dugmeSacuvaj.Location = new Point(160, 150);
            dugmeSacuvaj.Name = "dugmeSacuvaj";
            dugmeSacuvaj.Size = new Size(100, 32);
            dugmeSacuvaj.TabIndex = 4;
            dugmeSacuvaj.Text = "Sačuvaj";
            dugmeSacuvaj.UseVisualStyleBackColor = false;
            dugmeSacuvaj.Click += dugmeSacuvaj_Click;

            dugmePonisti.BackColor = Color.Goldenrod;
            dugmePonisti.FlatStyle = FlatStyle.Flat;
            dugmePonisti.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmePonisti.ForeColor = Color.White;
            dugmePonisti.Location = new Point(300, 150);
            dugmePonisti.Name = "dugmePonisti";
            dugmePonisti.Size = new Size(100, 32);
            dugmePonisti.TabIndex = 5;
            dugmePonisti.Text = " Poništi";
            dugmePonisti.UseVisualStyleBackColor = false;
            dugmePonisti.Click += dugmePonisti_Click;

            dugmeZatvori.BackColor = Color.IndianRed;
            dugmeZatvori.FlatStyle = FlatStyle.Flat;
            dugmeZatvori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dugmeZatvori.ForeColor = Color.White;
            dugmeZatvori.Location = new Point(440, 150);
            dugmeZatvori.Name = "dugmeZatvori";
            dugmeZatvori.Size = new Size(100, 32);
            dugmeZatvori.TabIndex = 6;
            dugmeZatvori.Text = " Zatvori";
            dugmeZatvori.UseVisualStyleBackColor = false;
            dugmeZatvori.Click += dugmeZatvori_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(700, 230);
            Controls.Add(listaIntervencija);
            Controls.Add(listaVozila);
            Controls.Add(lblIntervencija);
            Controls.Add(lblVozilo);
            Controls.Add(lblDatumOd);
            Controls.Add(lblDatumDo);
            Controls.Add(datumOdPicker);
            Controls.Add(datumDoPicker);
            Controls.Add(dugmeSacuvaj);
            Controls.Add(dugmePonisti);
            Controls.Add(dugmeZatvori);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaDodajAngazovano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Angažovanje vozila";
            Load += FormaDodajAngazovano_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox listaIntervencija;
        private ComboBox listaVozila;
        private Label lblIntervencija;
        private Label lblVozilo;
        private Label lblDatumOd;
        private Label lblDatumDo;
        private DateTimePicker datumOdPicker;
        private DateTimePicker datumDoPicker;
        private Button dugmeSacuvaj;
        private Button dugmePonisti;
        private Button dugmeZatvori;
    }
}
