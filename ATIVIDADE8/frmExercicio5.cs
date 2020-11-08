using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE8
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            string imprime = "";
            int i = 0;
            ArrayList ListaAlunos = new ArrayList { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            ListaAlunos.Remove("Otávio");
            foreach (string aluno in ListaAlunos)
            {
                imprime += $"Aluno {i + 1}: {aluno}\n";
                i++;
            }
            MessageBox.Show(imprime);
        }
    }
}
