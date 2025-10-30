namespace VanredneSituacije.Forme
{
    partial class FormaDodajInterventnu
    {
        private System.ComponentModel.IContainer sadrzaj = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (sadrzaj != null))
            {
                sadrzaj.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            naslovLabel = new Label();
            dugmeOpsta = new Button();
            dugmeSpecijalna = new Button();
            dugmeZatvori = new Button();
            panelLevi = new Panel();
            panelDesni = new Panel();
            SuspendLayout();
            // 
            // naslovLabel
            // 
            naslovLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            naslovLabel.ForeColor = Color.FromArgb(35, 60, 110);
            naslovLabel.Location = new Point(222, 26);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(370, 40);
            naslovLabel.TabIndex = 2;
            naslovLabel.Text = "Odaberite tip jedinice:";
            naslovLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dugmeOpsta
            // 
            dugmeOpsta.BackColor = Color.MediumSlateBlue;
            dugmeOpsta.FlatStyle = FlatStyle.Flat;
            dugmeOpsta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeOpsta.ForeColor = Color.White;
            dugmeOpsta.Location = new Point(222, 114);
            dugmeOpsta.Name = "dugmeOpsta";
            dugmeOpsta.Size = new Size(160, 45);
            dugmeOpsta.TabIndex = 3;
            dugmeOpsta.Text = "🚒 Opšta jedinica";
            dugmeOpsta.UseVisualStyleBackColor = false;
            dugmeOpsta.Click += dugmeOpsta_Click;
            // 
            // dugmeSpecijalna
            // 
            dugmeSpecijalna.BackColor = Color.Teal;
            dugmeSpecijalna.FlatStyle = FlatStyle.Flat;
            dugmeSpecijalna.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeSpecijalna.ForeColor = Color.White;
            dugmeSpecijalna.Location = new Point(412, 114);
            dugmeSpecijalna.Name = "dugmeSpecijalna";
            dugmeSpecijalna.Size = new Size(160, 45);
            dugmeSpecijalna.TabIndex = 4;
            dugmeSpecijalna.Text = "🎯 Specijalna jedinica";
            dugmeSpecijalna.UseVisualStyleBackColor = false;
            dugmeSpecijalna.Click += dugmeSpecijalna_Click;
            // 
            // dugmeZatvori
            // 
            dugmeZatvori.BackColor = Color.Firebrick;
            dugmeZatvori.FlatStyle = FlatStyle.Flat;
            dugmeZatvori.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeZatvori.ForeColor = Color.White;
            dugmeZatvori.Location = new Point(222, 266);
            dugmeZatvori.Name = "dugmeZatvori";
            dugmeZatvori.Size = new Size(350, 40);
            dugmeZatvori.TabIndex = 5;
            dugmeZatvori.Text = "Odustani";
            dugmeZatvori.UseVisualStyleBackColor = false;
            dugmeZatvori.Click += dugmeZatvori_Click;
            // 
            // panelLevi
            // 
            panelLevi.BackColor = Color.FromArgb(220, 230, 255);
            panelLevi.Dock = DockStyle.Left;
            panelLevi.Location = new Point(0, 0);
            panelLevi.Name = "panelLevi";
            panelLevi.Size = new Size(10, 366);
            panelLevi.TabIndex = 0;
            // 
            // panelDesni
            // 
            panelDesni.BackColor = Color.FromArgb(220, 230, 255);
            panelDesni.Dock = DockStyle.Right;
            panelDesni.Location = new Point(807, 0);
            panelDesni.Name = "panelDesni";
            panelDesni.Size = new Size(10, 366);
            panelDesni.TabIndex = 1;
            // 
            // FormaDodajInterventnu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(817, 366);
            Controls.Add(panelLevi);
            Controls.Add(panelDesni);
            Controls.Add(naslovLabel);
            Controls.Add(dugmeOpsta);
            Controls.Add(dugmeSpecijalna);
            Controls.Add(dugmeZatvori);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormaDodajInterventnu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi unos interventne jedinice";
            Load += FormaDodajInterventnu_Load;
            ResumeLayout(false);
        }

        private Label naslovLabel;
        private Button dugmeOpsta;
        private Button dugmeSpecijalna;
        private Button dugmeZatvori;
        private Panel panelLevi;
        private Panel panelDesni;
    }
}
