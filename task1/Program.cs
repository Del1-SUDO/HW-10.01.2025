using System;
class Program{
     static void Main(){
        Console.Write("Enter the price: ");
        double price = double.Parse(Console.ReadLine());

        if (price<50){
            Console.WriteLine(price*(1-0.05));
        }
        else if (price>=50 && price<100){
            Console.WriteLine(price*(1-0.10));
        }
        else {
            Console.WriteLine(price*(1-0.15));
        }
     }
}