namespace ATIVIDADE7
{
    partial class frmExercicio1
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
            this.rchTxtFrase = new System.Windows.Forms.RichTextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.btnAchaPar = new System.Windows.Forms.Button();
            this.btnContaR = new System.Windows.Forms.Button();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtFrase
            // 
            this.rchTxtFrase.Location = new System.Drawing.Point(58, 118);
            this.rchTxtFrase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchTxtFrase.MaxLength = 100;
            this.rchTxtFrase.Name = "rchTxtFrase";
            this.rchTxtFrase.Size = new System.Drawing.Size(616, 78);
            this.rchTxtFrase.TabIndex = 0;
            this.rchTxtFrase.Text = "";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(63, 68);
            this.lblFrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(508, 27);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Insira uma frase (máximo de 100 caracteres) : ";
            // 
            // btnAchaPar
            // 
            this.btnAchaPar.Location = new System.Drawing.Point(477, 217);
            this.btnAchaPar.Name = "btnAchaPar";
            this.btnAchaPar.Size = new System.Drawing.Size(197, 158);
            this.btnAchaPar.TabIndex = 4;
            this.btnAchaPar.Text = "Nº de vezes em que um mesmo par de letras ocorre na frase";
            this.btnAchaPar.UseVisualStyleBackColor = true;
            this.btnAchaPar.Click += new System.EventHandler(this.btnAchaPar_Click);
            // 
            // btnContaR
            // 
            this.btnContaR.Location = new System.Drawing.Point(255, 217);
            this.btnContaR.Name = "btnContaR";
            this.btnContaR.Size = new System.Drawing.Size(216, 158);
            this.btnContaR.TabIndex = 5;
            this.btnContaR.Text = "Nº de vezes que a letra \'R\' se repete";
            this.btnContaR.UseVisualStyleBackColor = true;
            this.btnContaR.Click += new System.EventHandler(this.btnContaR_Click);
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(58, 217);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(191, 158);
            this.btnEspacoBranco.TabIndex = 6;
            this.btnEspacoBranco.Text = "Nº de espaços em branco que existem na frase";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 469);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.btnContaR);
            this.Controls.Add(this.btnAchaPar);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.rchTxtFrase);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnAchaPar;
        private System.Windows.Forms.Button btnContaR;
        private System.Windows.Forms.Button btnEspacoBranco;
    }
}