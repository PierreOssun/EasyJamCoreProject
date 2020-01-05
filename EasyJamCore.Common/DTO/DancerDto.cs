namespace EasyJamCore.Common.DTO
{
    using System;
    using System.Collections.Generic;
    using EasyJamCore.Common.Model;

    public class DancerDto
    {
        public string Blaze { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime SignInDate { get; set; }

        public DateTime? Birthdate { get; set; }

        public ICollection<CrewModel> Crews { get; set; }

        public ICollection<CityModel> Cities { get; set; }

        public ICollection<CountryModel> Countries { get; set; }

        public int ID { get; set; }
    }
}
