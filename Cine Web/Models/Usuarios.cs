using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cine_Web.Models
{
    public class Usuarios { 
    
    public int id { get; set; }
    [Required]
    public string nombre { get; set; }

    
    }
}