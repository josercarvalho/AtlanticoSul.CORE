using AtlanticoSul.Domain.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace AtlanticoSul.Domain.Entity
{
    public class Condominio : Identificador
    {
        public Condominio()
        {
            this.Clientes = new List<ApplicationUser>();
        }

        // Sobre o condomínio

        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public Destinacao Destinacao { get; set; }
        public TipoCondominio TipoCondominio { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public IFormFile Foto { get; set; }

        // Sobre o síndico

        public string Sindico { get; set; }
        public DateTime InicioMandato { get; set; }
        public DateTime TerminoMandato { get; set; }
        public Sexo Sexo { get; set; }
        public Instrucao Instrucao { get; set; }
        public string FoneSindico { get; set; }
        public int IdadeSindico { get; set; }
        public string EmailSindico { get; set; }
        public bool SindicoAntes { get; set; }
        public string SubSindico { get; set; }
        public string FoneSubSindico { get; set; }
        public string EmailSubSindico { get; set; }

        // Sobre a Estrutura
        public bool Portaria { get; set; }
        public bool Elevador { get; set; }
        public bool CercaEletrica { get; set; }
        public bool CircuitoFechado { get; set; }
        public int Blocos { get; set; }
        public int Andares { get; set; }
        public int QtdApto { get; set; }
        public int QtdCoverturas { get; set; }
        public int MyProperty { get; set; }

        // Sobre os Funcionários
        public int Funcionarios { get; set; }
        public int NaPortaria { get; set; }
        public int NaLimpeza { get; set; }
        public int NaJardinagem { get; set; }

        // Clientes Ocupantes.
        public virtual ICollection<ApplicationUser> Clientes { get; set; }
        
    }
}
