using System;

namespace MyApplication {

  class Student {
    protected string name = "Sheeran";
  }

  class Program {
    static void Main(string[] args) {
    
      // creating object of student class
      Student student1 = new Student();
      
      // accessing name field and printing it
      Console.WriteLine("Name: " + student1.name);
      Console.ReadLine();
    }
  }
}