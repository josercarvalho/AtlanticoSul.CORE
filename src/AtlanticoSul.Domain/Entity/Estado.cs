using System.Collections.Generic;

namespace AtlanticoSul.Domain.Entity
{
    public class Estado
    {
        public Estado()
        {
            this.Cidades = new List<Cidade>();
        }

        public int EstadoId { get; set; }
        public int PaisId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
