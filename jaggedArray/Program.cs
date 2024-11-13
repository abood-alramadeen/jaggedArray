// See https://aka.ms/new-console-template for more information

/* jagged array is an array of arrays where the inner arrays can
 * have different lengths. Unlike a multi-dimensional array 
 * (which is a grid with equal-sized rows and columns),
 * a jagged array allows you to have rows of varying lengths.
 * 
 * 
 * Declaring a Jagged Array

int[][] jaggedArray = new int[3][];
Here, int[][] indicates that jaggedArray is an array of arrays (jagged array).
The outer array has 3 elements (new int[3][]), meaning it can hold 3 inner arrays.
Step 2: Initializing Inner Arrays

Each element of the outer array is an inner array that can have a different length.
jaggedArray[0] = new int[4]; initializes the first inner array with 4 elements.
jaggedArray[1] = new int[2]; initializes the second inner array with 2 elements.
jaggedArray[2] = new int[3]; initializes the third inner array with 3 elements.
Step 3: Assigning Values to the Jagged Array

We can now assign values to each inner array.
jaggedArray[0] = new int[] { 1, 2, 3, 4 }; assigns values 1, 2, 3, 4 to the first inner array.
Similarly, jaggedArray[1] and jaggedArray[2] are assigned different sets of values.
Step 4: Displaying the Elements

A nested for loop is used to iterate over the outer and inner arrays.
The outer loop (for (int i = 0; i < jaggedArray.Length; i++)) iterates through the rows (inner arrays).
The inner loop (for (int j = 0; j < jaggedArray[i].Length; j++)) iterates through the elements of each inner array.
This prints out the values in each row with their respective lengths.*/



//////////////////////////////////////////////////////////////////////////////////////////////

/*using System;

class Program
{
	static void Main()
	{
		// Step 1: Declare the jagged array
		int[][] jaggedArray = new int[3][];

		// Step 2: Initialize the inner arrays with different lengths
		jaggedArray[0] = new int[4]; // First inner array has 4 elements
		jaggedArray[1] = new int[2]; // Second inner array has 2 elements
		jaggedArray[2] = new int[3]; // Third inner array has 3 elements

		// Step 3: Assign values to the elements of the jagged array
		jaggedArray[0] = new int[] { 1, 2, 3, 4 };
		jaggedArray[1] = new int[] { 5, 6 };
		jaggedArray[2] = new int[] { 7, 8, 9 };

		// Step 4: Display the elements of the jagged array
		for (int i = 0; i < jaggedArray.Length; i++)
		{
			Console.Write("Row " + i + ": ");
			for (int j = 0; j < jaggedArray[i].Length; j++)
			{
				Console.Write(jaggedArray[i][j] + " ");
			}
			Console.WriteLine();
		}
	}
}
*/
/////////////////////////////////////////////////////////////////////////////////////////
///
//exception handling 

/*The try Block:

The try block contains the code that might throw an exception.
In this example, we prompt the user for a number, convert the 
input to an integer, and attempt to divide 100 by that number. If any errors occur in this block, 
execution is transferred to the appropriate catch block.
The catch Block:

catch blocks are used to handle exceptions that occur in the try block.
In this example, there are two catch blocks:
FormatException: This block handles the case where the user enters something that 
cannot be converted to an integer (e.g., letters or symbols). It prints an error message along 
with the details of the exception.
DivideByZeroException: This block catches the specific case where division by zero occurs,
preventing the program from crashing.
You can include multiple catch blocks to handle different types of exceptions.
The finally Block:

The finally block is optional and contains code that will always execute, regardless of whether
an exception was thrown or not.
In this example, it prints a message saying the program execution is complete. This is useful 
for cleanup operations, like closing files or releasing resources, no matter what happens
in the try block.*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Code that may throw an exception
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Intentional division by zero to trigger an exception
            int result = 100 / number;

            Console.WriteLine($"The result of 100 / {number} is {result}");
        }
        catch (FormatException ex)
        {
            // Handle if the user inputs a non-numeric value
            Console.WriteLine("Error: Please enter a valid number.");
            Console.WriteLine($"Exception Details: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            // Handle division by zero case
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Exception Details: {ex.Message}");
        }
        finally
        {
            // Code that will always run, regardless of an exception
            Console.WriteLine("Program execution completed.");
        }
    }
}
*/
/////////////////////////////////////////////////////////////////////////////////
//Fibonacci Sequence Example 

/*
using System;

class Program
{
    // Recursive method to calculate Fibonacci number
    static int Fibonacci(int n)
    {
        // Base cases: 
        // If n is 0, the Fibonacci number is 0
        // If n is 1, the Fibonacci number is 1
        if (n == 0) return 0;
        if (n == 1) return 1;

        // Recursive case:
        // Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Fibonacci terms to generate: ");
        int terms = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}

*/