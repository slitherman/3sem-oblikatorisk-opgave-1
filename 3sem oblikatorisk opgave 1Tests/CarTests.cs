using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3sem_oblikatorisk_opgave_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sem_oblikatorisk_opgave_1.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car cartest = new Car()
        {
            Id = -1,
            LicensePlate = "as",
            Price = -1,
            Model = "bmw",


        };

        [TestMethod()]
        public void ValidateIdTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cartest.ValidateId());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cartest.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cartest.ValidateLicensePlate());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cartest.ValidateModel());
        }
    }
}