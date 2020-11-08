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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[20];
            string imprime = "";

            for (int i = 0; i < vetor.Length; i++){
                if (double.TryParse(Interaction.InputBox($"Digite a posição {i + 1} do vetor: "), out vetor[i])){
                    imprime = $"{vetor[i]}\n{imprime}";
                } else
                {
                    MessageBox.Show("Apenas valores numéricos por favor!");
                    i--;
                }
            }
            MessageBox.Show(imprime);
        }
    }
}
