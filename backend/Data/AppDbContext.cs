using backend.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Employee> Employee { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options) { }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = ""; 
            var version = new MySqlServerVersion(new Version(11, 1, 2));

            services.AddDbContextPool<AppDbContext>(options => options
                .UseMySql(
                    connectionString,
                    version
                )
            );

            services.AddControllers();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    
        //    

        //    optionsBuilder.UseMySql(connectionString, version);

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
