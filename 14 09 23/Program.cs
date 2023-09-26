using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise 1");
        //Пользователь вводит с клавиатуры три числа.
        //Необходимо подсчитать количество последовательно этих трех чисел в массиве. 
        //Например: пользователь ввел: 7 6 5; массив: 7 6 5 3 4 7 6 5 8 7 6 5;
        //количества повторений по последовательности: 3.


        Console.WriteLine("Enter three numbers separated by a space:");//пользователь вводит 3 числа
        string input = Console.ReadLine();

        
        string[] inputNumbers = input.Split(' ');// Разбиваем введенную строку на числа

        if (inputNumbers.Length != 3)
        {
            Console.WriteLine("You entered the wrong number of numbers.");
            return;
        }

        
        int[] userInput = new int[3];// Преобразуем введенные строки в целые числа
        for (int i = 0; i < 3; i++)
        {
            userInput[i] = Convert.ToInt32(inputNumbers[i]);
        }

        int[] sequenceArray = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

        int sequenceCount = 0; // Счетчик для подсчета совпадений последовательности

        
        for (int i = 0; i < sequenceArray.Length - 2; i++)// Проходим по массиву и ищем совпадения
        {
            if (sequenceArray[i] == userInput[0] &&
                sequenceArray[i + 1] == userInput[1] &&
                sequenceArray[i + 2] == userInput[2])
            {
                sequenceCount++;
            }
        }
        Console.WriteLine("Array:");
        for (int i = 0; i < sequenceArray.Length; i++)
        {
            Console.Write(sequenceArray[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Number of sequence repetitions: {sequenceCount}");

        Console.WriteLine("Exercise 2");
        //Даны 2 массива размеров M и N соответственно.
        //Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };

        
        HashSet<int> uniqueElements = new HashSet<int>();// Создаем HashSet для хранения уникальных элементов

        
        foreach (int element in array1)// Добавляем элементы из первого массива 
        {
            uniqueElements.Add(element);
        }

        
        foreach (int element in array2)// Добавляем элементы из второго массива 
        {
            uniqueElements.Add(element);
        }

       
        int[] resultArray = new int[uniqueElements.Count]; 
        uniqueElements.CopyTo(resultArray);

        // Выводим результат
        Console.WriteLine("Common Unique Elements:");
        foreach (int element in resultArray)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("Exercise 3");

        //Разработайте приложение, которое будет использовать минимальное
        //и максимальное значение в двумерном массиве.
        int rows = 5;
        int cols = 5;

        
        int[,] array = new int[rows, cols];
        Random random = new Random();//заполняем массив случайными числами

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 101); // Заполняем случайными числами от 1 до 100
            }
        }

        // Выведите массив на экран
        Console.WriteLine("Two-dimensional array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

       
        int minValue = array[0, 0]; // Найдите минимальное значение в массиве
        int maxValue = array[0, 0]; // Найдите максимальное значение в массиве

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                }
                if (array[i, j] > maxValue)
                {
                    maxValue = array[i, j];
                }
            }
        }

        
        Console.WriteLine($"Minimum value: {minValue}");//  минимальное  значение
        Console.WriteLine($"Maximum value: {maxValue}");//  максимальное значение
    }
}



















