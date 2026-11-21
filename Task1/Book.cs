using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Book
    {
        //qustion1
       public  String Title;
       public  int Pages;
        public override string ToString()
        {
            return $"Title : {Title} , Pages : {Pages}  ";
        }
    }
}
