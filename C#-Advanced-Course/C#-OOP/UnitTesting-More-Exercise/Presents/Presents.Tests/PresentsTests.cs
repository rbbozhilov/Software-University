namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class PresentsTests
    {

        [Test]
        public void BagConstructor()
        {

            Bag bag = new Bag();

            Assert.IsNotNull(bag.GetPresents());

        }

        [Test]
        public void TestingPresentConstructor()
        {

            Present present = new Present("pesho", 25.4);

            Assert.AreEqual("pesho", present.Name);
            Assert.AreEqual(25.4, present.Magic);

        }

        [Test]
        public void TestCreate_ShouldThrowException()
        {

            Bag bag = new Bag();
            Assert.Throws<ArgumentNullException>(() => bag.Create(null));


        }

        [Test]
        public void TestCreate_ThrowExcExist()
        {

            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));


        }

        [Test]
        public void TestCreate_ReturnStringSuccessAdded()
        {

            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            string current = bag.Create(present);
            string expected = $"Successfully added present {present.Name}.";

            Assert.AreEqual(expected, current);

        }

        [Test]
        public void Removing_ShouldThrowTrue()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            bag.Create(present);

            Assert.IsTrue(bag.Remove(present));
        }

        [Test]
        public void Removing_ShouldThrowFalse()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            Present present1 = new Present("pesho", 25.4);
            bag.Create(present1);

            Assert.IsFalse(bag.Remove(present));
        }

        [Test]
        public void GetPresentWithLeastMagic()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            Present present1 = new Present("pesho", 26.6);
            Present present2 = new Present("pesho", 19);
            bag.Create(present1);
            bag.Create(present);
            bag.Create(present2);

            List<Present> presents = new List<Present>() { present, present1, present2 };

            Present expected = presents.OrderBy(p => p.Magic).First();
            Present current = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(expected, current);


        }

        [Test]
        public void GetPresentWithLeastMagicc()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            Present present1 = new Present("pesho", 26.6);
            Present present2 = new Present("pesho", 19);
            Present present3 = new Present("gosho", 190);
            Present present4 = new Present("joko", 9);
            bag.Create(present1);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            bag.Create(present4);

            List<Present> presents = new List<Present>() { present, present1, present2, present3, present4 };

            Present expected = presents.OrderBy(p => p.Magic).First();
            Present current = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(expected, current);


        }

        [Test]
        public void GetPresents_ReturnPresent()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 25.4);
            Present present1 = new Present("pesho", 26.6);
            Present present2 = new Present("pesh2o", 19);
            Present present3 = new Present("gosho", 190);
            Present present4 = new Present("joko", 9);
            bag.Create(present1);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            bag.Create(present4);


            Assert.AreEqual(present, bag.GetPresent("name"));




        }

        [Test]
        public void GetPresents_ReturnNull()
        {

            Assert.AreEqual(null, new Bag().GetPresent("name"));

        }


       [Test]
       public void AddedPresents()
        {

            Bag bag = new Bag();

            Present present = new Present("pesho", 20);
            Present present1 = new Present("pesho1", 220);
            Present present2 = new Present("pesho2", 18);
            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);

            IReadOnlyCollection<Present> presents = new List<Present>() { present, present1, present2 };

            CollectionAssert.AreEqual(presents, bag.GetPresents());

        }

        [Test]
        public void TestGetPresents()
        {

            Bag bag = new Bag();

            Present present = new Present("pesho", 20);
            Present present1 = new Present("pesho1", 220);
            Present present2 = new Present("pesho2", 18);
            Present present3 = new Present("tisho1", 2003);
            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);
            var current = bag.GetPresents();
            IReadOnlyCollection<Present> presents = new List<Present>() { present, present1, present2,present3 };

            CollectionAssert.AreEqual(presents, current);

        }


    }
}
