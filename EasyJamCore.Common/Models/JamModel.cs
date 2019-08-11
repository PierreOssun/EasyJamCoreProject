using System;
using System.Collections.Generic;

namespace EasyJamCore.Common.Model
{
    public class JamModel
    {
        public int ID { get; set; }
        public string JamName { get; set; }
        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        public string Location { get; set; }

        public CityModel City { get; set; }

        public CountryModel Country { get; set; }

        public virtual ICollection<HostModel> Host { get; set; }

        public virtual ICollection<BattleModel> Battle { get; set; }
    }
}
