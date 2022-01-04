using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class Context: DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=CASPERNIRVANA;database=UniversityDb; integrated security=true");
        //}
        //public DbSet<Login> Logins { get; set; }
    }
}
