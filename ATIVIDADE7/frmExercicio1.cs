using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE7
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            string frase;
            frase = rchTxtFrase.Text;
            int contador = 0;
            foreach(char letra in frase)
            {
                if(char.IsWhiteSpace(letra))
                {
                    contador++;
                }
            }
            MessageBox.Show("o número de espaços em branco na frase é: " + contador);
        }

        private void btnContaR_Click(object sender, EventArgs e)
        {
            string frase = rchTxtFrase.Text;
            int contador = 0;
            for(int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'R' || frase[i] == 'r')
                {
                    contador++;
                }
            }
            MessageBox.Show("O número de vezes em que R aparece na frase é: " + contador);
        }

        private void btnAchaPar_Click(object sender, EventArgs e)
        {
            string frase = rchTxtFrase.Text;
            int contaPar = 0;
            /*string par="";
            string[] Pares = new string[100];
            int contaPar = 0,maiorPar = 0;
            for(int i = 0; i < frase.Length; i++)
            {
                if (i > 0)
                {
                    if (frase[i-1] == frase[i])
                    {
                        par = string.Concat(frase[i - 1], frase[i]);
                        //MessageBox.Show(par);
                        Pares[contaPar] = par;
                        contaPar++; 
                               
                    }
                }
                
            }
            
            for(int i = 0; Pares[i] != null; i++)
            {
                contaPar = 1;
                for (int j = 0; Pares[j] != null; j++)
                {
                   
                    if(i != j)
                    {
                        if(Pares[i] == Pares[j])
                        {
                            contaPar++;
                        }
                        if(maiorPar < contaPar)
                        {
                            maiorPar = contaPar;
                            par = Pares[i];
                        }
                    }
                }
            }
            MessageBox.Show("O número de vezes que um mesmo par de letras ocorre é : " + maiorPar + " , onde o par é: "+par);*/
            for (int i = 0; i < frase.Length; i++)
            {
                if(i > 0)
                {
                    if (frase[i - 1] == frase[i])
                    {
                        contaPar++;
                    }
                }
                
            }
            MessageBox.Show("O número de vezes que um mesmo par de letras ocorre é : " + contaPar);
        }
    }
}
