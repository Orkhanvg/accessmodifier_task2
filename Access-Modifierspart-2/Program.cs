using Access_Modifierspart_2.model3;
using System;

namespace Access_Modifierspart_2
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                Student3 studentnew = new Student3();


                Console.WriteLine("please enter your name: ");
                studentnew.Name = Console.ReadLine();

                Console.WriteLine("surname: ");
                studentnew.Surname = Console.ReadLine();

                Console.WriteLine("please enter the age:  ");
                studentnew.Age = int.Parse(Console.ReadLine());


                Console.WriteLine("Please enter the Student's Point: ");
                studentnew.Point = int.Parse(Console.ReadLine());



            }
        }
    }
}
