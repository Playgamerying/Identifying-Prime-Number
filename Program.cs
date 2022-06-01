using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifying_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuation;

            do
            {
                long num;
                long count = 0;

                Console.Write("Enter the number which you want to check: ");
                num = Convert.ToInt64(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("{0} is a prime number \n" +
                        "Press enter to continue", num);
                }
                else if (count == 1)
                {
                    Console.WriteLine("{0} is neither a prime number nor a composite number \n" +
                        "Press enter to continue", num);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number and so is a composite number \n" +
                        "Press enter to continue", num);
                }
                Console.ReadLine();
                Console.Write("Do you want to continue? \n" +
                    "Press (y) for yes and (n) for no \n" +
                    ": ");
                continuation = Console.ReadLine();
            } 
            while (continuation=="y" || continuation == "Y" || continuation == "(y)");

            
        }
    }
}
