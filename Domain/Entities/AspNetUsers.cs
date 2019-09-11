using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class AspNetUsers
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> IdCompany { get; set; }
        public Nullable<int> IdAddress { get; set; }
        public Nullable<int> IdCountry { get; set; }
        public Nullable<bool> IsApproved { get; set; }

        public virtual Company Company { get; set; }
    }
}
