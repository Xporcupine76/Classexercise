using System;
namespace Classexercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Mustek visitors = new Mustek();
            Console.WriteLine("Visitors");
            Console.WriteLine(visitors.login);
            Console.WriteLine(visitors.checkout);
            visitors.CovidVaccine();

            Console.WriteLine("===============");

            Mustek students = new Mustek();
            Console.WriteLine("Students");
            Console.WriteLine(students.login);
            Console.WriteLine(students.checkout);
            Console.WriteLine(students.LunchBreak);

            Console.WriteLine("===============");

            Mustek employees = new Mustek();
            Console.WriteLine("Employees");
            Console.WriteLine(employees.login);
            Console.WriteLine(employees.checkout);
            Console.WriteLine(employees.LunchBreak);
            Console.WriteLine(employees.SeeManager);

            Console.WriteLine("===============");

            Mustek employee1 = new Mustek();
            Console.WriteLine("Employee1");
            Console.WriteLine(employee1.login);
            Console.WriteLine(employee1.checkout);
            Console.WriteLine(employee1.LunchBreak);
            Console.WriteLine(employee1.SeeManager);

            Console.WriteLine("===============");

            Mustek employee2 = new Mustek();
            Console.WriteLine("Employee2");
            Console.WriteLine(employee2.login);
            Console.WriteLine(employee2.checkout);
            Console.WriteLine(employee2.LunchBreak);


        }
        
    }
    public class Mustek
    {

        public string login = "Log in";
        public string checkout = "Go home";
        public string LunchBreak = "I am on lunch";
        public string SeeManager = "Comsulting with manager";

        public void CovidVaccine()
        {

            Console.WriteLine("Get Vacinated");

        }


    }

}