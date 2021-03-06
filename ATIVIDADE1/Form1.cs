﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroTrabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtraio.Clear();
            txtvolume.Clear();
            txtaltura.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double altura , raio;
            altura = 0;
            raio = 0;
            // tryParse é um método que retorna se o valor indicado para conversão foi um valor válido
            if (double.TryParse(txtaltura.Text, out altura) && (double.TryParse(txtraio.Text, out raio))) 
            {
                double volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtvolume.Text = volume.ToString("N2");

            }
            else
            {
                MessageBox.Show("Valores inválidos!!");
            }
        }

        private void txtraio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Testa se é Enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
