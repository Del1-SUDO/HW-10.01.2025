using System;
class Program{
     static void Main(){
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());

        if (b>a){
            a=b;
        }
        if (c>a){
            a=c;
        }
        System.Console.WriteLine($"Максимальное число: {a}");
     }
}