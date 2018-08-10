using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Curso
    {
        public int ID { get; set; }
        [Display(Name ="Nombre del Curso")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Descripcion { get; set; }
        public int Capacidad { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Responsable { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime InicioDeCurso { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Fecha Fin")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FinDeCurso { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
