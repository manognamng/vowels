using System;

namespace Method {

  class Program {   

    string work(string work) {
     return work;
      
    }

    static void Main(string[] args) {

      // create class object 
      Program p1 = new Program();

      //call method 
      string work = p1.work("Cleaning"); ;   

      Console.WriteLine("Work: " + work);
  
      Console.ReadLine();
     
    }
  }
}