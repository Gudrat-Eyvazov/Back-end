using Microsoft.EntityFrameworkCore;
using RepositoryWebModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWebDataAccess.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
           public  DbSet <Category> Categories { get; set; }
    }
}
