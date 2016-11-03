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
            WriteSomething();
            Calculator();
            //whoa
            Console.WriteLine(@" __       __   ______   __    __  ________         ______    ______    ______ _______   ________ __       __ __      __ ______   _______ ________   ______ ________         ______ ______    ______ ______  __ __");
            Console.WriteLine(@"|  \     /  \ /      \ |  \  /  \|        \       /      \  /      \  /      \ |       \ |        \|  \     /  \|  \    /  \       /      \ |       \ |        \ /      \|        \       /      \  /      \  /      \ |      \|  \  |  \");
            Console.WriteLine(@"| $$\   /  $$|  $$$$$$\| $$ /  $$| $$$$$$$$      |  $$$$$$\|  $$$$$$\|  $$$$$$\| $$$$$$$\| $$$$$$$$| $$\   /  $$ \$$\  /  $$      |  $$$$$$\| $$$$$$$\| $$$$$$$$|  $$$$$$\\$$$$$$$$      |  $$$$$$\|  $$$$$$\|  $$$$$$\ \$$$$$$| $$\ | $$");
            Console.WriteLine(@"| $$$\ /  $$$| $$__| $$| $$/  $$ | $$__          | $$__| $$| $$   \$$| $$__ | $$| $$  | $$| $$__    | $$$\ /  $$$  \$$\/  $$       | $$ __\$$| $$__| $$| $$__    | $$__| $$  | $$         | $$__| $$| $$ __\$$| $$__| $$  | $$  | $$$\| $$      ");
            Console.WriteLine(@"| $$$$\  $$$$| $$    $$| $$  $$  | $$  \         | $$    $$| $$      | $$    $$| $$  | $$| $$  \   | $$$$\  $$$$   \$$  $$        | $$|    \| $$    $$| $$  \   | $$    $$  | $$         | $$    $$| $$|    \| $$    $$  | $$  | $$$$\ $$");
            Console.WriteLine(@"| $$\$$ $$ $$| $$$$$$$$| $$$$$\  | $$$$$         | $$$$$$$$| $$   __ | $$$$$$$$| $$  | $$| $$$$$   | $$\$$ $$ $$    \$$$$         | $$ \$$$$| $$$$$$$\| $$$$$   | $$$$$$$$  | $$         | $$$$$$$$| $$ \$$$$| $$$$$$$$  | $$  | $$\$$ $$");
            Console.WriteLine(@"| $$ \$$$| $$| $$  | $$| $$ \$$\ | $$_____       | $$  | $$| $$__/  \| $$  | $$| $$__/ $$| $$_____ | $$ \$$$| $$    | $$          | $$__| $$| $$  | $$| $$_____ | $$  | $$  | $$         | $$  | $$| $$__| $$| $$  | $$ _| $$_ | $$ \$$$$");
            Console.WriteLine(@"| $$  \$ | $$| $$  | $$| $$  \$$\| $$     \      | $$  | $$ \$$    $$| $$  | $$| $$    $$| $$     \| $$  \$ | $$    | $$           \$$    $$| $$  | $$| $$     \| $$  | $$  | $$         | $$  | $$ \$$    $$| $$  | $$|   $$ \| $$  \$$$");
            Console.WriteLine(@" \$$      \$$ \$$   \$$ \$$   \$$ \$$$$$$$$       \$$   \$$  \$$$$$$  \$$   \$$ \$$$$$$$  \$$$$$$$$ \$$      \$$     \$$            \$$$$$$  \$$   \$$ \$$$$$$$$ \$$   \$$   \$$          \$$   \$$  \$$$$$$  \$$   \$$ \$$$$$$ \$$   \$$");





            WriteSomething();
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

        }
    }
}
