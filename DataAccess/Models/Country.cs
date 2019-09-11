using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int IdCountry { get; set; }
        public string CountryName { get; set; }
        public string CountryShortName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
