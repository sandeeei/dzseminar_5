// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Заполнение массива

int[] GetBinaryArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {

        array[i] = new Random().Next(-100, 100);

    }
    return array;
}
Console.WriteLine("Введиде размер массива: ");
int[] resultArray = GetBinaryArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Массив: [ {String.Join("; ", resultArray)} ]");
//Задаем размер нового массива в котором будет результат .
int size = resultArray.Length;
int result = 1;
int newsize=0;
if(size%2==0)
{
    newsize=size/2;
}
else
{
    newsize=(size/2+1);
}

// произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Запись результата в новый массив
int[] NewArray=new int[newsize];

for (int i = 0; i < size; i++)
{
    if (i==(size-1))
    {
        result=resultArray[i];
        NewArray[i] = result;
    }
    else
    {
    result = resultArray[i] * resultArray[size - 1];
    NewArray[i] = result;
    size--;
    }
}
Console.WriteLine($"Массив: [ {String.Join("; ", NewArray)} ]");