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
    public partial class frmLojaDeAcai : Form
    {

        public frmLojaDeAcai()
        {
            InitializeComponent();
        }


        private void btnPequeno_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai pequeno(300 ml) - R$ 15,00");
            lbxTotal.Items.Add("Acai de 300 - 15 reais");
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai medio (500 ml) - R$ 20,00");
            lbxTotal.Items.Add("Acai de 500 - 20 reais");
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai grande (700 ml) - R$ 25,00");
            lbxTotal.Items.Add("Acai de 700 - 25 reais");
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai familia (1L) - R$ 35,00");
            lbxTotal.Items.Add("Acai de 1 L - 35 reais");
        }

        private void QntGronola_ValueChanged(object sender, EventArgs e)
        {

            lbxComplementos.Items.Add("Granola - R$ 2,00");

            if (QntGronola.Value < 0)
            {
                lbxComplementos.Items.Add($"Granola - {QntGronola.Value}");

            }
            else
            {
                lbxComplementos.Items.Remove($"Granola - {QntGronola.Value + 1}");
               
            }
             
        }

        private void QntLeiteCondensado_ValueChanged_1(object sender, EventArgs e)
        {
            if (QntLeiteCondensado.Value < 0)
            {
                lbxComplementos.Items.Add($" LeiteCondensado- {QntLeiteCondensado.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"LeiteCondensado - {QntLeiteCondensado.Value + 1}");
            }

            lbxComplementos.Items.Add("LeiteCondensado - R$ 2,00");
        }

        private void QntLeiteEmPo_ValueChanged(object sender, EventArgs e)
        {
            lbxComplementos.Items.Add("Leite em Po - R$ 2,00");

            if (QntLeiteEmPo.Value < 0)
            {
                lbxComplementos.Items.Add($" Leite Em Po - {QntLeiteEmPo.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Leite em Po - {QntLeiteEmPo.Value + 1}");
            }
        }

        private void QntPaçoca_ValueChanged(object sender, EventArgs e)
        {
            lbxComplementos.Items.Add(" Paçoca - R$ 2,00");

            if (QntPaçoca.Value < 0)
            {
                lbxComplementos.Items.Add($" Paçoca - {QntPaçoca.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Paçoca - {QntPaçoca.Value + 1}");
            }
        }

        private void QntOvomaltine_ValueChanged(object sender, EventArgs e)
        {
            lbxComplementos.Items.Add(" Ovomaltine - R$ 2,00");

            if (QntOvomaltine.Value < 0)
            {
                lbxComplementos.Items.Add($" Ovomaltine - {QntOvomaltine.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Ovomaltine - {QntOvomaltine.Value + 1}");
            }
        }

        private void QntGranulado_ValueChanged(object sender, EventArgs e)
        {
            lbxComplementos.Items.Add(" Granulado - R$ 2,00");

            if (QntGranulado.Value < 0)
            {
                lbxComplementos.Items.Add($"Granulado - {QntGranulado.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Granulado - {QntGranulado.Value + 1}");
            }
        }

        private void QntAbacaxi_ValueChanged(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(" Abacaxi - R$ 3,00");

            if (QntAbacaxi.Value < 0)
            {
                lbxComplementos.Items.Add($"Abacaxi - {QntAbacaxi.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Abacaxi - {QntAbacaxi.Value + 1}");
            }
        }

        private void QntManga_ValueChanged(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(" Manga - R$ 3,00");

            if (QntManga.Value < 0)
            {
                lbxComplementos.Items.Add($"Manga - {QntManga.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Manga - {QntManga.Value + 1}");
            }
        }

        private void QntKiwi_ValueChanged(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(" Kiwi - R$ 3,00");

            if (QntKiwi.Value < 0)
            {
                lbxComplementos.Items.Add($"Kiwi - {QntKiwi.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Kiwi - {QntKiwi.Value + 1}");
            }
        }

        private void QntUva_ValueChanged(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(" Uva - R$ 3,00");
            if (QntUva.Value < 0)
            {
                lbxFrutas.Items.Add(" Uva - R$ 3,00");

                lbxComplementos.Items.Add($"Uva - {QntUva.Value}");
            }
            else
            {
                lbxFrutas.Items.Remove($"Uva - {QntUva.Value + 1}");
            }
        }

        private void QntMorango_ValueChanged(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(" Morango - R$ 3,00");

            if (QntMorango.Value < 0)
            {
                lbxComplementos.Items.Add($"Morango - {QntMorango.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Morango - {QntMorango.Value + 1}");
            }
        }

        private void QntBanana_ValueChanged(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(" Banana - R$ 3,00");

            if (QntBanana.Value < 0)
            {
                lbxComplementos.Items.Add($"Banana - {QntBanana.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Banana - {QntBanana.Value + 1}");
            }
        }

        private void QntGroseliaComplemento_ValueChanged_1(object sender, EventArgs e)
        {
            lbxCoberturas.Items.Add(" Groselia - R$ 3,00");

            if (QntGroseliaComplemento.Value < 0)
            {
                lbxComplementos.Items.Add($"Groselia - {QntGroseliaComplemento.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Groselia - {QntGroseliaComplemento.Value + 1}");
            }
        }
        private void QntChocolateComplemento_ValueChanged(object sender, EventArgs e)
        {
            lbxCoberturas.Items.Add(" Chocolate - R$ 3,00");

            if (QntChocolateComplemento.Value < 0)
            {
                lbxComplementos.Items.Add($"Chocolate - {QntChocolateComplemento.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Chocolate - {QntChocolateComplemento.Value + 1}");
            }
        }

        private void QntLimãoComplemento_ValueChanged(object sender, EventArgs e)
        {
            lbxCoberturas.Items.Add(" Limão - R$ 3,00");

            if (QntLimãoComplemento.Value < 0)
            {
                lbxComplementos.Items.Add($"Limão - {QntLimãoComplemento.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Limão - {QntLimãoComplemento.Value + 1}");
            }
        }

        private void QntUvaComplemento_ValueChanged(object sender, EventArgs e)
        {
            lbxCoberturas.Items.Add(" Uva - R$ 3,00");

            if (QntUvaComplemento.Value < 0)
            {
                lbxComplementos.Items.Add($"Uva - {QntUvaComplemento.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Uva - {QntUvaComplemento.Value + 1}");
            }
        }

        private void QntMorangoComplemento_ValueChanged(object sender, EventArgs e)
        {
            lbxCoberturas.Items.Add(" Morango - R$ 3,00");

            if (QntMorangoComplemento.Value < 0)
            {
                lbxComplementos.Items.Add($"Morango - {QntMorangoComplemento.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Morango - {QntMorangoComplemento.Value + 1}");
            }
        }

        private void QntCarameloComplemento_ValueChanged(object sender, EventArgs e)
        {
            lbxCoberturas.Items.Add(" Caramelo - R$ 3,00");

            if (QntCarameloComplemento.Value < 0)
            {
                lbxComplementos.Items.Add($"Caramelo - {QntCarameloComplemento.Value}");
            }
            else
            {
                lbxComplementos.Items.Remove($"Caramelo - {QntCarameloComplemento.Value + 1}");
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (lbxTotal.SelectedItem != null)
            {
                lbxTotal.Items.Remove("Acai de 500 - 30 reais");
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }


    }
}
       
    

