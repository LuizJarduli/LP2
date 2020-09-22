using ATIVIDADE4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE4
{
    public partial class ChecaTriangulo : Form
    {
        double a, b, c;
        string resultado;
        bool varTri = false;
        public ChecaTriangulo()
        {
            InitializeComponent();
        }
        string Triangulo(double a, double b, double c)
        {
            string tipoTrig;
            tipoTrig = a == b && a == c
                ? "Equilátero" : (a == b || a == c || c == b) && (a != b || a != c || b != c)
                ? "Isósceles" : a != b && b != c && c != a
                ? "Escaleno" : "Erro louco!";
            return tipoTrig;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ChecaTriangulo formulario = new ChecaTriangulo();
            foreach(Control txtbox in this.Controls)
            {
                if(txtbox is TextBox)
                {
                    txtbox.Text = String.Empty;
                    pbTriangulo.Image = Properties.Resources.img11;
                    pbTriangulo.Refresh();
                }
            }
        }

        private void ChecaTriangulo_Load(object sender, EventArgs e)
        {

            pbTriangulo.Image = Properties.Resources.img11;
            pbTriangulo.Refresh();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
            {
                varTri = a > Math.Abs(b - c) && a < b + c 
                        ? b > Math.Abs(a - c) && b < a + c 
                        ? c > Math.Abs(a - b) && c < a + b 
                        ? true : false : false : false;
                if(varTri == true)
                {
                    resultado = Triangulo(a, b, c);
                    if(resultado == "Equilátero")
                    {
                        pbTriangulo.Image = Properties.Resources.equilatero;
                    } else if(resultado == "Isósceles")
                    {
                        pbTriangulo.Image = Properties.Resources.isosceles;
                    } else 
                    {
                        pbTriangulo.Image = Properties.Resources.escaleno;
                    }
                    pbTriangulo.Refresh();
                    txtResultado.Text = resultado;
                } else
                {
                    MessageBox.Show("Os Lados desse triângulo \nnão são válidos!");
                }
            } else
            {
                MessageBox.Show("Valores Inválidos");
            }
        }
    }
}
