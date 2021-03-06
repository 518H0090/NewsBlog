using Microsoft.EntityFrameworkCore;
using NewsBlogAPI.Models;

namespace NewsBlogAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<NewsPost> newsPosts { get; set; }
    }
}
