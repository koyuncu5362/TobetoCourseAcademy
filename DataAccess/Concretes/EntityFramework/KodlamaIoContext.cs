using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class KodlamaIoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=KodlamaIo;TrustServerCertificate =True");
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<CourseInstructor> CourseInstructor { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course> Course { get; set; }

    }
}
