using System.Collections.Generic;

namespace EasyJamCore.Common.Model
{
    public class CrewModel
    {
        public int ID { get; set; }
        public string CrewName { get; set; }
        public virtual ICollection<CityModel> CityEntity { get; set; }
        public virtual ICollection<CountryModel> CountryEntity { get; set; }
    }
}
