using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoSul.Domain.Entity
{
    public class Boletos : Identificador
    {
        public Boletos()
        {

        }

        public int ClienteId { get; set; }
        public int CondominioId { get; set; }
        public Guid Token { get; set; }

        public decimal Valor { get; set; }
        public decimal Percentual { get; set; }
        public decimal ValorSeguro { get; set; } // Valor da minha comissão

        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Pagamento { get; set; }
        public string Status { get; set; } // A - Aberto, E - Emitido, V - Vencido, P - Pago, 

    }
}
