using System;

namespace Constructor {

  class Car {  
  
   // private constructor
   private Car () {
    Console.WriteLine("Private Constructor");    
    }
  }
    
    class CarDrive {

      static void Main(string[] args) {

      // call private constructor
      Car car1 = new Car();
      Console.ReadLine();
    }
  }
}