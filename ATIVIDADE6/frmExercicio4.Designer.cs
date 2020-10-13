namespace ATIVIDADE6
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.btnPosicaodobranco = new System.Windows.Forms.Button();
            this.btnContaNumeros = new System.Windows.Forms.Button();
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaLetras.Location = new System.Drawing.Point(500, 283);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(230, 106);
            this.btnContaLetras.TabIndex = 20;
            this.btnContaLetras.Text = "Quantidade de letras";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.btnContaLetras_Click);
            // 
            // btnPosicaodobranco
            // 
            this.btnPosicaodobranco.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicaodobranco.Location = new System.Drawing.Point(287, 283);
            this.btnPosicaodobranco.Name = "btnPosicaodobranco";
            this.btnPosicaodobranco.Size = new System.Drawing.Size(207, 106);
            this.btnPosicaodobranco.TabIndex = 19;
            this.btnPosicaodobranco.Text = "Posicao do primeiro espaço em branco";
            this.btnPosicaodobranco.UseVisualStyleBackColor = true;
            this.btnPosicaodobranco.Click += new System.EventHandler(this.btnPosicaodobranco_Click);
            // 
            // btnContaNumeros
            // 
            this.btnContaNumeros.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaNumeros.Location = new System.Drawing.Point(76, 283);
            this.btnContaNumeros.Name = "btnContaNumeros";
            this.btnContaNumeros.Size = new System.Drawing.Size(200, 106);
            this.btnContaNumeros.TabIndex = 18;
            this.btnContaNumeros.Text = "Quantidade de números";
            this.btnContaNumeros.UseVisualStyleBackColor = true;
            this.btnContaNumeros.Click += new System.EventHandler(this.btnContaNumeros_Click);
            // 
            // rchTexto
            // 
            this.rchTexto.Location = new System.Drawing.Point(189, 33);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(430, 180);
            this.rchTexto.TabIndex = 21;
            this.rchTexto.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchTexto);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnPosicaodobranco);
            this.Controls.Add(this.btnContaNumeros);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaLetras;
        private System.Windows.Forms.Button btnPosicaodobranco;
        private System.Windows.Forms.Button btnContaNumeros;
        private System.Windows.Forms.RichTextBox rchTexto;
    }
}