using Microsoft.EntityFrameworkCore;
using internship_api.Models.product;
using internship_api.Models.user;

namespace internship_api.Models
{
    public partial class IntDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        // private const string conStr = "server=mariadb,3306;user id=root; password=P@ssw0rd;database=internDb";
        public IntDbContext(DbContextOptions<IntDbContext> options) : base(options)
        {
        }


        public virtual DbSet<Product>? IntProducts { get; set; }
        public virtual DbSet<User>? IntUsers { get; set; }
    }   
}