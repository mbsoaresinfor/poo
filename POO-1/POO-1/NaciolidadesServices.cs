﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class NaciolidadesServices
    {
        public Boolean isBrasileiro(Pessoa pessoa)
        {
            return pessoa.Equals("brasil");
        }
    }
}
