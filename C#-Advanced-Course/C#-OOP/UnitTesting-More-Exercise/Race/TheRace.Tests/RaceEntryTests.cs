using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {


        private UnitCar car;


        [SetUp]
        public void SetUp()
        {
            car = new UnitCar("bmw", 200, 20);
        }

        [Test]
        public void TestConstructorOfUnitCar()
        {
            UnitCar car = new UnitCar("bmw", 200, 20.5);

            Assert.AreEqual("bmw", car.Model);
            Assert.AreEqual(200, car.HorsePower);
            Assert.AreEqual(20.5, car.CubicCentimeters);

        }

        [Test]
        public void TestConstructorOfUnitDriver()
        {
            UnitDriver driver = new UnitDriver("pesho", car);
            Assert.AreEqual("pesho", driver.Name);
            Assert.AreEqual(car, driver.Car);
        }

        [Test]
        public void TestConstructor_ShouldNameNotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() => new UnitDriver(null, car));

        }

        [Test]
        public void ConstructorOfEntry_ShouldBeCorrect()
        {


            RaceEntry race = new RaceEntry();

            Assert.AreEqual(0, race.Counter);

        }

        [Test]
        public void AddingDriver_ShouldThrowExceptionNullDriver()
        {

            Assert.Throws<InvalidOperationException>(() => new RaceEntry().AddDriver(null));

        }

        [Test]
        public void IfDrivenContains_ShouldThrowExc()
        {

            RaceEntry race = new RaceEntry();
            race.AddDriver(new UnitDriver("Pesho", car));
            UnitDriver driver = new UnitDriver("Pesho", car);
            Assert.Throws<InvalidOperationException>(() => race.AddDriver(driver));

        }

        [Test]
        public void AddDriver_ShouldWork()
        {
            RaceEntry race = new RaceEntry();
            race.AddDriver(new UnitDriver("pesho", car));
            race.AddDriver(new UnitDriver("gosho", new UnitCar("mercedes", 100, 20)));

            Assert.AreEqual(2, race.Counter);
        }

        [Test]
        public void ShouldReturnSomeString()
        {

            RaceEntry race = new RaceEntry();
            UnitDriver driver = new UnitDriver("gosho", car);
            string result = race.AddDriver(driver);
            string expected = string.Format("Driver {0} added in race.", driver.Name);

            Assert.AreEqual(expected, result);

        }

        [Test]
        public void CalculateAverage_ShouldThrowExc()
        {
            RaceEntry race = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverage_ShouldThrowExc1()
        {
            RaceEntry race = new RaceEntry();
            race.AddDriver(new UnitDriver("pesho", car));
            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }


        [Test]
        public void CalculateAverage_ShouldBeCorrect()
        {
            RaceEntry race = new RaceEntry();
            UnitDriver driver = new UnitDriver("gosho", new UnitCar("bmw", 100, 20));
            UnitDriver driver1 = new UnitDriver("pesho", new UnitCar("bmw", 200, 20));
            race.AddDriver(driver);
            race.AddDriver(driver1);

            Dictionary<string, UnitDriver> drivers = new Dictionary<string, UnitDriver>();

            drivers.Add(driver.Name,driver);
            drivers.Add(driver1.Name, driver1);

            double expected = drivers
             .Values
             .Select(x => x.Car.HorsePower)
             .Average();

            double current = race.CalculateAverageHorsePower();

            Assert.AreEqual(expected, current);

        }

    }
}