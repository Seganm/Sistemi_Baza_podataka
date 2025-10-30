using VanredneSituacije.Entitet;
using VanredneSituacije.Forme;

namespace VanredneSituacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {

        }



        private void PrikaziFormuUPanelu(Form forma)
        {

            panelPrikaz.Controls.Clear();

          
            forma.TopLevel = false;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Fill;

           
            panelPrikaz.Controls.Add(forma);
            forma.Show();
        }



        private void btnIntervencije_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledIntervencija());
        }

        private void btnIstorija_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledIstorijeUloga());
        }

        private void btnOprema_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledOpreme());
        }

        private void buttonSaradnje_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledSaradjivanja());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnJedinice_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledJedinice());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledAngazovanih());
        }

        private void btnVs_Click(object sender, EventArgs e)
        {

        }

        private void buttonUcestvuje_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledIntervenise());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledDodeljenih());
        }

        private void btnPrijava_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledPrijava());
        }

        private void btnVozila_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledVozila());
        }

        private void panelPrikaz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVs_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledSituacije());
        }

        private void btnZaposleni_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledZaposlenih());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledDodeljenih());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledSluzbe());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledPredstavnikaSluzbe());
        }

        private void buttonSaradnje_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledSaradjivanja());
        }

        private void btnIntervencije_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledIntervencija());
        }

        private void btnOprema_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledOpreme());
        }

        private void btnJedinice_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledJedinice());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledAngazovanih());
        }

        private void buttonUcestvuje_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledIntervenise());
        }

        private void btnIstorija_Click_1(object sender, EventArgs e)
        {
            PrikaziFormuUPanelu(new FormaPregledIstorijeUloga());
        }
    }
}
