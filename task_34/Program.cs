// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество
//   чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 10;
int count = 0;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
  array[i] = new Random().Next(100,1000); 
  if(array[i]%2==0)
  {
    count++;
  }
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Число четных чисел в данном массиве: {count}");