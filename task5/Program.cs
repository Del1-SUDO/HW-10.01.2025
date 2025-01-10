using System;
class Program {
    static void Main() {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);
        if (isPalindrome) { 
            Console.WriteLine("Палиндром: Да"); 
        } 
        else { 
            Console.WriteLine("Палиндром: Нет"); 
        }
    }

    static bool IsPalindrome(string str) {
        int left = 0;
        int right = str.Length - 1;

        while (left < right) {
            if (str[left] != str[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
