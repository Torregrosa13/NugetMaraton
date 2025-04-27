using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("Jugador")]
    public class Jugador
    {
        [Key]
        [Column("IdJugador")]
        public int IdJugador { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Apellidos")]
        public string Apellidos { get; set; }

        [Column("Dorsal")]
        public int Dorsal { get; set; }

        [Column("Goles")]
        public int Goles { get; set; }

        [Column("IdEquipo")]
        public int IdEquipo { get; set; }
    }
}
