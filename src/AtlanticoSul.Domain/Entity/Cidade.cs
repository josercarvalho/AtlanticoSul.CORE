namespace AtlanticoSul.Domain.Entity
{
    public class Cidade
    {
        public Cidade()
        {

        }

        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
