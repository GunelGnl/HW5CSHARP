// Task 34 Задайте массив заполненный случайными положительными 
//трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
       Console.WriteLine("Enter array size:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        int countEven = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                countEven++;
            }
        }

        Console.WriteLine("The array contains " + countEven + " even numbers.");
        Console.ReadLine ();
    


    // Task36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

int[] arr = new int[4];
int sum = 0;
Random rand = new Random();
for (int i = 0; i < arr.Length; i++) {
arr[i] = rand.Next(100);
if (i % 2 != 0) {
sum += arr[i];
}
}
Console.WriteLine("Array:");
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine("Sum of elements  " + sum);
Console.ReadKey();
