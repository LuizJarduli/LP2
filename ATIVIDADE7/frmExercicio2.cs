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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N;
            if(int.TryParse(txtNum.Text, out N))
            {
                double H = 0;
                for(int i = 1; i <= N; i++)
                {
                    H = H + ((double)1/i);
                }
                MessageBox.Show("Valor final da sequência é: " + H.ToString("N2"));

            } else {

                MessageBox.Show("valor inválido!");
            
            }
        }
    }
}
