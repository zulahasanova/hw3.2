﻿дз семинар 3.2

/*Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


int a = new Random().Next(100, 1000);
int b = a / 10 % 10;
    Console.Write($"{a} -> {b}");

    //1 число = а / 100
    //2 число = a / 10 % 10
    //3 число = а % 10

/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите день недели: ");
int numberDayofWeek = int.Parse(Console.ReadLine()!);

while(numberDayofWeek < 1 || numberDayofWeek > 7){
    Console.Write("Введен неправильный номер");
    return;}
if(numberDayofWeek > 0 && numberDayofWeek < 6)
    Console.Write("нет");
else
    Console.Write("да");

 /*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = 0;
if(a >= 100)
{
  while(a > 1000) //пока а будет до 1000, а / 10, показывает трехзначное число
  {
    a = a / 10;
  }
  //у трехзначнго числа находим 3 число
  b = a % 10;
  Console.Write($"{a} -> {b}");
}
else
{
    Console.Write($"{a} -> третьей цифры нет");
}