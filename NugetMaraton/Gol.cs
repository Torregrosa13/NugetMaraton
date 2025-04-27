using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("Gol")]
    public class Gol
    {
        [Key]
        [Column("IdGol")]
        public int IdGol { get; set; }

        [Column("IdPartido")]
        public int IdPartido { get; set; }

        [Column("IdJugador")]
        public int IdJugador { get; set; }

        [Column("Minuto")]
        public int? Minuto { get; set; }
    }
}
