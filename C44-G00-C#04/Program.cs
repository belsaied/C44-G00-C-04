namespace C44_G00_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1 : Enter 3 points and check if they're in the same line .
            //Console.WriteLine("Enter point 1 (x1, y1):");
            //double x1, y1;
            //ReadPoint(out x1, out y1);

            //Console.WriteLine("Enter point 2 (x2, y2):");
            //double x2, y2;
            //ReadPoint(out x2, out y2);

            //Console.WriteLine("Enter point 3 (x3, y3):");
            //double x3, y3;
            //ReadPoint(out x3, out y3);

            //// Check if the points are in the same line using the area of the triangle method
            //double area = 0.5 * ((x1 * (y2 - y3)) + (x2 * (y3 - y1)) + (x3 * (y1 - y2)));

            //if (area == 0)
            //{
            //    Console.WriteLine("The points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do NOT lie on the same straight line.");
            //} 
            #endregion

            #region Q2 : calculate the efficiency of the worker base on the hours he spend to perform a task:
            //Console.WriteLine("Enter time taken by the worker (in hours): ");
            //string input = Console.ReadLine();

            //// using switch C# 09
            //if (double.TryParse(input, out double timeTaken))
            //{
            //    string message = timeTaken switch
            //    {
            //        >= 2 and < 3 => "Worker is highly efficient.",
            //        >= 3 and < 4 => "Worker should increase their speed.",
            //        >= 4 and <= 5 => "Worker will be given training to improve speed.",
            //        > 5 => "Worker has to leave the company.",
            //        _ => "Invalid input."

            //    };

            //    Console.WriteLine(message);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid numeric value for time.");
            //}
            #endregion

            #region Q3 : Sum of all Elements in array:
            //Console.WriteLine("Enter the number of elements in the array: ");
            //int n;

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer: ");
            //}

            //int[] numbers = new int[n];

            //for (int i = 0; i < numbers.Length ; i++)
            //{
            //    Console.WriteLine($"Enter element #{i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer: ");
            //    }
            //}

            //int sum = numbers.Sum();
            //Console.WriteLine($"The sum of all elements in the array is: {sum}");
            #endregion

            #region Q4 : Merge 2 arrays in the same size sorted in asc order.
            //int size;

            //// Ask for the array size with validation
            //Console.WriteLine("Enter the size of the arrays: ");
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer: ");
            //}

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];

            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array1[i] = ReadInteger($"Element [{i + 1}] of array 1: ");
            //}

            //Console.WriteLine("Enter elements for the second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array2[i] = ReadInteger($"Element [{i + 1}] of array 2: ");
            //}
            //// Merge the two arrays
            //int[] merged = new int[size * 2];
            //array1.CopyTo(merged, 0);
            //array2.CopyTo(merged, size);

            //// Sort in ascending order
            //Array.Sort(merged);

            //// Display result
            //Console.WriteLine("Merged and Sorted Array:");
            //Console.WriteLine(string.Join(", ", merged));
            #endregion

            #region Q5 : find longest distance between 2 equal cells:
            //Console.WriteLine("Enter the elements of the array separated by ,:");
            //string[] input = Console.ReadLine().Split(',');

            //int[] array = new int[input.Length];

            //// Validate input: convert to integers
            //for (int i = 0; i < input.Length; i++)
            //{
            //    while (!int.TryParse(input[i], out array[i]))
            //    {
            //        Console.WriteLine($"Invalid input '{input[i]}'. Please enter an integer: ");
            //        input[i] = Console.ReadLine();
            //    }
            //}


            //int maxDistance = -1;
            //int valueWithMax = 0;


            //// Loop through each pair of elements
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = array.Length - 1; j > i; j--)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                valueWithMax = array[i];
            //            }
            //            break; 
            //        }
            //    }
            //}


            //if (maxDistance >= 0)
            //{
            //    Console.WriteLine($"Longest distance is {maxDistance} between two '{valueWithMax}' cells.");
            //}
            //else
            //{
            //    Console.WriteLine("No repeated values found.");
            //}
            #endregion

            #region Q6 :Given a list of space separated words, reverse the order of the words.
            Console.WriteLine("Enter a list of words separated by spaces:");
            string input = Console.ReadLine();

            // Split the string into words
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Reverse the array
            Array.Reverse(words);

            // Join the words back into a single string
            string reversed = string.Join(" ", words);

            Console.WriteLine("Reversed word order:");
            Console.WriteLine(reversed);
            #endregion
        }

        // Reads a point in the format (x,y) and make sure that the input is double digits.
        static void ReadPoint(out double x, out double y)
        {
            x = 0;
            y = 0;

            while (true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Trim().Split(',');

                if (parts.Length == 2 && double.TryParse(parts[0], out x) && double.TryParse(parts[1], out y))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter the point in the format (x,y)");
                }
            }
        }

        // Reads an integer with validation
        static int ReadInteger(string message)
        {
            int result;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return result;
        }
    }
}
