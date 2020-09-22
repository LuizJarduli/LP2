namespace ATIVIDADE3
{
    partial class CalcularPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbMulher = new System.Windows.Forms.RadioButton();
            this.rdbHomem = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.gpbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(44, 56);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(88, 32);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(44, 128);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(78, 32);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdbMulher);
            this.gpbGenero.Controls.Add(this.rdbHomem);
            this.gpbGenero.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGenero.Location = new System.Drawing.Point(377, 56);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(200, 223);
            this.gpbGenero.TabIndex = 4;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Gênero";
            // 
            // rdbMulher
            // 
            this.rdbMulher.AutoSize = true;
            this.rdbMulher.Checked = true;
            this.rdbMulher.Location = new System.Drawing.Point(32, 119);
            this.rdbMulher.Name = "rdbMulher";
            this.rdbMulher.Size = new System.Drawing.Size(121, 36);
            this.rdbMulher.TabIndex = 6;
            this.rdbMulher.TabStop = true;
            this.rdbMulher.Text = "Mulher";
            this.rdbMulher.UseVisualStyleBackColor = true;
            // 
            // rdbHomem
            // 
            this.rdbHomem.AutoSize = true;
            this.rdbHomem.Location = new System.Drawing.Point(32, 64);
            this.rdbHomem.Name = "rdbHomem";
            this.rdbHomem.Size = new System.Drawing.Size(134, 36);
            this.rdbHomem.TabIndex = 5;
            this.rdbHomem.Text = "Homem";
            this.rdbHomem.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(50, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(273, 55);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Location = new System.Drawing.Point(158, 66);
            this.mtxtAltura.Mask = "000 centimetros";
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.PromptChar = ' ';
            this.mtxtAltura.Size = new System.Drawing.Size(152, 22);
            this.mtxtAltura.TabIndex = 6;
            this.mtxtAltura.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Location = new System.Drawing.Point(158, 138);
            this.mtxtPeso.Mask = "000 Kg";
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.PromptChar = ' ';
            this.mtxtPeso.Size = new System.Drawing.Size(114, 22);
            this.mtxtPeso.TabIndex = 7;
            this.mtxtPeso.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // CalcularPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.mtxtPeso);
            this.Controls.Add(this.mtxtAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Name = "CalcularPesoIdeal";
            this.Text = "Calcular peso ideal";
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.RadioButton rdbMulher;
        private System.Windows.Forms.RadioButton rdbHomem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
    }
}

