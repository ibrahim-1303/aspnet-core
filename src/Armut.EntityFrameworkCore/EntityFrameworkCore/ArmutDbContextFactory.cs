using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Armut.Configuration;
using Armut.Web;

namespace Armut.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ArmutDbContextFactory : IDesignTimeDbContextFactory<ArmutDbContext>
    {
        public ArmutDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ArmutDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ArmutDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ArmutConsts.ConnectionStringName));

            return new ArmutDbContext(builder.Options);
        }
    }
}
