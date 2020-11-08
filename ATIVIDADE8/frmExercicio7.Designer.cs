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
            this.btnImprime = new System.Windows.Forms.Button();
            this.lbDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
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
            // lbDados
            // 
            this.lbDados.FormattingEnabled = true;
            this.lbDados.ItemHeight = 16;
            this.lbDados.Location = new System.Drawing.Point(418, 12);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(370, 420);
            this.lbDados.TabIndex = 2;
            // 
            // frmExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.btnImprime);
            this.Name = "frmExercicio7";
            this.Text = "frmExercicio7";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.ListBox lbDados;
    }
}