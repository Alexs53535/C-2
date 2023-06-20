// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = ReadInt ("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.Write(InCenter(number));
}

// Функции принимает для отображения в консоли и результат введенных данных пользователем
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функции вывода цифра стоящей в середине трехзначного числа
int InCenter(int a)
{
    int result = ((a / 10) % 10);

return result;
}