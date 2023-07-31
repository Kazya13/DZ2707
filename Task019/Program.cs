// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> д

Console.WriteLine("Введите 5 значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 9999 || number > 99999)
{
    Console.WriteLine("Некорректные данные");
    return;
}
Palindrom(number);
void Palindrom (int num)
{
    int reverseNum = 0; 
    int x = num; 
    while(x != 0)
    {
      reverseNum = reverseNum * 10 + x % 10; 
      x /= 10;    
    }
if (num == reverseNum) Console.Write("Число Палиндром: ");
else Console.Write("Число не Палиндром");
}
