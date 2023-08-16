namespace ShapeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            
            Triangle t =new Triangle();
            
            Rectangle r = new Rectangle();
            DisplayMenu();

              static void DisplayMenu()
            {
                Console.WriteLine("Select an option");
                Console.WriteLine("1.Display Area and Perimeter of Circle");
                Console.WriteLine("2.Display Area and Perimeter of Triangle");
                Console.WriteLine("3.Display Area and Perimeter of Rectangle");
                Console.WriteLine("Exit");

            }

            int  ch =  int.Parse(Console.ReadLine());
            
            switch(ch)
            {
                case 1:

                    c.CalculateArea();
                    c.CalculatePerimeter();
                    break;
                case 2:
                    t.CalculateArea();
                    t.CalculatePerimeter();
                    break;
                case 3:
                    r.CalculateArea();
                    r.CalculatePerimeter();
                    break;
                default:
                    Console.WriteLine("Enter the proper value!!!");
                    break;
            }
            Console.ReadLine();

        }
    }
}