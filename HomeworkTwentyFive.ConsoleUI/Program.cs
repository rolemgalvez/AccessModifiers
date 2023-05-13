using HomeworkTwentyFive.Library;
using System;

namespace HomeworkTwentyFive.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Profession profession = new Profession();
            Employee employee = new Employee();

            profession.Industry = "Information Technology";
            profession.Saying();

            employee.FavoriteTask();

            Console.ReadLine();
        }
    }
}
