using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities.Abstract
{
    public class Produtos: EntidadeBase
    {
        public string Nome { get; set; } 

        public string Descricao { get; set; } 

        public decimal Preco { get; set; } 

        public string UrlImagem { get; set; } 
       
        public int Estoque { get; set; } 

        public string Categoria { get; set; } 

        public bool Ativo { get; set; } 
    }
}
