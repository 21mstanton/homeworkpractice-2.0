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

        public interface IProduct 
        {
            public string productName{get; set;}

            public string productDescription{get; set;}
        }

        public class Employee : Factory : IProduct
        {
            public Employee(string employeeName, int employeeNumber, string product) : base(employeeName, employeeNumber, product)
            {
                employeeName = "Evan";
                employeeNumber = 172646;
                product = "Toy train";
                this.productName = "Toy train";
                this.productDescription = "it needs to run on sold tracks";
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
