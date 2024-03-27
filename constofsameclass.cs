using System;
 
namespace ThisKeyword {
  class Test {
    
    Test(int num1, int num2) {

      Console.WriteLine("Constructor with two parameter");
    }
    
    // invokes the constructor with 2 parameters
    Test(int num) : this(33, 22) {

      Console.WriteLine("Constructor with one parameter");
    }

    public static void Main(String[] args) {

      Test t1 = new Test(11); 
      Console.ReadLine();   
    }
  }
}