using Microsoft.EntityFrameworkCore;
using ProyectooFinal.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectooFinal.CONTEXT
{
    public class AppDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //aqui va la cadena de conexion
            options.UseMySQL("server=localhost; database=proyectoDb23Am; user=root; password=");

            //string connectionString = "server=localhost; database=Empleado45; user=root; password=";

            //si hay error con la migracion probar con la siguiente cadena
        }

        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Rol> Roles { get; set; }


    }
}
