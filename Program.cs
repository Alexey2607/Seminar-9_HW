// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// string Method(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + "  " + Method(start - 1, end));
// }
// Console.WriteLine(Method(n, 1));

// ____________________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// int Method(int start, int end)

// {
//     if (start == end)
//     {
//         return (start);
//     }
//     if (start>end)
//     {
//         Console.WriteLine("Числа введены некорректно");
//         return(0);
        
//     }
//     return(start + Method(start+1,end));
// }
// Console.WriteLine(Method(m,n)); 

// // ___________________________________________________________________________________

