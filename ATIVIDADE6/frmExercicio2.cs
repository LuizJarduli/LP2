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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnTestaIgual_Click(object sender, EventArgs e)
        {
            if(String.Compare(txtpalavra1.Text, txtpalavra2.Text,true) == 0)
            {
                MessageBox.Show("São iguais");
            } else
            {
                MessageBox.Show("São diferentes");
            }
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            int meio = txtpalavra2.Text.Length / 2;
            txtpalavra2.Text = txtpalavra2.Text.Substring(0, meio) + txtpalavra1.Text + txtpalavra2.Text.Substring(meio, txtpalavra2.Text.Length-meio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int meio = txtpalavra1.Text.Length / 2;
            txtpalavra2.Text = txtpalavra1.Text.Insert(meio, "**");
        }
    }
}
