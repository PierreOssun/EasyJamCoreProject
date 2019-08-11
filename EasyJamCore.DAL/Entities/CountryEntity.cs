using System.ComponentModel.DataAnnotations;

namespace EasyJamCore.DAL.Entities
{
    public class CountryEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string CountryName { get; set; }
    }
}
