using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_p_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop
            Console.WriteLine("first 10 natural numbers are ");
            for (int i= 0 ; i <= 10; i++)
            {
                
                Console.WriteLine(i);
            }

            //while loop
            int j = 2;
            Console.WriteLine("first 10  even natural numbers are " + j);
            while( j<=10)
            {
                Console.WriteLine(j);
                j+=2;
            }

            //do-while loop
            int k = 1;
            Console.WriteLine("the first 10 odd natural numbers are ");

            do
            {
                Console.WriteLine(k);
                k += 2;
            }
            while (k <= 10);
            
             Console.ReadKey();
        }
       

    }
}
