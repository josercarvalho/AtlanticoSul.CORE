using System.Collections.Generic;

namespace AtlanticoSul.Domain.Entity
{
    public class Pais
    {
        public Pais()
        {
            Estados = new List<Estado>();
        }

        public int PaisId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }

    }
}
