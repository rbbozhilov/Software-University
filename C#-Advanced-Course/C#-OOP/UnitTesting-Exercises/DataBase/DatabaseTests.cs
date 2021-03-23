using NUnit.Framework;
namespace Tests
{

    //using Database;
    using System;

    [TestFixture]
    public class DatabaseTests
    {


        [TestCase]
        public void TestingConstructorInitialize()
        {

            int[] data = new int[16];

            Database currentData = new Database(data);
            int expected = 16;
            int current = currentData.Count;

            Assert.AreEqual(expected, current);
        }

        [TestCase]
        public void ConstructorInitializeNot16IntegersLong_ShouldThrowException()
        {

            int[] data = new int[17];

            Assert.Throws<InvalidOperationException>(() => new Database(data));


        }

        [TestCase]
        public void AddingElement_ShouldAddedOnNextFreeSpace()
        {

            int[] array = new int[14];
            Database database = new Database(array);
            database.Add(5);
            int expected = 15;
            int current = database.Count;
            Assert.AreEqual(expected, current);


        }
        [TestCase]
        public void IfAddingElementDontHaveSpace_ShouldReturnException()
        {

            int[] array = new int[16];

            Database database = new Database(array);

            Assert.Throws<InvalidOperationException>(() => database.Add(7));


        }

        [TestCase]
        public void RemovingElementOfLastIndex()
        {

            int[] array = new int[4];
            Database database = new Database(array);
            database.Remove();
            int expected = 3;
            int current = database.Count;

            Assert.AreEqual(expected, current);

        }

        [TestCase]
        public void Should_ThrowExceptionIfCountIsZeroByRemoveMethod()
        {

            Assert.Throws<InvalidOperationException>(() => new Database().Remove());

        }

        [TestCase]
        public void FetchMethod_ShouldReturnElementsAsArray()
        {

            int[] array = new int[6];
            Database database = new Database(array);

            int[] newArray = database.Fetch();

            int expected = 6;
            int current = newArray.Length;

            Assert.AreEqual(expected, current);


        }

    }
}