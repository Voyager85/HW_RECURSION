// Задача 1:
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Задайте минимальное и максимальное значение через разделитель:");
string inputString = Console.ReadLine();
System.Console.WriteLine("Введено: " + inputString);
char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\n', '\t' };
string[] tmpstr = inputString.Split(delimiterChars);
int[] values = new int [tmpstr.Length];

if (values.Length != 2 ) {
    System.Console.WriteLine("Введите только 2 значения");
    return;
}

void FillValues (string[] input, int[] val, int index) 
{
    if (index >= input.Length)
    {
        return;
    }
    val[index] = Convert.ToInt32(input[index]);
    FillValues(input,val,index+1);
}
void PrintValues(int[] val, int ind)
{
    int currVal = val[0] + ind;
    if (currVal > val[val.Length-1])
    {
        System.Console.WriteLine();
        return;
    }
    System.Console.Write(currVal + " ");
    PrintValues(val, ind+1);
}


FillValues(tmpstr,values,0);
PrintValues(values,0);