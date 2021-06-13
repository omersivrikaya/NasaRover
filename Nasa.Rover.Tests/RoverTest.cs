using NUnit.Framework;
using System;

namespace Nasa.RoverProject.Tests
{
    public class RoverTest
    {
        [Test]
        public void InitializeRover_ShouldArgumentNullException_WhenBoundaryInputIsNull()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new Rover(null, null));
            Assert.That(ex.ParamName, Is.EqualTo("boundaryInput can not be null"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenBoundaryInputHasNot2ValidElements()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("5", null));
            Assert.That(ex.Message, Is.EqualTo("Boundary input is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenBoundaryCoordinateXIsNotInteger()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("A 5", null));
            Assert.That(ex.Message, Is.EqualTo("Boundary coordinateX is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenBoundaryCoordinateYIsNotInteger()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("5 A", null));
            Assert.That(ex.Message, Is.EqualTo("Boundary coordinateY is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenPositionInputHasNotThreeValidElements()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("8 8", "8 9"));
            Assert.That(ex.Message, Is.EqualTo("Position input is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenPositionCoordinateXIsNotInteger()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("8 8", "? 8 9"));
            Assert.That(ex.Message, Is.EqualTo("Position coordinateX is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenPositionCoordinateYIsNotInteger()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("8 8", "7 A 9"));
            Assert.That(ex.Message, Is.EqualTo("Position coordinateY is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldArgumentException_WhenDirectionIsInvalid()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Rover("4 4", "7 7 9"));
            Assert.That(ex.Message, Is.EqualTo("Position direction is incorrect"));
        }

        [Test]
        public void InitializeRover_ShouldInvalidOperationException_WhenPositionCoordinatesAreOutOfBoundary()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => new Rover("4 4", "7 7 W"));
            Assert.That(ex.Message, Is.EqualTo("Position is out of boundary"));
        }

        

        [Test]
        public void InitializeRover_ShouldSuccess_WhenInputIsCorrectFormat()
        {
            var rover = new Rover("4 4", "1 1 N");
        }


        [Test]
        public void ExecuteComand_ShouldArgumentException_WhenComandIncludesInCorrectChar()
        {
            var rover = new Rover("5 5","5 5 N");
            var ex = Assert.Throws<ArgumentException>(() => rover.ExecuteComand("XXX"));
            Assert.That(ex.Message, Is.EqualTo("Command is incorrect"));
        }

        [Test]
        public void ExecuteComand_ShouldInvalidOperationException_WhenMovesOutOfBoundary()
        {
            var rover = new Rover("5 5", "5 5 N");
            var ex = Assert.Throws<InvalidOperationException>(() => rover.ExecuteComand("M"));
            Assert.That(ex.Message, Is.EqualTo("Next position is out of boundary"));
        }

        [Test]
        public void ExecuteComand_ShouldSuccess_WhenInputIsCorrect()
        {
            var rover = new Rover("5 5", "5 5 N");
            rover.ExecuteComand("LMR");
        }

        [Test]
        public void PrintPosition_ShouldReturnCurrentPosition_WhenPositionIsSetted()
        {
            var rover = new Rover("5 5", "1 2 N");
            var actual =  rover.PrintPosition();
            Assert.AreEqual("1 2 N", actual);
        }

        [Test]
        public void PrintPosition_ShouldReturnValidResult_WhenCalledAfterExecuteComand()
        {
            var rover = new Rover("5 5", "1 2 N");
            rover.ExecuteComand("LMLMLMLMM");
            var actual = rover.PrintPosition();
            Assert.AreEqual("1 3 N", actual);
        }

        [Test]
        public void PrintPosition_ShouldReturnValidResult_WhenCalledAfterExecuteComandWithSecondData()
        {
            var rover = new Rover("5 5", "3 3 E");
            rover.ExecuteComand("MMRMMRMRRM");
            var actual = rover.PrintPosition();
            Assert.AreEqual("5 1 E", actual);
        }


    }
}
