namespace EmployeeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("Sushma",1,40000,10.7);
            Console.WriteLine(m1.ToString());
            Developer d1 = new Developer("Preeti", 2, 500000, 7.8);
            Console.WriteLine(d1.ToString());
            Salesperson s1 = new Salesperson("David", 3, 7009, 4.3);
            Console.WriteLine(s1.ToString());
        }
    }
}