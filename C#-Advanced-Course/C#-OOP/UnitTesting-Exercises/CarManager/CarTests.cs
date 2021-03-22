using NUnit.Framework;

namespace Tests
{
    
    using System;

    [TestFixture]
    public class CarTests
    {

        [TestCase(null, "bmw", 20, 10)]
        [TestCase("gosho", null, 20, 10)]
        [TestCase("pesho", "bmw", -3, 10)]
        [TestCase("tisho", "bmw", 20, -4)]
        public void AllPropertiesShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));


        }


        [TestCase]
        public void TestingConstructorInitilize()
        {

            string make = "ZERO";
            string model = "Bmw";
            double fuelConsumption = 2.5;
            double fuelCapacity = 20.5;
            double fuelAmount = 0;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(fuelAmount, car.FuelAmount);

        }

        [TestCase(null,"bmw",22,33)]
        [TestCase("","bmw",23,24)]
        public void IfMakeIsNullOrEmpty_ShouldThrowException(string make,string model,double fuelConsumption,double fuelCapacity)
        {
            
            Assert.Throws<ArgumentException>(()=> new Car(make, model, fuelConsumption, fuelCapacity));

        }


        [TestCase(null, "bmw", 22, 33)]
        [TestCase("", "bmw", 24, 25)]
        public void IfModelIsNullOrEmpty_ShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));


        }

        [TestCase("bate", "bmw", 0, 33)]
        [TestCase("bate", "bmw", -1, 33)]
        public void IfFuelConsuptionIsZeroOrNegative_ShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));

            
        }

        [TestCase("bate", "bmw", 20, 0)]
        [TestCase("bate", "bmw", 30, -1)]
        public void IfFuelCapacityIsZeroOrNegative_ShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));

        }


        [TestCase("bate", "bmw", 20, 20)]
        public void FuelRefuelMethodIfNegativeOrZero_ShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<ArgumentException>(() => car.Refuel(0));
            Assert.Throws<ArgumentException>(() => car.Refuel(-1));


        }

        [TestCase("bate", "bmw", 20, 10)]
        public void IfAmountIsLessThenCapacity_ShouldBeEcToRefuel(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(5);
            double expected = 5;
            double current = car.FuelAmount;

            Assert.AreEqual(expected, current);

        }

        [TestCase("bate", "bmw", 20, 20)]
        public void IfAmountIsBiggerThenRefuel_ShouldBeEcToCapacity(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(30);

            double expected = 20;
            double current = car.FuelAmount;

            Assert.AreEqual(expected, current);

        }


        [TestCase("bate", "bmw", 20, 10)]
        public void DriveMethodTestingIfFuelNeededMoreThenAmount_ShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<InvalidOperationException>(() => car.Drive(5));


        }


        [TestCase("bate", "bmw", 20, 10)]
        public void IfAmountIsNegative_ShouldThrowException(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Drive(0);

            double expected = 0;
            double current = car.FuelAmount;

            Assert.AreEqual(expected, current);


        }

        [TestCase("bate", "bmw", 20, 10)]
        public void ShouldBeNormalDrive(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            
            car.Refuel(15);
            car.Drive(15);
            
            double expected = 7;
            double current = car.FuelAmount;

            Assert.AreEqual(expected, current);



        }

        [TestCase("bate", "bmw", 20, 10)]
        public void Refuel_ShouldBeOk(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(15);

            double expected = 10;
            double current = car.FuelAmount;

            Assert.AreEqual(expected, current);


        }

        [TestCase("bate", "bmw", 20, 20)]
        public void Refuel_ShouldBeOkAndAmountLessThenCapacity(string make, string model, double fuelConsumption, double fuelCapacity)
        {

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(15);

            double expected = 15;
            double current = car.FuelAmount;

            Assert.AreEqual(expected, current);


        }
    }
}