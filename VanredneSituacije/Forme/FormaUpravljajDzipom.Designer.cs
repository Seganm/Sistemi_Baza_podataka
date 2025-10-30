using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajDzipom
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
            naslov = new Label();
            labelReg = new Label();
            textReg = new TextBox();
            labelProizvodjac = new Label();
            textProizvodjac = new TextBox();
            labelStatus = new Label();
            comboStatus = new ComboBox();
            labelLok = new Label();
            textLok = new TextBox();
            buttonSacuvaj = new Button();
            buttonReset = new Button();
            buttonCancel = new Button();

            SuspendLayout();

            
            naslov.AutoSize = true;
            naslov.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            naslov.ForeColor = Color.FromArgb(41, 128, 185);
            naslov.Location = new Point(290, 25);
            naslov.Name = "naslov";
            naslov.Size = new Size(175, 28);
            naslov.TabIndex = 0;
            naslov.Text = "Podaci o džipu";

           
            labelReg.AutoSize = true;
            labelReg.Font = new Font("Segoe UI", 10F);
            labelReg.Location = new Point(80, 110);
            labelReg.Name = "labelReg";
            labelReg.Size = new Size(88, 19);
            labelReg.TabIndex = 1;
            labelReg.Text = "Reg. oznaka:";

            
            textReg.Font = new Font("Segoe UI", 10F);
            textReg.Location = new Point(190, 107);
            textReg.Name = "textReg";
            textReg.Size = new Size(160, 25);
            textReg.TabIndex = 2;

         
            labelProizvodjac.AutoSize = true;
            labelProizvodjac.Font = new Font("Segoe UI", 10F);
            labelProizvodjac.Location = new Point(412, 110);
            labelProizvodjac.Name = "labelProizvodjac";
            labelProizvodjac.Size = new Size(80, 19);
            labelProizvodjac.TabIndex = 3;
            labelProizvodjac.Text = "Proizvođač:";
 
            textProizvodjac.Font = new Font("Segoe UI", 10F);
            textProizvodjac.Location = new Point(522, 107);
            textProizvodjac.Name = "textProizvodjac";
            textProizvodjac.Size = new Size(160, 25);
            textProizvodjac.TabIndex = 4;
 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F);
            labelStatus.Location = new Point(80, 155);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 19);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status:";
 
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Font = new Font("Segoe UI", 10F);
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Operativno", "U kvaru" });
            comboStatus.Location = new Point(190, 152);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(160, 25);
            comboStatus.TabIndex = 6;
            comboStatus.SelectedIndexChanged += comboStatus_SelectedIndexChanged;

     
            labelLok.AutoSize = true;
            labelLok.Font = new Font("Segoe UI", 10F);
            labelLok.Location = new Point(412, 155);
            labelLok.Name = "labelLok";
            labelLok.Size = new Size(64, 19);
            labelLok.TabIndex = 7;
            labelLok.Text = "Lokacija:";
 
            textLok.Font = new Font("Segoe UI", 10F);
            textLok.Location = new Point(522, 152);
            textLok.Name = "textLok";
            textLok.Size = new Size(160, 25);
            textLok.TabIndex = 8;

  
            buttonSacuvaj.BackColor = Color.FromArgb(46, 204, 113);
            buttonSacuvaj.FlatStyle = FlatStyle.Flat;
            buttonSacuvaj.FlatAppearance.BorderSize = 0;
            buttonSacuvaj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonSacuvaj.ForeColor = Color.White;
            buttonSacuvaj.Location = new Point(80, 250);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(149, 38);
            buttonSacuvaj.TabIndex = 9;
            buttonSacuvaj.Text = "💾 Sačuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
             
            buttonReset.BackColor = Color.FromArgb(241, 196, 15);
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonReset.ForeColor = Color.Black;
            buttonReset.Location = new Point(317, 250);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(138, 38);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "🔄 Resetuj";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;

     
            buttonCancel.BackColor = Color.FromArgb(231, 76, 60);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(543, 250);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(139, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "❌ Otkaži";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(744, 340);
            Controls.Add(naslov);
            Controls.Add(labelReg);
            Controls.Add(textReg);
            Controls.Add(labelProizvodjac);
            Controls.Add(textProizvodjac);
            Controls.Add(labelStatus);
            Controls.Add(comboStatus);
            Controls.Add(labelLok);
            Controls.Add(textLok);
            Controls.Add(buttonSacuvaj);
            Controls.Add(buttonReset);
            Controls.Add(buttonCancel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(44, 62, 80);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajDzipom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje džipom";
            Load += FormaUpravljajDzipom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label naslov;
        private Label labelReg;
        private TextBox textReg;
        private Label labelProizvodjac;
        private TextBox textProizvodjac;
        private Label labelStatus;
        private ComboBox comboStatus;
        private Label labelLok;
        private TextBox textLok;
        private Button buttonSacuvaj;
        private Button buttonReset;
        private Button buttonCancel;
    }
}
