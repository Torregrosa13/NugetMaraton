using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("Equipo")]
    public class Equipo
    {
        [Key]
        [Column("IdEquipo")]
        public int IdEquipo { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Escudo")]
        public string? Escudo { get; set; }
    }
}
