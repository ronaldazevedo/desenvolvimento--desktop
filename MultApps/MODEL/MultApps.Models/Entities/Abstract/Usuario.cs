using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities.Abstract
{
    public class Usuario : EntidadeBase
    {
         
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool StatusAtivo { get; set; }
        public bool StatusInativo { get; set; }
        public bool StatusTodos { get; set; }
    }
}

