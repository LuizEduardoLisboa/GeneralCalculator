using System.Data;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtresultado.Text = Convert.ToString(valor1 - valor2);

            }
            else if (operacao == "MULT")
            {
                txtresultado.Text = Convert.ToString(valor1 * valor2);

            }
            else
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = " ";
            valor1 = 0;
            valor2 = 0;
            lbloperacao.Text = " ";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void btndois_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = " ";
                operacao = "SOMA";
                lbloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Número antes da operação! ");
            }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = " ";
                operacao = "SUB";
                lbloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Número antes da operação");
            }
        }

        private void btnnove_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {


                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = " ";
                operacao = "MULT";
                lbloperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Número antes da operação!");
            }
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = " ";
                operacao = "DIV";
                lbloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Número antes da operação");


            }
        }

        private void btnoito_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btnquatro_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                txtresultado.Text = " ";
            }
            else if (txtresultado.Text == "")
            {
                MessageBox.Show("Não há o que limpar! ");
            }


        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}