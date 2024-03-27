using System;
 
namespace StaticKeyword {
 
  class Student {
    static public string schoolName = "Programiz School";
    public string studentName;
 
  }
 
    class Program {
    static void Main(string[] args) {
       
      Student s1 = new Student();
      s1.studentName = "Ram";

      // calls instance variable
      Console.WriteLine("Name: " + s1.studentName);
      // calls static variable
      Console.WriteLine("School: " + Student.schoolName);
 
      Student s2 = new Student();
      s2.studentName = "Shyam";
   
       // calls instance variable
      Console.WriteLine("Name: " + s2.studentName);
      // calls static variable
      Console.WriteLine("School: " + Student.schoolName);
      
      Console.ReadLine();
    }
  }
}