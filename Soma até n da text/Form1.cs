namespace Soma_até_n_da_text
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

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            int soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                soma = soma + i;
                listBox1.Items.Add("+" + i);
            }
            MessageBox.Show("A soma de 1 a " + numero + " é: " + soma);
        }
    }
}