using Dapper;
using MultApps.Models.Entities.Abstract;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repositories
{
    public class UsuarioRepository
    {
        private readonly string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public bool CadastrarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario (NomeCompleto, CPF, Email, Senha, DataCadastro, Status)
                                   VALUES (@NomeCompleto, @CPF, @Email, @Senha, @DataCadastro, @Status)";
                var parametros = new
                {
                    
                    CPF = usuario.CPF,
                    Email = usuario.Email,
                    Senha = usuario.Senha,
                    DataCadastro = usuario.DataCadastro,
                    Status = usuario.StatusAtivo
                };

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario
                                   SET NomeCompleto = @NomeCompleto, Email = @Email, Status = @Status
                                   WHERE Id = @Id";
                var parametros = new
                {
                    usuario.Id,
                    NomeCompleto = usuario.Nome,
                    usuario.Email,
                    Status = usuario.StatusAtivo
                };

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        public bool DeletarUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = "DELETE FROM usuario WHERE Id = @Id";
                return db.Execute(comandoSql, new { Id = id }) > 0;
            }
        }

        public List<Usuario> ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT Id, NomeCompleto AS Nome, CPF, Email, DataCadastro, Status AS StatusAtivo
                                   FROM usuario";
                return db.Query<Usuario>(comandoSql).ToList();
            }
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT Id, NomeCompleto AS Nome, CPF, Email, DataCadastro, Status AS StatusAtivo
                                   FROM usuario WHERE Id = @Id";
                return db.QueryFirstOrDefault<Usuario>(comandoSql, new { Id = id });
            }
        }
    }
}


