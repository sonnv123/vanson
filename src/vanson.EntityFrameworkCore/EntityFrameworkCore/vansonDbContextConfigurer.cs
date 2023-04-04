using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace vanson.EntityFrameworkCore
{
    public static class vansonDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<vansonDbContext> builder, string connectionString)
        {
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            builder.UseMySql(connectionString, serverVersion);
        }

        public static void Configure(DbContextOptionsBuilder<vansonDbContext> builder, DbConnection connection)
        {
            var serverVersion = ServerVersion.AutoDetect(connection.ConnectionString);
        builder.UseMySql(connection, serverVersion);
        }
    }
}
