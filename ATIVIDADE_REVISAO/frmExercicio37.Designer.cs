namespace ATIVIDADE_REVISAO
{
    partial class frmExercicio37
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
            this.rtbExercicio = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(12, 299);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(238, 83);
            this.btnInsere.TabIndex = 0;
            this.btnInsere.Text = "Inserir Itens no vetor";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // rtbDados
            // 
            this.rtbDados.Location = new System.Drawing.Point(478, 21);
            this.rtbDados.Name = "rtbDados";
            this.rtbDados.Size = new System.Drawing.Size(412, 361);
            this.rtbDados.TabIndex = 1;
            this.rtbDados.Text = "";
            // 
            // rtbExercicio
            // 
            this.rtbExercicio.Location = new System.Drawing.Point(12, 21);
            this.rtbExercicio.Name = "rtbExercicio";
            this.rtbExercicio.ReadOnly = true;
            this.rtbExercicio.Size = new System.Drawing.Size(412, 209);
            this.rtbExercicio.TabIndex = 2;
            this.rtbExercicio.Text = "";
            // 
            // frmExercicio37
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 462);
            this.Controls.Add(this.rtbExercicio);
            this.Controls.Add(this.rtbDados);
            this.Controls.Add(this.btnInsere);
            this.Name = "frmExercicio37";
            this.Text = "frmExercicio37";
            this.Load += new System.EventHandler(this.frmExercicio37_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.RichTextBox rtbDados;
        private System.Windows.Forms.RichTextBox rtbExercicio;
    }
}