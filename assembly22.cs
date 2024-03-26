// Code on Assembly2
using System;

// access Assembly1
using Assembly1;

namespace Assembly2 {

  // derived class of Greet
  class Program: Greet {
    static void Main(string[] args) {
      Program greet = new Program();

      // accessing name field from Assembly1
      Console.Write(greet.msg);
      Console.ReadLine();
    }
  }
}