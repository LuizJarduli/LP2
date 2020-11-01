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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string frase = txtpalindromo.Text.ToUpper();
            string semEspaco = frase.Trim().Replace(" ", "");
            char[] fraseChar = new char[50];
            fraseChar = semEspaco.ToCharArray();
            Array.Reverse(fraseChar);
            StringBuilder constroiString = new StringBuilder();
            foreach(char letra in fraseChar)
            {
                constroiString.Append(letra);
            }
            string fraseInvertida = constroiString.ToString();
            if(fraseInvertida == semEspaco)
            {
                MessageBox.Show("É palíndromo\nFrase Invertida: " + fraseInvertida + "\nFrase Normal: "+semEspaco);
            } else
            {
                MessageBox.Show("Não é palíndromo\n");
            }

        }
    }
}
