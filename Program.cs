using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRUDClassLibrary;

namespace CRUDConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to Employee Management System*************\n");
            Console.WriteLine("Please choose the operation you want to perform");
            Console.WriteLine("\t\t 1. List of all Employee");
            Console.WriteLine("\t\t 2. Add new Employee");
            Console.WriteLine("\t\t 3. Modify existing Employee");
            Console.WriteLine("\t\t 4. Delete an Employee");

            Console.Write("Enter your Choice no. : ");
            string ChoiceOption = Console.ReadLine();
            switch (ChoiceOption)
            {
                case "1":
                    Employee employee = new Employee();
                    Console.WriteLine("Please Enter Below Details for Employee:");
                    Console.Write("\t Employee First Name: "); Console.ReadLine();
                    break;
            }
            Console.WriteLine(ChoiceOption);

            //CRUDClassLibrary.CRUDOperation obj = new CRUDClassLibrary.CRUDOperation();
            //obj.AddEmployee();
            Console.ReadKey();
        }
    }
}
