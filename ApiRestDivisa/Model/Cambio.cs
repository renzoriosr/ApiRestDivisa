using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestDivisa.Model
{
    public class Cambio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }
        public decimal Tasa { get; set; }
        [NotMapped]
        public decimal Monto { get; set; }
        [NotMapped]
        public decimal Total { get; set; }
    }
}
