// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Persistence;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("9b025d3e-4862-4e84-8289-6140a1cae7ae"),
                            Descripcion = "Actividades con una prioridad mas alta",
                            Nombre = "Actividades Pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("9b025d3e-4862-4e84-8289-6140a1cae7a2"),
                            Descripcion = "Actividades con una prioridad mas baja",
                            Nombre = "Actividades Personales",
                            Peso = 50
                        });
                });

            modelBuilder.Entity("WebApi.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("9b025d3e-4862-4e84-8289-6140a1cae710"),
                            CategoriaId = new Guid("9b025d3e-4862-4e84-8289-6140a1cae7ae"),
                            Descripcion = "Pagar los servicios publicos antes de Noviembre",
                            FechaCreacion = new DateTime(2022, 8, 31, 13, 40, 27, 34, DateTimeKind.Utc).AddTicks(9401),
                            PrioridadTarea = 1,
                            Titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            TareaId = new Guid("9b025d3e-4862-4e84-8289-6140a1cae711"),
                            CategoriaId = new Guid("9b025d3e-4862-4e84-8289-6140a1cae7a2"),
                            Descripcion = "Otra tarea",
                            FechaCreacion = new DateTime(2022, 8, 31, 13, 40, 27, 34, DateTimeKind.Utc).AddTicks(9409),
                            PrioridadTarea = 0,
                            Titulo = "Otra tarea"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Tarea", b =>
                {
                    b.HasOne("WebApi.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("WebApi.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
