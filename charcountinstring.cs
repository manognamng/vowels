using System;

public class Charcountinstring
{
    public static int count(string s, char c)
    {
        int res = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
                res++;
        }

        return res;
    }
    public static void Main()
    {
        string str = "Manogna";
        char c = 'e';

        Console.WriteLine(count(str, c));
    }
}
