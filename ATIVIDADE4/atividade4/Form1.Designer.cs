namespace ATIVIDADE4
{
    partial class ChecaTriangulo
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pbTriangulo = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Location = new System.Drawing.Point(77, 108);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(102, 32);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Lado A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Location = new System.Drawing.Point(77, 170);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(104, 32);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Lado B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Location = new System.Drawing.Point(75, 232);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(105, 32);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Lado C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(236, 105);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(180, 39);
            this.txtA.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(236, 229);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(180, 39);
            this.txtC.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(236, 167);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(180, 39);
            this.txtB.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(236, 353);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(180, 93);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(530, 285);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(324, 39);
            this.txtResultado.TabIndex = 8;
            // 
            // pbTriangulo
            // 
            this.pbTriangulo.BackColor = System.Drawing.Color.Transparent;
            this.pbTriangulo.Location = new System.Drawing.Point(530, 105);
            this.pbTriangulo.Name = "pbTriangulo";
            this.pbTriangulo.Size = new System.Drawing.Size(324, 163);
            this.pbTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTriangulo.TabIndex = 6;
            this.pbTriangulo.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Location = new System.Drawing.Point(530, 353);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(324, 93);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ChecaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::ATIVIDADE4.Properties.Resources.img3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 541);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.pbTriangulo);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChecaTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triângulos";
            this.Load += new System.EventHandler(this.ChecaTriangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.PictureBox pbTriangulo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}

