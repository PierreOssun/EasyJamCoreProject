namespace EasyJamCore.DAL.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Country")]
    public class CountryEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
    }
}
