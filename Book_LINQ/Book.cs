using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_LINQ
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public int NoOfPage { get; set; }

        public int AuthorID { get; set; }
        public int PublisherID { get; set; }

       
   
    }

}

