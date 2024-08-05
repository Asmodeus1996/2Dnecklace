using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Input the dimensions of the 2D array
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        int rows = (cols % 2 == 0) ? cols : cols + 1; // Ensure rows are even

        int[,] array = new int[rows, cols];

        // Fill the array as specified
        for (int j = 0; j < cols; j++)
        {
            int rowStart = j + 1; // Starting rows count for each column
            if (j >= cols / 2)
            {
                rowStart = cols - j; // Decreasing row count after middle
            }

            for (int i = 0; i < rowStart; i++)
            {
                array[i, j] = rand.Next(1, 100); // Fill with random numbers
            }
        }

        // Print the array
        Console.WriteLine("Generated 2D Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] != 0)
                    Console.Write(array[i, j] + "\t");
                else
                    Console.Write("\t");
            }
            Console.WriteLine();
        }

        // Calculate and print the sum of elements in each column
        Console.WriteLine("\nSum of elements in each column:");
        for (int j = 0; j < cols; j++)
        {
            int colSum = 0;
            for (int i = 0; i < rows; i++)
            {
                colSum += array[i, j];
            }
            Console.WriteLine($"Column {j + 1}: {colSum}");
        }
    }
}
