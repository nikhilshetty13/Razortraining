using Microsoft.EntityFrameworkCore;
using Razortraining.Model;

namespace Razortraining.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }
        public DbSet<Category>? categories { get; set; }
    }
}
