﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
   public  class Usuario:BaseDTO
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
