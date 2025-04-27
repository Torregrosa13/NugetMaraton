using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("EquipoGrupo")]
    public class EquipoGrupo
    {
        [Key]
        [Column("IdEquipoGrupo")]
        public int IdEquipoGrupo { get; set; }

        [Column("IdGrupo")]
        public int IdGrupo { get; set; }

        [Column("IdEquipo")]
        public int IdEquipo { get; set; }
    }

}
