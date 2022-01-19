using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var number = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(number);

            //Print the first number of the array
            Console.WriteLine($"{number[0]}");
            //Print the last number of the array            
            Console.WriteLine($"{number[number.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(number);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(number);
            Console.WriteLine("---------REVERSE CUSTOM------------");


            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(number);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(number);
            NumberPrinter(number);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numberList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"{numberList.Capacity}");
            Console.WriteLine("populate list with random numbers");
            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);
            Console.WriteLine("list populate complete!");
            //Print the new capacity
            Console.WriteLine("list new capacity");
            Console.WriteLine($"{numberList.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(numberList);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            numberList = OddKiller(numberList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            numberList.Sort();
            NumberPrinter(numberList); 
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var myArray = numberList.ToArray();

            //Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i =0;i < numbers.Length;i++)
            { 
                if(i % 3 == 0)
                { numbers[i] = 0; }
            }
            NumberPrinter(numbers);
        }

        private static List<int> OddKiller(List<int> numberList)
        {
            var evens = new List<int>();
            foreach(int num in numberList) 
           { 
                if (num % 2 == 0)
                { 
                    evens.Add(num); 
                }
           }
            NumberPrinter(evens);
            return evens;
        }

        private static void NumberChecker(List<int> numberList /*int searchNumber*/)
        {
           var userInput = Console.ReadLine();

            bool success = int.TryParse(userInput, out int number);
            if (success)
            {

                bool isFound = false;
                foreach (var num in numberList)
                {
                    if (num == number)
                    {
                        Console.WriteLine($"{num} is on the list!!");
                        isFound = true;
                    }
                }                    
                if (isFound == false)
                {
                    Console.WriteLine($" {number} is not on the list!");

                }

            }

        }

        private static void Populater(List<int> numberList)
        {
            for (var i = 0; i < 50; i++)
            {


                Random rng = new Random();
                var num = rng.Next(0, 50);
                numberList.Add(num);
            }
                NumberPrinter(numberList);
                
            
        }

        private static void Populater(int[] numbers)
        {
            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            for(var i = 0; i < numbers.Length; i++)
            {
            Random rng = new Random();
                numbers[i] = rng.Next(0,50);
            }
           
        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
