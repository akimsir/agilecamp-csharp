using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unitTesting
{
    public class FirstTests
    {
        //[Test]
        //public void FirstSuccessTest()
        //{
        //    Assert.AreEqual(1, 1);
        //}

        //[Test]
        //public void FirstFailTest()
        //{
        //    Assert.True(false);
        //}

        //[Test]
        //public void SeccundFailTest()
        //{
        //    Assert.AreSame("ololo", "olo1");
        //}

        //[Test]
        //public void ParseCorrectString_ReturnInt()
        //{
        //    int result = int.Parse("56");

        //    Assert.AreEqual(56, result);

        //}

        //[Test]
        //public void Strings()
        //{
        //    bool result = "some str" == "some Str";

        //    Assert.False(result);

        //}

        //[Test]
        //public void IfStringIsNull()
        //{
        //    string nullStr = null;

        //    Assert.Throws<NullReferenceException>(() => { nullStr.Length.ToString(); });
        //}

        public static int _random = 3;

        [Test]
        public void Repeating()
        {
            _random = new Random().Next(0, 60);

            Assert.AreEqual(2, _random);
        }

        [Test]
        public void Repeating2()
        {
            Assert.AreEqual(_random, DateTime.Now.Second);
        }


    }
}
