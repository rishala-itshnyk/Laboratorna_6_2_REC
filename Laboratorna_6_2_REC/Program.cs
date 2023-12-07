using System;

namespace Laboratorna_6_2_REC
{
    public class Program
    {
        static void FillArrayRecursive(int[] arr, int n, int index)
        {
            if (index < n)
            {
                arr[index] = int.Parse(Console.ReadLine());
                FillArrayRecursive(arr, n, index + 1);
            }
        }

        static void FillArray(int[] arr, int n)
        {
            FillArrayRecursive(arr, n, 0);
        }

        static void PrintArrayRecursive(int[] arr, int n, int index)
        {
            if (index < n)
            {
                Console.Write($"{arr[index]} ");
                PrintArrayRecursive(arr, n, index + 1);
            }
            else
            {
                Console.WriteLine();
            }
        }

        static void PrintArray(int[] arr, int n)
        {
            Console.Write("Array: ");
            PrintArrayRecursive(arr, n, 0);
        }

        public static void FindMinMaxRecursive(int[] arr, int n, int index, ref int min, ref int max)
        {
            if (index >= n)
            {
                return;
            }
            if (arr[index] < min)
            {
                min = arr[index];
            }
            if (arr[index] > max)
            {
                max = arr[index];
            }

            FindMinMaxRecursive(arr, n, index + 1, ref min, ref max);
        }

        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.Error.WriteLine("Invalid array size");
                return;
            }

            int[] arr = new int[n];

            Console.WriteLine($"Enter {n} elements for the array:");
            FillArray(arr, n);
            PrintArray(arr, n);

            int minValue = int.MaxValue, maxValue = int.MinValue;
            FindMinMaxRecursive(arr, n, 0, ref minValue, ref maxValue);
            Console.WriteLine($"Min (recursive): {minValue}");
            Console.WriteLine($"Max (recursive): {maxValue}");
        }
    }
}