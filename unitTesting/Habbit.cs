using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unitTesting
{
    public class Habbit
    {
        public string Add(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                throw new ArgumentException();
            }

            return "Привычка: " + name;
        }


        [Test]
        public void HabbitValidationEmptyName()
        {
            Assert.Throws<ArgumentException>(()=>
            {
                var habbit = new Habbit();
                habbit.Add("");
            }
        );
        }

        [Test]
        public void HabbitValidationMinLength()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var habbit = new Habbit();
                habbit.Add("1");
            }
            );
        }

        [Test]
        public void HabbitValidationValidName()
        {
            Assert.DoesNotThrow(() =>
            {
                var habbit = new Habbit();
                habbit.Add("Abc");
            }
            );
        }

        [Test]
        public void HabbitValidationValidNamePrefix()
        {
            var habbit = new Habbit();
            var name = "abc";

            Assert.IsTrue(habbit.Add(name).Equals("Привычка: " + name));
        }

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

        //public static int _random = 3;

        //[Test]
        //public void Repeating()
        //{
        //    _random = new Random().Next(0, 60);

        //    Assert.AreEqual(2, _random);
        //}

        //[Test]
        //public void Repeating2()
        //{
        //    Assert.AreEqual(_random, DateTime.Now.Second);
        //}


    }
}
