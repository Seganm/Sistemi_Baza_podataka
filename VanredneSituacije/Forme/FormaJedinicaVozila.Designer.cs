namespace VanredneSituacije.Forme
{
    partial class FormaJedinicaVozila
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
            buttonObrisi = new Button();
            gridVozila = new DataGridView();
            lblNaslov = new Label();
            ((System.ComponentModel.ISupportInitialize)gridVozila).BeginInit();
            SuspendLayout();
           
            buttonObrisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonObrisi.BackColor = Color.Firebrick;
            buttonObrisi.FlatStyle = FlatStyle.Popup;
            buttonObrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonObrisi.ForeColor = Color.White;
            buttonObrisi.Location = new Point(228, 538);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(180, 35);
            buttonObrisi.TabIndex = 1;
            buttonObrisi.Text = "Obriši vozilo";
            buttonObrisi.UseVisualStyleBackColor = false;
            buttonObrisi.Click += buttonObrisi_Click;
           
            gridVozila.AllowUserToAddRows = false;
            gridVozila.AllowUserToDeleteRows = false;
            gridVozila.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridVozila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVozila.BackgroundColor = Color.White;
            gridVozila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVozila.Location = new Point(25, 70);
            gridVozila.Name = "gridVozila";
            gridVozila.ReadOnly = true;
            gridVozila.RowHeadersWidth = 51;
            gridVozila.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridVozila.Size = new Size(635, 450);
            gridVozila.TabIndex = 2;
            
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNaslov.ForeColor = Color.FromArgb(30, 60, 100);
            lblNaslov.Location = new Point(25, 20);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(247, 25);
            lblNaslov.TabIndex = 3;
            lblNaslov.Text = "Vozila interventne jedinice";
           
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(700, 600);
            Controls.Add(lblNaslov);
            Controls.Add(gridVozila);
            Controls.Add(buttonObrisi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaJedinicaVozila";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled vozila jedinice";
            Load += FormaJedinicaVozila_Load;
            ((System.ComponentModel.ISupportInitialize)gridVozila).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonObrisi;
        private DataGridView gridVozila;
        private Label lblNaslov;
    }
}
