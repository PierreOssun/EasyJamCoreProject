namespace EasyJamCore.DAL.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Crew")]
    public class CrewEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public string CrewName { get; set; }

        public virtual ICollection<CityEntity> Cities { get; set; }

        public virtual ICollection<CountryEntity> Countries { get; set; }
    }
}
