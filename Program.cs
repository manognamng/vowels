// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    public static void Main()
    {
        string inputstring;
        int i, len, vowels, consonants;

        inputstring = "manogna";
        vowels = 0;
        consonants = 0;
        len = inputstring.Length;
        for (i = 0; i < len; i++)
        {         
            var alphabet = inputstring[i];
            if (char.ToUpper(alphabet) == 'A' || char.ToUpper(alphabet) == 'E' || char.ToUpper(alphabet) == 'I' || char.ToUpper(alphabet) == 'O' || char.ToUpper(alphabet) == 'U')
            {
                vowels++;         
            }    
            else if (char.ToUpper(alphabet)>='A' && char.ToUpper(alphabet)<='Z')
            {               
                consonants++;
            }
        }       
        Console.WriteLine("count of vowel = " + vowels);
        Console.WriteLine("count of consonant = " + consonants);
    }
}