namespace Eje2_AngelHernandezIVD17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reiniciar el progresBar
            progressBar1.Value = 0;
            for (int i = 1; i <= 50; i++) {
                progressBar1.Value += i;
                Application.DoEvents();//Actualizar
                Thread.Sleep(50);
        }
    }
}
