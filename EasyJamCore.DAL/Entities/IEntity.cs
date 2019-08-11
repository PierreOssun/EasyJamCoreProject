using System.ComponentModel.DataAnnotations;

namespace EasyJamCore.DAL.Entities
{
    public interface IEntity
    {
        [Key]
        int ID { get; set; }
    }
}
