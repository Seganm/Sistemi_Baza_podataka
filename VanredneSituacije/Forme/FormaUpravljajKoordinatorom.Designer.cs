using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajKoordinatorom
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttonSacuvaj = new Button();
            buttonOdustani = new Button();
            buttonRst = new Button();
            textJmbg = new TextBox();
            textIme = new TextBox();
            textPrezime = new TextBox();
            checkMusko = new CheckBox();
            checkZensko = new CheckBox();
            dateRodjenje = new DateTimePicker();
            textKontakt = new TextBox();
            textEmail = new TextBox();
            textAdresa = new TextBox();
            dateZaposlenje = new DateTimePicker();
            SuspendLayout();
      
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(33, 100);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Prezime:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
   
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(33, 69);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
     
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(33, 40);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "JMBG:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
     
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(33, 128);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Datum rođenja:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
        
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(49, 181);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "Pol:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
    
            label6.ForeColor = Color.FromArgb(40, 40, 40);
            label6.Location = new Point(311, 37);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 5;
            label6.Text = "Kontakt:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
     
            label7.ForeColor = Color.FromArgb(40, 40, 40);
            label7.Location = new Point(311, 69);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
     
            label8.ForeColor = Color.FromArgb(40, 40, 40);
            label8.Location = new Point(311, 97);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 7;
            label8.Text = "Adresa:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
      
            label9.ForeColor = Color.FromArgb(40, 40, 40);
            label9.Location = new Point(297, 126);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 8;
            label9.Text = "Datum zaposlenja:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
     
            buttonSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            buttonSacuvaj.FlatAppearance.BorderSize = 0;
            buttonSacuvaj.FlatStyle = FlatStyle.Flat;
            buttonSacuvaj.ForeColor = Color.White;
            buttonSacuvaj.Location = new Point(299, 179);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(82, 25);
            buttonSacuvaj.TabIndex = 19;
            buttonSacuvaj.Text = "Sačuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
 
            buttonOdustani.BackColor = Color.FromArgb(220, 70, 70);
            buttonOdustani.FlatAppearance.BorderSize = 0;
            buttonOdustani.FlatStyle = FlatStyle.Flat;
            buttonOdustani.ForeColor = Color.White;
            buttonOdustani.Location = new Point(480, 179);
            buttonOdustani.Name = "buttonOdustani";
            buttonOdustani.Size = new Size(82, 25);
            buttonOdustani.TabIndex = 20;
            buttonOdustani.Text = "Odustani";
            buttonOdustani.UseVisualStyleBackColor = false;
            buttonOdustani.Click += buttonOdustani_Click;
   
            buttonRst.BackColor = Color.FromArgb(255, 200, 80);
            buttonRst.FlatAppearance.BorderSize = 0;
            buttonRst.FlatStyle = FlatStyle.Flat;
            buttonRst.Location = new Point(384, 179);
            buttonRst.Name = "buttonRst";
            buttonRst.Size = new Size(90, 25);
            buttonRst.TabIndex = 21;
            buttonRst.Text = "Reset";
            buttonRst.UseVisualStyleBackColor = false;
            buttonRst.Click += buttonRst_Click;
    
            textJmbg.Location = new Point(137, 35);
            textJmbg.MaxLength = 13;
            textJmbg.Name = "textJmbg";
            textJmbg.Size = new Size(147, 23);
            textJmbg.TabIndex = 9;
    
            textIme.Location = new Point(137, 66);
            textIme.Name = "textIme";
            textIme.Size = new Size(147, 23);
            textIme.TabIndex = 10;
    
            textPrezime.Location = new Point(137, 98);
            textPrezime.Name = "textPrezime";
            textPrezime.Size = new Size(147, 23);
            textPrezime.TabIndex = 11;
   
            checkMusko.Location = new Point(137, 180);
            checkMusko.Name = "checkMusko";
            checkMusko.Size = new Size(33, 24);
            checkMusko.TabIndex = 17;
            checkMusko.Text = "M";
      
            checkZensko.Location = new Point(176, 179);
            checkZensko.Name = "checkZensko";
            checkZensko.Size = new Size(33, 24);
            checkZensko.TabIndex = 18;
            checkZensko.Text = "Z";
        
            dateRodjenje.Location = new Point(137, 128);
            dateRodjenje.Name = "dateRodjenje";
            dateRodjenje.Size = new Size(147, 23);
            dateRodjenje.TabIndex = 15;
     
            textKontakt.Location = new Point(415, 35);
            textKontakt.Name = "textKontakt";
            textKontakt.Size = new Size(147, 23);
            textKontakt.TabIndex = 12;
        
            textEmail.Location = new Point(415, 69);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(147, 23);
            textEmail.TabIndex = 13;
         
            textAdresa.Location = new Point(415, 97);
            textAdresa.Name = "textAdresa";
            textAdresa.Size = new Size(147, 23);
            textAdresa.TabIndex = 14;
        
            dateZaposlenje.Location = new Point(415, 126);
            dateZaposlenje.Name = "dateZaposlenje";
            dateZaposlenje.Size = new Size(147, 23);
            dateZaposlenje.TabIndex = 16;
      
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 251);
            ClientSize = new Size(604, 235);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textJmbg);
            Controls.Add(textIme);
            Controls.Add(textPrezime);
            Controls.Add(textKontakt);
            Controls.Add(textEmail);
            Controls.Add(textAdresa);
            Controls.Add(dateRodjenje);
            Controls.Add(dateZaposlenje);
            Controls.Add(checkMusko);
            Controls.Add(checkZensko);
            Controls.Add(buttonSacuvaj);
            Controls.Add(buttonOdustani);
            Controls.Add(buttonRst);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajKoordinatorom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje koordinatorom";
            Load += FormaUpravljajKoordinatorom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button buttonSacuvaj;
        private Button buttonOdustani;
        private Button buttonRst;
        private TextBox textJmbg;
        private TextBox textIme;
        private TextBox textPrezime;
        private CheckBox checkMusko;
        private CheckBox checkZensko;
        private DateTimePicker dateRodjenje;
        private TextBox textKontakt;
        private TextBox textEmail;
        private TextBox textAdresa;
        private DateTimePicker dateZaposlenje;
    }
}
