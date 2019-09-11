using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Company
    {
        [Key]
        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public string CompanyShortName { get; set; }
        public Nullable<int> IdAddress { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> FoundedDate { get; set; }
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

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
