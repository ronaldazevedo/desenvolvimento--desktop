using MultApps.Models.Entidades;
using MultApps.Models.Entities.Abstract;

namespace MultApps.Models.Entities
{
    internal class Produto : EntidadeBase
    {
        
        
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Estoque { get; set; }
            public string Status { get; set; } 
        

    }
}
