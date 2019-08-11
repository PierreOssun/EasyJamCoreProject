using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJamCore.DAL.Entities
{
    public class BattleRoundEntity : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int Order { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime StartTime { get; set; }
        public BattleParticipantEntity Winner { get; set; }
        public BattleParticipantEntity Loser { get; set; }
        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }
    }
}
