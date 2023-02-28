// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// Создание массива

double[] GetBinaryArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {

        array[i] = Math.Round(100 * (new Random().NextDouble()), 2);

    }
    return array;
}
Console.WriteLine("Введите размер массива:");
double[] resultArray = GetBinaryArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Массив: [ {String.Join("; ", resultArray)} ]");
int size = resultArray.Length;
double max = resultArray[0];
double min = resultArray[0];
for (int i = 0; i < size; i++)
{
    if (resultArray[i] > max)
    {
        max = resultArray[i];

    }
    else if (resultArray[i] < min)
    {
        min = resultArray[i];
    }
}
double sum = max - min;
Console.WriteLine($"Разница между минимальным и максимальным значением массива =  {sum}");