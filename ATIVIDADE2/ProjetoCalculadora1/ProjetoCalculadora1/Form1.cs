using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora1
{
    public partial class formCal : Form
    {
        public formCal()
        {
            InitializeComponent();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            double b = 1;
            txtCalculo.Text += b.ToString();
 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double b = 2;
            txtCalculo.Text += b.ToString();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double b = 3;
            txtCalculo.Text += b.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double b = 4;
            txtCalculo.Text += b.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            double b = 5;
            txtCalculo.Text += b.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            double b = 6;
            txtCalculo.Text += b.ToString();   
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            double b = 7;
            txtCalculo.Text += b.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            double b = 8;
            txtCalculo.Text += b.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            double b = 9;
            txtCalculo.Text += b.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            double b = 0;
            txtCalculo.Text += b.ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            
            txtCalculo.Text += "+";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string operacaoMAT;
            int posicao = 0;
            if (txtCalculo.Text.Contains("+"))
            {
                posicao = txtCalculo.Text.IndexOf("+");
            }
            else if(txtCalculo.Text.Contains("-"))
            {
                posicao = txtCalculo.Text.IndexOf("-");
            }
            else if (txtCalculo.Text.Contains("*"))
            {
                posicao = txtCalculo.Text.IndexOf("*");
            }
            else if (txtCalculo.Text.Contains("/"))
            {
                posicao = txtCalculo.Text.IndexOf("/");
            }
            else
            {
                txtCalculo.Text = "Mensagem de erro Genérica";
            }

            operacaoMAT = txtCalculo.Text.Substring(posicao,1);
            double op1 = double.Parse(txtCalculo.Text.Substring(0,posicao));
            double op2 = double.Parse(txtCalculo.Text.Substring(posicao+1, txtCalculo.Text.Length - posicao -1));

            if (operacaoMAT == "+")
            {
                txtCalculo.Text += "=" + (op1 + op2);
            }
            else if (operacaoMAT == "-")
            {
                txtCalculo.Text += "=" + (op1 - op2);
            }
            else if (operacaoMAT == "*")
            {
                txtCalculo.Text += "=" + (op1 * op2);
            }
            else 
            {
                txtCalculo.Text += "=" + (op1 / op2);
            }

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "-";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "/";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "*";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
        }

        private void txtCalculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

    }
}
