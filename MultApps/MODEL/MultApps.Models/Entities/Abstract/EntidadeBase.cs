﻿using MultApps.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultApps.Models.Enums;

namespace MultApps.Models.Entities.Abstract
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public StatusEnum Status { get; set; }

    }
}
