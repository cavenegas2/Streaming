//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUStreaming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pelicula
    {
        public int id_pelicula { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El nombre de la pelicula es requerido"), MaxLength(50)]
        [Display(Name = "Nombre")]
        public string nombre_pelicula { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Lanzamiento")]
        public Nullable<System.DateTime> fech_lanz_pelicula { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Los nombres son requeridos"), MaxLength(25)]
        [Display(Name = "Categoria")]
        public string categoria_pelicula { get; set; }
        
        [Display(Name = "Duración de la Pelicula")]
        public Nullable<double> duracion_pelicula { get; set; }
    }
}
