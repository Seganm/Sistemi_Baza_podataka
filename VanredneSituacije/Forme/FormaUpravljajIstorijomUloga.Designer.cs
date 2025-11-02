using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajIstorijomUloga
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
            dateDatumDo = new DateTimePicker();
            label1 = new Label();
            dateDatumOf = new DateTimePicker();
            label2 = new Label();
            textJmbg = new TextBox();
            buttonReset = new Button();
            buttonOdustani = new Button();
            buttonSacuvaj = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();

            dateDatumDo.Format = DateTimePickerFormat.Short;
            dateDatumDo.Location = new Point(409, 51);
            dateDatumDo.Name = "dateDatumDo";
            dateDatumDo.Size = new Size(148, 23);
            dateDatumDo.TabIndex = 7;
  
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(304, 55);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 3;
            label1.Text = "Datum Do:";
            label1.TextAlign = ContentAlignment.MiddleLeft;

            dateDatumOf.Format = DateTimePickerFormat.Short;
            dateDatumOf.Location = new Point(409, 19);
            dateDatumOf.Name = "dateDatumOf";
            dateDatumOf.Size = new Size(148, 23);
            dateDatumOf.TabIndex = 6;

            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(304, 22);
            label2.Name = "label2";
            label2.Size = new Size(99, 16);
            label2.TabIndex = 2;
            label2.Text = "Datum Od:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
  
            textJmbg.Location = new Point(143, 19);
            textJmbg.Name = "textJmbg";
            textJmbg.Size = new Size(147, 23);
            textJmbg.TabIndex = 4;
    
            buttonReset.BackColor = Color.FromArgb(255, 200, 80);
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(252, 97);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(90, 25);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
         
            buttonOdustani.BackColor = Color.FromArgb(220, 70, 70);
            buttonOdustani.FlatAppearance.BorderSize = 0;
            buttonOdustani.FlatStyle = FlatStyle.Flat;
            buttonOdustani.ForeColor = Color.White;
            buttonOdustani.Location = new Point(360, 97);
            buttonOdustani.Name = "buttonOdustani";
            buttonOdustani.Size = new Size(82, 25);
            buttonOdustani.TabIndex = 9;
            buttonOdustani.Text = "Odustani";
            buttonOdustani.UseVisualStyleBackColor = false;
            buttonOdustani.Click += buttonOdustani_Click;
       
            buttonSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            buttonSacuvaj.FlatAppearance.BorderSize = 0;
            buttonSacuvaj.FlatStyle = FlatStyle.Flat;
            buttonSacuvaj.ForeColor = Color.White;
            buttonSacuvaj.Location = new Point(155, 97);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(82, 25);
            buttonSacuvaj.TabIndex = 10;
            buttonSacuvaj.Text = "Sačuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
      
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(38, 51);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 1;
            label3.Text = "Uloga:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
       
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(38, 23);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 0;
            label4.Text = "JMBG:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
      
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Operativni Radnik", "Koordinator", "Analitičar" });
            comboBox1.Location = new Point(143, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 5;
        
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 251);
            ClientSize = new Size(598, 144);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textJmbg);
            Controls.Add(comboBox1);
            Controls.Add(dateDatumOf);
            Controls.Add(dateDatumDo);
            Controls.Add(buttonReset);
            Controls.Add(buttonOdustani);
            Controls.Add(buttonSacuvaj);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajIstorijomUloga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje istorijom uloga";
            Load += FormaUpravljajIstorijomUloga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateDatumDo;
        private Label label1;
        private DateTimePicker dateDatumOf;
        private Label label2;
        private TextBox textJmbg;
        private Button buttonReset;
        private Button buttonOdustani;
        private Button buttonSacuvaj;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}
