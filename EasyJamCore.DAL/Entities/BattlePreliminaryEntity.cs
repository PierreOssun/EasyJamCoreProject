namespace EasyJamCore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BattlePreliminary")]
    public class BattlePreliminaryEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        public virtual IEnumerable<BattleRoundEntity> BattleRound { get; set; }

        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }
    }
}
