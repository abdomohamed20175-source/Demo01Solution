using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basics_Session05
{
    internal class Book
    {
       private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
      public  Genre genre { get; set; }

    }
}
