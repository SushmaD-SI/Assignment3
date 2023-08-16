using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventorySystem
{
    internal class Product
    {

        public int Productid { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public virtual void DisplayProductDetails()
        {
            Console.WriteLine($"Id: {Productid} \t Name: {Name} \t Price: {Price}, Quantity: {Quantity}");
        }

        public Product(int id, string name, double price, int quantity)
        {
            Productid = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }

    class Electronics : Product
    {

        public Electronics (string brand ,string features ,int id, string name, double price, int quantity) :  base(id, name, price, quantity)
            {
              Brand = brand;
              Features = features;
            }

        public string Brand { get; set; }
        public string Features { get; set; }
        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Brand: {Brand} \t Feature: {Features}");
        }
    }

    class Clothing : Product 
    {
        public Clothing (string sizeofclothing ,string style , int id, string name, double price, int quantity) :base(id, name, price, quantity)
        {
            SizeofClothing = sizeofclothing;
            Style = style;
        }

        public string SizeofClothing { get; set;}
        public string Style { get; set;}



        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Size :{SizeofClothing} Style :{Style}");
        }
    }

    class Books : Product
    {

        public Books (string genre ,string author ,int id, string name, double price, int quantity) :base (id, name, price, quantity)
        {
            Author = author;
            Genre = genre;
        }

        public string Author { get; set;}   
        public string Genre { get; set;}

        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($" Author :{Author} Genre :{Genre}");

        }
    }


}
