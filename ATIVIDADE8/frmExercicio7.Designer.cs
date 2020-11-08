namespace ATIVIDADE8
{
    partial class frmExercicio7
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
            this.rtbDados = new System.Windows.Forms.RichTextBox();
            this.btnImprime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDados
            // 
            this.rtbDados.Location = new System.Drawing.Point(418, 13);
            this.rtbDados.Name = "rtbDados";
            this.rtbDados.ReadOnly = true;
            this.rtbDados.Size = new System.Drawing.Size(370, 425);
            this.rtbDados.TabIndex = 0;
            this.rtbDados.Text = "";
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(12, 12);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(400, 127);
            this.btnImprime.TabIndex = 1;
            this.btnImprime.Text = "Executar";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // frmExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.rtbDados);
            this.Name = "frmExercicio7";
            this.Text = "frmExercicio7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDados;
        private System.Windows.Forms.Button btnImprime;
    }
}