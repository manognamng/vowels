using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the string:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the string:");
        char[] inputString = new char[x];
        for (int i = 0; i < x; i++)
        {
            inputString[i] = Convert.ToChar(Console.Read());
        }

        int vowels = 0;
        int consonants = 0;

        for (int i = 0; i < x; i++)
        {
            char currentChar = char.ToLower(inputString[i]);
            if (currentChar >= 'a' && currentChar <= 'z')
            {
                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("\nCount of vowels: " + vowels);
        Console.WriteLine("Count of consonants: " + consonants);
    }
}
