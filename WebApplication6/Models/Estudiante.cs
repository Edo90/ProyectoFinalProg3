using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Estudiante
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Calificación")]
        public char Grado { get; set; }
        [Display(Name = "Asignatura")]
        public int CursoID { get; set; }
        [ForeignKey("CursoID")]
        public Curso Curso { get; set; }
        private int test;
    }
}
