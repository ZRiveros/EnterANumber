using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp1Exercises.ArraysAndLists
{
/// <summary>
/// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
/// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
/// and display the result on the console.
/// </summary>
    public class Lists
    {
        static void Main(string[] args)
        {
            //Creates a list to save the numbers
            var numbers = new List<int>();
            //While-loop that continues until 5 numbers are registered
            while (numbers.Count <5) 
            {
                //Asks the user to enter a number
                Console.Write("Enter 5 unique numbers of your choice: ");
                //Reads the users registered number and converts it to a decimal
                var number = Convert.ToInt32(Console.ReadLine());
                //if-loop that controlls if the number is already registered
                if (numbers.Contains(number))
                {
                    //Writes out if you already entered a Unique number
                    Console.Write("You've previously entered " +  number);
                    //Continues in the loop and jumps to next
                    continue;
                }
                //Adds the number to list if it's Unique
                numbers.Add(number);
            }
            //Sorts the list in raising number
            numbers.Sort();
            //Writes out all the numbers in the registered list
            foreach (var number in numbers)
                Console.WriteLine(number);

        }
    }
}

//Step-by-step explanation:

// 1 List to store numbers:
// var numbers = new List<int>(); creates a dynamic list that can store integers.

// 2 While-loop:
// The loop continues as long as the number of elements in the list is less than 5 (numbers.Count < 5).

// 3 Reading the user's input:
// Console.ReadLine() takes text from the user, and Convert.ToInt32() converts it to an integer.

// 4 Checking for duplicate numbers:
// numbers.Contains(number) checks if the entered number is already in the list.
// If the number is there, the user is informed with Console.WriteLine and the loop continues with continue.

// 5 Adding a unique number:
// If the number is not in the list, it is added with numbers.Add(number).

// 6 Sorting the list:
// numbers.Sort(); sorts the list in ascending order.

// 7 Printing the numbers:
// A foreach loop is used to iterate through the list and print each number.