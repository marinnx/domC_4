// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetData(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}
int GetSumm(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    } 
    return summ;
}
int numberN = GetData("Введите число: ");
Console.WriteLine($"Сумма цифр числа {numberN} равна {GetSumm(numberN)}");