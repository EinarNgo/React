using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace kundeservice
{
    public class DBContextFactory : IDesignTimeDbContextFactory<KundeserviceContext>
    {
        public KundeserviceContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KundeserviceContext>();
            var connectionString = builder.UseSqlServer(
                "Server=tcp:kunderserviceserver.database.windows.net,1433;Initial Catalog=faqdatabase;Persist Security Info=False;User ID=einarn;Password=OPUpdGui9Cr;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new KundeserviceContext(builder.Options);
        }
    }

    public class KundeserviceContext : DbContext
    {

        public KundeserviceContext(DbContextOptions<KundeserviceContext> options) : base(options)
        {
        }

        public DbSet<dbsporsmal> sporsmals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dbsporsmal>().ToTable("dbsporsmal").HasData(new dbsporsmal[]
            {
                new dbsporsmal { ID = 1, Navn = "Einar", Spors = "Test", Svar = "Svar"},
                new dbsporsmal { ID = 2, Navn = "Einar", Spors = "Test", Svar = "Svar" },
            }) ;

        }
    }
}
