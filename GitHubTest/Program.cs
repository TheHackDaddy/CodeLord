using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //whoa

            Console.WriteLine("Make Academy Great Again");

            Calculator();
            WriteSomething();

        }

        private static void WriteSomething()
        {
            
        }

        private static void Calculator()
        {
            Console.WriteLine("Ange en siffra");
           var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange en siffra att addera med den första siffran du angav");
           var input2 = (Console.ReadLine());

            var sum = input1 + input2;

            Console.WriteLine("Sweet! Summan av de 2 talen är:");
            Console.WriteLine(sum);

        }
    }
}
