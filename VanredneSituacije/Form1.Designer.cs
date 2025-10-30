using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije
{
    partial class Form1
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
            panelDugmici = new Panel();
            lblNaslov = new Label();
            panelPrikaz = new Panel();
            button3 = new Button();
            btnJedinice = new Button();
            button2 = new Button();
            btnIntervencije = new Button();
            button1 = new Button();
            btnPrijava = new Button();
            buttonSaradnje = new Button();
            btnZaposleni = new Button();
            btnOprema = new Button();
            btnVozila = new Button();
            btnIstorija = new Button();
            button8 = new Button();
            buttonUcestvuje = new Button();
            btnVs = new Button();
            panelDugmici.SuspendLayout();
            SuspendLayout();
            // 
            // panelDugmici
            // 
            panelDugmici.AutoSize = true;
            panelDugmici.BackColor = Color.FromArgb(245, 247, 250);
            panelDugmici.Controls.Add(lblNaslov);
            panelDugmici.Controls.Add(panelPrikaz);
            panelDugmici.Controls.Add(button3);
            panelDugmici.Controls.Add(btnJedinice);
            panelDugmici.Controls.Add(button2);
            panelDugmici.Controls.Add(btnIntervencije);
            panelDugmici.Controls.Add(button1);
            panelDugmici.Controls.Add(btnPrijava);
            panelDugmici.Controls.Add(buttonSaradnje);
            panelDugmici.Controls.Add(btnZaposleni);
            panelDugmici.Controls.Add(btnOprema);
            panelDugmici.Controls.Add(btnVozila);
            panelDugmici.Controls.Add(btnIstorija);
            panelDugmici.Controls.Add(button8);
            panelDugmici.Controls.Add(buttonUcestvuje);
            panelDugmici.Controls.Add(btnVs);
            panelDugmici.Location = new Point(0, -1);
            panelDugmici.Name = "panelDugmici";
            panelDugmici.Size = new Size(1223, 644);
            panelDugmici.TabIndex = 0;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI Semibold", 14F);
            lblNaslov.ForeColor = Color.FromArgb(45, 45, 45);
            lblNaslov.Location = new Point(400, 22);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(414, 25);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "📋 Sistem za upravljanje vanrednim situacijama";
            // 
            // panelPrikaz
            // 
            panelPrikaz.BackColor = Color.White;
            panelPrikaz.BorderStyle = BorderStyle.FixedSingle;
            panelPrikaz.Location = new Point(13, 165);
            panelPrikaz.Name = "panelPrikaz";
            panelPrikaz.Size = new Size(1179, 476);
            panelPrikaz.TabIndex = 15;
            panelPrikaz.Paint += panelPrikaz_Paint;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(255, 190, 80);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(991, 121);
            button3.Name = "button3";
            button3.Size = new Size(146, 38);
            button3.TabIndex = 16;
            button3.Text = "🕓 Istorija vozila";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // btnJedinice
            // 
            btnJedinice.AutoSize = true;
            btnJedinice.BackColor = Color.FromArgb(0, 122, 204);
            btnJedinice.FlatAppearance.BorderSize = 0;
            btnJedinice.FlatStyle = FlatStyle.Flat;
            btnJedinice.Font = new Font("Segoe UI Semibold", 10F);
            btnJedinice.ForeColor = Color.White;
            btnJedinice.Location = new Point(370, 77);
            btnJedinice.Name = "btnJedinice";
            btnJedinice.Size = new Size(146, 38);
            btnJedinice.TabIndex = 17;
            btnJedinice.Text = "🏢 Jedinice";
            btnJedinice.UseVisualStyleBackColor = false;
            btnJedinice.Click += btnJedinice_Click_1;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(0, 122, 204);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(829, 121);
            button2.Name = "button2";
            button2.Size = new Size(156, 38);
            button2.TabIndex = 18;
            button2.Text = "👨‍✈️ Predstavnici službi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // btnIntervencije
            // 
            btnIntervencije.AutoSize = true;
            btnIntervencije.BackColor = Color.FromArgb(0, 122, 204);
            btnIntervencije.FlatAppearance.BorderSize = 0;
            btnIntervencije.FlatStyle = FlatStyle.Flat;
            btnIntervencije.Font = new Font("Segoe UI Semibold", 10F);
            btnIntervencije.ForeColor = Color.White;
            btnIntervencije.Location = new Point(522, 77);
            btnIntervencije.Name = "btnIntervencije";
            btnIntervencije.Size = new Size(146, 38);
            btnIntervencije.TabIndex = 19;
            btnIntervencije.Text = "🚒 Intervencije";
            btnIntervencije.UseVisualStyleBackColor = false;
            btnIntervencije.Click += btnIntervencije_Click_1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(677, 121);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 20;
            button1.Text = "🏛️ Službe";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnPrijava
            // 
            btnPrijava.AutoSize = true;
            btnPrijava.BackColor = Color.FromArgb(0, 122, 204);
            btnPrijava.FlatAppearance.BorderSize = 0;
            btnPrijava.FlatStyle = FlatStyle.Flat;
            btnPrijava.Font = new Font("Segoe UI Semibold", 10F);
            btnPrijava.ForeColor = Color.White;
            btnPrijava.Location = new Point(57, 77);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(146, 38);
            btnPrijava.TabIndex = 21;
            btnPrijava.Text = "➕ Nova prijava";
            btnPrijava.UseVisualStyleBackColor = false;
            btnPrijava.Click += btnPrijava_Click_1;
            // 
            // buttonSaradnje
            // 
            buttonSaradnje.AutoSize = true;
            buttonSaradnje.BackColor = Color.FromArgb(0, 122, 204);
            buttonSaradnje.FlatAppearance.BorderSize = 0;
            buttonSaradnje.FlatStyle = FlatStyle.Flat;
            buttonSaradnje.Font = new Font("Segoe UI Semibold", 10F);
            buttonSaradnje.ForeColor = Color.White;
            buttonSaradnje.Location = new Point(522, 121);
            buttonSaradnje.Name = "buttonSaradnje";
            buttonSaradnje.Size = new Size(146, 38);
            buttonSaradnje.TabIndex = 22;
            buttonSaradnje.Text = "\U0001f91d Saradnje";
            buttonSaradnje.UseVisualStyleBackColor = false;
            buttonSaradnje.Click += buttonSaradnje_Click_1;
            // 
            // btnZaposleni
            // 
            btnZaposleni.AutoSize = true;
            btnZaposleni.BackColor = Color.FromArgb(0, 122, 204);
            btnZaposleni.FlatAppearance.BorderSize = 0;
            btnZaposleni.FlatStyle = FlatStyle.Flat;
            btnZaposleni.Font = new Font("Segoe UI Semibold", 10F);
            btnZaposleni.ForeColor = Color.White;
            btnZaposleni.Location = new Point(677, 77);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(146, 38);
            btnZaposleni.TabIndex = 23;
            btnZaposleni.Text = "👷 Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = false;
            btnZaposleni.Click += btnZaposleni_Click_1;
            // 
            // btnOprema
            // 
            btnOprema.AutoSize = true;
            btnOprema.BackColor = Color.FromArgb(0, 122, 204);
            btnOprema.FlatAppearance.BorderSize = 0;
            btnOprema.FlatStyle = FlatStyle.Flat;
            btnOprema.Font = new Font("Segoe UI Semibold", 10F);
            btnOprema.ForeColor = Color.White;
            btnOprema.Location = new Point(368, 121);
            btnOprema.Name = "btnOprema";
            btnOprema.Size = new Size(148, 38);
            btnOprema.TabIndex = 24;
            btnOprema.Text = "⚙️ Oprema agencije";
            btnOprema.UseVisualStyleBackColor = false;
            btnOprema.Click += btnOprema_Click_1;
            // 
            // btnVozila
            // 
            btnVozila.AutoSize = true;
            btnVozila.BackColor = Color.FromArgb(0, 122, 204);
            btnVozila.FlatAppearance.BorderSize = 0;
            btnVozila.FlatStyle = FlatStyle.Flat;
            btnVozila.Font = new Font("Segoe UI Semibold", 10F);
            btnVozila.ForeColor = Color.White;
            btnVozila.Location = new Point(829, 77);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(156, 38);
            btnVozila.TabIndex = 25;
            btnVozila.Text = "🚗 Vozila";
            btnVozila.UseVisualStyleBackColor = false;
            btnVozila.Click += btnVozila_Click_1;
            // 
            // btnIstorija
            // 
            btnIstorija.AutoSize = true;
            btnIstorija.BackColor = Color.FromArgb(255, 190, 80);
            btnIstorija.FlatAppearance.BorderSize = 0;
            btnIstorija.FlatStyle = FlatStyle.Flat;
            btnIstorija.Font = new Font("Segoe UI Semibold", 10F);
            btnIstorija.ForeColor = Color.Black;
            btnIstorija.Location = new Point(210, 121);
            btnIstorija.Name = "btnIstorija";
            btnIstorija.Size = new Size(154, 38);
            btnIstorija.TabIndex = 26;
            btnIstorija.Text = "\U0001f9fe Istorija zaposlenih";
            btnIstorija.UseVisualStyleBackColor = false;
            btnIstorija.Click += btnIstorija_Click_1;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = Color.FromArgb(255, 190, 80);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 10F);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(991, 77);
            button8.Name = "button8";
            button8.Size = new Size(146, 38);
            button8.TabIndex = 27;
            button8.Text = "📜 Istorija učešća";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // buttonUcestvuje
            // 
            buttonUcestvuje.AutoSize = true;
            buttonUcestvuje.BackColor = Color.FromArgb(0, 122, 204);
            buttonUcestvuje.FlatAppearance.BorderSize = 0;
            buttonUcestvuje.FlatStyle = FlatStyle.Flat;
            buttonUcestvuje.Font = new Font("Segoe UI Semibold", 10F);
            buttonUcestvuje.ForeColor = Color.White;
            buttonUcestvuje.Location = new Point(57, 121);
            buttonUcestvuje.Name = "buttonUcestvuje";
            buttonUcestvuje.Size = new Size(146, 38);
            buttonUcestvuje.TabIndex = 28;
            buttonUcestvuje.Text = "\U0001f91d Učešća u V.S.";
            buttonUcestvuje.UseVisualStyleBackColor = false;
            buttonUcestvuje.Click += buttonUcestvuje_Click_1;
            // 
            // btnVs
            // 
            btnVs.AutoSize = true;
            btnVs.BackColor = Color.FromArgb(0, 122, 204);
            btnVs.FlatAppearance.BorderSize = 0;
            btnVs.FlatStyle = FlatStyle.Flat;
            btnVs.Font = new Font("Segoe UI Semibold", 10F);
            btnVs.ForeColor = Color.White;
            btnVs.Location = new Point(209, 77);
            btnVs.Name = "btnVs";
            btnVs.Size = new Size(155, 38);
            btnVs.TabIndex = 29;
            btnVs.Text = "🌐 Vanredne situacije";
            btnVs.UseVisualStyleBackColor = false;
            btnVs.Click += btnVs_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1224, 652);
            Controls.Add(panelDugmici);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem za upravljanje vanrednim situacijama";
            Load += Form1_Load;
            panelDugmici.ResumeLayout(false);
            panelDugmici.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDugmici;
        private Panel panelPrikaz;
        private Label lblNaslov;
        private Button btnVozila;
        private Button btnZaposleni;
        private Button btnIntervencije;
        private Button btnJedinice;
        private Button btnVs;
        private Button btnPrijava;
        private Button buttonUcestvuje;
        private Button button8;
        private Button btnOprema;
        private Button btnIstorija;
        private Button buttonSaradnje;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
