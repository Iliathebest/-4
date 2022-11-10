// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine(" any number a,please");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" any number b,please");
int b=Convert.ToInt32(Console.ReadLine());
int sum= a;
    for(int i = 1; i < b; i++)
          sum = sum * a;

Console.WriteLine( $"Результат возвидения {a} в степень{b}  равняется " + sum);