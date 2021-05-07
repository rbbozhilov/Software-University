namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RobotsTests
    {

        [Test]
        public void TestingRobotConstructor()
        {

            Robot robot = new Robot("pesho", 100);

            Assert.AreEqual("pesho", robot.Name);
            Assert.AreEqual(100, robot.MaximumBattery);
            Assert.AreEqual(100, robot.Battery);


        }

        [Test]
        public void TestingConstrutorOfRobotManager()
        {

            RobotManager manager = new RobotManager(100);
            Assert.AreEqual(100, manager.Capacity);
            Assert.AreEqual(0, manager.Count);


        }


        [Test]
        public void TestingConstr_ShouldThrowExcept()
        {

            Assert.Throws<ArgumentException>(() => new RobotManager(-1));
            

        }

        [Test]
        public void TestingCounter()
        {

            RobotManager manager = new RobotManager(2);
            manager.Add(new Robot("eee", 200));
            manager.Add(new Robot("eeee", 2003));

            Assert.AreEqual(2, manager.Count);


        }

        [Test]
        public void TestingAdder_ShouldThrowExc()
        {

            RobotManager manager = new RobotManager(2);
            Robot robot = new Robot("er", 100);
            manager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => manager.Add(robot));
        }

        [Test]
        public void TestingAdder_ShouldThrowExcCapacity()
        {

            RobotManager manager = new RobotManager(1);
            Robot robot = new Robot("er", 100);
            manager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => manager.Add(new Robot("3123",20)));
        }

        [Test]
        public void RobotToRemove_ShouldThrowExc()
        {

            Assert.Throws<InvalidOperationException>(() => new RobotManager(20).Remove("pesho"));

        }


        [Test]
        public void RemoveRobot_Success()
        {

            RobotManager manager = new RobotManager(1);
            Robot robot = new Robot("er", 100);
            manager.Add(robot);

            manager.Remove("er");

            Assert.AreEqual(0, manager.Count);

        }


        [Test]
        public void Work_ShouldThrowExc()
        {

            Assert.Throws<InvalidOperationException>(() => new RobotManager(20).Work("eee","tee",20));

        }


        [Test]
        public void WorkRobot_ShouldThrowExcLessBatteryUsage()
        {

            RobotManager manager = new RobotManager(1);
            Robot robot = new Robot("er", 100);
            manager.Add(robot);

            
            Assert.Throws<InvalidOperationException>(() => manager.Work("er", "softwaring", 200));

        }

        [Test]
        public void WorkShouldBeDone()
        {
            RobotManager manager = new RobotManager(1);
            Robot robot = new Robot("er", 100);
            manager.Add(robot);

            manager.Work("er", "job", 50);
            int expected = 100 - 50;

            Assert.AreEqual(expected, robot.Battery);

        }


        [Test]
        public void Charger_ShouldThrowExc()
        {

            Assert.Throws<InvalidOperationException>(() => new RobotManager(20).Charge("eee"));


        }

        [Test]
        public void SuccessCharging()
        {
            RobotManager manager = new RobotManager(1);
            Robot robot = new Robot("er", 100);
            manager.Add(robot);

            manager.Work("er", "job", 50);

            manager.Charge("er");
            int expected = 100;

            Assert.AreEqual(expected, robot.Battery);
            

        }



    }
}
