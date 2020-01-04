namespace EasyJamCore.Common.Model
{
    using System;
    using System.Collections.Generic;

    public class BattlePreliminaryModel
    {
        public int ID { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        public virtual IEnumerable<BattleRoundModel> BattleRound { get; set; }

        public virtual IEnumerable<BattleParticipantModel> Participants { get; set; }
    }
}
