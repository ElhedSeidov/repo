using System.Dynamic;

namespace ConsoleApp1
{




    public class PhotoBook
    {



        public PhotoBook()
        {

            NumPages = 16;
        }
        public PhotoBook(int numPages )
        {

            NumPages = numPages;
        }

        private int NumPages { get; set; }

        public int GetNumberPages()
        {
            
            return NumPages;
        }

   
    }

    public class BigPhotoBook
    {

        public BigPhotoBook()
        {

            NumPages = 64;
        }
        private int NumPages { get; set; }
        public int GetNumberPages()
        {

            return NumPages;
        }


    }



    public class Program
    {
        public static void Main()
        {
            PhotoBook book1 = new PhotoBook();   
           Console.WriteLine( book1.GetNumberPages());
            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine(book2.GetNumberPages());
            BigPhotoBook bigPhotoBook1 = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook1.GetNumberPages());
        }
    }




}