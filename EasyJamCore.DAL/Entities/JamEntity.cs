namespace EasyJamCore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class JamEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public string JamName { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        [Required]
        public string Location { get; set; }

        public CityEntity City { get; set; }

        public CountryEntity Country { get; set; }

        public virtual ICollection<HostEntity> Host { get; set; }

        public virtual ICollection<BattleEntity> Battle { get; set; }
    }
}