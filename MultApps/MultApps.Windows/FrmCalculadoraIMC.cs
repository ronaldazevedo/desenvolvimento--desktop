﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            cmbIdade.Visible = true;
            LblIdades.Visible = true;
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cmbIdade.Visible = false;
            LblIdades.Visible = false;

        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkFeminino.Checked = false;

        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkMasculino.Checked = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //PRIMEIRO PASSO OBTER OS VALORES
            var peso = double.Parse(txtPeso.Text);
            var altura = double.Parse(txtAltura.Text);

            // FAZ O PROCESSAMENTO
            var imc = peso / (altura * altura);
            var textoBase = $@"Meu IMC: {imc:N2} é";
            //exibe o resultado
            if (chkAdulto.Checked && chkMasculino.Checked)
            {
                #region Adulto Masculino



                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} abaixo do normal";
                    picBoxImc.Load(ImcImagem.MasculinoAbaixoDoPesoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} normal";
                    picBoxImc.Load(ImcImagem.MasculinoPesoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} sobrepeso";
                    picBoxImc.Load(ImcImagem.MasculinoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase}  obesidade grau 1";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 2";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau2);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 3";
                    picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau3);
                }
                #endregion


            }

            if (chkAdulto.Checked && chkFeminino.Checked)
            {
                #region Adulto Femenino

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} abaixo do normal";
                    picBoxImc.Load(ImcImagem.FemininoAbaixoDoPesoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} normal";
                    picBoxImc.Load(ImcImagem.FemininoPesoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} sobrepeso";
                    picBoxImc.Load(ImcImagem.FemininoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase}  obesidade grau 1";
                    picBoxImc.Load(ImcImagem.FemininoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 2";
                    picBoxImc.Load(ImcImagem.FemininoObesidadeGrau2);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 3";
                    picBoxImc.Load(ImcImagem.FemininoObesidadeGrau3);


                }
                #endregion
            }

            if (chkCrianca.Checked)
            {
                #region Crianca

                if (imc >= 2)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade";
                    picBoxImc.Load(ImcImagem.CriancaObesidade);
                }
                else if (imc < 2 && imc >= 1)
                {
                    lblResultadoImc.Text = $@"{textoBase} sobrepeso";
                    picBoxImc.Load(ImcImagem.CriancaSobrepeso);
                }
                else if (imc < 1 && imc >= -2)
                {
                    lblResultadoImc.Text = $@"{textoBase} peso normal";
                    picBoxImc.Load(ImcImagem.CriancaPesoNormal);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase} abaixo do normal";
                    picBoxImc.Load(ImcImagem.CriancaAbaixoDoPesoNormal);
                }
                #endregion

            }
        }
    }
}
