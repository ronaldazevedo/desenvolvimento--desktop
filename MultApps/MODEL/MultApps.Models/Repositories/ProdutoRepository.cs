using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models
{
    internal class ProdutoRepository
    {
        private string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public List<Produto> BuscarTodos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                return db.Query<Produto>("SELECT * FROM produto").ToList();
            }
        }

        public Produto BuscarPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                return db.QueryFirstOrDefault<Produto>("SELECT * FROM produto WHERE id = @Id", new { Id = id });
            }
        }

        public void Adicionar(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto (nome, descricao, categoria, preco, estoque, url_imagem, status)
                                   VALUES (@Nome, @Descricao, @Categoria, @Preco, @Estoque, @UrlImagem, @Status)";

                db.Execute(comandoSql, produto);
            }
        }

        public void Atualizar(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE produto SET nome = @Nome, descricao = @Descricao, categoria = @Categoria, 
                                   preco = @Preco, estoque = @Estoque, url_imagem = @UrlImagem, status = @Status 
                                   WHERE id = @Id";

                db.Execute(comandoSql, produto);
            }
        }

        public void Deletar(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                db.Execute("DELETE FROM produto WHERE id = @Id", new { Id = id });
            }
        }
    }
}
