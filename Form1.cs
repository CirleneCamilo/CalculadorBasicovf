namespace CalculadorBasicovf
{
    public partial class CalculadorBasicovf : Form
    {
        // Declaração de variáveis
        double n1,n2,resultado = 0;

        private void Bt02_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 - n2;
            Txt01.Text = "Resultado da subtração : " + resultado.ToString();
        }

        private void Bt03_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 * n2;
            Txt01.Text = "Resultado da multiplicação : " + resultado.ToString();
        }

        private void Bt04_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 / n2;
            Txt01.Text = "Resultado da divisão : " + resultado.ToString();
        }

        public CalculadorBasicovf()
        {
            InitializeComponent();
        }

        private void Bt01_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(CaixaTxt01.Text);
            n2 = Convert.ToDouble(CaixaTxt02.Text);

            resultado = n1 + n2;
            Txt01.Text = "Resultado da soma : " + resultado.ToString();
        }
    }
}