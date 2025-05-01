
using MultApps.Models;
using MultApps.Models.Entities;
using System;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmGestaoProdutos : Form
    {
        public FrmGestaoProdutos()

        {
            InitializeComponent();
            CarregarCategorias();
            CarregarProdutos();

        }

        private void CarregarCategorias()
        {
            cbmCategoria.Items.Clear();
            cbmCategoria.Items.Add("Todas");
            // Simulando categorias do banco:
            cbmCategoria.Items.Add("Eletrônicos");
            cbmCategoria.Items.Add("Roupas");
            cbmCategoria.SelectedIndex = 0;
        }

        private void CarregarProdutos()
        {
            // Simulação de dados
            dgvProdutos.Rows.Clear();
            dgvProdutos.Columns.Clear();

            dgvProdutos.Columns.Add("ID", "ID");
            dgvProdutos.Columns.Add("Nome", "Nome");
            dgvProdutos.Columns.Add("Categoria", "Categoria");
            dgvProdutos.Columns.Add("Preco", "Preço");
            dgvProdutos.Columns.Add("Estoque", "Estoque");
            dgvProdutos.Columns.Add("Status", "Status");

            // Exemplo de dados
            dgvProdutos.Rows.Add(1, "Notebook", "Eletrônicos", 3000.00, 10, "Ativo");
            dgvProdutos.Rows.Add(2, "Camiseta", "Roupas", 59.90, 20, "Inativo");
        }
        

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            var formProduto = new FrmGestaoProdutos();
            formProduto.ShowDialog();
            CarregarProdutos();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var formProduto = new FrmGestaoProdutos(); 
                formProduto.ShowDialog();
                CarregarProdutos();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e, bool sucesso)
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text)
        || cbmCategoria.SelectedIndex == -1
        || !decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0
        || !int.TryParse(txtEstoque.Text, out int estoque) || estoque < 0)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios corretamente.");
                return;
            }

            var produto = new Produto
            {
                Nome = txtNomeProduto.Text,
                CategoriaId = cbmCategoria.SelectedIndex , // confere se CategoriaId é int
                Preco = preco,
                Estoque = estoque,
                UrlImagem = txtUrlImagem.Text,
                Status = rbAtivo.Checked
            };

            var repo = new ProdutoRepository();

            if (!string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                produto.Id = int.Parse(txtNomeProduto.Text);
                sucesso = repo.AtualizarProduto(produto);
                if (sucesso)
                    MessageBox.Show("Produto atualizado com sucesso!");
            }
            else
            {
                sucesso = repo.AtualizarProduto(produto);
                if (sucesso)
                    MessageBox.Show("Produto cadastrado com sucesso!");
            }

            CarregarProdutos();
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Deseja inativar este produto?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult)
            {
                // Atualiza status para inativo
                MessageBox.Show("Produto inativado.");
                this.Close();
            }
        }
    }
}
