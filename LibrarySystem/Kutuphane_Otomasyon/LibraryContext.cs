using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otomasyon
{
    class LibraryContext:DbContext
    {
        public LibraryContext() : base("Library")
        {
            Database.SetInitializer<LibraryContext>(new CreateDatabaseIfNotExists<LibraryContext>());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
