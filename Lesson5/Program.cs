using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 1;
             
             while (num < 10)
             {
                 if (num == 5)
                 {
                     break;
                 }
                 Console.WriteLine(num++);
             }
             */
            /*
                        do
                        {
                            Console.WriteLine(num++);
                        } while (num < 10);
            */
            /*
            for (int i = 10; i > 0; i--)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            */

            // char symbol = 'a';
            /*
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j <10; j--)
                 {
                     Console.Write(j + " ");
                 }
                 Console.WriteLine();
             }
             */
            /*
                        int num = 0;

                        while (true)
                        {
                            Console.WriteLine(num);
                            num++;
                            if (num == 10)
                            {
                                break;
                            }
                        }
            */
            /*
            bool b = true;

            do
            {
                Console.Write("Enter first num: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Enter second num: ");
                int second = int.Parse(Console.ReadLine());

                if (first < second)
                {
                    Console.Write("Even between {0} and {1} is: ", first, second);

                    for (int i = first; i < second; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }

                    }
                    b = true;
                }
                else
                {
                    Console.WriteLine("Number second must to be greather than first. Try again!");
                }
            } while (b);
            */
            /*
            int n1 = 100;
            int sum = 0;

            for (int i = 1; i <= n1; i++)
            {
                sum += i;
               
                                
            }
            Console.Write(sum + " ");
            */

            Console.ReadLine();
        }
    }
}
