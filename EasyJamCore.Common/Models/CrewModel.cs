namespace EasyJamCore.Common.Model
{
    using System.Collections.Generic;

    public class CrewModel
    {
        public int ID { get; set; }

        public string CrewName { get; set; }

        public virtual ICollection<CityModel> Cities { get; set; }

        public virtual ICollection<CountryModel> Countries { get; set; }
    }
}
