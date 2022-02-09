using Microsoft.EntityFrameworkCore;
using internship_api.Models.product;
using internship_api.Models.locations.thLocation;
using internship_api.Models.user;



namespace internship_api.Models
{
    public partial class IntDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        // private const string conStr = "server=mariadb,3306;user id=root; password=P@ssw0rd;database=internDb";
        public IntDbContext(DbContextOptions<IntDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<ThLocation>(entity =>
            {
                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.District).HasMaxLength(20);

                entity.Property(e => e.Latitude).HasMaxLength(8);

                entity.Property(e => e.Longitude).HasMaxLength(9);

                entity.Property(e => e.Province).HasMaxLength(15);

                entity.Property(e => e.Subdistrict).HasMaxLength(23);

                entity.Property(e => e.ZipCode).HasMaxLength(7);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


        public virtual DbSet<Product> IntProducts { get; set; } = null!;
        public virtual DbSet<User> IntUsers { get; set; } = null!;
        public virtual DbSet<ThLocation> IntThLocations { get; set; } = null!;
        
    }   
}