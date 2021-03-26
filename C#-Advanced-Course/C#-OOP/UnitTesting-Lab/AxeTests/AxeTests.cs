using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{

    [TestCase(100, 100, 100, 100)]
    [TestCase(100, 100, 100, 99)]
    [TestCase(100, 100, 100, 10)]
    public void WeaponLosesDurabilityAfterEachAttack(int health, int experience, int attack, int durability)
    {
        //Arrange
        Dummy dummy = new Dummy(health, experience);
        Axe axe = new Axe(attack, durability);

        //Act
        axe.Attack(dummy);

        //Assert
        var expectedResult = durability - 1;
        var currentResult = axe.DurabilityPoints;
        Assert.AreEqual(expectedResult, currentResult);

    }

    [TestCase(100, 100, 100, -1)]
    [TestCase(100, 100, 100, 0)]
    public void AttackingWithABrokenWeapon(int health, int experience, int attack, int durability)
    {

        //Arrange
        Dummy dummy = new Dummy(health, experience);
        Axe axe = new Axe(attack, durability);

        //Act

        Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));


    }

}