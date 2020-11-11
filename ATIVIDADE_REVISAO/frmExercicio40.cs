using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_REVISAO
{
    public partial class frmExercicio_40 : Form
    {
        public frmExercicio_40()
        {
            InitializeComponent();
        }

        public double RetornaConversao(double valor, int IndiceSelecionado, bool sentido)
        {
            double conversao = 0;
            switch (IndiceSelecionado)
            {
                case 0:
                    if (sentido) conversao = valor * 15.0;
                    else conversao = valor / 15.0;
                    break;
                case 1:
                    if (sentido) conversao = valor * 0.4535923;
                    else conversao = valor / 0.4535923;
                    break;
                case 2:
                    if (sentido) conversao = valor * 28.349;
                    else conversao = valor / 28.349;
                    break;
                case 3:
                    if (sentido) conversao = valor * 0.4046856224;
                    else conversao = valor / 0.4046856224;
                    break;
                case 4:
                    if (sentido) conversao = valor * 10000.0;
                    else conversao = valor / 10000.0;
                    break;
                case 5:
                    if (sentido) conversao = valor * 4.84;
                    else conversao = valor / 4.84;
                    break;
                case 6:
                    if (sentido) conversao = valor * 2.42;
                    else conversao = valor / 2.42;
                    break;
                case 7:
                    if (sentido) conversao = valor * 2.72;
                    else conversao = valor / 2.72;
                    break;
                case 8:
                    if (sentido) conversao = valor * 1.8288;
                    else conversao = valor / 1.8288;
                    break;
                case 9:
                    if (sentido) conversao = valor * 0.9144;
                    else conversao = valor / 0.9144;
                    break;
                case 10:
                    if (sentido) conversao = valor * 30.48;
                    else conversao = valor / 30.48;
                    break;
                case 11:
                    if (sentido) conversao = valor * 2.54;
                    else conversao = valor / 2.54;
                    break;
                case 12:
                    if (sentido) conversao = valor * 1.609344;
                    else conversao = valor / 1.609344;
                    break;
                default:
                        break;
            }
            return conversao;
        }
        private void cbConversao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDe.Clear();
            txtPara.Clear();
            txtDe.Focus();
        }

        private void txtDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)13)
            {
                double val, retorno;
                if (double.TryParse(txtDe.Text, out val)){
                    retorno = RetornaConversao(val,cbConversao.SelectedIndex,true);
                    txtPara.Text = retorno.ToString();
                } else
                {
                    MessageBox.Show("Digite algum valor númerico!");
                }
                
            }
        }

        private void txtPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                double val, retorno;
                if (double.TryParse(txtPara.Text, out val))
                {
                    retorno = RetornaConversao(val, cbConversao.SelectedIndex, false);
                    txtDe.Text = retorno.ToString();
                }
                else
                {
                    MessageBox.Show("Digite algum valor númerico!");
                }

            }
        }
    }
}
