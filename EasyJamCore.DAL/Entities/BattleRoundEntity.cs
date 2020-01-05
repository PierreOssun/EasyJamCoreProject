namespace EasyJamCore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BattleRound")]
    public class BattleRoundEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public int Order { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        public IEnumerable<BattleParticipantEntity> Winner { get; set; }

        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }
    }
}
