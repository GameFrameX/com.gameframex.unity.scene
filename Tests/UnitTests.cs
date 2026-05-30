using System;
using NUnit.Framework;

namespace GameFrameX.Scene.Tests
{
    internal class UnitTests
    {
        // Here is an example of a unit test for the IsUnixSameDay method
        [Test]
        public void TestIsUnixSameDay()
        {
            // Arrange
            // long timestamp1 = 1617842400; // April 7, 2021 12:00:00 AM UTC
            // long timestamp2 = 1617896400; // April 7, 2021 12:00:00 PM UTC

            // Act
        }


        [Test]
        public void Test1()
        {
            var dateTime = new DateTime(2026, 5, 30, 10, 0, 0);
            var dateTime1 = dateTime.AddHours(1);

            Assert.That(dateTime1.Year, Is.EqualTo(dateTime.Year));
            Assert.That(dateTime1.Month, Is.EqualTo(dateTime.Month));
            Assert.That(dateTime1.Day, Is.EqualTo(dateTime.Day));
        }
    }
}