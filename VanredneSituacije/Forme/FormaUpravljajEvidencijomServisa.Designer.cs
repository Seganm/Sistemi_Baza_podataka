using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajEvidencijomServisa
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
            txtVozilo = new TextBox();
            txtTip = new TextBox();
            label1 = new Label();
            buttonReset = new Button();
            buttonOdustani = new Button();
            buttonSacuvaj = new Button();
            label5 = new Label();
            dateDatum = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtVozilo
            // 
            txtVozilo.Location = new Point(125, 20);
            txtVozilo.Margin = new Padding(3, 2, 3, 2);
            txtVozilo.Name = "txtVozilo";
            txtVozilo.Size = new Size(145, 23);
            txtVozilo.TabIndex = 2;
            // 
            // txtTip
            // 
            txtTip.Location = new Point(125, 48);
            txtTip.Margin = new Padding(3, 2, 3, 2);
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(145, 23);
            txtTip.TabIndex = 3;
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Tip servisa:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(255, 200, 80);
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(248, 100);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(88, 21);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += button3_Click;
            // 
            // buttonOdustani
            // 
            buttonOdustani.BackColor = Color.FromArgb(220, 70, 70);
            buttonOdustani.FlatAppearance.BorderSize = 0;
            buttonOdustani.FlatStyle = FlatStyle.Flat;
            buttonOdustani.ForeColor = Color.White;
            buttonOdustani.Location = new Point(388, 100);
            buttonOdustani.Margin = new Padding(3, 2, 3, 2);
            buttonOdustani.Name = "buttonOdustani";
            buttonOdustani.Size = new Size(79, 22);
            buttonOdustani.TabIndex = 6;
            buttonOdustani.Text = "Odustani";
            buttonOdustani.UseVisualStyleBackColor = false;
            buttonOdustani.Click += button2_Click;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            buttonSacuvaj.FlatAppearance.BorderSize = 0;
            buttonSacuvaj.FlatStyle = FlatStyle.Flat;
            buttonSacuvaj.ForeColor = Color.White;
            buttonSacuvaj.Location = new Point(125, 99);
            buttonSacuvaj.Margin = new Padding(3, 2, 3, 2);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(79, 22);
            buttonSacuvaj.TabIndex = 7;
            buttonSacuvaj.Text = "Sačuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += button1_Click;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(21, 22);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 8;
            label5.Text = "Vozilo:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateDatum
            // 
            dateDatum.Format = DateTimePickerFormat.Short;
            dateDatum.Location = new Point(388, 20);
            dateDatum.Margin = new Padding(3, 2, 3, 2);
            dateDatum.Name = "dateDatum";
            dateDatum.Size = new Size(145, 23);
            dateDatum.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(284, 23);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Datum:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormaUpravljajEvidencijomServisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 251);
            ClientSize = new Size(564, 149);
            Controls.Add(label2);
            Controls.Add(dateDatum);
            Controls.Add(txtVozilo);
            Controls.Add(txtTip);
            Controls.Add(label1);
            Controls.Add(buttonReset);
            Controls.Add(buttonOdustani);
            Controls.Add(buttonSacuvaj);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajEvidencijomServisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija servisa";
            Load += FormaUpravljajEvidencijomServisa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVozilo;
        private TextBox txtTip;
        private Label label1;
        private Button buttonReset;
        private Button buttonOdustani;
        private Button buttonSacuvaj;
        private Label label5;
        private DateTimePicker dateDatum;
        private Label label2;
    }
}
