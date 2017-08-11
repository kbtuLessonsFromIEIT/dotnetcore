using Microsoft.EntityFrameworkCore;

namespace List.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {
        }

        public virtual DbSet<Record> Records { get; set; }
    }
}