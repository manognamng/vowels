using System;

namespace Inheritance {

  // base class
  class Animal { 
    public virtual void eat() {

      Console.WriteLine("Animals eat food.");
    }
  } 
  
  // derived class of Animal 
  class Dog : Animal {

    // overriding method from Animal
    public override void eat() {
      
      // call method from Animal class
      base.eat();
      
      Console.WriteLine("Dogs eat Dog food.");
    }     
  }
  class Program {

    static void Main(string[] args) {

      Dog labrador = new Dog();
      labrador.eat();
    }
  }
}