using DataAccess;
using DataAccess.Models;
using Domain.Interfaces;
using Domain.Interfaces.DbObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class SqlRepository : IRepository
    {
        private readonly SchoolsAndCreatorContext context;

        public SqlRepository(SchoolsAndCreatorContext context)
        {
            this.context = context;
        }

        public IEnumerable<ICompany> GetCompanies()
        {
            var companies = context.Company
                .Include(x => x.IdAddressNavigation)
                .Include(x => x.AspNetUsers)
                .ToList();
            return companies;
        }
    }
}
