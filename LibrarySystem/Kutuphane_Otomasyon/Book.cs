using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otomasyon
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public bool IsAvailable { get; set; }
        public int? UserID { get; set; }
        public virtual User ByUser { get; set; }
        public virtual Author ByAuthor { get; set; }
    }
}
