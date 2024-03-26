using System;

namespace Assembly {

  class Student {
   internal string name = "Sheeran";
  }

  class Program {
    static void Main(string[] args) {
    
      // creating object of Student class
      Student theStudent = new Student();
      
      // accessing name field and printing it
      Console.WriteLine("Name: " + theStudent.name);
      Console.ReadLine();
    }
  }
}