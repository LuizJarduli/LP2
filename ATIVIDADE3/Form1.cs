using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE3
{
    public partial class CalcularPesoIdeal : Form
    {

        double altura,peso,  pesoIdeal;
        String mensagem;
        public CalcularPesoIdeal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(double.TryParse(mtxtAltura.Text, out altura)&& double.TryParse(mtxtPeso.Text, out peso))
            {
                peso = peso / 100.0;
                pesoIdeal = rdbHomem.Checked == true ? Math.Round((72.7 * (altura/100)) - 58,2) : Math.Round((62.1 * (altura/100)) - 44.7,2);
                mensagem = peso > pesoIdeal ? "Regime Obrigatório já! \nseu peso Ideal é "+ pesoIdeal
                         : peso < pesoIdeal ? "Coma bastante massas e doces!\nseu peso Ideal é "+ pesoIdeal 
                         : "Você está com o peso ideal\nseu peso Ideal é " + pesoIdeal;
                MessageBox.Show(mensagem);

            } else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }
    }
}
