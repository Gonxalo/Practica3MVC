using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace practica3MVC.Models
{
    public class Contexto:DbContext
    {
        public Contexto():base("CadenaConexion"){}

        public DbSet<Estado> Estado { set; get; }

        public DbSet<Municipio> Municipio { set; get; }


    }
}