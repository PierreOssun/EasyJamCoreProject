using System;
using System.Collections.Generic;

namespace EasyJamCore.Common.Model
{
    public class BattlePreliminaryModel
    {
        public int ID { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime StartTime { get; set; }
        public virtual IEnumerable<BattleRoundModel> BattleRound { get; set; }
        public virtual IEnumerable<BattleParticipantModel> Participants { get; set; }
    }
}
