using AtlanticoSul.Domain.Notificacoes;
using System;

namespace AtlanticoSul.Domain.Entity
{
    public class Identificador : Notifica
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
