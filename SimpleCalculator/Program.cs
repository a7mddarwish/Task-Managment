using System.Runtime.CompilerServices;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Calc();

            }

        }

        private static void Calc()
        {

            Console.Write("Enter First Number : ");

            int FNum = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the operator from [ + , - , * , / ] : ");

            char oprt = char.Parse(Console.ReadLine());

            Console.Write("\nEnter Second Number : ");

            int SNum = int.Parse(Console.ReadLine());


            switch (oprt)
            {
                case '+':
                    Console.WriteLine("Sum of two numbers => " + (FNum + SNum));
                    break;


                case '-':
                    Console.WriteLine("subtract of two numbers => " + (FNum - SNum));
                    break;

                case '*':
                    Console.WriteLine("multi of two numbers => " + (FNum * SNum));
                    break;

                case '/':
                    Console.WriteLine("devide of two numbers => " + (FNum / SNum));
                    break;


                default:
                    Console.WriteLine($"this operation [{oprt}] is not valied enter from [ + , - , * , / ] ");
                    break;


            }
            Console.WriteLine("\n\n--------------------------------------------\n\n");
        }
    }
}
