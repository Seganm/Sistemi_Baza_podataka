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

            dugmeSpecijalizacijaObrisii = new Button();
            dugmeSpecijalizacijaIzmenii = new Button();
            dugmeSpecijalizacijaDodajj = new Button();
            tabelaSpecijalizacija = new DataGridView();
            naslovLabela = new Label();

            ((System.ComponentModel.ISupportInitialize)tabelaSpecijalizacija).BeginInit();
            SuspendLayout();


            dugmeSpecijalizacijaDodajj.BackColor = Color.FromArgb(46, 204, 113);
            dugmeSpecijalizacijaDodajj.FlatStyle = FlatStyle.Flat;
            dugmeSpecijalizacijaDodajj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dugmeSpecijalizacijaDodajj.ForeColor = Color.White;
            dugmeSpecijalizacijaDodajj.Location = new Point(12, 12);
            dugmeSpecijalizacijaDodajj.Size = new Size(150, 35);
            dugmeSpecijalizacijaDodajj.Text = "Dodaj novu";
            dugmeSpecijalizacijaDodajj.UseVisualStyleBackColor = false;
            dugmeSpecijalizacijaDodajj.Click += dugmeSpecijalizacijaDodajj_Click;

            dugmeSpecijalizacijaIzmenii.BackColor = Color.FromArgb(241, 196, 15);
            dugmeSpecijalizacijaIzmenii.FlatStyle = FlatStyle.Flat;
            dugmeSpecijalizacijaIzmenii.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeSpecijalizacijaIzmenii.ForeColor = Color.Black;
            dugmeSpecijalizacijaIzmenii.Location = new Point(168, 12);
            dugmeSpecijalizacijaIzmenii.Size = new Size(150, 35);
            dugmeSpecijalizacijaIzmenii.Text = "Izmeni podatke";
            dugmeSpecijalizacijaIzmenii.UseVisualStyleBackColor = false;
            dugmeSpecijalizacijaIzmenii.Click += dugmeSpecijalizacijaIzmenii_Click;

            dugmeSpecijalizacijaObrisii.BackColor = Color.FromArgb(231, 76, 60);
            dugmeSpecijalizacijaObrisii.FlatStyle = FlatStyle.Flat;
            dugmeSpecijalizacijaObrisii.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dugmeSpecijalizacijaObrisii.ForeColor = Color.White;
            dugmeSpecijalizacijaObrisii.Location = new Point(1022, 11);
            dugmeSpecijalizacijaObrisii.Size = new Size(150, 35);
            dugmeSpecijalizacijaObrisii.Text = "Obriši zapis";
            dugmeSpecijalizacijaObrisii.UseVisualStyleBackColor = false;
            dugmeSpecijalizacijaObrisii.Click += dugmeSpecijalizacijaObrisii_Click;

 
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
            naslovLabela.Text = "Evidencija specijalizacija";

            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabela);
            Controls.Add(tabelaSpecijalizacija);
            Controls.Add(dugmeSpecijalizacijaObrisii);
            Controls.Add(dugmeSpecijalizacijaIzmenii);
            Controls.Add(dugmeSpecijalizacijaDodajj);
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

        private Button dugmeSpecijalizacijaObrisii;
        private Button dugmeSpecijalizacijaIzmenii;
        private Button dugmeSpecijalizacijaDodajj;
        private DataGridView tabelaSpecijalizacija;
        private Label naslovLabela;
    }
}
