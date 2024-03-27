using System;

namespace VariableScope {
  class Program {

    public void method1() {
      // display variable inside method
      string str = "method level";
    }

    public void method2() {

      // accessing str from method2()
      Console.WriteLine(str);
    }

    static void Main(string[] args) {
      Program ps = new Program();
      ps.method2();

      Console.ReadLine();
    }
  }
}