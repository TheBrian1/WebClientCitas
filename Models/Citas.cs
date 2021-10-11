using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientCitas.Models
{
    public class Citas
    {
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public int CitaId { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public DateTime Fecha_Cita { get; set; }
        public string Username { get; set; }
    
        public Citas()
        {
            CitaId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Descripcion = string.Empty;
            Direccion = string.Empty;
            Fecha_Cita = DateTime.Now;
            Username = string.Empty;
        }
    
    }

    
}
