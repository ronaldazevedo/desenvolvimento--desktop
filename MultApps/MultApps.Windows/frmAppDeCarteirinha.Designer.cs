namespace MultApps.Windows
{
    partial class frmAppDeCarteirinha
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdadeCliente = new System.Windows.Forms.Label();
            this.lblCpfMostrado = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.btnGerarCarteirinha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Swis721 Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(745, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GERADOR DE CARTEIRINHA DE ACESSO AO PARQUE";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(21, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(21, 169);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 16);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(24, 195);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(167, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(24, 282);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(167, 20);
            this.txtNascimento.TabIndex = 5;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(21, 263);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(150, 16);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data De Nascimento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdadeCliente);
            this.panel1.Controls.Add(this.lblCpfMostrado);
            this.panel1.Controls.Add(this.lblNomeCompleto);
            this.panel1.Location = new System.Drawing.Point(473, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 268);
            this.panel1.TabIndex = 7;
            // 
            // lblIdadeCliente
            // 
            this.lblIdadeCliente.AutoSize = true;
            this.lblIdadeCliente.Location = new System.Drawing.Point(83, 223);
            this.lblIdadeCliente.Name = "lblIdadeCliente";
            this.lblIdadeCliente.Size = new System.Drawing.Size(0, 13);
            this.lblIdadeCliente.TabIndex = 2;
            // 
            // lblCpfMostrado
            // 
            this.lblCpfMostrado.AutoSize = true;
            this.lblCpfMostrado.Location = new System.Drawing.Point(108, 203);
            this.lblCpfMostrado.Name = "lblCpfMostrado";
            this.lblCpfMostrado.Size = new System.Drawing.Size(0, 13);
            this.lblCpfMostrado.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(108, 148);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(0, 13);
            this.lblNomeCompleto.TabIndex = 0;
            // 
            // btnGerarCarteirinha
            // 
            this.btnGerarCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCarteirinha.Location = new System.Drawing.Point(209, 354);
            this.btnGerarCarteirinha.Name = "btnGerarCarteirinha";
            this.btnGerarCarteirinha.Size = new System.Drawing.Size(121, 23);
            this.btnGerarCarteirinha.TabIndex = 8;
            this.btnGerarCarteirinha.Text = "Gerar Carteirinha";
            this.btnGerarCarteirinha.UseVisualStyleBackColor = true;
            this.btnGerarCarteirinha.Click += new System.EventHandler(this.btnGerarCarteirinha_Click);
            // 
            // frmAppDeCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.btnGerarCarteirinha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAppDeCarteirinha";
            this.Text = "frmAppDeCarteira";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdadeCliente;
        private System.Windows.Forms.Label lblCpfMostrado;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Button btnGerarCarteirinha;
    }
}