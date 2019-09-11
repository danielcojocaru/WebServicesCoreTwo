using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.DbObjects
{
    public interface ICompany
    {
        int IdCompany { get; set; }
        string CompanyName { get; set; }
        string CompanyShortName { get; set; }
        int? IdAddress { get; set; }
        string Type { get; set; }
        DateTime? FoundedDate { get; set; }
        string WelcomeText { get; set; }
        string OpeningHours { get; set; }
        string Color { get; set; }
        string SubdomainName { get; set; }
        string LogoPicPath { get; set; }
        bool IsActive { get; set; }
        int ActiveCodes { get; set; }
        string BackgroundPic { get; set; }
        string Email { get; set; }
        string Layout { get; set; }
    }
}
