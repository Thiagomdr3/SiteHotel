using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Models.Usuario.Entities
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="e-mail")]
        public string Email { get; set; }
        public string Senha { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
