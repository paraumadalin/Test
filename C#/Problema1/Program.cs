using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[args.Length];

            Console.WriteLine("Number of command line parameters = {0}", args.Length);

            if (0 == args.Length)
            //testcase 1
            //////////////////////////////////////////////////
            {
                Console.WriteLine("Error: Null size array!");
                return;
            }
            /////////////////////////////////////////////////

            Console.WriteLine("Problema 1");
            //problema 1
            ////////////////////////////////////////////////////////////////////////
            int suma = 0;
            //testcase2
            //////////////////////////////////////////////////////////////////////////////////
            if (suma == null)
            {
                Console.WriteLine("Error: Variable suma not Initialized!");
            }
            //////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(args[i].ToString());
                Console.WriteLine("numbers[{0}] = [{1}]", i, numbers[i]);
                if (numbers[i] % 2 == 0)
                {
                    suma = suma + numbers[i];
                    //testcase2
                    //////////////////////////////////////////////////////////////////////////////////
                    if (suma % 2 == 0) 
                    {
                        Console.WriteLine("The number is even");
                    }
                    else
                        Console.WriteLine("The summ is not even one of the numbers is odd");
                    //////////////////////////////////////////////////////////////////////////////////
           
                }
                //testcase4
                //////////////////////////////////////////////////////////////////////////////////
                else 
                {
                    Console.WriteLine("number not even");
                }
                //////////////////////////////////////////////////////////////////////////////////
           
                Console.WriteLine("Suma: {0}", suma);

            }
            Console.WriteLine("suma elementelor pare: {0}", suma);

            
        }
    }
}
