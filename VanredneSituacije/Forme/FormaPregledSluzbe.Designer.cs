using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledSluzbe
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
            components = new System.ComponentModel.Container();

            naslovLabela = new Label();
            dugmeObrisiSluzbu = new Button();
            dugmeIzmeniSluzbu = new Button();
            dugmeDodajSluzbu = new Button();
            tabelaSluzbi = new DataGridView();
            kolonaIdSektora = new DataGridViewTextBoxColumn();
            kolonaTipSektora = new DataGridViewTextBoxColumn();
            kolonaJMBGPredstavnika = new DataGridViewTextBoxColumn();
            kolonaImePredstavnika = new DataGridViewTextBoxColumn();
            kolonaPrezimePredstavnika = new DataGridViewTextBoxColumn();
            bindingSluzbi = new BindingSource(components);

            ((System.ComponentModel.ISupportInitialize)tabelaSluzbi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSluzbi).BeginInit();
            SuspendLayout();

    
            naslovLabela.AutoSize = true;
            naslovLabela.Font = new Font("Segoe UI Semibold", 16F);
            naslovLabela.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabela.Location = new Point(20, 12);
            naslovLabela.Text = "📋 Pregled svih službi";

            dugmeDodajSluzbu.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodajSluzbu.FlatAppearance.BorderSize = 0;
            dugmeDodajSluzbu.FlatStyle = FlatStyle.Flat;
            dugmeDodajSluzbu.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodajSluzbu.ForeColor = Color.White;
            dugmeDodajSluzbu.Location = new Point(710, 12);
            dugmeDodajSluzbu.Size = new Size(150, 32);
            dugmeDodajSluzbu.Text = "➕ Dodaj službu";
            dugmeDodajSluzbu.UseVisualStyleBackColor = false;
            dugmeDodajSluzbu.Click += dugmeDodajSluzbu_Click;

 
            dugmeIzmeniSluzbu.BackColor = Color.FromArgb(255, 193, 7);
            dugmeIzmeniSluzbu.FlatAppearance.BorderSize = 0;
            dugmeIzmeniSluzbu.FlatStyle = FlatStyle.Flat;
            dugmeIzmeniSluzbu.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeniSluzbu.ForeColor = Color.Black;
            dugmeIzmeniSluzbu.Location = new Point(866, 12);
            dugmeIzmeniSluzbu.Size = new Size(150, 32);
            dugmeIzmeniSluzbu.Text = "✏ Izmeni službu";
            dugmeIzmeniSluzbu.UseVisualStyleBackColor = false;
            dugmeIzmeniSluzbu.Click += dugmeIzmeniSluzbu_Click;

            dugmeObrisiSluzbu.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisiSluzbu.FlatAppearance.BorderSize = 0;
            dugmeObrisiSluzbu.FlatStyle = FlatStyle.Flat;
            dugmeObrisiSluzbu.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisiSluzbu.ForeColor = Color.White;
            dugmeObrisiSluzbu.Location = new Point(1022, 12);
            dugmeObrisiSluzbu.Size = new Size(150, 32);
            dugmeObrisiSluzbu.Text = "🗑 Obriši službu";
            dugmeObrisiSluzbu.UseVisualStyleBackColor = false;
            dugmeObrisiSluzbu.Click += dugmeObrisiSluzbu_Click;

            tabelaSluzbi.AutoGenerateColumns = false;
            tabelaSluzbi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaSluzbi.BackgroundColor = Color.White;
            tabelaSluzbi.BorderStyle = BorderStyle.None;
            tabelaSluzbi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelaSluzbi.EnableHeadersVisualStyles = false;
            tabelaSluzbi.GridColor = Color.FromArgb(225, 225, 225);
            tabelaSluzbi.Location = new Point(12, 50);
            tabelaSluzbi.Size = new Size(1160, 599);
            tabelaSluzbi.RowHeadersVisible = false;
            tabelaSluzbi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaSluzbi.MultiSelect = false;
            tabelaSluzbi.DataSource = bindingSluzbi;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(230, 235, 245),
                Font = new Font("Segoe UI Semibold", 10F),
                ForeColor = Color.FromArgb(30, 30, 30),
                SelectionBackColor = Color.FromArgb(180, 200, 240),
                WrapMode = DataGridViewTriState.True
            };
            tabelaSluzbi.ColumnHeadersDefaultCellStyle = headerStyle;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(50, 50, 50),
                SelectionBackColor = Color.FromArgb(200, 220, 250),
                SelectionForeColor = Color.Black
            };
            tabelaSluzbi.DefaultCellStyle = cellStyle;

            kolonaIdSektora.DataPropertyName = "SektorrId";
            kolonaIdSektora.HeaderText = "ID sektora";

            kolonaTipSektora.DataPropertyName = "TipSektora";
            kolonaTipSektora.HeaderText = "Tip sektora";

            kolonaJMBGPredstavnika.DataPropertyName = "JMBGPredstavnika";
            kolonaJMBGPredstavnika.HeaderText = "JMBG predstavnika";

            kolonaImePredstavnika.DataPropertyName = "ImePredstavnika";
            kolonaImePredstavnika.HeaderText = "Ime predstavnika";

            kolonaPrezimePredstavnika.DataPropertyName = "PrezimePredstavnika";
            kolonaPrezimePredstavnika.HeaderText = "Prezime predstavnika";

            tabelaSluzbi.Columns.AddRange(new DataGridViewColumn[]
            {
                kolonaIdSektora, kolonaTipSektora, kolonaJMBGPredstavnika,
                kolonaImePredstavnika, kolonaPrezimePredstavnika
            });

            bindingSluzbi.DataSource = typeof(DTO.DTOVratiSluzbu);

 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(tabelaSluzbi);
            Controls.Add(naslovLabela);
            Controls.Add(dugmeObrisiSluzbu);
            Controls.Add(dugmeIzmeniSluzbu);
            Controls.Add(dugmeDodajSluzbu);
            Font = new Font("Segoe UI", 9F);
            Name = "FormaPregledSluzbe";
            Text = "Pregled službi";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormaPregledSluzbe_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaSluzbi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSluzbi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label naslovLabela;
        private Button dugmeObrisiSluzbu;
        private Button dugmeIzmeniSluzbu;
        private Button dugmeDodajSluzbu;
        private DataGridView tabelaSluzbi;
        private BindingSource bindingSluzbi;
        private DataGridViewTextBoxColumn kolonaIdSektora;
        private DataGridViewTextBoxColumn kolonaTipSektora;
        private DataGridViewTextBoxColumn kolonaJMBGPredstavnika;
        private DataGridViewTextBoxColumn kolonaImePredstavnika;
        private DataGridViewTextBoxColumn kolonaPrezimePredstavnika;
    }
}
