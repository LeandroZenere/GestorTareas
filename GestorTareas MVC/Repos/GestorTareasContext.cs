using GestorTareas_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace GestorTareas_MVC.Repos
{
    public partial class GestorTareasContext : DbContext
    {
        public GestorTareasContext()
        {
        }

        public GestorTareasContext(DbContextOptions<GestorTareasContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Tarea> Tareas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        //public virtual DbSet<Estado> Estado { get; set; }
        //public virtual DbSet<Reserva> Reserva { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer("name=conexion");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
