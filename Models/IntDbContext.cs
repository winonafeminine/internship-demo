using Microsoft.EntityFrameworkCore;
using internship_api.Models.product;
using Pomelo.EntityFrameworkCore.MySql;

namespace internship_api.Models
{
    public partial class IntDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        // private const string conStr = "server=mariadb,3306;user id=root; password=P@ssw0rd;database=internDb";
        public IntDbContext(DbContextOptions<IntDbContext> options) : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseMySql(conStr);
        // }

        public virtual DbSet<Product> IntProducts { get; set; }
    }   
}