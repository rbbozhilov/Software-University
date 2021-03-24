using NUnit.Framework;

namespace Tests
{

    using System;
    //using ExtendedDatabase;

    [TestFixture]
    public class ExtendedDatabaseTests
    {

        [TestCase]
        public void TestingPersonConstructor()
        {
            long id = 544234;
            string name = "Tisho";

            Person person = new Person(id, name);

            Assert.AreEqual(id, person.Id);
            Assert.AreEqual(name, person.UserName);


        }


        [TestCase]
        public void TestingConstructorOfDataBase()
        {

            Person[] persons = new Person[3];
            persons[0] = new Person(31232132, "pesho");
            persons[1] = new Person(3123, "gosho");
            persons[2] = new Person(1123, "tisho");

            ExtendedDatabase database = new ExtendedDatabase(persons);

            int expected = 3;
            int actual = database.Count;

            Assert.AreEqual(expected, actual);


        }
        [TestCase]
        public void ShouldReturnExceptionMoreThen16()
        {

            Person[] persons = new Person[17];

            for(int i=0;i<persons.Length;i++)
            {
                persons[i] = new Person(i, "a" + i);
            }

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(persons));

        }

        [TestCase]
        public void IfPersonsAre16AndWeTryToAddMoreExceptionExpected()
        {

            Person[] persons = new Person[16];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, "a" + i);
            }

            ExtendedDatabase dataBase = new ExtendedDatabase(persons);

            Assert.Throws<InvalidOperationException>(() => dataBase.Add(new Person(331, "tishoe")));


        }
       
        [TestCase]
        public void CheckingIfSameIdWillThrowException()
        {

            Person person = new Person(123, "Pesho");

            ExtendedDatabase dataBase = new ExtendedDatabase(new Person(123, "toshko"));

            Assert.Throws<InvalidOperationException>(() => dataBase.Add(person));


        }

        [TestCase]
        public void ChekingIfSameNameWillThrowException()
        {

            Person person = new Person(234, "Goshko");

            ExtendedDatabase dataBase = new ExtendedDatabase(new Person(4234, "Goshko"));

            Assert.Throws<InvalidOperationException>(() => dataBase.Add(person));


        }

        [TestCase]
        public void AddCurrectPersonShouldBeOk()
        {

            Person person = new Person(3213, "Goshko");

            ExtendedDatabase dataBase = new ExtendedDatabase(new Person(312311, "toshko"));

            dataBase.Add(person);
            int expected = 2;
            int actual = dataBase.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestCase]
        public void TestingRemoveMethodItShouldRemoveTheLastOnePerson()
        {

            Person person = new Person(3123, "Toshko");
            ExtendedDatabase dataBase = new ExtendedDatabase(person);

            dataBase.Remove();
            int expected = 0;
            int current = dataBase.Count;

            Assert.AreEqual(expected, current);

        }

        [TestCase]
        public void RemoveMethodShouldReturnExceptionForNonPersonsForRemoving()
        {

            Assert.Throws<InvalidOperationException>(() => new ExtendedDatabase().Remove());

        }

        [TestCase]
        public void IfNameIsNullOrEmpty_ShouldReturnException()
        {

            ExtendedDatabase dataBase = new ExtendedDatabase(new Person(3213,"Gosho"));
            Assert.Throws<ArgumentNullException>(() => dataBase.FindByUsername(null));
            Assert.Throws<ArgumentNullException>(() => dataBase.FindByUsername(string.Empty));

        }

        [TestCase]
        public void NotFoundUserByName_ShouldThrowException()
        {

            ExtendedDatabase database = new ExtendedDatabase();
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Goshko"));


        }

        [TestCase]
        public void ShouldBeFoundThePersonCurrect()
        {

            ExtendedDatabase dataBase = new ExtendedDatabase(new Person(3123, "gosho"));
            Person person = dataBase.FindByUsername("gosho");
            Person expected = new Person(3123, "gosho");
            Assert.AreEqual(expected.UserName, person.UserName);
            Assert.AreEqual(expected.Id, person.Id);

        }

        [TestCase]
        public void IfIdIsNegative_ShouldThrowException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => new ExtendedDatabase().FindById(-1));

        }

        [TestCase]
        public void IfUserNotFoundById_ShouldThrowException()
        {

            Assert.Throws<InvalidOperationException>(() => new ExtendedDatabase().FindById(3123));

        }

        [TestCase]
        public void IfUserIsFoundById_ShouldReturnThePerson()
        {

            ExtendedDatabase dataBase = new ExtendedDatabase(new Person(123, "Tisho"));

            Person person = dataBase.FindById(123);
            Person expected = new Person(123, "Tisho");

            Assert.AreEqual(person.Id, expected.Id);
            Assert.AreEqual(person.UserName, expected.UserName);
            

        }



    }
}