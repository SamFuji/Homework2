Console.Clear();
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine ("Enter the number from 100 to 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100 || number > 999)
// {
//     do
//     {
//     Console.WriteLine ("Wrong number!Enter the number from 100 to 999: ");
//     Int32.TryParse(Console.ReadLine(), out number);
//     } while (number < 100 || number > 999);
// }               
// number = number/10;
// int SecondNumber =  number % 10;
// Console.WriteLine("The second number is " + SecondNumber);  




    
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Enter the number:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(N);
// if (N<100)
// {
//     Console.Write("Third number doesn't exist");
// }
// else if (N>999) //Примечания: с использованием while вместо if, консоль выводит все значения остатков от деления, пока число на станет третьего разряда
// {
//     while (N>999) //если после ИФ не поставить ВАЙЛ, то консоль закончит программу выводом остатка от первого деления числа
//     N = N/10;
//     {
//     int thirdNumber = N % 10;
//     Console.WriteLine("The tird number is " + thirdNumber);
//     }
// }





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Enter the number:");
int Day = Convert.ToInt32(Console.ReadLine());
int holyday = Day % 7;
if (holyday == 0 || holyday == 6)
{
    Console.WriteLine($"The {Day} is holiday!!!");
}
else
{
    Console.WriteLine("Работаем с 09:00 и до изнеможения. Изнемогаем в 18:00 каждый день, пока не наступит суббота.");
}

// 6 -> да
// 7 -> да
// 1 -> нет