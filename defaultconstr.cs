using System;

namespace Constructor {

  class Program {  

    int a;

    static void Main(string[] args) {

      // call default constructor
      Program p1 = new Program();

      Console.WriteLine("Default value of a: " + p1.a);
      Console.ReadLine();
     
    }
  }
}