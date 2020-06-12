using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyProjectCore.EntityFrameworkCore
{
    public static class MyProjectCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
