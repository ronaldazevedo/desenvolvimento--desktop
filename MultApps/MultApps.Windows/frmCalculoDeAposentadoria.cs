using System;
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
    public partial class frmCalculoDeAposentadoria : Form
    {
        public frmCalculoDeAposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    // Validação inicial
                    if (string.IsNullOrWhiteSpace(txtNascimento.Text) ||
                        string.IsNullOrWhiteSpace(txtSexo.Text) ||
                        string.IsNullOrWhiteSpace(txtContribuicao.Text))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos.");
                        return;
                    }

                    // Processamento
                    DateTime dataNascimento;
                    if (!DateTime.TryParse(txtNascimento.Text, out dataNascimento))
                    {
                        MessageBox.Show("Data de nascimento inválida. Use o formato DD/MM/AAAA.");
                        return;
                    }

                    string sexoBiologico = txtSexo.Text.ToLower();
                    if (sexoBiologico != "masculino" && sexoBiologico != "feminino")
                    {
                        MessageBox.Show("Sexo biológico inválido. Use 'masculino' ou 'feminino'.");
                        return;
                    }

                    int tempoContribuicao;
                    if (!int.TryParse(txtContribuicao.Text, out tempoContribuicao) || tempoContribuicao < 0)
                    {
                        MessageBox.Show("Tempo de contribuição inválido. Insira um número válido.");
                        return;
                    }

                    // Cálculo da idade
                    int idade = DateTime.Now.Year - dataNascimento.Year;
                    if (DateTime.Now.Date < dataNascimento.AddYears(idade)) idade--;

                    int pontuacao = idade + tempoContribuicao;
                    
                    if (pontuacao > 0)


                    // Validação lógica
                    if (tempoContribuicao < idade)
                    {
                        MessageBox.Show("O tempo de contribuição não pode ser maior que a idade.");
                        return;
                    }

                    // Requisitos para aposentadoria
                    bool aptoParaAposentar = (sexoBiologico == "masculino" && idade >= 65 && tempoContribuicao <= 35) ||
                                             (sexoBiologico == "feminino" && idade >= 62 && tempoContribuicao <= 30);

                    // Exibição do resultado
                    if (aptoParaAposentar)
                    {
                        lblResultado.Text = "Você não cumpre os requisitos para se aposentar.";
                        painelResultado.BackColor = Color.LightCoral;
                        
                    }
                    else
                    {
                        lblResultado.Text = "Você pode dar entrada no processo de aposentadoria.";
                        painelResultado.BackColor = Color.LightGreen;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira os dados no formato correto.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado: " + ex.Message);
                }
            }

        }
    }
}
