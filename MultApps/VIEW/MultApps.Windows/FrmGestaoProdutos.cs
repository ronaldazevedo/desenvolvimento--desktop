using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmGestaoProdutos : Form
    {
        private readonly object produto;

        public FrmGestaoProdutos()
        {
            InitializeComponent();
            

        }

        private void FrmGestaoProdutos_Load(object sender, EventArgs e )
        {
            var categoriaRepository = new CategoriaRepository();
            var listaDeCategorias = categoriaRepository.ListarTodasCategorias();

            cbmCategoria.DataSource = produto;
            cbmCategoria.DisplayMember = "Nome";
            cbmCategoria.ValueMember = "ID";


            cbmCategoria.DataSource = new CategoriaRepository();
            cbmCategoria.DisplayMember += cbmCategoria;
        }

        private void CarregarProdutos()
        {
            // Simulando carregamento de dados (substituir por banco de dados)
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("Preço");
            dt.Columns.Add("Estoque");
            dt.Columns.Add("Status");
            dt.Columns.Add("UrlImagem");

            dataGridView1.DataSource = dt;
        }

        private void CarregarCategorias()
        {
            cbmCategoria.Items.Clear();
            cbmCategoria.SelectedIndex = 0; // Define um item padrão
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente inativar este produto?", "Confirmação");
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Produto inativado!");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            cbmCategoria.SelectedIndex = -1;
            cbmStatusFiltro.SelectedIndex = -1;
            cmbCategorias.SelectedIndex = -1;
            txtUrlImagem.Clear();
        }

        

        private void InativarProduto(int id)
        {
            string query = "UPDATE Produtos SET Status='Inativo' WHERE ID=@ID";

            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Produto inativado!");
            CarregarProdutos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) || string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque) || estoque < 0)
            {
                MessageBox.Show("Estoque inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var categoria = new Categoria();
            categoria.Nome = txtNomeProduto.Text;
            categoria.Status = (StatusEnum)cbmStatusFiltro.SelectedIndex;

            var categoriaRepository = new CategoriaRepository();

            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("O nome do produto é obrigatório.", "Erro");
                return;
            }

            MessageBox.Show("Produto salvo com sucesso!");

            CarregarProdutos();
        }

        private void cbmStatusFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cbmStatusFiltro.SelectedItem.ToString();
            string categoria = cbmCategoria.SelectedItem.ToString();

            string query = "SELECT * FROM Produtos WHERE 1=1";

            if (status != "Todos")
                query += $" AND Status = '{status}'";
            if (categoria != "Todas")
                query += $" AND Categoria = '{categoria}'";

            using (SqlConnection conn = new SqlConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

    }

}