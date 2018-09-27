using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cine_Web.Models
{
    public class CineBD : DbContext
    {
        public DbSet <Administrador> administrador{ get; set; }
    }
}