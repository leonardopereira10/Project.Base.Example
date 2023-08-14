using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Project.Base.Example.Repository
{
    public class DbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            string stringDeConexao = "Server='DESKTOP-ISJ1TBU:1433'; Database='Example'; User Id='sa'; Password='admin';";

            DbContextOptionsBuilder<MyDbContext> builder = new();
            _ = builder.UseSqlServer(stringDeConexao, opcoes =>
                opcoes.MigrationsAssembly("Project.Base.Example.Repository"));

            return (MyDbContext)Activator.CreateInstance(typeof(MyDbContext), new object[] { builder.Options });
        }
    }
}
