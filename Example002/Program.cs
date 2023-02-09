// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int GetNumber(string message) //ввод числа

{
    int result = 0;

    while (true)
    {
        System.Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            System.Console.WriteLine("Вы не ввели число, повторите ввод");
        }

    }
    return result;
}

int FindDigit(int number) //функция по поиску 3 числа
{
    int ThirdDigit = 0;
    if (number / 100 > 0)
    {
        ThirdDigit = number % 10;
        number = number * 10;
        
    }
    else 
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    
    return ThirdDigit;
}
int number = GetNumber("Введите число");
int ThirdDigit = FindDigit (number);
System.Console.WriteLine(ThirdDigit);






