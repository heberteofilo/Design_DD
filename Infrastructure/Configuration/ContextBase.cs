using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            //verificar se as databases dbset existem no banco, caso não cria automaticamente.
            //Database.EnsureCreated();
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig(), b => b.MigrationsAssembly("Web_DDD_2020"));
            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=HEBER\\SQLEXPRESS;Initial Catalog=Design_DD_2020;Integrated Security=False;User ID=sa;Password=123qwe;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }

    }
}
