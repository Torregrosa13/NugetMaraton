using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetMaraton
{
    [Table("Grupo")]
    public class Grupo
    {
        [Key]
        [Column("IdGrupo")]
        public int IdGrupo { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }
    }

}
