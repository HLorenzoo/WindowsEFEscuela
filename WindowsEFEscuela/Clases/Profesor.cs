using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Clases
{
    [Table("Docente")]


    public class Profesor
    {
        [Column("Id")]
        public int ProfesorId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }


        // CASO 2
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]


        public string Titulo { get; set; }




    }
}
