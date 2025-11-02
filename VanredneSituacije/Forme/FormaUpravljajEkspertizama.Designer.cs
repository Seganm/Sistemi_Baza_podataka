using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajEkspertizama
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
            txtOblastEkspertize = new TextBox();
            lblOblastEkspertize = new Label();
            txtJmbgAnaliticara = new TextBox();
            lblJmbgAnaliticara = new Label();
            btnResetuj = new Button();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            lblNaslov = new Label();
            SuspendLayout();
 
            txtOblastEkspertize.Location = new Point(476, 77);
            txtOblastEkspertize.Name = "txtOblastEkspertize";
            txtOblastEkspertize.Size = new Size(140, 25);
            txtOblastEkspertize.TabIndex = 4;
 
            lblOblastEkspertize.AutoSize = true;
            lblOblastEkspertize.Location = new Point(341, 82);
            lblOblastEkspertize.Name = "lblOblastEkspertize";
            lblOblastEkspertize.Size = new Size(117, 19);
            lblOblastEkspertize.TabIndex = 3;
            lblOblastEkspertize.Text = "Oblast ekspertize:";
 
            txtJmbgAnaliticara.Location = new Point(173, 78);
            txtJmbgAnaliticara.Name = "txtJmbgAnaliticara";
            txtJmbgAnaliticara.Size = new Size(140, 25);
            txtJmbgAnaliticara.TabIndex = 2;
 
            lblJmbgAnaliticara.AutoSize = true;
            lblJmbgAnaliticara.Location = new Point(38, 83);
            lblJmbgAnaliticara.Name = "lblJmbgAnaliticara";
            lblJmbgAnaliticara.Size = new Size(113, 19);
            lblJmbgAnaliticara.TabIndex = 1;
            lblJmbgAnaliticara.Text = "JMBG analitičara:";
 
            btnResetuj.BackColor = Color.FromArgb(241, 196, 15);
            btnResetuj.FlatStyle = FlatStyle.Flat;
            btnResetuj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnResetuj.ForeColor = Color.Black;
            btnResetuj.Location = new Point(253, 159);
            btnResetuj.Name = "btnResetuj";
            btnResetuj.Size = new Size(164, 39);
            btnResetuj.TabIndex = 6;
            btnResetuj.Text = "Resetuj";
            btnResetuj.UseVisualStyleBackColor = false;
            btnResetuj.Click += btnResetuj_Click;
 
            btnOdustani.BackColor = Color.FromArgb(231, 76, 60);
            btnOdustani.FlatStyle = FlatStyle.Flat;
            btnOdustani.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnOdustani.ForeColor = Color.White;
            btnOdustani.Location = new Point(444, 159);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(172, 39);
            btnOdustani.TabIndex = 7;
            btnOdustani.Text = "Otkaži";
            btnOdustani.UseVisualStyleBackColor = false;
            btnOdustani.Click += btnOdustani_Click;
 
            btnSacuvaj.BackColor = Color.FromArgb(46, 204, 113);
            btnSacuvaj.FlatStyle = FlatStyle.Flat;
            btnSacuvaj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSacuvaj.ForeColor = Color.White;
            btnSacuvaj.Location = new Point(38, 159);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(188, 39);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(41, 128, 185);
            lblNaslov.Location = new Point(253, 9);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(199, 28);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Podaci o ekspertizi";
 
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(675, 243);
            Controls.Add(lblNaslov);
            Controls.Add(lblJmbgAnaliticara);
            Controls.Add(txtJmbgAnaliticara);
            Controls.Add(lblOblastEkspertize);
            Controls.Add(txtOblastEkspertize);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnResetuj);
            Controls.Add(btnOdustani);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(44, 62, 80);
            Name = "FormaUpravljajEkspertizama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje ekspertizama";
            Load += FormaUpravljajEkspertizama_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOblastEkspertize;
        private Label lblOblastEkspertize;
        private TextBox txtJmbgAnaliticara;
        private Label lblJmbgAnaliticara;
        private Button btnResetuj;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private Label lblNaslov;
    }
}
