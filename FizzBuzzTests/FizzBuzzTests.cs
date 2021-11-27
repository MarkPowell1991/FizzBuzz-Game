

using NUnit.Framework;

using FizzBuzz;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        //
        [Test]
        public void FizzBuzzer_GiveInt1_ReturnString1()
        {
            int input = 1;
            string expected = "1";
            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,"1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        public void FizzBuzzer_GiveInt2_ReturnString2(int input, string expected)
        {
       
            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz2(input);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void FizzBuzzer_GiveInt3_ReturnString3(int input, string expected)
        {

            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz3(input);
            Assert.AreEqual(expected, actual);
        }

        //The test remains the same but the Program has changed
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void FizzBuzzer_GiveInt4_ReturnString4(int input, string expected)
        {

            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz4(input);
            Assert.AreEqual(expected, actual);
        }


    }
}
