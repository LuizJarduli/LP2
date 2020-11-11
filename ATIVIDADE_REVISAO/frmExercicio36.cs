using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_REVISAO
{
    public partial class frmExercicio36 : Form
    {
        public frmExercicio36()
        {
            InitializeComponent();
        }

        private void frmExercicio36_Load(object sender, EventArgs e)
        {
            rtbExercicio.Text = "36. Fazer um programa para calcular e exibir a soma dos “N” primeiros valores da sequência abaixo.O \n" +
                "valor “N” será digitado(TextBox), deverá ser positivo, maior que zero, mas menor que cinquenta.\n" +
                "Caso o valor não satisfaça a restrição, enviar mensagem de erro e solicitar o valor novamente.A\n" +
                "sequência: 1 / 2, 2 / 3, 3 / 4, 4 / 5,... até N/ (N + 1)";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int val;
            double resultado = 0;

            if(int.TryParse(txtNum.Text, out val))
            {
                if(val < 0 || val >= 50)
                {
                    MessageBox.Show("O número precisa ser maior que zero e menor que cinquenta!\nTente novamente");
                } else
                {
                    for (var i = 1.0; i <= val; i++)
                    {
                        resultado += (i / (i+1));
                        
                    }
                    txtResultado.Text = resultado.ToString("N2");
                }
            } else
            {
                MessageBox.Show("Insira somente valores numéricos!\nTente novamente");
            }
        }
    }
}
