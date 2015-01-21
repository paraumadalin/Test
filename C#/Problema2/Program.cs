using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[args.Length];

            Console.WriteLine("Number of command line parameters = {0}", args.Length);
            //testcase1
            //////////////////////////////////////////////////////////////////////////////////            
            if (0 == args.Length)
            {
                Console.WriteLine("Error: Null size array!");
                return;
            }
            //////////////////////////////////////////////////////////////////////////////////
            int big = 0;
            int bigger = 0;
            int biggest = 0;
            //testcase2
            //////////////////////////////////////////////////////////////////////////////////
            if (big == null)
            {
                Console.WriteLine("Error: Variable big not Initialized!");
            }
            if (bigger == null)
            {
                Console.WriteLine("Error: Variable big not Initialized!");
            }
            //////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(args[i].ToString());
                Console.WriteLine("numbers[{0}] = [{1}]", i, numbers[i]);
                if (numbers[i]>big)
                {
                   big = numbers[i];
                 }
                //testcase3
                ///////////////////////////////////////////////////////////////////////////
                if (big > numbers[i])
                {
                    Console.WriteLine("{0} is too big ", numbers[i]);
                }
                if (numbers[i] > bigger)
                {
                    big = bigger;
                    bigger = numbers[i];
                }
                //testcase4
                ///////////////////////////////////////////////////////////////////////////
                if (bigger > numbers[i])
                {
                    Console.WriteLine("{0} is too big ", numbers[i]);
                }
                   // while (big < biggest) big = biggest;
                Console.WriteLine("Status: bigger = {0}, big = {1}", bigger, big);
                //testcase5
                ///////////////////////////////////////////////////////////////////////////
                if (big > bigger)
                {
                    Console.WriteLine("{0} is too big ", numbers[i]);
                }
                ///////////////////////////////////////////////////////////////////////////

                //Console.WriteLine("primul element cel mai mare: {0}", mare1);
            }
            Console.WriteLine("primul element cel mai mare: {0}", big);
            Console.WriteLine("al doilea element cel mai mare: {0}", bigger);
        }
    }
}
