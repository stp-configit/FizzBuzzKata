using System;
using TDDKata;

namespace TDDKataOutput {
  class Program {
    static void Main( string[] args ) {
      var fizzBuzz = new FizzBuzz();

      Console.Out.WriteLine( fizzBuzz.PrintFizzbuzz() );
      Console.ReadKey();
    }
  }
}
