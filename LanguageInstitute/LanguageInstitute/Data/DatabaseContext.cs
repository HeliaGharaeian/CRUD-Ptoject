using LanguageInstitute.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;

namespace LanguageInstitute.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }


        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Class> classes { get; set; }
    }
}
