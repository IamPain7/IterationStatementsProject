using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO
            //STEP 1 Create a List called "numbers"
            //STEP 2 Create a variable of type int and initialize the variable with a value of 0 
            //STEP 3 Create a do-while loop 
            //STEP 4 Then add your variable to "numbers" 
            //STEP 5 Increment your variable by 1 
            //STEP 6 While your variable is less than 100
            var numbers = new List<int>(); // STEP 1 DONE
            int num = 0;   //STEP 2 DONE
            {               
            do                    // STEP 3
            {
            numbers.Add(num);    // STEP4
            num++;               //STEP 5
            } while (num < 100); //STEP 6   

            }
            //TODO 2
            //STEP 1 Create a while loop
            //STEP 2 While your variable is less than 200
            //STEP 3 Increment your variable by 1
            //STEP 4 Then add your variable to "numbers"
            {
                while (num < 200) ;

                numbers.Add(num);
                num++;
                
            }

            Console.WriteLine("Increase:");
            //TODO
            // Create a foreach loop
            // Write your variable to the console
            Console.WriteLine(num);
            Console.WriteLine("Decrease:");
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
            }
        }
    }
}
