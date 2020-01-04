namespace EasyJamCore.DAL.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class CountryEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
    }
}
