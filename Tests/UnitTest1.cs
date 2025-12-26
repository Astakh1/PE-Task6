using NUnit.Framework;
using ConsoleApp1;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            double value = 30;
            double result = Program.ConvertTemperature(value, "C", "K");
            Assert.That(result, Is.EqualTo(303.15));
        }

        [Test]
        public void Test2()
        {
            double value = 100;
            double result = Program.ConvertTemperature(value, "F", "K");
            Assert.That(result, Is.EqualTo(310.9277777777778).Within(0.0001));
        }

        [Test]
        public void Test3()
        {
            double value = -10;
            double result = Program.ConvertTemperature(value, "C", "F");
            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void Test4()
        {
            double value = 25;
            double result = Program.ConvertTemperature(value, "C", "C");
            Assert.That(result, Is.EqualTo(value));
        }

        [Test]
        public void Test5()
        {
            double value = 25;
            Assert.Throws<ArgumentException>(() =>
                Program.ConvertTemperature(value, "X", "C"));
        }

        [Test]
        public void Test6()
        {
            double value = 25;
            Assert.Throws<ArgumentException>(() =>
                Program.ConvertTemperature(value, "C", "X"));
        }
    }
}