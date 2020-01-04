namespace EasyJamCore.DAL.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CrewEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public string CrewName { get; set; }

        public virtual ICollection<CityEntity> CityEntity { get; set; }

        public virtual ICollection<CountryEntity> CountryEntity { get; set; }
    }
}
