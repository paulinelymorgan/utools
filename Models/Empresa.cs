using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace utools.Models
{
    public class Empresa
    {
        // [Key]
        [Required]
        [Display(Name = "C.N.P.J.")]
        [MinLength(14, ErrorMessage = "O CNPJ está errado")]   
        // [Required(ErrorMessage = "O CNPJ é obrigatório")]
        // [MaxLength(15, ErrorMessage = "CNPJ muito grande")]        
        public string cnpj { get; set; }
        public string tipo { get; set; }
        public string abertura { get; set; }
        public string nome { get; set; }
        public string fantasia { get; set; }
        public string porte { get; set; }
        public List<Cnae> atividade_principal { get; set; }
        public List<Cnae> atividades_secundarias { get; set; }
        public string natureza_juridica { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        // [EmailAddress]
        public string email { get; set; }
        public string telefone { get; set; }
        public string efr { get; set; }
        public string situacao { get; set; }
        public string data_situacao { get; set; }
     
        [JsonIgnore]
        public DateTime DataCriacao { get; set; }
        
        public Empresa()
        {
            DataCriacao = DateTime.Now;
        }
    }
}