using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace practica3MVC.Models
{
    public class Estado
    {
         [Key]
        public int Id { get; set; }

        [Required] //not null
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Municipio> Municipio { get; set; }//a un estado le pertenece a un muchos municipios
    }

    public class Municipio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int CantidadHabitante { get; set; }

        public virtual Estado Estado { get; set; } //a un municipio le pertenece un estado
    }


}