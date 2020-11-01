namespace ATIVIDADE7
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
            this.txtpalindromo = new System.Windows.Forms.TextBox();
            this.lblpalindromo = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpalindromo
            // 
            this.txtpalindromo.Location = new System.Drawing.Point(100, 146);
            this.txtpalindromo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtpalindromo.MaxLength = 50;
            this.txtpalindromo.Name = "txtpalindromo";
            this.txtpalindromo.Size = new System.Drawing.Size(496, 34);
            this.txtpalindromo.TabIndex = 0;
            // 
            // lblpalindromo
            // 
            this.lblpalindromo.AutoSize = true;
            this.lblpalindromo.Location = new System.Drawing.Point(95, 102);
            this.lblpalindromo.Name = "lblpalindromo";
            this.lblpalindromo.Size = new System.Drawing.Size(349, 27);
            this.lblpalindromo.TabIndex = 1;
            this.lblpalindromo.Text = "Digite para ver se é Palíndromo";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(100, 203);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(496, 212);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 427);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.lblpalindromo);
            this.Controls.Add(this.txtpalindromo);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpalindromo;
        private System.Windows.Forms.Label lblpalindromo;
        private System.Windows.Forms.Button btnVerifica;
    }
}