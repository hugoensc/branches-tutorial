using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;

            if (a + b > 10)
            {
                Console.WriteLine($"The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine($"The answer is not greater than 10.");
            }

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second.");
            }
            else 
            {
                Console.WriteLine("The answer is not greater than 10.");
                Console.WriteLine("Or the first number is not equal to the second.");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("Or the frist number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10.");
                Console.WriteLine("And the first number is not equal to the second.");
            }
        }

        static void LoopsMethods()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World!. The counter is {counter}");
                counter++;
            }

            counter = -10;
            do 
            {
                Console.WriteLine($"Hello Wolrd! The counter is {counter}");
                counter++;
            } while (counter <= 10);
            
            for (int index = 0; index < 101; index++)
            {
                Console.WriteLine($"Hello World! The counter is ... {index}");
            }
        }

        static void Main(string[] args)
        {
            // ExploreIf();
            // LoopsMethods();
            int result = 0;
            for (int counter = 20; counter > 0; counter--)
            {
                if ((counter % 3) == 0)
                {
                    result = result + counter;
                    Console.WriteLine(result);
                }
            }

            Console.WriteLine(result);


        }
    }
}
