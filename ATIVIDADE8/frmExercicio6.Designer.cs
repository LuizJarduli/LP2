namespace ATIVIDADE8
{
    partial class frmExercicio6
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
            this.btnCalcula = new System.Windows.Forms.Button();
            this.rtbDados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(12, 12);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(343, 97);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Inserir Notas";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // rtbDados
            // 
            this.rtbDados.Location = new System.Drawing.Point(361, 12);
            this.rtbDados.Name = "rtbDados";
            this.rtbDados.ReadOnly = true;
            this.rtbDados.Size = new System.Drawing.Size(427, 426);
            this.rtbDados.TabIndex = 1;
            this.rtbDados.Text = "";
            // 
            // frmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDados);
            this.Controls.Add(this.btnCalcula);
            this.Name = "frmExercicio6";
            this.Text = "frmExercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.RichTextBox rtbDados;
    }
}