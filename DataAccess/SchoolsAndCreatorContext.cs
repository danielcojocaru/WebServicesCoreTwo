using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class SchoolsAndCreatorContext : DbContext
    {
        public SchoolsAndCreatorContext(DbContextOptions<SchoolsAndCreatorContext> options) : base(options)
        {

        }

        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
