namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PrimeiroNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void somar_Click(object sender, EventArgs e)
        {
            int primNum, segNum, resultado;
            primNum = Int32.Parse(PrimeiroNumero.Text);
            segNum = Int32.Parse(SegundoNumero.Text);
            resultado = primNum + segNum;
            resultadoText.Text = resultado.ToString();
        }
    }
}