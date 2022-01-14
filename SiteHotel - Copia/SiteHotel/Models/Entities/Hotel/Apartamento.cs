using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Models.Hotel.Entities
{
    public class Apartamento
    {
        public int Id { get; set; }
        [Display(Name ="Dormitorios")]
        public int QuantidadeDormitorios { get; set; }
        public decimal ValorDiaria { get; set; }

        public virtual ICollection<Reserva> Reserva { get; set; }
        public virtual ICollection<Imagens> Imagens { get; set; }
    }
}
