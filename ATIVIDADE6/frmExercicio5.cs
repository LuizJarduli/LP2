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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int valor = 0, num1,num2;
            if(int.TryParse(txtnumero1.Text,out num1) && int.TryParse(txtnumero2.Text,out num2))
            {
                valor = aleatorio.Next(num1, num2);
                MessageBox.Show("O número aleatório gerado entre " + num1 + " e " + num2 + " é : " + valor);
            }
            
        }
    }
}
