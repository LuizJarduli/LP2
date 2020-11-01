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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach(Control controle in gpbDados.Controls)
            {
                if(controle is TextBox)
                {
                    controle.Text = "";
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome, cargo, nInscricao;
            double salario = 0, salBruto = 0, gratificacao = 0;
            int producao, b = 0, c = 0, d = 0;
            if(double.TryParse(txtSalario.Text, out salario) && double.TryParse(txtGratificacao.Text, out gratificacao) && int.TryParse(txtProducao.Text, out producao))
            {
                nome = txtNome.Text;
                cargo = txtCargo.Text;
                nInscricao = txtInscricao.Text;
                if (producao >= 150) d = 1;
                if (producao >= 120) c = 1;
                if (producao >= 100) b = 1;
                salBruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                if(salBruto > 7000)
                {
                    if (producao >= 150 && gratificacao > 0) MessageBox.Show("Salário Bruto de: " + salBruto.ToString("c2"));
                    else MessageBox.Show("Salário Bruto de: R$7.000,00");
                } else
                {
                    MessageBox.Show("Salário Bruto de: " + salBruto.ToString("c2"));
                }

            } else
            {
                MessageBox.Show("Dados Inválidos");
            }
        }
    }
}
