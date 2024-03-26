using System;

namespace ContinueForeach {
  class Program {
    static void Main(string[] args) {

      int[] num = { 1, 2, 3, 4, 5 };
      foreach(int number in num) {

        // skips the iteration
        if(number==3) {
          continue; 
         }

        Console.WriteLine(number);
      }
    }
  }
}