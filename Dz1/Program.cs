
// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6
int Prompt( string message );
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
int GetThirdRank(int number)
{
while (number>999)
{
    number /=10;
}
return number%10;
}
bool VaildateNumber(int number)
{

if (number <100)
{
    Console.WriteLine ("Третьей цифры нету");
    return false;
}
    return false;
}

int number = Prompt("Введите число >");
if (VaildateNumber (number))
{
    Console.WriteLine(GetThirdRank(number));
}