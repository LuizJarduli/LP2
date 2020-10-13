namespace ATIVIDADE6
{
    partial class frmExercicio2
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
            this.lblpalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtpalavra1 = new System.Windows.Forms.TextBox();
            this.txtpalavra2 = new System.Windows.Forms.TextBox();
            this.btnTestaIgual = new System.Windows.Forms.Button();
            this.btnInsere = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpalavra1
            // 
            this.lblpalavra1.AutoSize = true;
            this.lblpalavra1.Location = new System.Drawing.Point(64, 87);
            this.lblpalavra1.Name = "lblpalavra1";
            this.lblpalavra1.Size = new System.Drawing.Size(112, 27);
            this.lblpalavra1.TabIndex = 0;
            this.lblpalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(64, 156);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(112, 27);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtpalavra1
            // 
            this.txtpalavra1.Location = new System.Drawing.Point(203, 84);
            this.txtpalavra1.Name = "txtpalavra1";
            this.txtpalavra1.Size = new System.Drawing.Size(237, 34);
            this.txtpalavra1.TabIndex = 2;
            // 
            // txtpalavra2
            // 
            this.txtpalavra2.Location = new System.Drawing.Point(203, 149);
            this.txtpalavra2.Name = "txtpalavra2";
            this.txtpalavra2.Size = new System.Drawing.Size(237, 34);
            this.txtpalavra2.TabIndex = 3;
            // 
            // btnTestaIgual
            // 
            this.btnTestaIgual.Location = new System.Drawing.Point(69, 305);
            this.btnTestaIgual.Name = "btnTestaIgual";
            this.btnTestaIgual.Size = new System.Drawing.Size(200, 106);
            this.btnTestaIgual.TabIndex = 4;
            this.btnTestaIgual.Text = "Testar se são iguais";
            this.btnTestaIgual.UseVisualStyleBackColor = true;
            this.btnTestaIgual.Click += new System.EventHandler(this.btnTestaIgual_Click);
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(280, 305);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(207, 106);
            this.btnInsere.TabIndex = 5;
            this.btnInsere.Text = "Insere o primeiro no meio do segundo";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 106);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insere asterisco no meio do primeiro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.btnTestaIgual);
            this.Controls.Add(this.txtpalavra2);
            this.Controls.Add(this.txtpalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblpalavra1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmExercicio2";
            this.Text = " Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtpalavra1;
        private System.Windows.Forms.TextBox txtpalavra2;
        private System.Windows.Forms.Button btnTestaIgual;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button button1;
    }
}