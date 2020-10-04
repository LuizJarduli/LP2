using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double[] AliquotaINSS_calc(double salarioB)
        {
            // função pra retornar a Alíquota do INSS
            double[] Aliquota = new double[2];
            // Definindo o percentual do desconto de acordo com o salário bruto
            Aliquota[0] = salarioB <= 800.47
                       ? salarioB * 0.0765 : salarioB <= 1050
                       ? salarioB * 0.0865 : salarioB <= 1400.77
                       ? salarioB * 0.09 : salarioB <= 2801.56
                       ? salarioB * 0.11 : 308.17;
            // Definindo a porcentagem do desconto para exibir para o usuário
            Aliquota[1] = salarioB <= 800.47
                       ? 7.65 : salarioB <= 1050
                       ? 8.65 : salarioB <= 1400.77
                       ? 9.00 : salarioB <= 2801.56
                       ? 11.0 : 0;
            //  retornando o resultado
            Aliquota[0] = Math.Round(Aliquota[0], 2);
            Aliquota[1] = Math.Round(Aliquota[1], 2);
            return Aliquota;
        }
        public static double[] AliquotaIRPF_calc(double salarioB)
        {
            // função para retornar a Alíquota do IRPF
            double[] Aliquota = new double[2];
            // definindo o percentual do desconto
            Aliquota[0] = salarioB <= 1257.12
                       ? 0 : salarioB <= 2512.08
                       ? salarioB * 0.15 : salarioB * 0.275;
            // Definindo a porcentagem do desconto para exibir para o usuário
            Aliquota[1] = salarioB <= 1257.12
                       ? 0 : salarioB <= 2512.08
                       ? 15 : 27.5;
            //retornando o resultado
            Aliquota[0] = Math.Round(Aliquota[0], 2);
            Aliquota[1] = Math.Round(Aliquota[1], 2);
            return Aliquota;
        }
        public static double SalFamilia_calc(double salarioB, int filhos)
        {
            //função para retornar o salário família 
            //com base no salário bruto e número de filhos
            double SalFamilia = 0;
            SalFamilia = salarioB <= 435.52
                         ? filhos * 22.33 : salarioB <= 654.61
                         ? filhos * 15.74 : 0;
            return Math.Round(SalFamilia,2);
        }
        public static void limparCampos(GroupBox grupo)
        {
            // função pra limpar uma série de componentes
            foreach (Control componente in grupo.Controls)
            {
                if (componente is TextBox)
                {
                    ((TextBox)componente).Clear();
                }
                else if (componente is MaskedTextBox)
                {
                    ((MaskedTextBox)componente).Clear();
                }
                else if (componente is ComboBox)
                {
                    ((ComboBox)componente).SelectedIndex = -1;
                }
                else if (componente is CheckBox)
                {
                    ((CheckBox)componente).Checked = false;
                }
                else if (componente is RadioButton)
                {
                    ((RadioButton)componente).Checked = false;
                }
                else if (componente is PictureBox)
                {
                    ((PictureBox)componente).Image = null;
                }
                else if (componente is RichTextBox)
                {
                    ((RichTextBox)componente).Clear();
                }
                else if (componente is ProgressBar)
                {
                    ((ProgressBar)componente).Value = ((ProgressBar)componente).Minimum;
                }
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // declaração das variáveis que serão utilizadas no decorrer do cálculo
            string nomeFuncionario, mensagem;
            int filhos;
            double Salbruto,
                   SalFamilia,
                   SalLiquido;
            double[] AliqDescInss = new double[2];
            double[] AliqDescIrpf = new double[2];
            nomeFuncionario = txtnome.Text.Trim();
            
            // validando as entradas do usuário
            if(double.TryParse(mtxtSalBrut.Text, out Salbruto) && 
               int.TryParse(mtxtnumF.Text, out filhos) &&
               txtnome.Text != "")
            {
                // Usando as funções definidas acima para calcular os descontos do INSS/IRPF e também 
                // os valores do salário família
                AliqDescInss = AliquotaINSS_calc(Salbruto);
                AliqDescIrpf = AliquotaIRPF_calc(Salbruto);
                SalFamilia = SalFamilia_calc(Salbruto, filhos);
                SalLiquido = Math.Round(Salbruto - AliqDescIrpf[0] - AliqDescInss[0] + SalFamilia,2);
                if(rdbFem.Checked == true)
                {
                    // caso os dados sejam de uma pessoa do sexo feminino
                    mensagem = "Os descontos do salário da Sra. " + nomeFuncionario;
                    if(ckbCasado.Checked == true)
                    {
                        mensagem += " que é Casada";
                    } else
                    {
                        mensagem += " que é Solteira";
                    }
                    if(filhos > 0)
                    {
                        mensagem += " e tem "+filhos+" filho(s) são: ";
                    } else
                    {
                        mensagem += " e não possui filhos são: ";
                    }
                } else
                {
                    // caso os dados sejam de uma pessoa do sexo masculino
                    mensagem = "Os descontos do salário do Sr. " + nomeFuncionario;
                    if (ckbCasado.Checked == true)
                    {
                        mensagem += " que é Casado";
                    }
                    else
                    {
                        mensagem += " que é Solteiro";
                    }
                    if (filhos > 0)
                    {
                        mensagem += " e tem " + filhos + " filho(s) são: ";
                    }
                    else
                    {
                        mensagem += " e não possui filhos são: ";
                    }
                }
                // atribuindo as variáveis com seus devidos resultados aos MaskedTextBox para exibição para o usuário
                txtsituacao.Text = mensagem;
                txtsituacao.Show();
                mtxtAliqInss.Text = AliqDescInss[1] == 0 ? "Teto" : AliqDescInss[1].ToString() + " %";
                mtxtAliqIrpf.Text = AliqDescIrpf[1].ToString() + " %";
                mtxtSalFam.Text = SalFamilia.ToString("c2");
                mtxtDescInss.Text = AliqDescInss[0].ToString("c2");
                mtxtDescIrpf.Text = AliqDescIrpf[0].ToString("c2");
                mtxtSalLiq.Text = SalLiquido.ToString("c2");

            } else
            {
                // caso o usuário digite valores inválidos, a seguinte mensagem será transmitida
                MessageBox.Show("Valores inválidos! Digite novamente");
            }

        }

        private void btnLimpar_click(object sender, EventArgs e)
        {
            // chamando a função limparCampos para remover os dados do formulário
            limparCampos(gpbEntrada);
            limparCampos(gbpResult);
            txtsituacao.Clear();
            txtsituacao.Hide();
        }
    }
}
