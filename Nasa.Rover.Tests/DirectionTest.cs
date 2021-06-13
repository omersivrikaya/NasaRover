using NUnit.Framework;
using System;

namespace Nasa.RoverProject.Tests
{
    public class DirectionTest
    {
        [Test]
        public void TurnRight_ShouldReturnWest_WhenDirectionIsSouth()
        {
            IDirection direction = new DirectionSouth();
            direction = direction.TurnRight();
            Assert.AreEqual(direction.GetType(), typeof(DirectionWest));
        }

        [Test]
        public void TurnLeft_ShouldReturnEast_WhenDirectionIsSouth()
        {
            IDirection direction = new DirectionSouth();
            direction = direction.TurnLeft();
            Assert.AreEqual(direction.GetType(), typeof(DirectionEast));
        }

        [Test]
        public void TurnRight_ShouldReturnEast_WhenDirectionIsNorth()
        {
            IDirection direction = new DirectionNorth();
            direction = direction.TurnRight();
            Assert.AreEqual(direction.GetType(), typeof(DirectionEast));
        }

        [Test]
        public void TurnLeft_ShouldReturnWest_WhenDirectionIsNorth()
        {
            IDirection direction = new DirectionNorth();
            direction = direction.TurnLeft();
            Assert.AreEqual(direction.GetType(), typeof(DirectionWest));
        }


        [Test]
        public void TurnRight_ShouldReturnNorth_WhenDirectionIsWest()
        {
            IDirection direction = new DirectionWest();
            direction = direction.TurnRight();
            Assert.AreEqual(direction.GetType(), typeof(DirectionNorth));
        }

        [Test]
        public void TurnLeft_ShouldReturnSouth_WhenDirectionIsWest()
        {
            IDirection direction = new DirectionWest();
            direction = direction.TurnLeft();
            Assert.AreEqual(direction.GetType(), typeof(DirectionSouth));
        }

        [Test]
        public void TurnRight_ShouldReturnSouth_WhenDirectionIsEast()
        {
            IDirection direction = new DirectionEast();
            direction = direction.TurnRight();
            Assert.AreEqual(direction.GetType(), typeof(DirectionSouth));
        }

        [Test]
        public void TurnLeft_ShouldReturnSouth_WhenDirectionIsEast()
        {
            IDirection direction = new DirectionEast();
            direction = direction.TurnLeft();
            Assert.AreEqual(direction.GetType(), typeof(DirectionNorth));
        }
    }
}
