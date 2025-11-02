using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaUpravljajKamionom
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
            textLok = new TextBox();
            label1 = new Label();
            textPro = new TextBox();
            comboStatus = new ComboBox();
            textReg = new TextBox();
            buttonReset = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
   
            textLok.Location = new Point(375, 64);
            textLok.Margin = new Padding(3, 2, 3, 2);
            textLok.Name = "textLok";
            textLok.Size = new Size(147, 23);
            textLok.TabIndex = 0;
   
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(274, 64);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lokacija:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
         
            textPro.Location = new Point(119, 58);
            textPro.Margin = new Padding(3, 2, 3, 2);
            textPro.Name = "textPro";
            textPro.Size = new Size(147, 23);
            textPro.TabIndex = 2;
      
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Location = new Point(375, 26);
            comboStatus.Margin = new Padding(3, 2, 3, 2);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(147, 23);
            comboStatus.TabIndex = 3;
       
            textReg.Location = new Point(119, 29);
            textReg.Margin = new Padding(3, 2, 3, 2);
            textReg.Name = "textReg";
            textReg.Size = new Size(147, 23);
            textReg.TabIndex = 4;

            buttonReset.BackColor = Color.FromArgb(255, 200, 80);
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(211, 131);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(90, 24);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
   
            buttonCancel.BackColor = Color.FromArgb(220, 70, 70);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(349, 131);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 24);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Odustani";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
       
            buttonSave.BackColor = Color.FromArgb(0, 122, 204);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(89, 131);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(82, 24);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Sačuvaj";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
    
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(274, 32);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 8;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
      
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(18, 63);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 9;
            label3.Text = "Proizvođač:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
  
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(18, 34);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 10;
            label4.Text = "Reg. oznaka:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
     
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 251);
            ClientSize = new Size(539, 185);
            Controls.Add(textLok);
            Controls.Add(label1);
            Controls.Add(textPro);
            Controls.Add(comboStatus);
            Controls.Add(textReg);
            Controls.Add(buttonReset);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormaUpravljajKamionom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje kamionom";
            Load += FormaUpravljajKamionom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textLok;
        private Label label1;
        private TextBox textPro;
        private ComboBox comboStatus;
        private TextBox textReg;
        private Button buttonReset;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label5;
        private Label label3;
        private Label label4;
    }
}
