
using EsraSevincBlogProject.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlog.Core.DataAccess
{
    public class DatabaseConnect : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BKM1IFH;Initial Catalog=BlogDb;Integrated Security=True; TrustServerCertificate=True;");
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
