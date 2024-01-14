using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoSul.Domain.Entity
{
    public class ClienteDados : Identificador
    {
        public ClienteDados()
        {

        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int  Cidade { get; set; }
        public int Estado { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser Cliente { get; set; }

    }

}
