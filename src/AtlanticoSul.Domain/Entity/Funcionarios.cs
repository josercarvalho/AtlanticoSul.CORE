using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoSul.Domain.Entity
{
    public class Funcionarios : Identificador
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public string Celular { get; set; }

        public string UserId { get; set; }
        public ApplicationUser Cliente { get; set; }
    }
}
