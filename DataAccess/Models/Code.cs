using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Code
    {
        public int IdCode { get; set; }
        public string IdUser { get; set; }
        public string IdOwner { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TheCode { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime? DateTimeUpdated { get; set; }
        public DateTime ExpiringDate { get; set; }
        public string Class { get; set; }
        public string SelectedClass { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExamDate { get; set; }
        public bool IsRegular { get; set; }
        public int IdVersion { get; set; }
        public string City { get; set; }
        public string Plz { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? EmailSent { get; set; }
        public bool IsEmailSent { get; set; }
        public bool CanDoTests { get; set; }

        public virtual AspNetUsers IdOwnerNavigation { get; set; }
        public virtual AspNetUsers IdUserNavigation { get; set; }
    }
}
