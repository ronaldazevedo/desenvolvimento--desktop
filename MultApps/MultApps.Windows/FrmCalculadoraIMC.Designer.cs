﻿namespace MultApps.Windows
{
    partial class FrmCalculadoraIMC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxImc = new System.Windows.Forms.PictureBox();
            this.lblResultadoImc = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelAdulto = new System.Windows.Forms.Panel();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.LblIdades = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.chkFeminino = new System.Windows.Forms.CheckBox();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImc)).BeginInit();
            this.panelAdulto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picBoxImc);
            this.panel1.Controls.Add(this.lblResultadoImc);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.panelAdulto);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.chkFeminino);
            this.panel1.Controls.Add(this.chkMasculino);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkCrianca);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 759);
            this.panel1.TabIndex = 0;
            // 
            // picBoxImc
            // 
            this.picBoxImc.Location = new System.Drawing.Point(710, 158);
            this.picBoxImc.Name = "picBoxImc";
            this.picBoxImc.Size = new System.Drawing.Size(250, 378);
            this.picBoxImc.TabIndex = 10;
            this.picBoxImc.TabStop = false;
            // 
            // lblResultadoImc
            // 
            this.lblResultadoImc.AutoSize = true;
            this.lblResultadoImc.Location = new System.Drawing.Point(403, 455);
            this.lblResultadoImc.Name = "lblResultadoImc";
            this.lblResultadoImc.Size = new System.Drawing.Size(94, 24);
            this.lblResultadoImc.TabIndex = 9;
            this.lblResultadoImc.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(78, 450);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 34);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelAdulto
            // 
            this.panelAdulto.Controls.Add(this.txtAltura);
            this.panelAdulto.Controls.Add(this.cmbIdade);
            this.panelAdulto.Controls.Add(this.txtPeso);
            this.panelAdulto.Controls.Add(this.LblIdades);
            this.panelAdulto.Controls.Add(this.LblAltura);
            this.panelAdulto.Controls.Add(this.LblPeso);
            this.panelAdulto.Location = new System.Drawing.Point(57, 216);
            this.panelAdulto.Name = "panelAdulto";
            this.panelAdulto.Size = new System.Drawing.Size(496, 199);
            this.panelAdulto.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(137, 46);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(83, 29);
            this.txtAltura.TabIndex = 16;
            // 
            // cmbIdade
            // 
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "1 anos",
            "2 anos",
            "3 ano s",
            "4 anos ",
            "5 anos",
            "6 anos",
            "7 anos ",
            "8 anos",
            "9 anos ",
            "10 anos ",
            "11 anos ",
            "12 anos ",
            "13 anos ",
            "14 anos ",
            "15 anos ",
            "16 anos ",
            "17 anos ",
            "18 anos "});
            this.cmbIdade.Location = new System.Drawing.Point(283, 46);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(173, 32);
            this.cmbIdade.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(21, 46);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(83, 29);
            this.txtPeso.TabIndex = 10;
            // 
            // LblIdades
            // 
            this.LblIdades.AutoSize = true;
            this.LblIdades.Location = new System.Drawing.Point(279, 19);
            this.LblIdades.Name = "LblIdades";
            this.LblIdades.Size = new System.Drawing.Size(57, 24);
            this.LblIdades.TabIndex = 9;
            this.LblIdades.Text = "Idade";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(133, 19);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(58, 24);
            this.LblAltura.TabIndex = 1;
            this.LblAltura.Text = "Altura";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Location = new System.Drawing.Point(21, 19);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(53, 24);
            this.LblPeso.TabIndex = 0;
            this.LblPeso.Text = "Peso";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(73, 141);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(184, 25);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Acima de 19 anos";
            // 
            // chkFeminino
            // 
            this.chkFeminino.AutoSize = true;
            this.chkFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFeminino.ForeColor = System.Drawing.Color.Gray;
            this.chkFeminino.Location = new System.Drawing.Point(750, 82);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.Size = new System.Drawing.Size(176, 41);
            this.chkFeminino.TabIndex = 2;
            this.chkFeminino.Text = "Feminino";
            this.chkFeminino.UseVisualStyleBackColor = true;
            this.chkFeminino.Click += new System.EventHandler(this.chkFeminino_CheckedChanged);
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Checked = true;
            this.chkMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasculino.ForeColor = System.Drawing.Color.Orange;
            this.chkMasculino.Location = new System.Drawing.Point(537, 82);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(189, 41);
            this.chkMasculino.TabIndex = 1;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            this.chkMasculino.Click += new System.EventHandler(this.chkMasculino_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sexo";
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.Color.Gray;
            this.chkCrianca.Location = new System.Drawing.Point(212, 82);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(154, 41);
            this.chkCrianca.TabIndex = 2;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = true;
            this.chkCrianca.Click += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.Orange;
            this.chkAdulto.Location = new System.Drawing.Point(78, 82);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(134, 41);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.Click += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione";
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1599, 831);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCalculadoraIMC";
            this.Text = "FrmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImc)).EndInit();
            this.panelAdulto.ResumeLayout(false);
            this.panelAdulto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkCrianca;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFeminino;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelAdulto;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label LblIdades;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultadoImc;
        private System.Windows.Forms.PictureBox picBoxImc;
    }
}