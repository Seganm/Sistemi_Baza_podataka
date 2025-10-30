namespace VanredneSituacije.Forme
{
    partial class FormaOperativciJedinice
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridRadnici = new DataGridView();
            dugmeBrisi = new Button();
            naslovLabela = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRadnici).BeginInit();
            SuspendLayout();
            
            dataGridRadnici.AllowUserToAddRows = false;
            dataGridRadnici.AllowUserToDeleteRows = false;
            dataGridRadnici.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridRadnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRadnici.BackgroundColor = Color.White;
            dataGridRadnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRadnici.Location = new Point(25, 60);
            dataGridRadnici.Name = "dataGridRadnici";
            dataGridRadnici.ReadOnly = true;
            dataGridRadnici.RowHeadersVisible = false;
            dataGridRadnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRadnici.Size = new Size(950, 330);
            dataGridRadnici.TabIndex = 1;
            dataGridRadnici.CellContentClick += dataGridRadnici_CellContentClick;
         
            dugmeBrisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dugmeBrisi.BackColor = Color.IndianRed;
            dugmeBrisi.FlatStyle = FlatStyle.Popup;
            dugmeBrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeBrisi.ForeColor = Color.White;
            dugmeBrisi.Location = new Point(408, 403);
            dugmeBrisi.Name = "dugmeBrisi";
            dugmeBrisi.Size = new Size(200, 35);
            dugmeBrisi.TabIndex = 1;
            dugmeBrisi.Text = " Obriši radnika";
            dugmeBrisi.UseVisualStyleBackColor = false;
            dugmeBrisi.Click += dugmeBrisi_Click_1;
          
            naslovLabela.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            naslovLabela.ForeColor = Color.FromArgb(20, 60, 120);
            naslovLabela.Location = new Point(20, 15);
            naslovLabela.Name = "naslovLabela";
            naslovLabela.Size = new Size(400, 30);
            naslovLabela.TabIndex = 0;
            naslovLabela.Text = "Lista operativnih radnika";
            naslovLabela.TextAlign = ContentAlignment.MiddleLeft;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1000, 450);
            Controls.Add(naslovLabela);
            Controls.Add(dataGridRadnici);
            Controls.Add(dugmeBrisi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaOperativciJedinice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operativci interventne jedinice";
            Load += FormaOperativciJedinice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridRadnici).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridRadnici;
        private Button dugmeBrisi;
        private Label naslovLabela;
    }
}
