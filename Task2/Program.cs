/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int totalsum = 0;
int GetSumNumbers(int m, int n)
{
    
    if (m==n)
    {
        return totalsum + n;
    }
    else
    {
       return totalsum = m + GetSumNumbers(m+1, n);
    }
}
Console.WriteLine(GetSumNumbers(4,8));
