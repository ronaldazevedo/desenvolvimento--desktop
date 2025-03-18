using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MultApps.Windows
{
    public partial class frmAppDeCarteirinha : Form
    {
        public frmAppDeCarteirinha()
        {
            InitializeComponent();
        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {

            this.Text = "Carteirinha Diversão Total";
            this.Size = new Size(250, 400);

            // Painel principal
            Panel painel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = GetCorZona(Text)
            };
            this.Controls.Add(painel);

            // Adiciona a imagem da zona
            PictureBox pbIcone = new PictureBox
            {
                

                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top,
                Height = 150
            };
            painel.Controls.Add(pbIcone);

            // Nome
            Label lblNome = new Label
            {
                Text = $"Nome: {lblNomeCompleto}",
                Font = new Font("Arial", 12),
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };
            painel.Controls.Add(lblNome);

            // Idade
            Label lblIdade = new Label
            {
                Text = $"Idade: {lblIdadeCliente}",
                Font = new Font("Arial", 12),
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };
            painel.Controls.Add(lblIdade);

            // CPF
            Label lblCPF = new Label
            {
                Text = $"CPF: {(lblCpfMostrado)}",
                Font = new Font("Arial", 12),
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };
            painel.Controls.Add(lblCPF);
        }

        // Define a cor da zona
        private Color GetCorZona(string zona)
        {
            switch (zona)
            {
                case "Azul": return Color.LightBlue; // Crianças
                case "Verde": return Color.LightGreen; // Idosos
                case "Amarela": return Color.Yellow; // Jovens
                case "Roxa": return Color.MediumPurple; // Adultos
                default: return Color.White;
            }
        }

      string cpf = "12345678901";


//Copie esse código jogue no chatgpt adicionando no final: Sou iniciante em programação, me explique o código para que eu possa entender ele.
private string OfuscarCPF(string cpf)
{
    // Garante que o CPF tem 11 caracteres
    if (cpf.Length != 11)
        return "CPF inválido";

    // Pega os números do meio
    string parte1 = cpf.Substring(3, 3);
    string parte2 = cpf.Substring(6, 3);

    // Retorna o CPF ofuscado
    return $"***.{parte1}.{parte2}.***";
}

       
        }

        
        
    

    
    
}
