using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    [TestFixture]
    public class DummyTests
    {

        [TestCase(100,100,10)]
        public void LosesHealthIfAttacked(int health,int experience,int attackPoints)
        {
            //Arrange
            Dummy dummy = new Dummy(health, experience);

            //Act 
            int expectedHealth = dummy.Health - attackPoints;
            dummy.TakeAttack(attackPoints);
            int currentHealth = dummy.Health;

            //Assert
            Assert.AreEqual(expectedHealth, currentHealth);


        }

        [TestCase(-5,50,2)]
        [TestCase(-1,50,20)]
        [TestCase(0,50,10)]
        public void DeadDummyThrowExceptionIfAttack(int health,int experience,int attackPoints)
        {

            //Arrange
            Dummy dummy = new Dummy(health, experience);

        
            //Act - Assert
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(attackPoints));
            

        }


        [TestCase(0,5)]
        [TestCase(-3,5)]

        public void DeathDummyGiveHp(int health,int experience)
        {
            //Arrange
            Dummy dummy = new Dummy(health, experience);

            //Act

            Assert.AreEqual(experience, dummy.GiveExperience());


        }
        [TestCase(2,3)]
        [TestCase(100,100)]
        public void NotDeathDummyDontGiveHP(int health,int experience)
        {

            //Arrange

            Dummy dummy = new Dummy(health, experience);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            

        }


    }
}
