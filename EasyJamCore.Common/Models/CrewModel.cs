namespace EasyJamCore.Common.Model
{
    using System.Collections.Generic;

    public class CrewModel
    {
        public int ID { get; set; }

        public string CrewName { get; set; }

        public virtual ICollection<CityModel> CityEntity { get; set; }

        public virtual ICollection<CountryModel> CountryEntity { get; set; }
    }
}
