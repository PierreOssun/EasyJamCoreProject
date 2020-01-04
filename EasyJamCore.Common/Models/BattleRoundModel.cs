namespace EasyJamCore.Common.Model
{
    using System;
    using System.Collections.Generic;

    public class BattleRoundModel
    {
        public int ID { get; set; }

        public int Order { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        public BattleParticipantModel Winner { get; set; }

        public BattleParticipantModel Loser { get; set; }

        public virtual IEnumerable<BattleParticipantModel> Participants { get; set; }
    }
}
