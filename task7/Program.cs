using System;
class Program{
     static void Main(){
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        factorial(number);
     }

     static void factorial(int number){
        int cnt = 1;
        for(int i=1; i<=number; i++){
            cnt*=i;
        }
        System.Console.WriteLine($"Факториал: {cnt}");
     }
}