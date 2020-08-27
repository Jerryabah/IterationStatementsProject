using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - Done
            int myNum = 0;


            // Create a do-while loop - Done
            do            
            {
                // Increment your variable by 1 - Done
                myNum++;
                // Then add your variable to "numbers" - Done
                numbers.Add(myNum);
                // While your variable is less than 100 - Done
            } while (myNum < 100);


            // Create a while loop - Done
            // While your variable is less than 200 - Done
            while (myNum < 200)
            {
                // Increment your variable by 1 - Done
                myNum++;
                // Then add your variable to "numbers" - Done
                numbers.Add(myNum);
            }

            Console.WriteLine($"Increase:");

            // Create a foreach loop
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            // Write your variable to the console

            Console.WriteLine($"{myNum}");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i-=2)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers[i]);
            }
           
        }
    }
}
