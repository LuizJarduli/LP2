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
    public partial class frmAtividade7 : Form
    {
        public frmAtividade7()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbfrmPrincipal.Hide();
            Form fc = Application.OpenForms["frmExercicio1"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio1 FrmExercicio1 = new frmExercicio1();
            FrmExercicio1.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio1.WindowState = FormWindowState.Maximized;
            FrmExercicio1.Show();
        }
        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbfrmPrincipal.Hide();
            Form fc = Application.OpenForms["frmExercicio2"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio2 FrmExercicio2 = new frmExercicio2();
            FrmExercicio2.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio2.WindowState = FormWindowState.Maximized;
            FrmExercicio2.Show();
        }
        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbfrmPrincipal.Hide();
            Form fc = Application.OpenForms["frmExercicio3"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio3 FrmExercicio3 = new frmExercicio3();
            FrmExercicio3.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio3.WindowState = FormWindowState.Maximized;
            FrmExercicio3.Show();
        }
        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbfrmPrincipal.Hide();
            Form fc = Application.OpenForms["frmExercicio4"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio4 FrmExercicio4 = new frmExercicio4();
            FrmExercicio4.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio4.WindowState = FormWindowState.Maximized;
            FrmExercicio4.Show();
        }
    }
}
