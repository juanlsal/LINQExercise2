using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {

            //TODO: Print the Sum of numbers
            var answer = numbers.Sum();
            //Console.WriteLine(answer);

            //TODO: Print the Average of numbers
            var answer2 = numbers.Average();
            //Console.WriteLine(answer2);

            //TODO: Order numbers in ascending order and print to the console
            var answer3 = numbers.OrderBy(x => x);
            /*foreach (var num in answer3 )
            {
                Console.WriteLine(num);
            }*/

            //TODO: Order numbers in decsending order and print to the console
            var answer4 = numbers.OrderByDescending(x => x);
            /*foreach (var num in answer4 )
            {
                Console.WriteLine(num);
            }*/

            //TODO: Print to the console only the numbers greater than 6
            var answer5 = numbers.Where(x => x > 6);
            /* foreach( var x in answer5)
             {
                 Console.WriteLine(x);
             }*/
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            /*Random rng = new Random();*/
            /*foreach (var num in numbers.OrderBy(x => rng.Next()).Take(4).OrderBy(x => x))
            {
                Console.WriteLine(num);
            }*/

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            /*foreach (var num in numbers.Take(numbers[4] = 22))
            {
                Console.WriteLine(num);
            }*/
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            /*foreach (var person in employees)
            {
                Console.WriteLine(person.FullName);
            }*/
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            /* var cNames = employees.Where(x => x.FullName.StartsWith("C"));
             var sNames = employees.Where(x => x.FullName.StartsWith("S"));
             var Names = new List<Employee>();
             Names.AddRange(cNames);
             Names.AddRange(sNames);
             foreach (var teacher in Names.OrderBy(x => x.FirstName))
             {
                 Console.WriteLine(teacher.FullName);
             }*/
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var age26 = employees.Where(x => x.Age > 26).OrderBy(x => x.YearsOfExperience <= 10 && x.Age > 35);
            foreach ( var employee in age26 )
            {
                Console.WriteLine(employee.FullName);
                Console.WriteLine(employee.Age);
            }
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var sumYOE = employees.Where(emp => emp.YearsOfExperience <= 10 && emp.Age > 35);
            Console.WriteLine(sumYOE.Sum(x => x.YearsOfExperience));
            Console.WriteLine(sumYOE.Average(x => x.YearsOfExperience));
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Juan", "Salamanca", 22, 0)).ToList();

            foreach( var employee in employees )
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
