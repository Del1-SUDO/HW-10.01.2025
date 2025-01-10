using System;
class Program{
     static void Main(){
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        if (number%2==0){
            Console.WriteLine("Четное");
        }
        else if (number%2==1){
            Console.WriteLine("Нечетное");
        }
        else {
            Console.WriteLine("Unknown error...");
        }
     }
}