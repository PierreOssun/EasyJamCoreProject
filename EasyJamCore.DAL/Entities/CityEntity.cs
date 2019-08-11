using System.ComponentModel.DataAnnotations;

namespace EasyJamCore.DAL.Entities
{
    public class CityEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string CityName { get; set; }
    }
}
