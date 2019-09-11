using DataAccess;
using Domain.Entities;
using Domain.Interfaces;
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

        public IEnumerable<Company> GetCompanies()
        {
            var companies = context.Company;
            return companies;
        }
    }
}
