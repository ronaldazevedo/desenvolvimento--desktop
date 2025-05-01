using MultApps.Models.Entidades;
using MultApps.Models.Entities.Abstract;

namespace MultApps.Models.Entities
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string UrlImagem { get; set; }
    }
}
