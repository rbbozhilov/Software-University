using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ParkingSystem.Tests
{

    [TestFixture]
    public class SoftParkTest
    {


        [Test]
        public void TestingCarConstructor()
        {

            Car car = new Car("make", "12345");

            Assert.AreEqual("make", car.Make);
            Assert.AreEqual("12345", car.RegistrationNumber);

        }

        [Test]
        public void TestSoftPark_ShouldBeOk()
        {

            var parking = new Dictionary<string, Car>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            SoftPark soft = new SoftPark();

            Assert.AreEqual(parking, soft.Parking);



        }


        [Test]
        public void ParkCar_ShouldThrowException()
        {


            Assert.Throws<ArgumentException>(() => new SoftPark().ParkCar("dsddd", new Car("make", "321321")));


        }

        [Test]
        public void ParkCar_ShouldThrowException()
        {

            Car car = new Car("make", "32131");
            SoftPark parking = new SoftPark();
            parking.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() => parking.ParkCar("A1", new Car("make", "321321")));



        }

        [Test]
        public void ParkCar_ShouldThrowExceptioneSameCar()
        {

            Car car = new Car("make", "32131");
            SoftPark parking = new SoftPark();
            parking.ParkCar("A1", car);

            Assert.Throws<InvalidOperationException>(() => parking.ParkCar("A2", car));



        }

        [Test]
        public void ParkCar_ShouldBeOk()
        {

            Car car = new Car("make", "32131");
            Car car1 = new Car("mazarate", "CB4444BB");
            SoftPark parking = new SoftPark();
            parking.ParkCar("A1", car);
            parking.ParkCar("A2", car1);

            var parked = new Dictionary<string, Car>
            {
                {"A1", car},
                {"A2", car1},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            Assert.AreEqual(parked, parking.Parking);



        }

        [Test]
        public void ParkCar_ShouldReturnParkedSuccesfully()
        {

            Car car = new Car("make", "32131");
            SoftPark parking = new SoftPark();
            var current = parking.ParkCar("A1", car);
            var expected = $"Car:{car.RegistrationNumber} parked successfully!";


            Assert.AreEqual(expected, current);



        }


        [Test]
        public void RemoveCar_ShouldThrowExcepDoesNotExSlot()
        {


            Assert.Throws<ArgumentException>(() => new SoftPark().RemoveCar("dsddd", new Car("make", "321321")));


        }


        [Test]
        public void RemoveCar_ShouldThrowExcepCarDoesntExc()
        {

           

            Assert.Throws<ArgumentException>(() => new SoftPark().RemoveCar("A1", new Car("make", "321321")));


        }


        [Test]
        public void RemoveCar_ShouldRemoveCar()
        {

            Car car = new Car("maare", "31232");
            SoftPark parking = new SoftPark();
            parking.ParkCar("A1", car);

            parking.RemoveCar("A1", car);

            var parked = new Dictionary<string, Car>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            Assert.AreEqual(parked, parking.Parking);


        }



        [Test]
        public void RemoveCar_ShouldReturnCarNumber()
        {

            Car car = new Car("maare", "31232");
            SoftPark parking = new SoftPark();
            parking.ParkCar("A1", car);

            var current = parking.RemoveCar("A1", car);
            var expected = $"Remove car:{car.RegistrationNumber} successfully!";
          
            Assert.AreEqual(expected, current);


        }

    }
}