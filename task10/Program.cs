using System;
class Program {
    static void Main() {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        long[] fibonachi = new long[n];

        for (int i = 0; i < n; i++) {
            if (i == 0) {
                fibonachi[i] = 0;
            } else if (i == 1) {
                fibonachi[i] = 1;
            } else {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }
        }

        for (int i = 0; i < n; i++) {
            Console.Write(fibonachi[i]);
            if (i < n - 1) {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
