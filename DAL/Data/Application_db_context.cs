using DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace DAL.Data
{
    public class Application_db_context : DbContext
    {
        public Application_db_context(DbContextOptions<Application_db_context> options) : base(options)
        {

        }
        public DbSet<std_details> std_Detail   { get; set; }   
        
    }

}
