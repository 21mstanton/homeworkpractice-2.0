
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

            /// <summary>
            /// this is the part of the inheritance whre we define specifically 
            /// how the factory operates and how and what is going to work and 
            /// be defined into the factory class
            /// <summary/>
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

    //     static void Main(string[] args)
    //     {
    //         IProduct product = new product();
    //     }
    // }

    //this is ch7 through finish reading practice.
    public class PdaItem
    {
        [disallowNull]
        public string? Name {get; set;}

        public DateTime LastUpdated {get; set;}

        public class Contact : PdaItem
        {
            public string Address {get; set;}
            public string phone {get; set;}

        }

        public class Program
        {
            public static void Main()
            {
                Contact contact = new Contact();
                contact.Name = "Inigo Montoya";
                //more main example
            }

        }

        class GPSCoordinates
        {
            public static implicit operator UTMCoordinates(GPSCoordinates coordinates)
            {
                // method examlpe
            }
        }
        }
    }
}
}
