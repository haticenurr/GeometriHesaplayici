namespace GeometriHesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KARE ALANI
            int karekenar = Convert.ToInt32(textBoxKareKenar.Text);
            int karealan = karekenar * karekenar;
            labelKare.Text = Convert.ToString(karealan);
            //D�KD�RTGEN ALANI
            int uzunkenar = Convert.ToInt32(textBoxUzunKenar.Text);
            int kisakenar = Convert.ToInt32(textBoxKisaKenar.Text);
            int dikdortgenalan = uzunkenar * kisakenar;
            labelD�kdortgen.Text = Convert.ToString(dikdortgenalan);
            //DA�RE ALANI
            int yaricap = Convert.ToInt32(textBoxYaricap.Text);
            int pi = 3;
            int dairealan = pi * yaricap * yaricap;
            labelDaire.Text = Convert.ToString(dairealan);
        }
    }
}