// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int numreverse = 0;
int temp = num;

while (num > 0)
{
    int dig = num % 10;
    numreverse = numreverse * 10 + dig;
    num = num / 10;
}
   
if (temp == numreverse)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}

