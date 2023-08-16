using System.Numerics;

namespace OnlineInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics e1 = new Electronics("Samsung","Camera", 102, "Phone", 20000,5);
            Electronics e2 = new Electronics("Bajaj", "GX-3701 750", 103, "P", 20000, 5);
            Electronics e3= new Electronics("Philips", "Ultra wide", 104, "TV", 30000, 7);

            e1.DisplayProductDetails();
            e2.DisplayProductDetails(); 
            e3.DisplayProductDetails();


            Clothing c1 = new Clothing("XL","Western", 201 ,"T-shirt" ,800, 3);
            Clothing c2 = new Clothing("XXL", "Traditional", 202, "Kurti", 900, 2);
            Clothing c3 = new Clothing("S", "Western", 203, "skirt", 1000, 2);

            c1.DisplayProductDetails();
            c2.DisplayProductDetails();
            c3.DisplayProductDetails();

            Books b1 = new Books("J.K Rowling", "Fantasy", 301, "Harry Potter", 500, 6);
            Books b2 = new Books("Colleen Hoover", "Romance", 302, "It Ends With Us", 600, 10);
            Books b3 = new Books("Hector Garsia", "Self help book", 303, "Ikigai", 400, 4);

            b1.DisplayProductDetails();
            b2.DisplayProductDetails();
            b3.DisplayProductDetails();

            Console.ReadKey();
        }
    }
}