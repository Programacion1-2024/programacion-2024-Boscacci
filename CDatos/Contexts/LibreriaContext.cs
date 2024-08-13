using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Contexts
{
    public partial class LibreriaContext : DbContext
    {
        public LibreriaContext()
        {
        }

        public LibreriaContext(DbContextOptions<LibreriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<AutorLibro> AutorLibro { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CopiaLibro> CopiaLibro { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<FormaDePago> FormaPago { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<GeneroLibro> GeneroLibro { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibreriaProg2024;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK_ID_AUTOR");
            });
            modelBuilder.Entity<AutorLibro>(entity =>
            {
                entity.HasKey(e => e.IdAutorLibro)
                    .HasName("PK_ID_AUTORLIBRO");
            });
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_ID_Cliente");
            });
            modelBuilder.Entity<CopiaLibro>(entity =>
            {
                entity.HasKey(e => e.IdCopiaLibro)
                    .HasName("PK_ID_CopiaLibro");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
