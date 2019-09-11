using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Company
    {
        public Company()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public string CompanyShortName { get; set; }
        public int? IdAddress { get; set; }
        public string Type { get; set; }
        public DateTime? FoundedDate { get; set; }
        public string WelcomeText { get; set; }
        public string OpeningHours { get; set; }
        public string Color { get; set; }
        public string SubdomainName { get; set; }
        public string LogoPicPath { get; set; }
        public bool IsActive { get; set; }
        public int ActiveCodes { get; set; }
        public string BackgroundPic { get; set; }
        public string Email { get; set; }
        public string Layout { get; set; }

        public virtual Address IdAddressNavigation { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
