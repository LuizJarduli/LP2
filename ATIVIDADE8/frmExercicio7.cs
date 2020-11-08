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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            // Meu RA = 0030482011021 - último dígito é 1
            int N = 1, chars = 0;
            int[] numCaracter = new int[N];
            string[] nomes = new string[N];
            string imprime = "";

            for(int i = 0; i < N; i++)
            {
                nomes[i] = Interaction.InputBox($"Insira o nome {i + 1}: ", "Nomes");
                chars = 0;
                foreach (char letra in nomes[i])
                {
                    if (!char.IsWhiteSpace(letra)) chars++;
                }
                numCaracter[i] = chars;
                imprime += $"o nome:{nomes[i]} tem {numCaracter[i]} caracteres\n";
            }
            lbDados.Items.Add(imprime);
        }
    }
}
