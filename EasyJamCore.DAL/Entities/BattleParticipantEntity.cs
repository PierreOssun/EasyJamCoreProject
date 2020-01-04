namespace EasyJamCore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BattleParticipantEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string BattleBlaze { get; set; }

        public DateTime SubscritpionDate { get; set; }

        public int? Rank { get; set; }

        public virtual IEnumerable<DancerEntity> Dancer { get; set; }

        public virtual IEnumerable<CrewEntity> Crew { get; set; }
    }
}
