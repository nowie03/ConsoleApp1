using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PhotoBook
    {
        private int _noOfPages;

       public PhotoBook()
        {
            this._noOfPages = 16;
        }

        public PhotoBook(int pages)
        {
            this._noOfPages = pages;
        }

        public int NoOfPages { get { return this._noOfPages; } }
    }
}
