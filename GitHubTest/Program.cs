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

            //WriteSomething(); hahhahahahhaha BUG BUGBUG BUG BUG!!!!
            Calculator();

        }

        private static void WriteSomething()
        {
            Console.WriteLine("Awesome kalkylator!");
        }
        
        private static void Calculator()
        {
            Console.WriteLine("Ange en siffra");
           var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange en siffra att addera med den första siffran du angav");
           var input2 = Convert.ToInt32(Console.ReadLine());

            var sum = input1 + input2;

            Console.WriteLine("Sweet! Summan av de 2 talen är:");
            Console.WriteLine(sum);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Console.Beep();
            }

        }
    }
}
