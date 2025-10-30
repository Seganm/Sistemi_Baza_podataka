namespace VanredneSituacije.Forme
{
    partial class FormaAngazovanostVozila
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
           
            label1 = new Label();
            panelZaglavlje = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelZaglavlje.SuspendLayout();
            SuspendLayout();
          
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(40, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1100, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1184, 60);
            label1.TabIndex = 0;
            label1.Text = "Pregled angažovanosti vozila";
            label1.TextAlign = ContentAlignment.MiddleCenter;
           
            panelZaglavlje.BackColor = Color.FromArgb(35, 90, 160);
            panelZaglavlje.Controls.Add(label1);
            panelZaglavlje.Dock = DockStyle.Top;
            panelZaglavlje.Location = new Point(0, 0);
            panelZaglavlje.Name = "panelZaglavlje";
            panelZaglavlje.Size = new Size(1184, 60);
            panelZaglavlje.TabIndex = 0;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 661);
            Controls.Add(panelZaglavlje);
            
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormaAngazovanostVozila";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Angažovanost vozila";
            Load += FormaAngazovanostVozila_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelZaglavlje.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dataGridView1;
       
        private Label label1;
        private Panel panelZaglavlje;

        #endregion
    }
}
