/*
   Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
    и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int num1 = ReadData("Введите число А: ");
int num2 = ReadData("Введите число B: ");

string LineNum(int i, int p)
{
    string outLine = "";
    outLine = outLine + Math.Pow(i, p);
    return outLine;
}

string degree = LineNum(num1, num2);

PrintData("Число A в натуральной степени B равно: ", degree);

