// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetData(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}
int GetStepen(int osn, int pok)
{
    int step = 1;
    int i = 1;
    while (i <= pok)
    {
        step *= osn;
        i += 1;
    } 
    return step;
}
int numberA = GetData("Введите основание степени: ");
int numberB = GetData("Введите показатель степени: ");
int stepen = GetStepen(numberA, numberB);
Console.WriteLine($"При возведении числа {numberA} в натуральную степень {numberB} -> {stepen}");