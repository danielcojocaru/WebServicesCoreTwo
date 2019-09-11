using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Address
    {
        public Address()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            Company = new HashSet<Company>();
        }

        public int IdAddress { get; set; }
        public int? IdCountry { get; set; }
        public string City { get; set; }
        public string Plz { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Floor { get; set; }
        public string Interphone { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string PhoneSecond { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}
