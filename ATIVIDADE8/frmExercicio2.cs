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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[20];
            string imprime = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                if (!double.TryParse(Interaction.InputBox($"Digite a posição {i + 1} do vetor: "), out vetor[i]))
                {
                    MessageBox.Show("Apenas valores numéricos por favor!");
                    i--;
                }
            }
            //Método reverse
            Array.Reverse(vetor);
            for(int i = 0; i < vetor.Length; i++)
            {
                imprime += $"\n{vetor[i]}";
            }
            MessageBox.Show(imprime);
        }
    }
}
