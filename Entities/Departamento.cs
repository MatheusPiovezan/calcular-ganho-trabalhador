﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular.Entities
{
    internal class Departamento
    {
        public string Nome { get; set; }

        public Departamento() { }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }

}