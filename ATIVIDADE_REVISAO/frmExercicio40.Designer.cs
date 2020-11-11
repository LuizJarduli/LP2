namespace ATIVIDADE_REVISAO
{
    partial class frmExercicio_40
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
            this.cbConversao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnSeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbConversao
            // 
            this.cbConversao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConversao.FormattingEnabled = true;
            this.cbConversao.Items.AddRange(new object[] {
            "De Arroba Para Quilo ",
            "De Libra Para Quilo ",
            "De Onça Para Grama ",
            "De Acre Para Hectare ",
            "De Hectare Para Metro2 ",
            "De AlqueireMG Para Hectare ",
            "De AlqueireSP Para Hectare ",
            "De AlqueireNorte Para Hectare ",
            "De Braça Para Metro ",
            "De Jarda Para Metro ",
            "De Pé Para Centímetro ",
            "De Polegada Para Centímetro ",
            "De Milha Para Quilometro "});
            this.cbConversao.Location = new System.Drawing.Point(265, 117);
            this.cbConversao.Name = "cbConversao";
            this.cbConversao.Size = new System.Drawing.Size(362, 24);
            this.cbConversao.TabIndex = 0;
            this.cbConversao.SelectedIndexChanged += new System.EventHandler(this.cbConversao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione uma medida de conversão";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(265, 188);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(132, 22);
            this.txtDe.TabIndex = 2;
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Para";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(493, 188);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(132, 22);
            this.txtPara.TabIndex = 4;
            this.txtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPara_KeyPress);
            // 
            // btnSeta
            // 
            this.btnSeta.Location = new System.Drawing.Point(404, 186);
            this.btnSeta.Name = "btnSeta";
            this.btnSeta.Size = new System.Drawing.Size(83, 24);
            this.btnSeta.TabIndex = 6;
            this.btnSeta.Text = "-";
            this.btnSeta.UseVisualStyleBackColor = true;
            // 
            // frmExercicio_40
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 468);
            this.Controls.Add(this.btnSeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConversao);
            this.Name = "frmExercicio_40";
            this.Text = "frmExercicio_40";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConversao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnSeta;
    }
}