using System;

class Program {
    static void Main() {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Random rand = new Random();
        for (int i = 0; i < n; i++) {
            numbers[i] = rand.Next(1, 51);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        double average = total(numbers);
        Console.WriteLine("Среднее значение: " + average);
    }

    static double total(int[] numbers) {
        double sum = 0;
        foreach (int num in numbers) {
            sum+=num;
        }
        return sum/numbers.Length;
    }
}
