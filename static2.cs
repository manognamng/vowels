using System;

namespace StaticKeyword {

  static class Test {
    static int a = 5;
    static void display() {

      Console.WriteLine("Static method");
    }
  
    static void Main(string[] args) {

      // creating object of Test
      Test t1 = new Test();
      Console.WriteLine(a);
      display();
    }
  }
}