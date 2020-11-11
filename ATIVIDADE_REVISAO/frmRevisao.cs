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
    public partial class frmRevisao : Form
    {
        public frmRevisao()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio36ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio36"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio36 FrmExercicio = new frmExercicio36();
            FrmExercicio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio.WindowState = FormWindowState.Maximized;
            FrmExercicio.Show();
        }

        private void exercicio37ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio37"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio37 FrmExercicio = new frmExercicio37();
            FrmExercicio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio.WindowState = FormWindowState.Maximized;
            FrmExercicio.Show();
        }

        private void exercicio38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio37"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio38 FrmExercicio = new frmExercicio38();
            FrmExercicio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio.WindowState = FormWindowState.Maximized;
            FrmExercicio.Show();
        }

        private void exercicio39ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio_39"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio_39 FrmExercicio = new frmExercicio_39();
            FrmExercicio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio.WindowState = FormWindowState.Maximized;
            FrmExercicio.Show();
        }

        private void exercicio40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio_40"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio_40 FrmExercicio = new frmExercicio_40();
            FrmExercicio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmExercicio.WindowState = FormWindowState.Maximized;
            FrmExercicio.Show();
        }
    }
}
