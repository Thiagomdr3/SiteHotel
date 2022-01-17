using SiteHotel.Models.Hotel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Models.Usuario.Entities
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Foto { get; set; }
        public string Sexo { get; set; }
        [Display(Name ="Data de nascimento")]
        public DateTime Nascimento { get; set; }
        [Display(Name ="CPF")]
        public string Cpf { get; set; }
        [Display(Name ="Estado civil")]
        public string EstadoCivil { get; set; }

        public virtual Endereco Enderecos { get; set; }
        public virtual Login Login { get; set; }
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
