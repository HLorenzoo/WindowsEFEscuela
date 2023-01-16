using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Clases
{
    [Table("Aula")]


    public class Aula
    {
        

        public int Id { get; set; }
        [Required]

        public int Capacidad { get; set; }


        [Required]
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Codigo { get; set; }


    }
}
