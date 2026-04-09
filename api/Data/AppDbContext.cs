using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Character> Characters => Set<Character>();
    }
}
