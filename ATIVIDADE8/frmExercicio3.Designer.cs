namespace ATIVIDADE8
{
    partial class frmExercicio3
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
            this.btnInsere = new System.Windows.Forms.Button();
            this.rtbDados = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(29, 12);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(355, 89);
            this.btnInsere.TabIndex = 0;
            this.btnInsere.Text = "Inserir Mercadorias";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // rtbDados
            // 
            this.rtbDados.Location = new System.Drawing.Point(405, 12);
            this.rtbDados.Name = "rtbDados";
            this.rtbDados.ReadOnly = true;
            this.rtbDados.Size = new System.Drawing.Size(383, 410);
            this.rtbDados.TabIndex = 1;
            this.rtbDados.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(29, 107);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(355, 89);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rtbDados);
            this.Controls.Add(this.btnInsere);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.RichTextBox rtbDados;
        private System.Windows.Forms.Button btnLimpar;
    }
}