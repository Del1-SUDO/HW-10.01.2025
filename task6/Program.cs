using System;
class Program{
     static void Main(){
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        int cnt = 0;
        for(int i=1; i<=number; i++){
            if (i%2==0){
                cnt+=i;
            }
        }
        System.Console.WriteLine($"Сумма четных чисел: {cnt}");
     }
}