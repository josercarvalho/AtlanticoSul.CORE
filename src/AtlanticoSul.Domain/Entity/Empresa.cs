namespace AtlanticoSul.Domain.Entity
{
    public class Empresa : Identificador
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public string Fone { get; set; }
        public string WhatsApp { get; set; }

        public Pais Pais { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
    }
}
