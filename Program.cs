
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace homeworkpractice_2._0 
{
    internal class Program
    {
        public interface IProduct
        {
            public void productDetails();
        }
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

        public class product : IProduct
        {
            string productName;
            int productCode;
            string productSafteyLevel;
            public void productDetails()
                {
                    productName = "Custom";
                    productCode = 28374678;
                    productSafteyLevel = "10+";

                }

        static void Main(string[] args)
        {
            IProduct product = new product();
        }
    }
}
}
