using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String anser = "Anwser is ";
            Console.Write("#######################################################################\n" +
                "This is Console Calculator\n" +
                "Please Choose operation\n" +
                "\n"
                +
                " \t+ = add\n" +
                " \t- = min\n" +
                " \t* = mul\n" +
                " \t/ = div\n");
Console.WriteLine("Enter the option :");
            String op=Console.ReadLine();
            Console.WriteLine("Enter the first number : ");
            double a = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            double b=Convert.ToDouble( Console.ReadLine());
            if (op == "add")
            {
               Console.WriteLine(anser+( a + b));

            }else if (op == "min")
            {
                Console.WriteLine(anser +(a-b));
            }
            else if (op=="mul")
            {
                Console.WriteLine(anser+(a*b));
            }
            else if (op == "div")
            {
                Console.WriteLine(anser+(a/b));
            }
            else
            {
                Console.WriteLine("Enter the command carefully !");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
