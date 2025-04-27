using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("Tarjeta")]
    public class Tarjeta
    {
        [Key]
        [Column("IdTarjeta")]
        public int IdTarjeta { get; set; }

        [Column("IdPartido")]
        public int IdPartido { get; set; }

        [Column("IdEquipo")]
        public int IdEquipo { get; set; }

        [Column("IdJugador")]
        public int? IdJugador { get; set; }

        [Column("TipoTarjeta")]
        public string TipoTarjeta { get; set; }
    }

}
