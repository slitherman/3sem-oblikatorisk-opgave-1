using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3sem_oblikatorisk_opgave_1;

namespace CarApi.Repository.Tests
{
    [TestClass()]
    public class CarsRepoTests
    {
        public readonly CarsRepo? _repo = new CarsRepo();

        Car NewCar = new Car()
        {
            Id = 7,
            LicensePlate = "aaaaa",
            Model = "Audi",
            Price = 141,


        };

        [TestInitialize()]
        public void Startup()

        {
            Car testcar = new Car()
            {
                Id = 11,
                LicensePlate = "adcd",
                Model = "Audi",
                Price = 11,


            };


        }
        [TestMethod()]
        public void GetAllTest()
        {


            Assert.IsTrue(_repo.GetAll().Count > -1);


        }

        [TestMethod()]
        public void DeleteTest()
        {
            _repo.Create(NewCar);
            _repo.Delete(7);

            Assert.IsTrue(_repo.GetById(7) == null);


        }

    }
}