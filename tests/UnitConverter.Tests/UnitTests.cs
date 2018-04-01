using System;
using Conversor.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter.Business.Services;

namespace UnitConverter.Tests
{
    [TestClass]
    public class UnitTests
    {
        private readonly IConverterService _service;

        public UnitTests()
        {
            _service = new ConverterService();
        }

        [TestMethod]
        public void MustConvertAValueInMeters()
        {
            var result = _service.FromMeters(25);

            Assert.AreEqual(25, Math.Round(result.Meter, 2));
            Assert.AreEqual(984.25, Math.Round(result.Inch, 2));
            Assert.AreEqual(0.02, Math.Round(result.Kilometer, 2));
            Assert.AreEqual(82.02, Math.Round(result.Feet, 2));
        }

        [TestMethod]
        public void MustConvertAValueInInches()
        {
            var result = _service.FromInches(9);

            Assert.AreEqual(0.23, Math.Round(result.Meter, 2));
            Assert.AreEqual(9.00, Math.Round(result.Inch, 2));
            Assert.AreEqual(0.00, Math.Round(result.Kilometer, 2));
            Assert.AreEqual(0.75, Math.Round(result.Feet, 2));
        }

        [TestMethod]
        public void MustConvertAValueInKilometers()
        {
            var result = _service.FromKilometers(544);

            Assert.AreEqual(544000.00, Math.Round(result.Meter, 2));
            Assert.AreEqual(21417280.00, Math.Round(result.Inch, 2));
            Assert.AreEqual(544.00, Math.Round(result.Kilometer, 2));
            Assert.AreEqual(1784755.20, Math.Round(result.Feet, 2));
        }

        [TestMethod]
        public void MustConvertAValueInFeet()
        {
            var result = _service.FromFeet(1000);

            Assert.AreEqual(304.80, Math.Round(result.Meter, 2));
            Assert.AreEqual(12000.00, Math.Round(result.Inch, 2));
            Assert.AreEqual(0.30, Math.Round(result.Kilometer, 2));
            Assert.AreEqual(1000.00, Math.Round(result.Feet, 2));
        }
    }
}
