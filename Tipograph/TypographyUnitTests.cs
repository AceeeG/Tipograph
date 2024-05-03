using System;
using NUnit.Framework;


namespace Tipograph
{
    [TestFixture]
    internal class TypographyUnitTests
    {
        [Test]
        public void TestPunctuationSpacing()
        {
            string input = "Привет,мир!";
            string expected = "Привет, мир!";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestMultipleSpaces()
        {
            string input = "Это    текст  с     лишними    пробелами.";
            string expected = "Это текст с лишними пробелами.";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestHyphenSpacing()
        {
            string input = "красно-белый";
            string expected = "красно - белый";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestQuotesSpacing()
        {
            string input = "Он сказал:«Привет мир!»";
            string expected = "Он сказал: «Привет мир!»";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestBracketSpacing()
        {
            string input = "Русский (или славянский) текст.";
            string expected = "Русский (или славянский) текст.";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestColonSpacing()
        {
            string input = "Задача:написать код.";
            string expected = "Задача: написать код.";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestDashSpacing()
        {
            string input = "Он работал в 10-часовую смену.";
            string expected = "Он работал в 10-часовую смену.";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestQuotationMarks()
        {
            string input = "Он сказал: \"Привет мир!\"";
            string expected = "Он сказал: «Привет мир!»";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestWordReplacement()
        {
            string input = "Я люблю сыр.";
            string expected = "Я люблю колбаса.";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestEmptyInput()
        {
            string input = "";
            string expected = "";
            Assert.That(Tipograph.FormatText(input), Is.EqualTo(expected));
        }
    }
}
