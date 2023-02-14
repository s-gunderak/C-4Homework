// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int num2 = int.Parse(Console.ReadLine());
int Pow(int number1, int number2)
{
    int result = Math.Pow(num1, num2);
    return result;
}
int pow = Pow(num1, num2);
Console.Write(pow);