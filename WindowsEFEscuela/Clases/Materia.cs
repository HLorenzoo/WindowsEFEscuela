using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Clases
{
    [Table("Materia")]


    public class Materia
    {
        

        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Programa { get; set; }


    }
}
