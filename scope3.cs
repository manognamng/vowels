using System;
namespace VariableScope {
  class Program {

    public void display() {
     string str = "inside method";

      // accessing method level variable
      Console.WriteLine(str);
    }

    static void Main(string[] args) {
    Program ps = new Program();
    ps.display();

    Console.ReadLine();
    }
  }
}