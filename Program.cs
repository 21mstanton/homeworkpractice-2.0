using System;

namespace homeworkpractice_2._0 
{
    internal class Program
    {
        public class Factory
        {
            public int employeeNumber;
            public string employeeName;
            public string product;
            public int productCount{get; }

            public Factory(string employeeName, int employeeNumber, string product)
            {
                this.employeeName = employeeName;

                this.employeeNumber = employeeNumber;

                this.product = product;              
            }
        }
        public class Employee : Factory 
        {
            public Employee(string employeeName, int employeeNumber, string product) : base(employeeName, employeeNumber, product)
            {
                employeeName = "Evan";
                employeeNumber = 172646;
                product = "Toy train";
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
