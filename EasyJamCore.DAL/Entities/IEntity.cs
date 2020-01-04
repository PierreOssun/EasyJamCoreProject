namespace EasyJamCore.DAL.Entities
{
    using System.ComponentModel.DataAnnotations;

    public interface IEntity
    {
        [Key]
        int ID { get; set; }
    }
}