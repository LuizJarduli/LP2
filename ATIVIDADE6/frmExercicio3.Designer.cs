namespace ATIVIDADE6
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
            this.Inverte = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtpalavra2 = new System.Windows.Forms.TextBox();
            this.txtpalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblpalavra1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inverte
            // 
            this.Inverte.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inverte.Location = new System.Drawing.Point(500, 283);
            this.Inverte.Name = "Inverte";
            this.Inverte.Size = new System.Drawing.Size(230, 106);
            this.Inverte.TabIndex = 13;
            this.Inverte.Text = "Inverte palavra";
            this.Inverte.UseVisualStyleBackColor = true;
            this.Inverte.Click += new System.EventHandler(this.Inverte_Click);
            // 
            // btnRemover2
            // 
            this.btnRemover2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover2.Location = new System.Drawing.Point(287, 283);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(207, 106);
            this.btnRemover2.TabIndex = 12;
            this.btnRemover2.Text = "Remover (replace)";
            this.btnRemover2.UseVisualStyleBackColor = true;
            this.btnRemover2.Click += new System.EventHandler(this.btnRemover2_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(76, 283);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(200, 106);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover primeiro do segundo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtpalavra2
            // 
            this.txtpalavra2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalavra2.Location = new System.Drawing.Point(210, 127);
            this.txtpalavra2.Name = "txtpalavra2";
            this.txtpalavra2.Size = new System.Drawing.Size(237, 34);
            this.txtpalavra2.TabIndex = 10;
            // 
            // txtpalavra1
            // 
            this.txtpalavra1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalavra1.Location = new System.Drawing.Point(210, 62);
            this.txtpalavra1.Name = "txtpalavra1";
            this.txtpalavra1.Size = new System.Drawing.Size(237, 34);
            this.txtpalavra1.TabIndex = 9;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(71, 134);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(112, 27);
            this.lblPalavra2.TabIndex = 8;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // lblpalavra1
            // 
            this.lblpalavra1.AutoSize = true;
            this.lblpalavra1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpalavra1.Location = new System.Drawing.Point(71, 65);
            this.lblpalavra1.Name = "lblpalavra1";
            this.lblpalavra1.Size = new System.Drawing.Size(112, 27);
            this.lblpalavra1.TabIndex = 7;
            this.lblpalavra1.Text = "Palavra 1";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inverte);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtpalavra2);
            this.Controls.Add(this.txtpalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblpalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inverte;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtpalavra2;
        private System.Windows.Forms.TextBox txtpalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblpalavra1;
    }
}