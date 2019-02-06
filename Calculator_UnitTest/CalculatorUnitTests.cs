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

        // TEST AF ADD METODE

        //Med hele tal
        [Test]
        public void Add2And1_Return3()
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

        //Plus med kommatal
        [Test]
        public void Add2_2And1_1_Return3_3()
        {
            uut.a = 2.2;
            uut.b = 1.1;

            Assert.That(uut.Add(uut.a, uut.b), Is.EqualTo(3.3).Within(0.01));
        }




        // TEST SUBTRACT METODE
        //Minus med hele positive tal
        [Test]
        public void Subtract2And2_Return0()
        {
            uut.a = 2;
            uut.b = 2;

            Assert.That(uut.Subtract(uut.a, uut.b), Is.EqualTo(0));
        }

       

        //Minus med negativ resultat
        [Test]
        public void Subtract0_0And2_1_Return0()
        {
            uut.a = 0.0;
            uut.b = 2.1;

            Assert.That(uut.Subtract(uut.a, uut.b), Is.EqualTo(-2.1));
        }

        // TEST MULTIPLY METODE

        [Test]
        public void Multiply2And2_Return4()
        {
            uut.a = 2;
            uut.b = 2;

            Assert.That(uut.Multiply(uut.a, uut.b), Is.EqualTo(4));
        }

        //Ganger med negative værdier
        [Test]

        public void Multiply_2_And_5_Return4()
        {
            uut.a = -2;
            uut.b = -5;

            Assert.That(uut.Multiply(uut.a, uut.b), Is.EqualTo(10));
        }

        // TEST POWER METODE

        [Test]
        public void Power2And3_Return8()
        {
            uut.a = 2;
            uut.b = 3;

            Assert.That(uut.Power(uut.a, uut.b), Is.EqualTo(8));
        }


        // TEST DIVIDE METODE

        [Test]
        public void Divide_4_By_2_Return2()
        {
            uut.divident = 4;
            uut.divisor = 2;
            Assert.That(uut.Divide(uut.divident, uut.divisor), Is.EqualTo(2));
        }

        [Test]
        public void Divide_6_By_0_ReturnError()
        {
            Assert.Catch<DivideByZeroException>(() => uut.Divide(6, 0));

        }

        // TEST ACCUMULATOR

        [Test]
        public void AccumulatorDefaultReturns0()
        {
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void AccumulatorReturns384When24And16IsMultiplied()
        {
            uut.Multiply(24, 16);
            Assert.That(uut.Accumulator, Is.EqualTo(384));
        }

        [Test]
        public void AccumulatorReturns168When240And32IsSubstract()
        {
            uut.Subtract(240, 72);
            Assert.That(uut.Accumulator, Is.EqualTo(168));
        }

        [Test]
        public void AccumulatorReturns4When2And2IsAdded()
        {
            uut.Add(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }

        //TEST AF ACCUMULATE OG ADD METODEN
        [Test]
        public void AddAccumulateAnd1_Return12()
        {
            uut.Add(2, 1);
            uut.addend = 9;

            Assert.That(uut.Add(uut.addend), Is.EqualTo(12));
        }


        //TEST AF ACCUMULATE OG SUBSTRACT METODEN
        [Test]
        public void SubstractAccumulateAnd1_Return12()
        {
            uut.Subtract(10, 5);
            uut.subtractor = 9;

            Assert.That(uut.Subtract(uut.subtractor), Is.EqualTo(12));
        }

        // TEST CLEAR METODE

        [Test]
        public void ClearAccumulationForZeroes()
        {
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }

}
