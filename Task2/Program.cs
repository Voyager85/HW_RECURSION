// Задача 2:
// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

void FillValues(string[] input, int[] val, int index)
{
    if (index >= input.Length)
    {
        return;
    }
    val[index] = Convert.ToInt32(input[index]);
    FillValues(input, val, index + 1);
}

int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkerman(m-1, 1);
    else return akkerman(m-1, akkerman(m, n-1));
}

System.Console.WriteLine("Задайте два неотрицательных  значения через разделитель:");
string inputString = Console.ReadLine();
System.Console.WriteLine("Введено: " + inputString);
char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\n', '\t' };
string[] tmpstr = inputString.Split(delimiterChars);
int[] values = new int[tmpstr.Length];

if (values.Length != 2)
{
    System.Console.WriteLine("Введите только 2 значения");
    return;
}

FillValues(tmpstr, values, 0);
Console.WriteLine($"Функция Аккермана : {akkerman(values[0], values[1])}");
