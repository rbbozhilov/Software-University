namespace Computers.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class ComputerTests
    {
       


        [Test]
        public void ConstructorOfPart()
        {

            Part part = new Part("CPU", 99.99m);

            Assert.AreEqual("CPU", part.Name);
            Assert.AreEqual(99.99m, part.Price);

        }

        [Test]
        public void ConstructorOfComputer_ShouldBeOk()
        {

            Computer computer = new Computer("pesho");
            List<Part> parts = new List<Part>();

            Assert.AreEqual("pesho", computer.Name);
            CollectionAssert.AreEqual(parts, computer.Parts);


        }

        [Test]
        public void Constructor_ShouldThrowNullException()
        {

            Assert.Throws<ArgumentNullException>(() => new Computer(null));
            
        }


        [Test]
        public void Constructor_ShouldReturnExcWhiteSpace()
        {

            Assert.Throws<ArgumentNullException>(() => new Computer("  "));

        }

        [Test]
        public void Constructor_ShouldReturnExcWhiteSpacee()
        {

            Assert.Throws<ArgumentNullException>(() => new Computer(""));

        }

        [Test]
        public void AddPart_ShouldThrowExc()
        {

            Computer computer = new Computer("pesho");
            Assert.Throws<InvalidOperationException>(() => computer.AddPart(null));

        }


        [Test]
        public void AddPart_ShouldBeCorrect()
        {

            Computer computer = new Computer("pesho");
            Part part = new Part("CPU", 999.99m);
            Part part1 = new Part("RAM", 899.99m);
            computer.AddPart(part);
            computer.AddPart(part1);

            List<Part> parts = new List<Part>() { part, part1 };

            CollectionAssert.AreEqual(parts, computer.Parts);

        }

        [Test]
        public void RemovingPart_ShouldReturnTrue()
        {

            Computer computer = new Computer("pesho");
            Part part = new Part("CPU", 999.99m);
           
            computer.AddPart(part);

            Assert.IsTrue(computer.RemovePart(part));
          
        }

        [Test]
        public void RemovingPart_ShouldReturnFalse()
        {

            Assert.IsFalse(new Computer("pesho").RemovePart(new Part("videocard", 100m)));

        }


        [Test]
        public void GetPart_ShouldReturnPart()
        {

            Computer computer = new Computer("pesho");
            Part part = new Part("CPU", 999.99m);
            computer.AddPart(part);


            Part current = computer.GetPart("CPU");

            Assert.AreEqual(part, current);

        }

        [Test]
        public void GetPart_ShouldBeCorrect()
        {

            Computer computer = new Computer("pesho");
            Part part = new Part("CPU", 999.99m);
            Part part1 = new Part("RAM", 999.99m);
            Part part2 = new Part("VideoCard", 999.99m);
            computer.AddPart(part);
            computer.AddPart(part1);
            computer.AddPart(part2);


            Part current = computer.GetPart("RAM");

            Assert.AreEqual(part1, current);

        }


        [Test]
        public void TotalPriceSum()
        {

            Computer computer = new Computer("pesho");
            Part part = new Part("CPU", 999.99m);
            Part part1 = new Part("RAM", 999.99m);
            Part part2 = new Part("VideoCard", 999.99m);
            computer.AddPart(part);
            computer.AddPart(part1);
            computer.AddPart(part2);
            List<Part> parts = new List<Part>() { part, part1, part2 };

            decimal totalPrice = parts.Sum(s => s.Price);

            Assert.AreEqual(totalPrice, computer.TotalPrice);


        }


        [Test]
        public void TotalPriceSumer()
        {

            
           
           
           
            Assert.AreEqual(0, new Computer("pesho").TotalPrice);


        }

    }
}