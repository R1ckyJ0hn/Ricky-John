using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace EFCore2.Models
{
    public class BookDbContext :DbContext
    {
        public BookDbContext()
        {
            
        }
        public BookDbContext(DbContextOptions<BookDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NE6M66C;Initial Catalog=Newdatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Books> Bookscollection { get; set; }

    }
}
