namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void TestingConstructorFish()
        {

            Fish fish = new Fish("name");

            Assert.AreEqual("name", fish.Name);
            Assert.IsTrue(fish.Available);

        }

        [Test]
        public void TestingConstOfFish()
        {

            Fish fish = new Fish("name");

            fish.Available = false;
            Assert.AreEqual("name", fish.Name);
            Assert.IsFalse(fish.Available);

        }

        [Test]
        public void TestingAuariumConst()
        {

            Aquarium aue = new Aquarium("pesho", 2);

            Assert.AreEqual("pesho", aue.Name);
            Assert.AreEqual(2, aue.Capacity);


        }

        [Test]
        public void TestingAuariumConst_ShouldThrowNameEXCE()
        {

            Assert.Throws<ArgumentNullException>(() => new Aquarium("", 2));


        }

        [Test]
        public void TestingAuariumConst_ShouldThrowNameEXCEe()
        {

            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 2));


        }

        [Test]
        public void TestingCapacity_ShouldThrowExc()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("pesho", -1));
        }

        [Test]
        public void TestingCount()
        {

            Aquarium aue = new Aquarium("name",2);

            Assert.AreEqual(0, aue.Count);


        }

        [Test]
        public void TestingCounter()
        {

            Aquarium aue = new Aquarium("name", 2);
            aue.Add(new Fish("pesho"));
            Assert.AreEqual(1, aue.Count);


        }

        [Test]
        public void TestingAddMethod()
        {

            Aquarium aue = new Aquarium("name", 3);
            aue.Add(new Fish("pesho"));
            aue.Add(new Fish("gosho"));
            aue.Add(new Fish("tisho"));
            Assert.AreEqual(3, aue.Count);


        }

        [Test]
        public void FullAuer_ShouldThrowExc()
        {
            Aquarium aue = new Aquarium("name", 3);
            aue.Add(new Fish("pesho"));
            aue.Add(new Fish("gosho"));
            aue.Add(new Fish("tisho"));
            Assert.Throws<InvalidOperationException>(() => aue.Add(new Fish("tosho")));
           
        }

        [Test]
        public void RemoveFish_ShouldThrowExc()
        {
            Aquarium aue = new Aquarium("name", 3);
            Assert.Throws<InvalidOperationException>(() => aue.RemoveFish("gosho"));
        }

        [Test]
        public void RemoveFish_ShouldBeOk()
        {
            Aquarium aue = new Aquarium("name", 3);
            aue.Add(new Fish("name"));
            aue.RemoveFish("name");

            Assert.AreEqual(0, aue.Count);
        }


        [Test]
        public void SellingFish_ShouldThrowExc()
        {
            Aquarium aue = new Aquarium("name", 3);
            Assert.Throws<InvalidOperationException>(() => aue.SellFish("gosho"));
        }


        [Test]
        public void SellingFish_ShouldReturnFalse()
        {
            Aquarium aue = new Aquarium("name", 3);
            Fish fish = new Fish("name");
            aue.Add(fish);
            aue.SellFish("name");

            Assert.IsFalse(fish.Available);
        }

        [Test]
        public void SellingFish_ShouldReturnTheFish()
        {
            Aquarium aue = new Aquarium("name", 3);
            Fish fish = new Fish("name");
            aue.Add(fish);
           Fish fisher =  aue.SellFish("name");

            Assert.AreEqual(fish,fisher);
        }


        [Test]
        public void FishNamesReturning()
        {
            Aquarium aue = new Aquarium("name", 3);
            Fish fish = new Fish("name");
            Fish fish1 = new Fish("pesho");
            aue.Add(fish);
            aue.Add(fish1);

            string current = aue.Report();
            List<Fish> fishes = new List<Fish>() { fish, fish1 };

            string fishNames = string.Join(", ",fishes.Select(f => f.Name));
            string report = $"Fish available at {aue.Name}: {fishNames}";

            Assert.AreEqual(report, current);

        }

        [Test]
        public void FishReport()
        {
            Aquarium aue = new Aquarium("name", 4);
            Fish fish = new Fish("name");
            Fish fish1 = new Fish("pesho");
            Fish fish2 = new Fish("tisho");
            Fish fish3 = new Fish("jiki");
            aue.Add(fish);
            aue.Add(fish1);
            aue.Add(fish2);
            aue.Add(fish3);

            string current = aue.Report();
            List<Fish> fishes = new List<Fish>() { fish, fish1,fish2,fish3 };

            string fishNames = string.Join(", ", fishes.Select(f => f.Name));
            string report = $"Fish available at {aue.Name}: {fishNames}";

            Assert.AreEqual(report, current);

        }



    }
}
