using System;
 
namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            char[] myArray = {'H','e','l','l','o'};
 
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
