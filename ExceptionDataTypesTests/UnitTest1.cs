using NUnit.Framework;
using ExceptionTypes;
using System;

namespace ExceptionDataTypesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-34)]
        [TestCase(-1)]
        [TestCase(1)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int grade)
        {
            Assert.That(() => Program.Grade(grade), Throws.TypeOf<ArgumentOutOfRangeException>());
            // Do this first - () => Program.Grade(grade) 

            // and then compary it to Throws.TypeOf<ArgumentOutOfRangeException>()
        
            // () => IS A LAMDA EXPRESSION  
        }
    }
}