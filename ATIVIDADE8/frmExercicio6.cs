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
    public partial class frmExercicio6 : Form
    {
        public const int linha =  20;
        public const int coluna = 3;
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            int[,] matrizAlunos = new int[linha,coluna];
            double media = 0;
            string imprime = "";

            for(int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    if(int.TryParse(Interaction.InputBox($"Digite a nota {j+1} do Aluno {i+1}: ", "Boletim"), out matrizAlunos[i,j]))
                    {
                        media += matrizAlunos[i, j];
                    } else
                    {
                        MessageBox.Show("Apenas Valores Numéricos por favor!");
                        j--;
                    }
                }
                media = media / 3.0;
                imprime += $"Aluno {i + 1}: média {media.ToString("N1")}.\n";
                media = 0;
            }
            rtbDados.Text = imprime;
        }
    }
}
