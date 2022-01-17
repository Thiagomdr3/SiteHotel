using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteHotel.Models.Hotel.Entities
{
    public class Imagens
    {
        public int Id { get; set; }
        public byte[] Imagem { get; set; }
        [Display(Name ="Titulo")]
        public string NomeImagens { get; set; }
        public int ApartamentoId { get; set; }
        public virtual Apartamento Apartamento { get; set; }
    }
}
