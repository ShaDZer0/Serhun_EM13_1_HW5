using System;
using System.Linq;

namespace Serhun_EM13_1_HW5
{
    internal class Program
    {
        //Task 1
        static void vivodRazdeliteley(string razdelitel)
        {
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat(razdelitel, 50)));
        }
        static int[] createArray(int size,int min, int max)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }
        static int[] sortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
        static void arrayOutput(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Task2
            int size = 100, min = 100, max = 901, sum = 0;
            int[] array = createArray(size, min, max);
            Console.WriteLine("Array: ");
            arrayOutput(array);
            //a
            vivodRazdeliteley("-");
            Console.WriteLine("Numbers greater than 500 in the array: ");
            for(int i = 0; i < size; i++)
            {
                if (array[i] > 500)
                {
                    Console.Write(array[i]+ " ");
                }
            }
            vivodRazdeliteley("-");
            //b
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            Console.Write("Sum of numbers in an array: " + sum);
            vivodRazdeliteley("-");
            //c
            Console.WriteLine("Numbers divisible by 5 in an array:");
            for (int i = 0; i < size; i++) { 
                if (array[i] % 5 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
            vivodRazdeliteley("-");
            //d
            min = array[0];
            max = array[0];
            for (int i = 0; i < size; i++)
            {
                if (min > array[i])
                    min = array[i];
                else if (max < array[i])
                    max = array[i];
            }
            Console.Write("Min number in an array: "+ min +"\nMax number in an array: "+ max);
            //e
            vivodRazdeliteley("-");
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] >= 500 && array[i] <= 600)
                {
                    count++;
                }
            }
            Console.Write("Count of numbers in an array between 500 and 600: " + count);
            //f
            vivodRazdeliteley("-");
            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0)
                    Console.Write(array[i] + " ");
            }
            //g
            vivodRazdeliteley("-");
            double average = (double)sum / size;
            Console.Write("Average of numbers in an array: " + average);
            //h
            vivodRazdeliteley("-");
            count = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] < average)
                    count++;
            }
            Console.Write("Count of numbers in an array less than average: " + count);
            //i
            vivodRazdeliteley("-");
            int[] srtarray = sortArray(array);
            count = size-1;
            while (srtarray[count] == srtarray[size-1])
            {
                count--;
            }
            Console.Write("The second largest number in the array: " + srtarray[count]);
            //j
            vivodRazdeliteley("-");
            Console.WriteLine("Numbers in the array that contain 7: ");
            for (int i = 0; i < size; i++)
            {
                int num = array[i];
                while (num > 0)
                {
                    if (num % 10 == 7)
                    {
                        Console.Write(array[i] + " ");
                        break;
                    }
                    num /= 10;
                }
            }
            vivodRazdeliteley("-");
            //Task 3
            try
            {
                int[] numberCount = {0, 0, 0, 0, 0, 0};
                Console.WriteLine("Enter the length of the array: ");
                int length = Convert.ToInt32(Console.ReadLine());
                if (length < 1)
                {
                    throw new Exception("Length must be greater than 0");
                }
                int[] arr = new int[length];
                int arrayNum = 2;
                for (int i = 0; i < length; i++)
                {
                    arr[i] = arrayNum;
                    numberCount[arrayNum-2]++;
                    arrayNum++;
                    if (arrayNum > 7)
                    {
                        arrayNum = 2;
                    }
                }
                Console.WriteLine("Array: ");
                arrayOutput(arr);
                Console.WriteLine("Count of numbers in the array: ");
                for (int i = 2; i <= 7; i++)
                {
                    Console.WriteLine(i +": " + numberCount[i-2]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
