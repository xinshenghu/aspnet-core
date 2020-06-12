using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyProjectCore.Configuration;
using MyProjectCore.Web;

namespace MyProjectCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyProjectCoreDbContextFactory : IDesignTimeDbContextFactory<MyProjectCoreDbContext>
    {
        public MyProjectCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyProjectCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyProjectCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyProjectCoreConsts.ConnectionStringName));

            return new MyProjectCoreDbContext(builder.Options);
        }
    }
}
