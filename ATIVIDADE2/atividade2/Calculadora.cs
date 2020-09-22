using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE2
{
    public partial class Calculadora : Form
    {
        double numero1, numero2, resultado;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out numero1) && double.TryParse(txtnumero2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtresultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out numero1) && double.TryParse(txtnumero2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtresultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out numero1) && double.TryParse(txtnumero2.Text, out numero2))
            {
                if(numero2 == 0)
                {
                    txtresultado.Text = "Não pode mano!";
                }
                else
                {
                    resultado = numero1 / numero2;
                    txtresultado.Text = resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtresultado.Clear();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
           if(double.TryParse(txtnumero1.Text, out numero1) && double.TryParse(txtnumero2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtresultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }
    }
}
