using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482011021
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false; 
        private DataSet dsCidade = new DataSet();
        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try { 

                Cidade Cid = new Cidade(); 
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;
                txtid.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtcidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cbxEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");
                // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
            } catch (Exception ex)
            { 
                    MessageBox.Show(ex.Message);             
            } 
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            bnCidade.AddNew();
            txtcidade.Enabled = true;
            cbxEstado.Enabled = true;
            cbxEstado.SelectedIndex = 0;
            txtcidade.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true; 

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtcidade.Text == "")
            {
                MessageBox.Show("Cidade inválida!");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtid.Text);
                RegCid.Nomecidade = txtcidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();
                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso!");
                        btnSalvar.Enabled = false;
                        txtid.Enabled = false;
                        txtcidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                        bInclusao = false;
                        // recarrega o grid
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        txtid.Enabled = false;
                        txtcidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            txtcidade.Enabled = true;
            cbxEstado.Enabled = true;
            txtcidade.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
           == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtid.Text);
                RegCid.Nomecidade = txtcidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();
                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso!");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();
            btnSalvar.Enabled = false;
            txtcidade.Enabled = false;
            cbxEstado.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
