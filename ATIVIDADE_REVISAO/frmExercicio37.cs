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

namespace ATIVIDADE_REVISAO
{
    public partial class frmExercicio37 : Form
    {
        public const int TAM = 10;
        public frmExercicio37()
        {
            InitializeComponent();
        }

        private void frmExercicio37_Load(object sender, EventArgs e)
        {
            rtbExercicio.Text = "37. Desenvolver um programa que carregue 10 números em um vetor A utilizando InputBox.Construir\n" +
                "uma Matriz B de mesmo tipo, observando a seguinte lei de formação: Se o valor do índice for par, o\n" +
                "valor deverá ser multiplicado por 5, se for ímpar, o valor deverá ser somado com 5.Ao final, mostrar\n" +
                "os conteúdos das duas matrizes.";
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            int[] vetorA = new int[TAM], vetorB = new int[TAM];
            string auxA = "", auxB = "";
            for(var i = 0; i < TAM; i++)
            {
                if (int.TryParse(Interaction.InputBox($"Digite o numero da posição {i} do vetor", "Entrada de dados"), out vetorA[i]))
                {
                    if (i % 2 == 0) vetorB[i] = vetorA[i] * 5;
                    else vetorB[i] = vetorA[i] + 5;
                    auxA += $"vetor A posicao {i} => {vetorA[i]}\n";
                    auxB += $"vetor B posicao {i} => {vetorB[i]}\n";
                } else
                {
                    MessageBox.Show("Somente valores numéricos!");
                    i--;
                }
            }
            rtbDados.Text = auxA +"\n"+ auxB;
            
        }
    }
}
