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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int posicao = txtpalavra2.Text.IndexOf(txtpalavra1.Text);
            while (posicao >= 0)
            {
                txtpalavra2.Text = txtpalavra2.Text.Substring(0, posicao)
                    + txtpalavra2.Text.Substring(posicao
                    + txtpalavra1.Text.Length, txtpalavra2.Text.Length - 
                    txtpalavra1.Text.Length - posicao);
                posicao = txtpalavra2.Text.IndexOf(txtpalavra1.Text);
            }
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            txtpalavra2.Text = txtpalavra2.Text.Replace(txtpalavra1.Text, "");
        }

        private void Inverte_Click(object sender, EventArgs e)
        {
            txtpalavra2.Text = "";
            char[] auxiliar = txtpalavra1.Text.ToCharArray();
            Array.Reverse(auxiliar);
            foreach(char c in auxiliar)
            {
                txtpalavra2.Text += c;
            }
        }
    }
}
