namespace BlueOrigin.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class SpaceshipTests
    {
       

        [Test]
        public void TestingConstructorOfAstru()
        {

            Astronaut astro = new Astronaut("pesho", 25.4);

            Assert.AreEqual("pesho", astro.Name);
            Assert.AreEqual(25.4, astro.OxygenInPercentage);


        }

        [Test]
        public void SpaceShipConstructorShouldBeFine()
        {

            Spaceship space = new Spaceship("pesho", 15);
            List<Astronaut> astro = new List<Astronaut>();

            Assert.AreEqual("pesho", space.Name);
            Assert.AreEqual(15, space.Capacity);
            Assert.AreEqual(astro.Count, space.Count);

        }

        [Test]
        public void SpaceShipConstructor_ShouldThrowNameExc()
        {

            

            Assert.Throws<ArgumentNullException>(() => new Spaceship("", 15));

        }

        [Test]
        public void SpaceShipConstructor_ShouldThrowNameExc1()
        {

            Assert.Throws<ArgumentNullException>(() => new Spaceship(null, 15));

        }

        [Test]
        public void IfCapacityLessThenZero_ShouldThrowExc()
        {

            Assert.Throws<ArgumentException>(() => new Spaceship("pesho", -1));

        }

       [Test]
       public void AddAstro_ShouldThrowExc()
        {

            Spaceship space = new Spaceship("pesho", 0);

            Assert.Throws<InvalidOperationException>(() => space.Add(new Astronaut("pesho", 15)));


        }

        [Test]
        public void AddAStro_ShouldThrowExcCapacity()
        {

            Spaceship space = new Spaceship("pesho", 1);
            space.Add(new Astronaut("gosho", 25));
            Assert.Throws<InvalidOperationException>(() => space.Add(new Astronaut("pesho", 15)));


        }

        [Test]
        public void AddAstro_ShouldThrowExcExistAstro()
        {

            Spaceship space = new Spaceship("pesho", 1);
            Astronaut astro = new Astronaut("gosho", 25);
            space.Add(astro);
            Assert.Throws<InvalidOperationException>(() => space.Add(astro));


        }

        [Test]
        public void AddAStro_ShouldBeOk()
        {

            Spaceship space = new Spaceship("pesho", 4);
            Astronaut astro = new Astronaut("gosho", 25);
            Astronaut astro1 = new Astronaut("pesho2", 24);
            space.Add(astro);
            space.Add(astro1);

            Assert.AreEqual(2, space.Count);


        }

        [Test]
        public void RemovingAstro_ShouldBeTrue()
        {

            Spaceship space = new Spaceship("pesho", 4);
            Astronaut astro = new Astronaut("gosho", 25);
            Astronaut astro1 = new Astronaut("pesho2", 24);
            space.Add(astro);
            space.Add(astro1);

            Assert.IsTrue(space.Remove("gosho"));


        }

        [Test]
        public void RemovingAstro_ShouldReturnFalse()
        {

            Spaceship space = new Spaceship("pesho", 4);
            Astronaut astro = new Astronaut("gosho", 25);
            Astronaut astro1 = new Astronaut("pesho2", 24);
            space.Add(astro);
            space.Add(astro1);

            Assert.IsFalse(space.Remove("31231"));


        }

    }
}