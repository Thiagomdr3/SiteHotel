using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Models.Usuario.Entities
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="CEP")]
        public string Cep { get; set; }
        [Display(Name ="Rua/Av.")]
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        [Display(Name ="Cidade")]
        public string Cidade { get; set; }
        [Display(Name ="UF")]
        public string Uf { get; set; }       
        [Display(Name ="Telefone")]
        public string Telefone { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
