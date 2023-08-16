using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    interface IShape
    {
        void CalculateArea();

        void CalculatePerimeter();
    }


    class Circle : IShape
    {

        double radius { get; set; }
       
        public void CalculateArea()
        {
            Console.WriteLine("Area of Circle:");
            double Area;
            Console.WriteLine("Enter the radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            Area = 3.14 * radius * radius;
            Console.WriteLine($"The Area of the circle is {Area}");
            
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Perimeter of Circle:");
            double Perimeter;
            //Console.WriteLine("Enter the radius");
            //double q = Convert.ToDouble(Console.ReadLine());
            Perimeter = 2 * 3.14 * radius;
            Console.WriteLine($"The perimeter of the Circle is {Perimeter}");
            Console.WriteLine("************************************");

        }

    }
    class Triangle : IShape
    {
    
        public void CalculateArea()
        {
            Console.WriteLine("Area of Triangle:");
            double Area;

            Console.WriteLine("Enter the breadth");
            double breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height");
            double height = Convert.ToDouble(Console.ReadLine());
            Area = (breadth * height);
            double m = Area / 2;
            Console.WriteLine($" Area of the triangle is  {Area}");
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine("Perimeter of Triangle");
            double perimeter;
            Console.WriteLine("Enter the the length of side 1");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 2");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 3");
            double C = Convert.ToDouble(Console.ReadLine());
            perimeter = A + B + C;
            Console.WriteLine($"Perimeter  of the triangle is + {perimeter}");
            Console.WriteLine("************************************");
        }
    }
    class Rectangle : IShape

    {       double length {get;set;}
            double breadth { get; set; }
            public void CalculateArea()
            {
           
                    double Area;
                    Console.WriteLine("Area of Rectangle:");
                    Console.WriteLine("Enter the  length : ");
                    length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the breadth:");
                    breadth = Convert.ToDouble(Console.ReadLine());
                    Area = length * breadth;
                    Console.WriteLine($"The Area of the rectangle is : {Area}");


                   
            }

            public void CalculatePerimeter() 
                
                {  
                   //Console.Write("Perimeter of Rectangle:");
                   double perimeter;
                   perimeter = 2 * (length + breadth);
                   Console.WriteLine($"The perimeter of the rectangle is : {perimeter}");
                   Console.WriteLine("************************************");

        }

        }

    }


    

