// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

//Заполнение массива

int[] GetBinaryArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {

        array[i] = new Random().Next(-100,100);

    }
    return array;
}
Console.WriteLine("Введиде размер массива: ");
int[] resultArray = GetBinaryArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");

//Нахождение суммы не четных элементов массива

int size = resultArray.Length;
int sum = 0;
for (int i = 1; i < size; i += 2)
{
    sum=sum+resultArray[i];
}
Console.WriteLine($"Сумма элементов массива с не четными индексами = {sum}");