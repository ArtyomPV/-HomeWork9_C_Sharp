/*
Задача 64: Написать рекурсивную функцию перевода 
из десятичной системы исчисления в двоичную.
*/
//====================== task 1 ========================

//  void ConvertDecToBin(int n){
//     string binNumber = string.Empty;
//     if(n!=0) ConvertDecToBin(n/2);
//     binNumber+=n%2;
//     Console.Write(binNumber);
//      }
// Console.Write("Enter a decimal number: ");
// int decNumber = Convert.ToInt32(Console.ReadLine());
// ConvertDecToBin(decNumber);
/*
Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму
  натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

//====================== task 2 ========================
int SumLineMN(int m, int n){
    if(m>=n){
        Console.WriteLine("the 1st must be less than the 2d number!");
        return 0;
    }
        if(m <= n)  return SumLineMN(m+1, n) + m;
    else return 0;
}
Console.Write("Enter a 1st number: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a 2d number: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
int sum = SumLineMN(startNumber, endNumber);
if(sum > 0)
Console.Write(sum);