using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledSpecijalizacija
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            dugmeObrisiSpecijalizaciju = new Button();
            dugmeIzmeniSpecijalizaciju = new Button();
            dugmeDodajSpecijalizaciju = new Button();
            tabelaSpecijalizacija = new DataGridView();
            naslovLabela = new Label();

            ((System.ComponentModel.ISupportInitialize)tabelaSpecijalizacija).BeginInit();
            SuspendLayout();


            dugmeDodajSpecijalizaciju.BackColor = Color.FromArgb(46, 204, 113);
            dugmeDodajSpecijalizaciju.FlatStyle = FlatStyle.Flat;
            dugmeDodajSpecijalizaciju.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dugmeDodajSpecijalizaciju.ForeColor = Color.White;
            dugmeDodajSpecijalizaciju.Location = new Point(12, 12);
            dugmeDodajSpecijalizaciju.Size = new Size(150, 35);
            dugmeDodajSpecijalizaciju.Text = "➕ Dodaj novu";
            dugmeDodajSpecijalizaciju.UseVisualStyleBackColor = false;
            dugmeDodajSpecijalizaciju.Click += dugmeDodajSpecijalizaciju_Click;

            dugmeIzmeniSpecijalizaciju.BackColor = Color.FromArgb(241, 196, 15);
            dugmeIzmeniSpecijalizaciju.FlatStyle = FlatStyle.Flat;
            dugmeIzmeniSpecijalizaciju.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeIzmeniSpecijalizaciju.ForeColor = Color.Black;
            dugmeIzmeniSpecijalizaciju.Location = new Point(168, 12);
            dugmeIzmeniSpecijalizaciju.Size = new Size(150, 35);
            dugmeIzmeniSpecijalizaciju.Text = "✏ Izmeni podatke";
            dugmeIzmeniSpecijalizaciju.UseVisualStyleBackColor = false;
            dugmeIzmeniSpecijalizaciju.Click += dugmeIzmeniSpecijalizaciju_Click;

            dugmeObrisiSpecijalizaciju.BackColor = Color.FromArgb(231, 76, 60);
            dugmeObrisiSpecijalizaciju.FlatStyle = FlatStyle.Flat;
            dugmeObrisiSpecijalizaciju.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeObrisiSpecijalizaciju.ForeColor = Color.White;
            dugmeObrisiSpecijalizaciju.Location = new Point(1022, 11);
            dugmeObrisiSpecijalizaciju.Size = new Size(150, 35);
            dugmeObrisiSpecijalizaciju.Text = "🗑 Obriši zapis";
            dugmeObrisiSpecijalizaciju.UseVisualStyleBackColor = false;
            dugmeObrisiSpecijalizaciju.Click += dugmeObrisiSpecijalizaciju_Click;

 
            tabelaSpecijalizacija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaSpecijalizacija.BackgroundColor = Color.White;
            tabelaSpecijalizacija.BorderStyle = BorderStyle.None;

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(52, 73, 94);
            headerStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            headerStyle.SelectionForeColor = Color.White;
            tabelaSpecijalizacija.ColumnHeadersDefaultCellStyle = headerStyle;

            cellStyle.BackColor = Color.WhiteSmoke;
            cellStyle.Font = new Font("Segoe UI", 9F);
            cellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            cellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            cellStyle.SelectionForeColor = Color.White;
            tabelaSpecijalizacija.DefaultCellStyle = cellStyle;

            tabelaSpecijalizacija.EnableHeadersVisualStyles = false;
            tabelaSpecijalizacija.GridColor = Color.FromArgb(189, 195, 199);
            tabelaSpecijalizacija.Location = new Point(12, 55);
            tabelaSpecijalizacija.RowTemplate.Height = 26;
            tabelaSpecijalizacija.Size = new Size(1160, 590);

            naslovLabela.AutoSize = true;
            naslovLabela.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            naslovLabela.ForeColor = Color.FromArgb(52, 73, 94);
            naslovLabela.Location = new Point(410, 9);
            naslovLabela.Text = "📘 Evidencija specijalizacija";

            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabela);
            Controls.Add(tabelaSpecijalizacija);
            Controls.Add(dugmeObrisiSpecijalizaciju);
            Controls.Add(dugmeIzmeniSpecijalizaciju);
            Controls.Add(dugmeDodajSpecijalizaciju);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(33, 37, 41);
            Name = "FormaPregledSpecijalizacija";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled specijalizacija";
            Load += FormaPregledSpecijalizacija_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaSpecijalizacija).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dugmeObrisiSpecijalizaciju;
        private Button dugmeIzmeniSpecijalizaciju;
        private Button dugmeDodajSpecijalizaciju;
        private DataGridView tabelaSpecijalizacija;
        private Label naslovLabela;
    }
}
