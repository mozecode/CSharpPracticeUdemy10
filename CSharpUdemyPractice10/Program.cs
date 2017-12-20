using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter their name. Use an array to reverse the name and then 
            //store the result in a new string. Display the reversed name on the console.

            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();

            var nameCharArray = name.ToCharArray();
            Array.Reverse(nameCharArray); //split into an array of letters & reverse?

           //convert back into string using new keyword (ToString won't work)

            var stringified= new string(nameCharArray);


            Console.WriteLine(stringified);














        }
    }
}
