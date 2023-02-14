// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B:");
int num2 = int.Parse(Console.ReadLine());
int pow = Pow(num1, num2);
Console.Write(pow);
int Pow(int number1, int number2)
{
    int result = (int)Math.Pow(num1, num2);// гугл поведал, что Math.Pow возвращает значение типа double,
    // но при определении типа переменной result как double я получал ошибку:
    // "Не удается неявно преобразовать тип "double" в "int"" в следующей строке с "return result". В итоге нашёл решение с приведением
    // к типу int, но всё равно до конца не понял, в чём была ошибка. Буду благодарен за пояснения:)
    return result;
}
