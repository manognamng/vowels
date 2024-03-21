using System;
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Enter the string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                revs += s[i].ToString();
            }
            if (revs == s)   
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
