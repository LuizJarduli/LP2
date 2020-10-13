using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE6
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchTexto.Text.Length;i++)
            {
                if (char.IsNumber(rchTexto.Text[i])) contador++;
            }
            MessageBox.Show("Quantidade de números digitados : "+ contador);
        }

        private void btnPosicaodobranco_Click(object sender, EventArgs e)
        {
            int contador = 0, posicao = 0;
            while (!char.IsWhiteSpace(rchTexto.Text[contador]))
            {
                contador++;
            }
            posicao = contador;
            MessageBox.Show("posicao do primeiro espaço em branco: "+(posicao+1));
        }

        private void btnContaLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach(char letra in rchTexto.Text)
            {
                if (char.IsLetter(letra)) contador++;
            }
            MessageBox.Show("Quantidade de letras digitadas : " + contador);
        }
    }
}
