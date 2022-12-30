/*
Задача 64: Написать рекурсивную функцию перевода 
из десятичной системы исчисления в двоичную.
*/
//====================== task 1 ========================

 void ConvertDecToBin(int n){
    string binNumber = string.Empty;
    if(n!=0) ConvertDecToBin(n/2);
    binNumber+=n%2;
    Console.Write(binNumber);
     }
Console.Write("Enter a decimal number: ");
int decNumber = Convert.ToInt32(Console.ReadLine());
ConvertDecToBin(decNumber);
/*
Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму
  натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

//====================== task 1 ========================