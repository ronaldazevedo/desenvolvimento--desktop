﻿using MultApps.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models
{
    internal class Usuarios : EntidadeBase
    {
     
        public string Nome { get; set; } 

       
        public string Email { get; set; } 

        
        public string Senha { get; set; }

    }
}

