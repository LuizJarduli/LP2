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
    public partial class frmExercicio_39 : Form
    {
        public frmExercicio_39()
        {
            InitializeComponent();
        }

        public void LimparCampos(GroupBox grupo)
        {
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(gpbDados);
            LimparCampos(gpbEmpresa);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome, telefone, estadoCivil, sexo, nomeEmpresa, retorno = "";
            int idade;
            double salPretendido;
            if (!string.IsNullOrWhiteSpace(txtnome.Text) &&
                !string.IsNullOrWhiteSpace(txtTelefone.Text) &&
                !string.IsNullOrWhiteSpace(txtLastEmpresa.Text) &&
                int.TryParse(CombIdade.Text,out idade) &&
                double.TryParse(mtxtSalario.Text, out salPretendido) &&
                (chbFem.Checked == true || chbMasc.Checked == true))
            {
                nome = txtnome.Text;
                telefone = txtTelefone.Text;
                nomeEmpresa = txtLastEmpresa.Text;

                if (rdbCasado.Checked == true) estadoCivil = rdbCasado.Text;
                else if (rdbDesquitado.Checked == true) estadoCivil = rdbDesquitado.Text;
                else if (rdbDivorciado.Checked == true) estadoCivil = rdbDivorciado.Text;
                else if (rdbOutros.Checked == true) estadoCivil = rdbOutros.Text;
                else if (rdbSolteiro.Checked == true) estadoCivil = rdbSolteiro.Text;
                else estadoCivil = rdbViuvo.Text;
                
                if (chbMasc.Checked == true) sexo = chbMasc.Text;
                else sexo = chbFem.Text;

                if(cbExper.SelectedIndex == 0) retorno = "Você não tem os requisitos necessários para a vaga, Desculpe.\nObrigado pela participação";
                if(cbExper.SelectedIndex == 1) retorno = "Você será chamado para um teste, aguarde nosso contato";
                if(combDistancia.SelectedIndex == 3) retorno = "Você não tem os requisitos necessários para a vaga,\na empresa não fornece transporte. Desculpe!\nObrigado pela participação";
                if (salPretendido < 1000 && salPretendido > 2500) retorno = "Você não tem os requisitos necessários para a vaga, salário pretendido está muito alto! Desculpe\nObrigado pela participação";
                if (retorno == "") retorno = "Parabéns, você foi selecionado para a vaga!\nEntraremos em contato";
                MessageBox.Show(retorno);
            } else
            {
                MessageBox.Show("Alguns campos possuem valores inválidos \nou não foram preenchidos!");
            }
        }

        private void chbMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMasc.Checked == true) chbFem.Checked = false;
            else chbMasc.Checked = false;
        }

        private void chbFem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFem.Checked == true) chbMasc.Checked = false;
            else chbFem.Checked = false;
        }
    }
}
