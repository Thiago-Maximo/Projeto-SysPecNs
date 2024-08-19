namespace SysPecNsDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello TI96");
        }

        private void btnconfirma_Click(object sender, EventArgs e)
        {
            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero1 = 0;
            if (txtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(txtNumero1.Text);
            }
            double numero2 = 0;
            double resultado = 0;
            if (posicaoOperacao < 5)
            {
                if (txtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                }

            }
            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Sqrt(numero1);
                    break;
                case 6:
                    resultado = Math.Log(numero1);
                    break;
            }


            lstresultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}");

            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperacao.Focus();
            btnconfirma.Enabled = false;
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero1.Text == string.Empty)
            {
                btnconfirma.Enabled = false;
            }
            else
            {
                btnconfirma.Enabled = true;
            }
        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = false;
            }
            else
            {
                txtNumero2.Enabled = true;
            }
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
            btnconfirma.Enabled = false;
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero2.Text == string.Empty)
            {
                btnconfirma.Enabled = false;
            }
            else
            {
                btnconfirma.Enabled= true;
            }
        }
    }
}
