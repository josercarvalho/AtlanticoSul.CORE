using AtlanticoSul.Domain.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace AtlanticoSul.Domain.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.ClienteUnidade = new List<ClienteCondominio>();
            this.Veiculos = new List<Veiculos>();
            this.Funcionarios = new List<Funcionarios>();
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public IFormFile Foto { get; set; }
        public string Url { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Contato { get; set; }
        public string FoneContato { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public string FoneResidencial { get; set; }
        public string FoneComercial { get; set; }
        public string Celular { get; set; }
        public string WhatsApp { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual int PerfilUsuarioId { get; set; }

        public Pais Pais { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }

        public int CondominioId { get; set; }
        public Condominio Condominio { get; set; }

        public ICollection<ClienteCondominio> ClienteUnidade { get; set; }
        public ICollection<Veiculos> Veiculos { get; set; }
        public ICollection<Funcionarios> Funcionarios { get; set; }

    }
}
