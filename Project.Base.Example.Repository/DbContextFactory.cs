using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Project.Base.Example.Repository
{
    public class DbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            string stringDeConexao = "Data Source='192.168.1.9';Database='Example';User Id='sa';Password='admin';Trusted_Connection=false;MultipleActiveResultSets=true;TrustServerCertificate=true;";

            DbContextOptionsBuilder<MyDbContext> builder = new();
            _ = builder.UseSqlServer(stringDeConexao, opcoes =>
                opcoes.MigrationsAssembly("Project.Base.Example.Repository"));

            return (MyDbContext)Activator.CreateInstance(typeof(MyDbContext), new object[] { builder.Options });
        }
    }
}
