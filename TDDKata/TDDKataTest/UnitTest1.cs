using NUnit.Framework;
using TDDKata;

namespace TDDKataTest {
  [TestFixture]
  public class TestFizzBuzz{
    [Test]
    public void PrintWorks() {
      var fizzbuzz = new FizzBuzz();

      Assert.DoesNotThrow( () => fizzbuzz.PrintFizzbuzz() );
    }
  }
}
