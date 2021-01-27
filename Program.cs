using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_1
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayMenu();

            Console.ReadKey();
        }

        public static void DisplayMenu()
        {
            while (true)
            {
                int option = 0;
                Console.WriteLine("Please enter the option : ");
                try
                {
                    Console.WriteLine("\n1. Add an employee \n2. Modify an employee detail \n3. Print all employee's details \n4. Print an employee detail \n5. Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input !!! Enter a number from  1 to 5  ");
                }

                Employee emp = new Employee();
                switch (option)
                {
                    case 1:
                        int check = 1;
                        while (check == 1)
                        {
                            emp.TakeEmployeeDetailsFromUser();
                            try
                            {
                                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                                check = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Enter Either 1 or 0 !!!");
                            }
                        }
                        break;
                    case 2:
                        Employee.ModifyEmployeeDetails();
                        break;
                    case 3:
                        Employee.PrintEmployeeDetails();
                        break;
                    case 4:
                        Employee.PrintEmployeeByID();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Not an Valid Option !!! Enter an option from 1 to 5 ");
                        break;

                }
            }
        }

    }
}