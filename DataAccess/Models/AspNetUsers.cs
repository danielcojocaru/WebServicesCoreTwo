using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            CodeIdOwnerNavigation = new HashSet<Code>();
            CodeIdUserNavigation = new HashSet<Code>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? IdCompany { get; set; }
        public int? IdAddress { get; set; }
        public int? IdCountry { get; set; }
        public bool? IsApproved { get; set; }

        public virtual Address IdAddressNavigation { get; set; }
        public virtual Company IdCompanyNavigation { get; set; }
        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<Code> CodeIdOwnerNavigation { get; set; }
        public virtual ICollection<Code> CodeIdUserNavigation { get; set; }
    }
}
