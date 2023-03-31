using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class PhotoBookTest
    {
        [TestMethod]
        public void DefaultPhotoBookTest()
        {
            PhotoBook book = new PhotoBook();

            Assert.AreEqual(16, book.NoOfPages);
            Console.WriteLine($"book created with {book.NoOfPages} pages");
        }

        [TestMethod]
        public void CustomPhotoBookTest() { 
            PhotoBook book = new PhotoBook(32);
            Assert.AreEqual(32, book.NoOfPages);
            Console.WriteLine($"book created with {book.NoOfPages} pages");

        }

        [TestMethod]
        public void LargePhotoBookTest() {
            AddPhotoBook book = new AddPhotoBook();
            Assert.AreEqual(64, book.PhotoBook.NoOfPages);
            Console.WriteLine($"book created with {book.PhotoBook.NoOfPages} pages");

        }
    }
}
