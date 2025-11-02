using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajDodeljenim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            dateDo = new DateTimePicker();
            label1 = new Label();
            dateOd = new DateTimePicker();
            label2 = new Label();
            btnCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboJedinica = new ComboBox();
            comboRadnik = new ComboBox();
            comboVozilo = new ComboBox();
            buttonDodaj = new Button();
            buttonReset = new Button();
            SuspendLayout();
       
            dateDo.Font = new Font("Segoe UI", 10F);
            dateDo.Format = DateTimePickerFormat.Short;
            dateDo.Location = new Point(495, 77);
            dateDo.Name = "dateDo";
            dateDo.Size = new Size(200, 25);
            dateDo.TabIndex = 9;
      
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 45, 45);
            label1.Location = new Point(405, 80);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 8;
            label1.Text = "Datum do:";
          
            dateOd.Font = new Font("Segoe UI", 10F);
            dateOd.Format = DateTimePickerFormat.Short;
            dateOd.Location = new Point(495, 42);
            dateOd.Name = "dateOd";
            dateOd.Size = new Size(200, 25);
            dateOd.TabIndex = 7;
       
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 45, 45);
            label2.Location = new Point(405, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 6;
            label2.Text = "Datum od:";
     
            btnCancel.BackColor = Color.FromArgb(220, 70, 70);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(628, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Odustani";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
    
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 45, 45);
            label3.Location = new Point(60, 85);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 2;
            label3.Text = "Radnik:";
    
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 45, 45);
            label4.Location = new Point(60, 125);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 4;
            label4.Text = "Jedinica:";
   
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 45, 45);
            label5.Location = new Point(60, 45);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 0;
            label5.Text = "Vozilo:";
 
            comboJedinica.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJedinica.Font = new Font("Segoe UI", 10F);
            comboJedinica.Location = new Point(150, 122);
            comboJedinica.Name = "comboJedinica";
            comboJedinica.Size = new Size(200, 25);
            comboJedinica.TabIndex = 5;
            comboJedinica.SelectedIndexChanged += comboJedinica_SelectedIndexChanged;

            comboRadnik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRadnik.Font = new Font("Segoe UI", 10F);
            comboRadnik.Location = new Point(150, 82);
            comboRadnik.Name = "comboRadnik";
            comboRadnik.Size = new Size(200, 25);
            comboRadnik.TabIndex = 3;
            comboRadnik.SelectedIndexChanged += comboRadnik_SelectedIndexChanged;

            comboVozilo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVozilo.Font = new Font("Segoe UI", 10F);
            comboVozilo.Location = new Point(150, 42);
            comboVozilo.Name = "comboVozilo";
            comboVozilo.Size = new Size(200, 25);
            comboVozilo.TabIndex = 1;
            comboVozilo.SelectedIndexChanged += comboVozilo_SelectedIndexChanged;

            buttonDodaj.BackColor = Color.FromArgb(0, 120, 215);
            buttonDodaj.FlatAppearance.BorderSize = 0;
            buttonDodaj.FlatStyle = FlatStyle.Flat;
            buttonDodaj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonDodaj.ForeColor = Color.White;
            buttonDodaj.Location = new Point(388, 122);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(100, 35);
            buttonDodaj.TabIndex = 10;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += btnSave_Click;

            buttonReset.BackColor = Color.FromArgb(255, 210, 80);
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonReset.ForeColor = Color.FromArgb(60, 60, 60);
            buttonReset.Location = new Point(508, 122);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 35);
            buttonReset.TabIndex = 11;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += btnRst_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(848, 192);
            Controls.Add(label5);
            Controls.Add(comboVozilo);
            Controls.Add(label3);
            Controls.Add(comboRadnik);
            Controls.Add(label4);
            Controls.Add(comboJedinica);
            Controls.Add(label2);
            Controls.Add(dateOd);
            Controls.Add(label1);
            Controls.Add(dateDo);
            Controls.Add(buttonDodaj);
            Controls.Add(buttonReset);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajDodeljenim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje dodeljivanjem";
            Load += FormaUpravljajDodeljenim_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DateTimePicker dateDo;
        private Label label1;
        private DateTimePicker dateOd;
        private Label label2;
        private Button btnCancel;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboJedinica;
        private ComboBox comboRadnik;
        private ComboBox comboVozilo;
        private Button buttonDodaj;
        private Button buttonReset;
    }
}
