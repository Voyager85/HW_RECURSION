// Задача 3:
// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


void FillArray(int[] array, int min, int max)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(min, max);
        index++;
    }
}

void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write(array[index] + " ");
    }
    System.Console.WriteLine("");
}

void RecursivePrintArray(int[] array, int index)
{
    if (index > array.Length - 1) return;
    System.Console.Write(array[array.Length - index -1] + " ");
    RecursivePrintArray(array,index+1);
}

//Задаем произвольный массив целых чисел
int[] array = new int[10];
//Заполняем случайными числами в диапазоне от 1 до 30
FillArray(array, 1, 30);
// Выводим на дисплей
System.Console.Write("ЗАДАН МАССИВ:       ");
PrintArray(array);
// Выводим на дисплей с применением рекурсии начиная с конца
System.Console.Write("РЕКУРСИВНЫЙ МАССИВ: ");
RecursivePrintArray(array,0);
System.Console.WriteLine("");