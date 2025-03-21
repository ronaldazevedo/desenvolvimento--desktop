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
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai medio (500 ml) - R$ 20,00");
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai grande (700 ml) - R$ 25,00");

        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            lbxTamanho.Items.Add("Açai familia  (1L) - R$ 35,00");

        }

        private void QntGonolaChanged(object sender, EventArgs e)
        {
            if (QntGronola.Value < 0)
            {
                lbxComplementos.Items.Add($"Granola - {QntGronola.Value}");
            }
            else 
            { 
                lbxComplementos.Items.Remove($"Granola - {QntGronola.Value + 1}");
            }
                
        }
    }
}
