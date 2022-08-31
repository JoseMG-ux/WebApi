using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Persistence
{
    public class TareasContext : DbContext
    {

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Categoria> categoriasInit = new List<Categoria>();
            categoriasInit.Add(new Categoria()
            {
                CategoriaId = Guid.Parse("9b025d3e-4862-4e84-8289-6140a1cae7ae"),
                Nombre = "Actividades Pendientes",
                Descripcion = "Actividades con una prioridad mas alta",
                Peso = 20
            });
            categoriasInit.Add(new Categoria()
            {
                CategoriaId = Guid.Parse("9b025d3e-4862-4e84-8289-6140a1cae7a2"),
                Nombre = "Actividades Personales",
                Descripcion = "Actividades con una prioridad mas baja",
                Peso = 50
            });
            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(e => e.CategoriaId);
                categoria.Property(e => e.Nombre).IsRequired(true).HasMaxLength(150);
                categoria.Property(e => e.Descripcion).IsRequired(false).HasMaxLength(200);
                categoria.Property(e => e.Peso);
                categoria.HasData(categoriasInit);
            });

            List<Tarea> tareasInit = new List<Tarea>();
            tareasInit.Add(new Tarea()
            {
                TareaId = Guid.Parse("9b025d3e-4862-4e84-8289-6140a1cae710"),
                CategoriaId = Guid.Parse("9b025d3e-4862-4e84-8289-6140a1cae7ae"),
                PrioridadTarea = Prioridad.Media,
                Titulo = "Pago de servicios publicos",
                Descripcion = "Pagar los servicios publicos antes de Noviembre",
                FechaCreacion = DateTime.UtcNow
            });
            tareasInit.Add(new Tarea()
            {
                TareaId = Guid.Parse("9b025d3e-4862-4e84-8289-6140a1cae711"),
                CategoriaId = Guid.Parse("9b025d3e-4862-4e84-8289-6140a1cae7a2"),
                PrioridadTarea = Prioridad.Baja,
                Titulo = "Otra tarea",
                Descripcion = "Otra tarea",
                FechaCreacion = DateTime.UtcNow
            });
            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tarea");
                tarea.HasKey(p => p.TareaId);

                tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);
                tarea.Property(p => p.Titulo).IsRequired(true).HasMaxLength(200);
                tarea.Property(p => p.Descripcion).IsRequired(false).HasMaxLength(200);
                tarea.Property(p => p.PrioridadTarea);
                tarea.Property(p => p.FechaCreacion);
                tarea.Ignore(p => p.Resumen);
                tarea.HasData(tareasInit);
            });
        }
    }
}
