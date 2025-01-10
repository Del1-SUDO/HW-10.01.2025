using System;
class Program{
     static void Main(){
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        int cnt = 0;
        for(int i=1; i<=number; i++){
            if(number%i==0) {
                cnt++;
            }
        }
        if (cnt<=2){
            System.Console.WriteLine("Простое число: Да");
        }
        else if (cnt>2){
            System.Console.WriteLine("Простое число: Нет");
        }
        else {
            System.Console.WriteLine("Error!");
        }
     }
}