using ASP.NET_Core_Task_1.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Task_1.DAL
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions <AppDbContex> options):base(options) { }
       
        public DbSet<Ozellik> Ozelliks { get; set; }
    }
}
