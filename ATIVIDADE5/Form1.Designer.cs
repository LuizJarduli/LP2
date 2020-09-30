namespace ATIVIDADE5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbEntrada = new System.Windows.Forms.GroupBox();
            this.mtxtnumF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSalBrut = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.ckbCasado = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.lblnumf = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.lblfunc = new System.Windows.Forms.Label();
            this.gbpResult = new System.Windows.Forms.GroupBox();
            this.mtxtSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDescIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDescInss = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSalFam = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAliqIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAliqInss = new System.Windows.Forms.MaskedTextBox();
            this.lbldescirpf = new System.Windows.Forms.Label();
            this.lbldescInss = new System.Windows.Forms.Label();
            this.lblSalliq = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblirpf = new System.Windows.Forms.Label();
            this.lblinss = new System.Windows.Forms.Label();
            this.txtsituacao = new System.Windows.Forms.TextBox();
            this.lblsit = new System.Windows.Forms.Label();
            this.gpbEntrada.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEntrada
            // 
            this.gpbEntrada.Controls.Add(this.mtxtnumF);
            this.gpbEntrada.Controls.Add(this.mtxtSalBrut);
            this.gpbEntrada.Controls.Add(this.btnLimpar);
            this.gpbEntrada.Controls.Add(this.txtnome);
            this.gpbEntrada.Controls.Add(this.btnCalc);
            this.gpbEntrada.Controls.Add(this.ckbCasado);
            this.gpbEntrada.Controls.Add(this.panel1);
            this.gpbEntrada.Controls.Add(this.lblnumf);
            this.gpbEntrada.Controls.Add(this.lblsal);
            this.gpbEntrada.Controls.Add(this.lblfunc);
            this.gpbEntrada.Location = new System.Drawing.Point(12, 12);
            this.gpbEntrada.Name = "gpbEntrada";
            this.gpbEntrada.Size = new System.Drawing.Size(426, 491);
            this.gpbEntrada.TabIndex = 3;
            this.gpbEntrada.TabStop = false;
            this.gpbEntrada.Text = "Dados Funcionário";
            // 
            // mtxtnumF
            // 
            this.mtxtnumF.Location = new System.Drawing.Point(200, 147);
            this.mtxtnumF.Mask = "00";
            this.mtxtnumF.Name = "mtxtnumF";
            this.mtxtnumF.Size = new System.Drawing.Size(58, 30);
            this.mtxtnumF.TabIndex = 11;
            // 
            // mtxtSalBrut
            // 
            this.mtxtSalBrut.Location = new System.Drawing.Point(200, 103);
            this.mtxtSalBrut.Mask = "00000.00";
            this.mtxtSalBrut.Name = "mtxtSalBrut";
            this.mtxtSalBrut.Size = new System.Drawing.Size(209, 30);
            this.mtxtSalBrut.TabIndex = 10;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(230, 412);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 61);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(200, 58);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(209, 30);
            this.txtnome.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(24, 412);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(190, 61);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Verificar Desconto";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // ckbCasado
            // 
            this.ckbCasado.AutoSize = true;
            this.ckbCasado.Location = new System.Drawing.Point(24, 354);
            this.ckbCasado.Name = "ckbCasado";
            this.ckbCasado.Size = new System.Drawing.Size(100, 27);
            this.ckbCasado.TabIndex = 6;
            this.ckbCasado.Text = "Casado";
            this.ckbCasado.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.rdbMasc);
            this.panel1.Controls.Add(this.rdbFem);
            this.panel1.Location = new System.Drawing.Point(24, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 125);
            this.panel1.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(10, 12);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 23);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(14, 90);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(48, 27);
            this.rdbMasc.TabIndex = 1;
            this.rdbMasc.Text = "M";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Checked = true;
            this.rdbFem.Location = new System.Drawing.Point(14, 47);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(43, 27);
            this.rdbFem.TabIndex = 0;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "F";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // lblnumf
            // 
            this.lblnumf.AutoSize = true;
            this.lblnumf.Location = new System.Drawing.Point(20, 150);
            this.lblnumf.Name = "lblnumf";
            this.lblnumf.Size = new System.Drawing.Size(158, 23);
            this.lblnumf.TabIndex = 5;
            this.lblnumf.Text = "Número de filhos";
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(20, 106);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(124, 23);
            this.lblsal.TabIndex = 4;
            this.lblsal.Text = "Salário Bruto";
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Location = new System.Drawing.Point(20, 61);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(161, 23);
            this.lblfunc.TabIndex = 3;
            this.lblfunc.Text = "Nome funcionário";
            // 
            // gbpResult
            // 
            this.gbpResult.Controls.Add(this.mtxtSalLiq);
            this.gbpResult.Controls.Add(this.mtxtDescIrpf);
            this.gbpResult.Controls.Add(this.mtxtDescInss);
            this.gbpResult.Controls.Add(this.mtxtSalFam);
            this.gbpResult.Controls.Add(this.mtxtAliqIrpf);
            this.gbpResult.Controls.Add(this.mtxtAliqInss);
            this.gbpResult.Controls.Add(this.lbldescirpf);
            this.gbpResult.Controls.Add(this.lbldescInss);
            this.gbpResult.Controls.Add(this.lblSalliq);
            this.gbpResult.Controls.Add(this.lblSalFamilia);
            this.gbpResult.Controls.Add(this.lblirpf);
            this.gbpResult.Controls.Add(this.lblinss);
            this.gbpResult.Controls.Add(this.txtsituacao);
            this.gbpResult.Controls.Add(this.lblsit);
            this.gbpResult.Enabled = false;
            this.gbpResult.Location = new System.Drawing.Point(462, 12);
            this.gbpResult.Name = "gbpResult";
            this.gbpResult.Size = new System.Drawing.Size(446, 491);
            this.gbpResult.TabIndex = 12;
            this.gbpResult.TabStop = false;
            this.gbpResult.Text = "Resultados";
            // 
            // mtxtSalLiq
            // 
            this.mtxtSalLiq.Location = new System.Drawing.Point(190, 376);
            this.mtxtSalLiq.Name = "mtxtSalLiq";
            this.mtxtSalLiq.Size = new System.Drawing.Size(232, 30);
            this.mtxtSalLiq.TabIndex = 25;
            // 
            // mtxtDescIrpf
            // 
            this.mtxtDescIrpf.Location = new System.Drawing.Point(190, 332);
            this.mtxtDescIrpf.Name = "mtxtDescIrpf";
            this.mtxtDescIrpf.Size = new System.Drawing.Size(232, 30);
            this.mtxtDescIrpf.TabIndex = 24;
            // 
            // mtxtDescInss
            // 
            this.mtxtDescInss.Location = new System.Drawing.Point(190, 290);
            this.mtxtDescInss.Name = "mtxtDescInss";
            this.mtxtDescInss.Size = new System.Drawing.Size(232, 30);
            this.mtxtDescInss.TabIndex = 23;
            // 
            // mtxtSalFam
            // 
            this.mtxtSalFam.Location = new System.Drawing.Point(190, 245);
            this.mtxtSalFam.Name = "mtxtSalFam";
            this.mtxtSalFam.Size = new System.Drawing.Size(232, 30);
            this.mtxtSalFam.TabIndex = 22;
            // 
            // mtxtAliqIrpf
            // 
            this.mtxtAliqIrpf.Location = new System.Drawing.Point(190, 194);
            this.mtxtAliqIrpf.Name = "mtxtAliqIrpf";
            this.mtxtAliqIrpf.Size = new System.Drawing.Size(232, 30);
            this.mtxtAliqIrpf.TabIndex = 21;
            // 
            // mtxtAliqInss
            // 
            this.mtxtAliqInss.Location = new System.Drawing.Point(190, 147);
            this.mtxtAliqInss.Name = "mtxtAliqInss";
            this.mtxtAliqInss.Size = new System.Drawing.Size(232, 30);
            this.mtxtAliqInss.TabIndex = 20;
            // 
            // lbldescirpf
            // 
            this.lbldescirpf.AutoSize = true;
            this.lbldescirpf.Location = new System.Drawing.Point(22, 335);
            this.lbldescirpf.Name = "lbldescirpf";
            this.lbldescirpf.Size = new System.Drawing.Size(144, 23);
            this.lbldescirpf.TabIndex = 19;
            this.lbldescirpf.Text = "Desconto IRPF";
            // 
            // lbldescInss
            // 
            this.lbldescInss.AutoSize = true;
            this.lbldescInss.Location = new System.Drawing.Point(22, 293);
            this.lbldescInss.Name = "lbldescInss";
            this.lbldescInss.Size = new System.Drawing.Size(144, 23);
            this.lbldescInss.TabIndex = 18;
            this.lbldescInss.Text = "Desconto INSS";
            // 
            // lblSalliq
            // 
            this.lblSalliq.AutoSize = true;
            this.lblSalliq.Location = new System.Drawing.Point(22, 379);
            this.lblSalliq.Name = "lblSalliq";
            this.lblSalliq.Size = new System.Drawing.Size(141, 23);
            this.lblSalliq.TabIndex = 17;
            this.lblSalliq.Text = "Salário Líquido";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(22, 248);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(141, 23);
            this.lblSalFamilia.TabIndex = 16;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblirpf
            // 
            this.lblirpf.AutoSize = true;
            this.lblirpf.Location = new System.Drawing.Point(22, 201);
            this.lblirpf.Name = "lblirpf";
            this.lblirpf.Size = new System.Drawing.Size(133, 23);
            this.lblirpf.TabIndex = 15;
            this.lblirpf.Text = "Alíquota IRPF";
            // 
            // lblinss
            // 
            this.lblinss.AutoSize = true;
            this.lblinss.Location = new System.Drawing.Point(22, 154);
            this.lblinss.Name = "lblinss";
            this.lblinss.Size = new System.Drawing.Size(133, 23);
            this.lblinss.TabIndex = 14;
            this.lblinss.Text = "Alíquota INSS";
            // 
            // txtsituacao
            // 
            this.txtsituacao.Location = new System.Drawing.Point(114, 34);
            this.txtsituacao.Multiline = true;
            this.txtsituacao.Name = "txtsituacao";
            this.txtsituacao.Size = new System.Drawing.Size(308, 99);
            this.txtsituacao.TabIndex = 13;
            this.txtsituacao.Visible = false;
            // 
            // lblsit
            // 
            this.lblsit.AutoSize = true;
            this.lblsit.Location = new System.Drawing.Point(22, 37);
            this.lblsit.Name = "lblsit";
            this.lblsit.Size = new System.Drawing.Size(86, 23);
            this.lblsit.TabIndex = 12;
            this.lblsit.Text = "Situação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 515);
            this.Controls.Add(this.gbpResult);
            this.Controls.Add(this.gpbEntrada);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imposto de Renda";
            this.gpbEntrada.ResumeLayout(false);
            this.gpbEntrada.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbpResult.ResumeLayout(false);
            this.gbpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEntrada;
        private System.Windows.Forms.MaskedTextBox mtxtnumF;
        private System.Windows.Forms.MaskedTextBox mtxtSalBrut;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox ckbCasado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.Label lblnumf;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.GroupBox gbpResult;
        private System.Windows.Forms.TextBox txtsituacao;
        private System.Windows.Forms.Label lblsit;
        private System.Windows.Forms.MaskedTextBox mtxtSalLiq;
        private System.Windows.Forms.MaskedTextBox mtxtDescIrpf;
        private System.Windows.Forms.MaskedTextBox mtxtDescInss;
        private System.Windows.Forms.MaskedTextBox mtxtSalFam;
        private System.Windows.Forms.MaskedTextBox mtxtAliqIrpf;
        private System.Windows.Forms.MaskedTextBox mtxtAliqInss;
        private System.Windows.Forms.Label lbldescirpf;
        private System.Windows.Forms.Label lbldescInss;
        private System.Windows.Forms.Label lblSalliq;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblirpf;
        private System.Windows.Forms.Label lblinss;
    }
}

