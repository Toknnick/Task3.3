using System;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeOfArray = 30;
            int lastNumberInArray = sizeOfArray - 1;
            int firstNumberInArray = 0;
            int maxValueInArray = 1000;
            int minValueInArray = 0;
            int[] arrayOfNumbers = new int[sizeOfArray];
            int number = 1;
            Console.WriteLine("Массив:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(minValueInArray, maxValueInArray);
                Console.Write(arrayOfNumbers[i] + " ");
            }

            Console.WriteLine("\n");

            if (arrayOfNumbers[firstNumberInArray] > arrayOfNumbers[firstNumberInArray + number])
            {
                firstNumberInArray = arrayOfNumbers[firstNumberInArray];
                Console.WriteLine($"Локальный максимум - первый элемент {firstNumberInArray}");
            }

            if (arrayOfNumbers[lastNumberInArray] > arrayOfNumbers[lastNumberInArray - number])
            {
                lastNumberInArray = arrayOfNumbers[lastNumberInArray];
                Console.WriteLine($"Локальный максимум - последний элемент {lastNumberInArray}");
            }

            for (int i = number; i < sizeOfArray - number; ++i)
            {
                if (arrayOfNumbers[i] > arrayOfNumbers[i - number] && arrayOfNumbers[i] > arrayOfNumbers[i + number])
                {
                    Console.WriteLine("Локальный максимум:\t" + arrayOfNumbers[i]);
                }
            }
        }
    }
}
