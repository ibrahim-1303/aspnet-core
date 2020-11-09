using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Armut.EntityFrameworkCore
{
    public static class ArmutDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ArmutDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ArmutDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
