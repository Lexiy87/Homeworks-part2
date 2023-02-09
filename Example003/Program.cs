// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        System.Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 8)
        {
            break;
        }
        else System.Console.WriteLine("Не правильный ввод, повторите");
    }
    return result;
}

int number = GetNumber("Введите цифровое значения дня недели");

if (number > 5)
{
    System.Console.WriteLine("Сегодня выходной");

}
else System.Console.WriteLine("Сегодня будний день");
