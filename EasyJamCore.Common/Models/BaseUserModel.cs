using System;
using System.Collections.Generic;

namespace EasyJamCore.Common.Model
{
    public class BaseUserModel
    {
        public string Blaze { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime SignInDate { get; set; }

        public string Age { get; set; }

        public virtual ICollection<CrewModel> Crews { get; set; }

        public virtual ICollection<CityModel> CityEntity { get; set; }

        public virtual ICollection<CountryModel> CountryEntity { get; set; }
        public int ID { get; set; }
    }
}
