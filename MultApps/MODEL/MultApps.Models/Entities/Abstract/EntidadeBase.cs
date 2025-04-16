using MultApps.Models.Enums;
using System;

namespace MultApps.Models.Entities.Abstract
{
    public class EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimoAcesso { get; set; }
        
    }
}
