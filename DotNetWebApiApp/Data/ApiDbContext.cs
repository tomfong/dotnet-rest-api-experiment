using Microsoft.EntityFrameworkCore;
using DotNetWebApiApp.Models;

namespace DotNetWebApiApp.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}