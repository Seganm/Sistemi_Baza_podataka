using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajLicnomZastitom
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
            dateNabavka = new DateTimePicker();
            comboTip = new ComboBox();
            label6 = new Label();
            comboJedinica = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textNaziv = new TextBox();
            comboStatus = new ComboBox();
            textSb = new TextBox();
            buttonRst = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
     
            dateNabavka.Location = new Point(383, 15);
            dateNabavka.Name = "dateNabavka";
            dateNabavka.Size = new Size(148, 23);
            dateNabavka.TabIndex = 0;
        
            comboTip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTip.FormattingEnabled = true;
            comboTip.Location = new Point(383, 77);
            comboTip.Name = "comboTip";
            comboTip.Size = new Size(147, 23);
            comboTip.TabIndex = 1;
        
            label6.ForeColor = Color.FromArgb(40, 40, 40);
            label6.Location = new Point(280, 80);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 2;
            label6.Text = "Tip:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
        
            comboJedinica.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJedinica.FormattingEnabled = true;
            comboJedinica.Location = new Point(383, 45);
            comboJedinica.Name = "comboJedinica";
            comboJedinica.Size = new Size(147, 23);
            comboJedinica.TabIndex = 3;
      
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(280, 47);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Jedinica:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
        
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(280, 19);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Datum nabavke:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
         
            textNaziv.BackColor = Color.White;
            textNaziv.Location = new Point(120, 44);
            textNaziv.Name = "textNaziv";
            textNaziv.Size = new Size(147, 23);
            textNaziv.TabIndex = 6;
       
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(120, 72);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(147, 23);
            comboStatus.TabIndex = 7;
        
            textSb.BackColor = Color.White;
            textSb.Location = new Point(120, 16);
            textSb.Name = "textSb";
            textSb.Size = new Size(147, 23);
            textSb.TabIndex = 8;
       
            buttonRst.BackColor = Color.FromArgb(255, 210, 90);
            buttonRst.FlatAppearance.BorderSize = 0;
            buttonRst.FlatStyle = FlatStyle.Flat;
            buttonRst.Font = new Font("Segoe UI Semibold", 9F);
            buttonRst.Location = new Point(241, 128);
            buttonRst.Name = "buttonRst";
            buttonRst.Size = new Size(90, 25);
            buttonRst.TabIndex = 9;
            buttonRst.Text = "Reset";
            buttonRst.UseVisualStyleBackColor = false;
           
            buttonCancel.BackColor = Color.FromArgb(230, 80, 80);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 9F);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(383, 128);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 25);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Odustani";
            buttonCancel.UseVisualStyleBackColor = false;
         
            buttonSave.BackColor = Color.FromArgb(60, 120, 200);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI Semibold", 9F);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(96, 128);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(82, 25);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Sačuvaj";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
      
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(16, 78);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 12;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
       
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(16, 50);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 13;
            label3.Text = "Naziv:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
    
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(16, 21);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 14;
            label4.Text = "Serijski broj:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
       
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(592, 182);
            Controls.Add(dateNabavka);
            Controls.Add(comboTip);
            Controls.Add(label6);
            Controls.Add(comboJedinica);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textNaziv);
            Controls.Add(comboStatus);
            Controls.Add(textSb);
            Controls.Add(buttonRst);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajLicnomZastitom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje ličnom zaštitom";
            Load += FormaUpravljajLicnomZastitom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateNabavka;
        private ComboBox comboTip;
        private Label label6;
        private ComboBox comboJedinica;
        private Label label1;
        private Label label2;
        private TextBox textNaziv;
        private ComboBox comboStatus;
        private TextBox textSb;
        private Button buttonRst;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label5;
        private Label label3;
        private Label label4;
    }
}
