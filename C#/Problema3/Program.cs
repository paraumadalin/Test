using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[args.Length];

            Console.WriteLine("Number of command line parameters = {0}", args.Length);
            //testecase1
            /////////////////////////////////////////////////////////////////////////////////
            if (0 == args.Length)
            {
                Console.WriteLine("Error: Null size array!");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Problema 3");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(args[i].ToString());
                Console.WriteLine("numbers[{0}] = [{1}]", i, numbers[i]);
                //testecase2
                /////////////////////////////////////////////////////////////////////////////////
                if (numbers[i] < 1)
                {
                    Console.WriteLine("Error: Array has numbers smaller than 1");
                    return;
                }
                /////////////////////////////////////////////////////////////////////////////////
                //testecase3
                /////////////////////////////////////////////////////////////////////////////////
                if (numbers[i] > numbers.Length)
                {
                    Console.WriteLine("Error: number is too big");
                    return;
                }
                /////////////////////////////////////////////////////////////////////////////////
            
            }
            printRepeating(numbers);
        }
        private static void printRepeating(int[] numbers)
        {
            int i;

            Console.WriteLine("The repeating elements are: ");

            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[Math.Abs(numbers[i])] > 0)
                    numbers[Math.Abs(numbers[i])] = -numbers[Math.Abs(numbers[i])];
                else
                   Console.WriteLine(" {0} ", Math.Abs(numbers[i]));
                    
                
            }
                   
        }
    }
}
