using MultApps.Models.Entities.Abstract;

namespace MultApps.Models.Entities
{
    public class Categoria : EntidadeBase
    {
        public int  Id { get; set; }

        public string Nome { get; set; }
    }
}
