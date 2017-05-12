using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Exercises.Sum()*/;
            //        Person[] people = new Person[4];

            //        people[0] = new Person { Id = 1, FirstName = "Blaine" };
            //        people[1] = new Person { Id = 2, FirstName = "Cameron" };
            //        people[2] = new Person { Id = 3, FirstName = "Jennifer" };
            //        people[3] = new Person { Id = 4, FirstName = "Ryan" };

            //        Console.WriteLine("Length of array: {0}", people.Length);

            //        //commented out int id = 2;

            //        // Grab the person to delete from the list
            //        foreach (var person in people)
            //        {
            //            if(person.Id == 2)
            //            {
            //                //commented out people.Remove(person);
            //                break;
            //            }
            //        }

            //Uncomment each line to check method one at a time.

            //Assert("Hello World String Works", Exercises.HelloWorld() == "Hello World!");
            //Assert("Say Hello Works", Exercises.SayHello() == "Hello Lisa!");
            //Assert("Sum is Correct", Exercises.Sum(3,2) == 5);
            //Assert("Divide is Correct", Exercises.Divide(0.50, 0.25) == 2);
            //Assert("Customer Age", Exercises.CanOpenCheckingAccount(18) == "true");
            //Assert("First Name is Split", Exercises.GetFirstName() == "Lisa");
            //Assert ("Reverse String Works", Exercises.ReverseStringHard() == "olleh");
            //Assert("Reverse String Works", Exercises.ReverseStringEasy() == "olleh");
            //Assert("Timestable Passed", Exercises.PrintTimesTable().ToString() == "3 * 3 = 9\r\n3 * 2 = 6\r\n3 * 1 = 3\r\n3 * 0 = 0");
            //Assert("Conversion Works", Exercises.ConvertKelvinToFarenheit() == 32);

            Console.WriteLine("Enter");
            Console.ReadLine();
        }

        static void Assert(string exerciseName, bool condition) {
            if (condition) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[PASS] - {exerciseName}");
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] - {exerciseName}");
            } Console.ForegroundColor = ConsoleColor.White;
        }
    }
    //class Person
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}
}
