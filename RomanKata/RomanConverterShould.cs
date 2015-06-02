﻿using NUnit.Framework;
namespace RomanKata
{
    [TestFixture]
    class RomanConverterShould
    {
        [Test] public void ConvertArabicOne()
        {
            Assert.AreEqual("I", RomanConverter.From(1));
        }
    }
}

// Ctrl-Shift B : build
// Shift-Alt-F10 : choose & do action
// Ctrl-R A : run all tests