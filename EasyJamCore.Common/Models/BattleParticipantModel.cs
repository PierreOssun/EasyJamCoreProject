namespace EasyJamCore.Common.Model
{
    using System;
    using System.Collections.Generic;

    public class BattleParticipantModel
    {
        public int ID { get; set; }

        public string BattleBlaze { get; set; }

        public DateTime SubscritpionDate { get; set; }

        public int? Rank { get; set; }

        public virtual IEnumerable<DancerModel> Dancer { get; set; }

        public virtual IEnumerable<CrewModel> Crew { get; set; }
    }
}
