// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
// этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//принимает на вход трёхзначное число
// int GetNumber (string message)
// {
//     System.Console.WriteLine(message);
//     int number = Convert.ToInt32 (Console.ReadLine ());
//     return number;
// }


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result<1000 && result>99)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы не ввели трехзначное число. Повторите ввод");
        }
    }

    return result;
}
// на выходе показывает вторую цифру этого числа
int GetDigitNumber (int number)
{
    int digit1 = number/100;
    int digit2 = number%10;
    int SecondDigit = (number -(digit1*100 + digit2))/10;
    return SecondDigit;    
}
int number = GetNumber ("Введите трехзначное число");
int SecondDigit = GetDigitNumber (number);

System.Console.WriteLine("Вторая цифра трехзначного числа "+ SecondDigit);



