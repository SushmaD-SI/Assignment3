using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{    

    abstract internal class Employee
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }


        public Employee(string name, int empid, double salary, double bonus)
        {
            Name = name;
            EmpId = empid;
            Salary = salary;
            Bonus = bonus;

        }

        public override string ToString()
        {
            return $"Name : {Name} Empid : {EmpId} Salary : {Salary}  Bonus :{CalculateBonus()} ";
        }
        abstract public double CalculateBonus();

    }
    class Manager : Employee
    {

        public Manager (string name, int empid, double salary, double bonus) : base(name,  empid,  salary,  bonus)
        { }
        public override double CalculateBonus()
        {   

            return ((Bonus/100)* Salary ) +1000;
        }

    }
    class Developer : Employee
     {

        public Developer (string name, int empid, double salary, double bonus) : base(name, empid, salary, bonus)
        {

        }

        public override double CalculateBonus()
        {
              return ( (Bonus/100)* Salary) + 500;
        }

    }
    class Salesperson : Employee
    {
        public Salesperson(string name, int empid, double salary , double bonus) : base(name, empid, salary, bonus)
        {

        }
        public override double CalculateBonus()
        {
            return ((Bonus / 100) * Salary);
        }

    }

}