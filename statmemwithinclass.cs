using System;
 
namespace StaticKeyword {
 
  class Test {
 
    static int age = 25;
    public static void display() {
 
      Console.WriteLine("Static method");
    }
   
    static void Main(string[] args) {
 
      Console.WriteLine(age);
      display();
      Console.ReadLine();
    }
  }
}