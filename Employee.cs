using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_1
{
    class Employee
    {
        int id, age;
        string name;
        double salary;

        static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            try
            {
                Console.WriteLine("Please enter the employee ID");
                id = int.Parse(Console.ReadLine());
                if (employees.ContainsKey(id))
                {
                    Console.WriteLine("This ID has been already added !!! Use a new ID. ");
                    TakeEmployeeDetailsFromUser();
                    return;
                }
            }
            catch
            {
                Console.WriteLine("ID must be a number !!!");
                TakeEmployeeDetailsFromUser();
                return;
            }

            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();

            try
            {
                Console.WriteLine("Please enter the employee age");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Age must be a number !!!");
                TakeEmployeeDetailsFromUser();
                return;
            }

            try
            {
                Console.WriteLine("Please enter the employee salary");
                salary = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Salary must be a number !!!");
                TakeEmployeeDetailsFromUser();
                return;
            }

            try
            {
                employees.Add(id, new Employee(id, age, name, salary));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ID value cannot be NULL !!!!");
                TakeEmployeeDetailsFromUser();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This ID has been already added !!! Use a new ID. ");
                TakeEmployeeDetailsFromUser();
                return;
            }

        }

        public static void ModifyEmployeeDetails()
        {
            int id = -1;
            try
            {
                Console.WriteLine("Please enter the employee ID : ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ID must be an Integer !!!");
                ModifyEmployeeDetails();
                return;
            }

            Console.WriteLine("The employee details:");

            Employee _empModify = employees[id];
            if (_empModify != null)
            {

                Console.WriteLine(_empModify.ToString());

                Console.WriteLine("Please enter the updated employee details : ");
                Console.WriteLine("Please enter the employee name : ");
                _empModify.name = Console.ReadLine();

                try
                {
                    Console.WriteLine("Please enter the employee age : ");
                    _empModify.age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Age must be a number !!!");
                    ModifyEmployeeDetails();
                    return;
                }

                try
                {
                    Console.WriteLine("Please enter the employee salary");
                    _empModify.salary = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Salary must be a number !!!");
                    ModifyEmployeeDetails();
                    return;
                }

            }
            else
            {
                Console.WriteLine("Employee not found in this ID !!!");
                ModifyEmployeeDetails();
                return;
            }
        }

        public static void PrintEmployeeDetails()
        {
            foreach (KeyValuePair<int, Employee> pair in employees)
            {
                Console.WriteLine(pair.Value.ToString());
                Console.WriteLine("------------------------");
            }
        }

        public static void PrintEmployeeByID()
        {
            int id = -1;
            try
            {
                Console.WriteLine("Please enter the employee ID : ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ID must be an Integer !!!");
                ModifyEmployeeDetails();
            }

            if (employees.ContainsKey(id))
            {
                Console.WriteLine("The employee details:");
                Employee emp = employees[id];
                Console.WriteLine(emp.ToString());
            }
            else
            {
                Console.WriteLine("No Employee is not found in this ID !!!!");
                PrintEmployeeByID();
                return;
            }

        }

        public override string ToString()
        {
            return "\nEmployee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary + "\n";
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}