using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("Partido")]
    public class Partido
    {
        [Key]
        [Column("IdPartido")]
        public int IdPartido { get; set; }

        [Column("FechaHora")]
        public DateTime FechaHora { get; set; }

        [Column("IdEquipoLocal")]
        public int IdEquipoLocal { get; set; }

        [Column("IdEquipoVisitante")]
        public int IdEquipoVisitante { get; set; }

        [Column("GolesLocal")]
        public int? GolesLocal { get; set; }

        [Column("GolesVisitante")]
        public int? GolesVisitante { get; set; }

        [Column("Fase")]
        public string Fase { get; set; }

        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }

    }
}
