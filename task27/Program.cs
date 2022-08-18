// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число : ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number>=0) {
    int sum=0;
    while (Number>=1) {
        sum=sum+Number%10;
        Number=Number/10; }
    Console.WriteLine($"Результат : {sum}");}
else Console.WriteLine($"Введенное число : {Number} не натуральное");