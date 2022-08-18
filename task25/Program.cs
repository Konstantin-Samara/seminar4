// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!
Console.Write("Введите число : ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение степени : ");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number2>0) {
    int sum = Number;
    for (int i=2; i<=Number2; i++) {sum = sum*Number;}
    Console.WriteLine($"Результат : {sum}");}
else {Console.WriteLine($"Введенное значение степени : {Number2} не натуральное");}