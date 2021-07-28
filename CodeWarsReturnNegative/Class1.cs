using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CodeWarsReturnNegative
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, Kata.MakeNegative(42));
        } 
    }
        

public static class Kata
    {
        //In this simple assignment you are given a number and have to make it negative.
        //But maybe the number is already negative?
        public static int MakeNegative(int number)
        {
            //if (number < 0)
            //{
            //    return number;
            //}
            //else
            //{
            //    return number * -1;
            //}
            return -Math.Abs(number);

        }
    }
}
