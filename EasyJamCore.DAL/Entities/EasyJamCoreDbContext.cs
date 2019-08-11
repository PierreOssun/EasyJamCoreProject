using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace EasyJamCore.DAL.Entities
{
    public class EasyJamCoreDbContext : DbContext
    {
        public EasyJamCoreDbContext(DbContextOptions<EasyJamCoreDbContext> options) : base(options)
        {
        }
        public DbSet<BattleEntity> BattleEntity { get; set; }
        public DbSet<BattleParticipantEntity> BattleParticipantEntity { get; set; }
        public DbSet<BattlePreliminaryEntity> BattlePreliminaryEntity { get; set; }
        public DbSet<BattleRoundEntity> BattleRoundEntity { get; set; }
        public DbSet<CityEntity> CityEntity { get; set; }
        public DbSet<CountryEntity> CountryEntity { get; set; }
        public DbSet<CrewEntity> CrewEntity { get; set; }
        public DbSet<DancerEntity> DancerEntitiy { get; set; }
        public DbSet<DjEntity> DjEntity { get; set; }
        public DbSet<HostEntity> HostEntity { get; set; }
        public DbSet<JamEntity> JamEntity { get; set; }
        public DbSet<JudgeEntity> JudgeEntity { get; set; }
        public DbSet<SpeakerEntity> SpeakerEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}