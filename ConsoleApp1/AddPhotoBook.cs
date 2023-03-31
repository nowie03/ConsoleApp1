using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace ConsoleApp1
{
    public class AddPhotoBook
    {
        private PhotoBook _photoBook;
        public AddPhotoBook() { 
            this._photoBook = new PhotoBook(64);
        }

        public PhotoBook PhotoBook { get {  return this._photoBook; } }
    }
}
