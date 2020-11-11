namespace ATIVIDADE_REVISAO
{
    partial class frmExercicio38
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
            this.rtbExercicio = new System.Windows.Forms.RichTextBox();
            this.btnInsere = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbExercicio
            // 
            this.rtbExercicio.Location = new System.Drawing.Point(12, 12);
            this.rtbExercicio.Name = "rtbExercicio";
            this.rtbExercicio.ReadOnly = true;
            this.rtbExercicio.Size = new System.Drawing.Size(483, 209);
            this.rtbExercicio.TabIndex = 5;
            this.rtbExercicio.Text = "";
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(12, 285);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(238, 83);
            this.btnInsere.TabIndex = 3;
            this.btnInsere.Text = "Inserir Itens na matriz";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 16;
            this.lbResultado.Location = new System.Drawing.Point(521, 12);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(327, 356);
            this.lbResultado.TabIndex = 6;
            // 
            // frmExercicio38
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.rtbExercicio);
            this.Controls.Add(this.btnInsere);
            this.Name = "frmExercicio38";
            this.Text = "frmExercicio38";
            this.Load += new System.EventHandler(this.frmExercicio38_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbExercicio;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.ListBox lbResultado;
    }
}