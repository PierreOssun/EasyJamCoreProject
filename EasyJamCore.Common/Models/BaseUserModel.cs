﻿namespace EasyJamCore.Common.Model
{
    using System;
    using System.Collections.Generic;

    public class BaseUserModel
    {
        public string Blaze { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime SignInDate { get; set; }

        public DateTime? Birthdate { get; set; }

        public virtual ICollection<CrewModel> Crews { get; set; }

        public virtual ICollection<CityModel> Cities { get; set; }

        public virtual ICollection<CountryModel> Countries { get; set; }

        public int ID { get; set; }
    }
}
