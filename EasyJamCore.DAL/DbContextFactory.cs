namespace EasyJamCore.DAL
{
    using EasyJamCore.DAL.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class DbContextFactory : IDesignTimeDbContextFactory<EasyJamCoreDbContext>
    {
        public EasyJamCoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EasyJamCoreDbContext>();
            return new EasyJamCoreDbContext(optionsBuilder.Options);
        }
    }
}
