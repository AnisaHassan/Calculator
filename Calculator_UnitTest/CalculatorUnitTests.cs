using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {

        private calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new calculator();
        }

        //Med hele tal
        [Test]
        public void Add2And1_Return4()
        {
            uut.a = 2;
            uut.b = 1;

            Assert.That(uut.Add(uut.a, uut.b), Is.EqualTo(3));
        }

        //Testcases med hele tal
        [TestCase(1, 2, 3)]
        [TestCase(-3, -1, -4)]
        [TestCase(-1, 2, 1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        [TestCase(6, 6, 12)]
        [TestCase(2, 1, 3)]
        public void AddTestCases(int a, int b, int result)
        {

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [Test]
        public void Subtract2And2_Return0()
        {
            uut.a = 2;
            uut.b = 2;

            Assert.That(uut.Subtract(uut.a, uut.b), Is.EqualTo(0));
        }

        [Test]
        public void Multiply2And2_Return4()
        {
            uut.a = 2;
            uut.b = 2;

            Assert.That(uut.Multiply(uut.a, uut.b), Is.EqualTo(4));
        }

        [Test]
        public void Power2And3_Return8()
        {
            uut.a = 2;
            uut.b = 3;

            Assert.That(uut.Power(uut.a, uut.b), Is.EqualTo(8));
        }

        //Plus med kommatal
        [Test]
        public void Add2_2And1_1_Return3_3()
        {
            uut.a = 2.2;
            uut.b = 1.1;

            Assert.That(uut.Add(uut.a, uut.b), Is.EqualTo(3.3).Within(0.01));
        }

        //Minus med negativ resultat
        [Test]
        public void Subtract0_0And2_1_Return0()
        {
            uut.a = 0.0;
            uut.b = 2.1;

            Assert.That(uut.Subtract(uut.a, uut.b), Is.EqualTo(-2.1));
        }


        //Ganger med negativ værdier
        [Test]

        public void Multiply_2_And_5_Return4()
        {
            uut.a = -2;
            uut.b = -5;

            Assert.That(uut.Multiply(uut.a, uut.b), Is.EqualTo(10));
        }


        [Test]
        public void Divide_4_And_2_Return2()
        {
            uut.Divident = 4;
            uut.Divisor = 2;
            Assert.That(uut.Divide(uut.Divident, uut.Divisor), Is.EqualTo(2));
        }

        [Test]
        public void Divide_6_And_0_ReturnError()
        {
            uut.Divident = 6;
            uut.Divisor = 0;
            Assert.That(uut.Divide(uut.Divident, uut.Divisor), Is.EqualTo(0));
        }

        [Test]
        public void AccumulatorDefaultReturns0()
        {
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void AccumulatorReturns4When2And2IsAdded()
        {
            uut.Add(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }
    }
}
