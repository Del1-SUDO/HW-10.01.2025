using System;
class Program{
     static void Main(){
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        Calculations(a,b);
     }

     static void Calculations(int a, int b){
        System.Console.Write($"Сумма: {a+b}, ");
        System.Console.Write($"Разность: {a-b}, ");
        System.Console.Write($"Произведение: {a*b}");
     }
}