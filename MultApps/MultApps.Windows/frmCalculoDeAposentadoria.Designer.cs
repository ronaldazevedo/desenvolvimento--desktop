namespace MultApps.Windows
{
    partial class frmCalculoDeAposentadoria
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
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTempoContribuicao = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtContribuicao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.painelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.painelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNascimento.Location = new System.Drawing.Point(12, 18);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(221, 25);
            this.lblNascimento.TabIndex = 0;
            this.lblNascimento.Text = "Data de nascimento";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(15, 47);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(241, 20);
            this.txtNascimento.TabIndex = 1;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSexo.Location = new System.Drawing.Point(12, 96);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(167, 25);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo biológico";
            // 
            // lblTempoContribuicao
            // 
            this.lblTempoContribuicao.AutoSize = true;
            this.lblTempoContribuicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoContribuicao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTempoContribuicao.Location = new System.Drawing.Point(12, 165);
            this.lblTempoContribuicao.Name = "lblTempoContribuicao";
            this.lblTempoContribuicao.Size = new System.Drawing.Size(371, 25);
            this.lblTempoContribuicao.TabIndex = 3;
            this.lblTempoContribuicao.Text = "Tempo de contribuição (em anos).";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(17, 124);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(239, 20);
            this.txtSexo.TabIndex = 4;
            // 
            // txtContribuicao
            // 
            this.txtContribuicao.Location = new System.Drawing.Point(17, 193);
            this.txtContribuicao.Name = "txtContribuicao";
            this.txtContribuicao.Size = new System.Drawing.Size(239, 20);
            this.txtContribuicao.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(226, 247);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 33);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // painelResultado
            // 
            this.painelResultado.Controls.Add(this.lblResultado);
            this.painelResultado.Location = new System.Drawing.Point(17, 301);
            this.painelResultado.Name = "painelResultado";
            this.painelResultado.Size = new System.Drawing.Size(589, 67);
            this.painelResultado.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Transparent;
            this.lblResultado.Location = new System.Drawing.Point(47, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 24);
            this.lblResultado.TabIndex = 0;
            // 
            // frmCalculoDeAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(618, 395);
            this.Controls.Add(this.painelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtContribuicao);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblTempoContribuicao);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.lblNascimento);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmCalculoDeAposentadoria";
            this.Text = "frmCalculoDeAposentadoria";
            this.painelResultado.ResumeLayout(false);
            this.painelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTempoContribuicao;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtContribuicao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel painelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}