﻿namespace EasyJamCore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BaseUser")]
    public class BaseUserEntity : IEntity
    {
        [Required]
        [MaxLength(50)]
        public string Blaze { get; set; }

        [Required]
        [MaxLength(1)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime? SignInDate { get; set; }

        public DateTime? Birthdate { get; set; }

        public virtual ICollection<CrewEntity> Crews { get; set; }

        public virtual ICollection<CityEntity> Cities { get; set; }

        public virtual ICollection<CountryEntity> Countries { get; set; }

        public int ID { get; set; }
    }
}
