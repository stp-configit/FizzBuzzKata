using NUnit.Framework;

using TDDKata;

namespace FizzBuzzTest{
  [TestFixture]
  public class UnitTest1 {
    [Test]
    public void TestFizzBuzzWorks() {
      var fizzBuzz = new FizzBuzz();

      Assert.DoesNotThrow( () => fizzBuzz.PrintFizzbuzz() );
    }
  }
}
