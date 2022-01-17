using SiteHotel.Models.Usuario.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Models.Hotel.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        [Display(Name ="Check in")]
        public DateTime DataInicial { get; set; }
        [Display(Name ="Check out")]
        public DateTime DataFinal { get; set; }
        [Display(Name = "Duração Estadia")]
        public int DiasDuracao { get; set; }
        public decimal Valor { get; set; }
        public int ApartmentoId { get; set; }
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Apartamento Apartamento { get; set; }

    }
}
