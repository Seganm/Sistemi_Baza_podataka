using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajIntervenise
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
            comboVs = new ComboBox();
            comboJedinica = new ComboBox();
            label2 = new Label();
            buttonOdustani = new Button();
            buttonSacuvaj = new Button();
            label3 = new Label();
            label4 = new Label();
            comboIntervencija = new ComboBox();
            SuspendLayout();
 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 251);
            ClientSize = new Size(380, 260);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Upravljanje intervencijama";
            Load += FormaUpravljajIntervenise_Load;
 
            label4.Text = "Jedinica:";
            label4.Location = new Point(60, 29);
            label4.Size = new Size(110, 20);
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.TextAlign = ContentAlignment.MiddleLeft;
   
            label3.Text = "Intervencija:";
            label3.Location = new Point(60, 67);
            label3.Size = new Size(110, 20);
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.TextAlign = ContentAlignment.MiddleLeft;

            label2.Text = "Vanredna situacija:";
            label2.Location = new Point(44, 110);
            label2.Size = new Size(140, 22);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.TextAlign = ContentAlignment.MiddleLeft;

            comboJedinica.Location = new Point(182, 26);
            comboJedinica.Size = new Size(170, 28);
            comboJedinica.DropDownStyle = ComboBoxStyle.DropDownList;
            comboJedinica.SelectedIndexChanged += comboJedinica_SelectedIndexChanged;

            comboIntervencija.Location = new Point(182, 67);
            comboIntervencija.Size = new Size(170, 28);
            comboIntervencija.DropDownStyle = ComboBoxStyle.DropDownList;
            comboIntervencija.SelectedIndexChanged += comboIntervencija_SelectedIndexChanged;

            comboVs.Location = new Point(182, 108);
            comboVs.Size = new Size(170, 28);
            comboVs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVs.SelectedIndexChanged += comboVs_SelectedIndexChanged;

            buttonSacuvaj.Text = "Sačuvaj";
            buttonSacuvaj.Location = new Point(66, 190);
            buttonSacuvaj.Size = new Size(94, 30);
            buttonSacuvaj.BackColor = Color.FromArgb(0, 122, 204);
            buttonSacuvaj.ForeColor = Color.White;
            buttonSacuvaj.FlatStyle = FlatStyle.Flat;
            buttonSacuvaj.FlatAppearance.BorderSize = 0;
            buttonSacuvaj.Click += button1_Click;

            buttonOdustani.Text = "Odustani";
            buttonOdustani.Location = new Point(258, 190);
            buttonOdustani.Size = new Size(94, 30);
            buttonOdustani.BackColor = Color.FromArgb(220, 70, 70);
            buttonOdustani.ForeColor = Color.White;
            buttonOdustani.FlatStyle = FlatStyle.Flat;
            buttonOdustani.FlatAppearance.BorderSize = 0;
            buttonOdustani.Click += button2_Click;
  
            Controls.Add(comboIntervencija);
            Controls.Add(comboVs);
            Controls.Add(comboJedinica);
            Controls.Add(label2);
            Controls.Add(buttonOdustani);
            Controls.Add(buttonSacuvaj);
            Controls.Add(label3);
            Controls.Add(label4);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboVs;
        private ComboBox comboJedinica;
        private Label label2;
        private Button buttonOdustani;
        private Button buttonSacuvaj;
        private Label label3;
        private Label label4;
        private ComboBox comboIntervencija;
    }
}
