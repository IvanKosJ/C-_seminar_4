//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

int number_A = GetInfo("Введите число A: ");
int number_B = GetInfo("Введите число B: ");
Console.WriteLine($"Результат возведения числа {number_A} в {number_B} степень - {ToDegree(number_A, number_B)}");