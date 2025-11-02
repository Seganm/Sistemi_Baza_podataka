using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajIntervencijama
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
            label1 = new Label();
            numericPovredjeni = new NumericUpDown();
            dateDatumVreme = new DateTimePicker();
            textResursi = new TextBox();
            textLokacija = new TextBox();
            buttonRst = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboStatus = new ComboBox();
            numericSpaseni = new NumericUpDown();
            numericUspesnost = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericPovredjeni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSpaseni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUspesnost).BeginInit();
            SuspendLayout();
           
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(259, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Broj povređenih:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            
            numericPovredjeni.Location = new Point(393, 34);
            numericPovredjeni.Margin = new Padding(3, 2, 3, 2);
            numericPovredjeni.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericPovredjeni.Name = "numericPovredjeni";
            numericPovredjeni.Size = new Size(128, 23);
            numericPovredjeni.TabIndex = 4;
          
            dateDatumVreme.Location = new Point(120, 8);
            dateDatumVreme.Margin = new Padding(3, 2, 3, 2);
            dateDatumVreme.Name = "dateDatumVreme";
            dateDatumVreme.Size = new Size(129, 23);
            dateDatumVreme.TabIndex = 5;
         
            textResursi.Location = new Point(119, 88);
            textResursi.Margin = new Padding(3, 2, 3, 2);
            textResursi.Multiline = true;
            textResursi.Name = "textResursi";
            textResursi.Size = new Size(129, 52);
            textResursi.TabIndex = 6;
            
            textLokacija.Location = new Point(121, 35);
            textLokacija.Margin = new Padding(3, 2, 3, 2);
            textLokacija.Name = "textLokacija";
            textLokacija.Size = new Size(129, 23);
            textLokacija.TabIndex = 7;
           
            buttonRst.BackColor = Color.FromArgb(255, 200, 80);
            buttonRst.FlatAppearance.BorderSize = 0;
            buttonRst.FlatStyle = FlatStyle.Flat;
            buttonRst.Location = new Point(362, 117);
            buttonRst.Margin = new Padding(3, 2, 3, 2);
            buttonRst.Name = "buttonRst";
            buttonRst.Size = new Size(79, 23);
            buttonRst.TabIndex = 8;
            buttonRst.Text = "Reset";
            buttonRst.UseVisualStyleBackColor = false;
            buttonRst.Click += buttonRst_Click;
           
            buttonCancel.BackColor = Color.FromArgb(220, 70, 70);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(449, 119);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(72, 21);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Odustani";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
         
            buttonSave.BackColor = Color.FromArgb(0, 122, 204);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(281, 119);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(72, 21);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Sačuvaj";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click_1;
          
            label9.ForeColor = Color.FromArgb(40, 40, 40);
            label9.Location = new Point(259, 7);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 11;
            label9.Text = "Broj spašenih:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
           
            label8.ForeColor = Color.FromArgb(40, 40, 40);
            label8.Location = new Point(20, 103);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 12;
            label8.Text = "Resursi:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(259, 64);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 13;
            label5.Text = "Uspešnost (%):";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(20, 66);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 14;
            label3.Text = "Status:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(19, 10);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 15;
            label2.Text = "Datum i vreme:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
           
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(20, 38);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 16;
            label4.Text = "Lokacija:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
           
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Items.AddRange(new object[] { "U_toku", "Zavrsena" });
            comboStatus.Location = new Point(119, 61);
            comboStatus.Margin = new Padding(3, 2, 3, 2);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(129, 23);
            comboStatus.TabIndex = 2;
          
            numericSpaseni.Location = new Point(393, 5);
            numericSpaseni.Margin = new Padding(3, 2, 3, 2);
            numericSpaseni.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericSpaseni.Name = "numericSpaseni";
            numericSpaseni.Size = new Size(128, 23);
            numericSpaseni.TabIndex = 1;
           
            numericUspesnost.Location = new Point(393, 64);
            numericUspesnost.Margin = new Padding(3, 2, 3, 2);
            numericUspesnost.Name = "numericUspesnost";
            numericUspesnost.Size = new Size(128, 23);
            numericUspesnost.TabIndex = 0;
          
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 251);
            ClientSize = new Size(574, 158);
            Controls.Add(numericUspesnost);
            Controls.Add(numericSpaseni);
            Controls.Add(comboStatus);
            Controls.Add(label1);
            Controls.Add(numericPovredjeni);
            Controls.Add(dateDatumVreme);
            Controls.Add(textResursi);
            Controls.Add(textLokacija);
            Controls.Add(buttonRst);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajIntervencijama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje intervencijama";
            Load += FormaUpravljajIntervencijama_Load;
            ((System.ComponentModel.ISupportInitialize)numericPovredjeni).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSpaseni).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUspesnost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericPovredjeni;
        private DateTimePicker dateDatumVreme;
        private TextBox textResursi;
        private TextBox textLokacija;
        private Button buttonRst;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox comboStatus;
        private NumericUpDown numericSpaseni;
        private NumericUpDown numericUspesnost;
    }
}
