using CORE.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace COREAPI.DATA
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
