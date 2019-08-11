using System;
using System.Collections.Generic;

namespace EasyJamCore.Common.Model
{
    public class BattleModel
    {
        public int ID { get; set; }

        public string BattleName { get; set; }

        public Type Type { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        public string Location { get; set; }

        public BattlePreliminaryModel BattlePreliminary { get; set; }

        public virtual IEnumerable<BattleParticipantModel> BattleEntry { get; set; }

        public virtual IEnumerable<JudgeModel> Judge { get; set; }

        public virtual IEnumerable<DjModel> Dj { get; set; }

        public virtual IEnumerable<SpeakerModel> Speaker { get; set; }

        public virtual IEnumerable<BattleRoundModel> BattleRound { get; set; }
    }

    public enum Type
    {
        Break, AllStyle, HipHop
    }
}
