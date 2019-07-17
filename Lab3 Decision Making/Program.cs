using System;

namespace Lab3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First and Last name");
            string username = Console.ReadLine();

            bool continueLoop = true;
            while (continueLoop)
            {
                
                Console.WriteLine("Please enter an integer between 1 and 100.");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 >= 1 && num1 <= 100)
                {
                    //input

                    if (num1 % 2 == 0)
                    {
                        if (num1 >= 2 && num1 < 25)
                        {
                            Console.WriteLine("Even and less than 25.");
                            break;
                        }
                        else if (num1 >= 26 && num1 <= 60)
                        {
                            Console.WriteLine("Even");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{num1} Even");
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine($"{num1} This number is Odd.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Number out range");
                }
               
            }
            Console.WriteLine($"{username} If you would like to end program please press enter");
            Console.ReadLine();
        }
    }
}
