using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cine_Web.Models
{
    public class Administrador
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido_paterno { get; set; }
        [Required]
        public string apellido_materno { get; set; }
        [Required]
        public string edad { get; set; }
        [Required]
        public string fecha_de_nacimiento { get; set; }
        [Required]
        public string correo_electronico { get; set; }
        [Required]
        public string contraseña { get; set; }
        

    }
  
    }
