using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ATIVIDADE8
{
    public partial class frmExercicio3 : Form
    {
        public const int TAM = 10;
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            double[] vpreco = new double[10];
            int[] vqtd = new int[10];
            double totalMes = 0;
            string imprime = "";

            for(int i = 0; i < TAM; i++)
            {
                if(int.TryParse(Interaction.InputBox($"Digite a quantidade vendida da mercadoria {i+1}: ", "Quantidade"),out vqtd[i])
                    && double.TryParse(Interaction.InputBox($"Digite o preço unitário da mercadoria {i + 1}: ", "Preço"), out vpreco[i]))
                {
                    totalMes = vqtd[i] * vpreco[i];
                    imprime += $"O Total Faturado no mês da mercadoria {i + 1} foi de {totalMes.ToString("c2")}\n";
                } else
                {
                    MessageBox.Show("Somente Valores Numéricos!");
                    i--;
                }
            }
            rtbDados.Text = imprime;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbDados.Clear();
        }
    }
}
