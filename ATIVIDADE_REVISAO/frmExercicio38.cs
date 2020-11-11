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
    public partial class frmExercicio38 : Form
    {
        public const int linha = 7;
        public const int coluna = 5;
        public frmExercicio38()
        {
            InitializeComponent();
        }

        private void frmExercicio38_Load(object sender, EventArgs e)
        {
            rtbExercicio.Text = "38. Faça um programa que carregue valores(usando InputBox) de uma compra em uma matriz 7x5\n" +
                "(a linha é o dia da semana e a coluna são os produtos), depois some os elementos de cada linha,\n" +
                "gerando o vetor TotalporDia. Em seguida somar os elementos do vetor na variável TotalGeral.\n" +
                "Finalmente jogar todos os resultados do Vetor Linha e do TotalGeral em um componente ListBox."; 
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();
            double[,] matriz = new double[linha, coluna];
            double[] TotalPorDia = new double[linha];
            double TotalGeral = 0;
            
            for(var i = 0; i < linha; i++)
            {
                TotalPorDia[i] = 0;
                for (var j = 0; j < coluna; j++)
                {
                    if(double.TryParse(Interaction.InputBox($"insira o valor coluna {j+1} da matriz, presente na linha {i+1}: ","Entrada de dados"), out matriz[i,j]))
                    {
                        TotalPorDia[i] += matriz[i, j];
                    } else
                    {
                        MessageBox.Show("Insira Valores Númericos por favor!");
                    }
                }
                TotalGeral += TotalPorDia[i];
            }
            int x = 0;
            foreach(double valor in TotalPorDia)
            {
                lbResultado.Items.Add($"Dia {x+1}: {valor.ToString("c2")}\n");
                x++;
            }
            lbResultado.Items.Add($"\nTotal Geral dos 7 dias: {TotalGeral.ToString("c2")}");

        }
    }
}
