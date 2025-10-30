using System;
using System.Drawing;
using System.Windows.Forms;

namespace VanredneSituacije.Forme
{
    partial class FormaPregledSoftvera
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle alternateRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            dugmeObrisiSoftver = new Button();
            dugmeIzmeniSoftver = new Button();
            dugmeDodajSoftver = new Button();
            tabelaSoftveri = new DataGridView();
            kolonaId = new DataGridViewTextBoxColumn();
            kolonaImeAnaliticara = new DataGridViewTextBoxColumn();
            kolonaPrezimeAnaliticara = new DataGridViewTextBoxColumn();
            kolonaJMBGAnaliticara = new DataGridViewTextBoxColumn();
            kolonaNaziv = new DataGridViewTextBoxColumn();
            softverBinding = new BindingSource(components);
            naslovLabela = new Label();

            ((System.ComponentModel.ISupportInitialize)tabelaSoftveri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)softverBinding).BeginInit();
            SuspendLayout();

         
            dugmeDodajSoftver.BackColor = Color.FromArgb(0, 122, 204);
            dugmeDodajSoftver.FlatAppearance.BorderSize = 0;
            dugmeDodajSoftver.FlatStyle = FlatStyle.Flat;
            dugmeDodajSoftver.Font = new Font("Segoe UI Semibold", 9F);
            dugmeDodajSoftver.ForeColor = Color.White;
            dugmeDodajSoftver.Location = new Point(12, 11);
            dugmeDodajSoftver.Size = new Size(150, 32);
            dugmeDodajSoftver.Text = "➕ Dodaj softver";
            dugmeDodajSoftver.UseVisualStyleBackColor = false;
            dugmeDodajSoftver.Click += dugmeDodajSoftver_Click;

   
            dugmeIzmeniSoftver.BackColor = Color.FromArgb(255, 193, 7);
            dugmeIzmeniSoftver.FlatAppearance.BorderSize = 0;
            dugmeIzmeniSoftver.FlatStyle = FlatStyle.Flat;
            dugmeIzmeniSoftver.Font = new Font("Segoe UI Semibold", 9F);
            dugmeIzmeniSoftver.ForeColor = Color.Black;
            dugmeIzmeniSoftver.Location = new Point(168, 11);
            dugmeIzmeniSoftver.Size = new Size(150, 32);
            dugmeIzmeniSoftver.Text = "✏ Izmeni podatke";
            dugmeIzmeniSoftver.UseVisualStyleBackColor = false;
            dugmeIzmeniSoftver.Click += dugmeIzmeniSoftver_Click;

            dugmeObrisiSoftver.BackColor = Color.FromArgb(220, 70, 70);
            dugmeObrisiSoftver.FlatAppearance.BorderSize = 0;
            dugmeObrisiSoftver.FlatStyle = FlatStyle.Flat;
            dugmeObrisiSoftver.Font = new Font("Segoe UI Semibold", 9F);
            dugmeObrisiSoftver.ForeColor = Color.White;
            dugmeObrisiSoftver.Location = new Point(1022, 11);
            dugmeObrisiSoftver.Size = new Size(150, 32);
            dugmeObrisiSoftver.Text = "🗑 Obriši zapis";
            dugmeObrisiSoftver.UseVisualStyleBackColor = false;
            dugmeObrisiSoftver.Click += dugmeObrisiSoftver_Click;

            alternateRowStyle.BackColor = Color.FromArgb(250, 250, 253);
            tabelaSoftveri.AlternatingRowsDefaultCellStyle = alternateRowStyle;
            tabelaSoftveri.AutoGenerateColumns = false;
            tabelaSoftveri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaSoftveri.BackgroundColor = Color.White;

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(230, 235, 245);
            headerStyle.Font = new Font("Segoe UI Semibold", 10F);
            headerStyle.ForeColor = Color.FromArgb(30, 30, 30);
            headerStyle.WrapMode = DataGridViewTriState.True;
            tabelaSoftveri.ColumnHeadersDefaultCellStyle = headerStyle;

            tabelaSoftveri.Columns.AddRange(new DataGridViewColumn[] {
                kolonaId, kolonaImeAnaliticara, kolonaPrezimeAnaliticara, kolonaJMBGAnaliticara, kolonaNaziv
            });

            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(45, 45, 45);
            cellStyle.SelectionBackColor = Color.FromArgb(200, 220, 250);
            cellStyle.SelectionForeColor = Color.Black;
            tabelaSoftveri.DefaultCellStyle = cellStyle;
            tabelaSoftveri.EnableHeadersVisualStyles = false;
            tabelaSoftveri.GridColor = Color.FromArgb(225, 225, 225);
            tabelaSoftveri.Location = new Point(12, 45);
            tabelaSoftveri.RowTemplate.Height = 28;
            tabelaSoftveri.Size = new Size(1160, 605);
            tabelaSoftveri.DataSource = softverBinding;

 
            kolonaId.DataPropertyName = "Id";
            kolonaId.HeaderText = "ID";

            kolonaImeAnaliticara.DataPropertyName = "ImeAnaliticara";
            kolonaImeAnaliticara.HeaderText = "Ime analitičara";

            kolonaPrezimeAnaliticara.DataPropertyName = "PrezimeAnaliticara";
            kolonaPrezimeAnaliticara.HeaderText = "Prezime analitičara";

            kolonaJMBGAnaliticara.DataPropertyName = "JMBGAnaliticara";
            kolonaJMBGAnaliticara.HeaderText = "JMBG analitičara";

            kolonaNaziv.DataPropertyName = "Naziv";
            kolonaNaziv.HeaderText = "Naziv softvera";

 
            naslovLabela.AutoSize = true;
            naslovLabela.Font = new Font("Segoe UI Semibold", 14F);
            naslovLabela.ForeColor = Color.FromArgb(45, 45, 45);
            naslovLabela.Location = new Point(500, 13);
            naslovLabela.Text = "💻 Softverski alati analitičara";

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 661);
            Controls.Add(naslovLabela);
            Controls.Add(tabelaSoftveri);
            Controls.Add(dugmeObrisiSoftver);
            Controls.Add(dugmeIzmeniSoftver);
            Controls.Add(dugmeDodajSoftver);
            Font = new Font("Segoe UI", 10F);
            Name = "FormaPregledSoftvera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled softverskih alata";
            Load += FormaPregledSoftvera_Load;

            ((System.ComponentModel.ISupportInitialize)tabelaSoftveri).EndInit();
            ((System.ComponentModel.ISupportInitialize)softverBinding).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dugmeObrisiSoftver;
        private Button dugmeIzmeniSoftver;
        private Button dugmeDodajSoftver;
        private DataGridView tabelaSoftveri;
        private BindingSource softverBinding;
        private DataGridViewTextBoxColumn kolonaId;
        private DataGridViewTextBoxColumn kolonaImeAnaliticara;
        private DataGridViewTextBoxColumn kolonaPrezimeAnaliticara;
        private DataGridViewTextBoxColumn kolonaJMBGAnaliticara;
        private DataGridViewTextBoxColumn kolonaNaziv;
        private Label naslovLabela;
    }
}
