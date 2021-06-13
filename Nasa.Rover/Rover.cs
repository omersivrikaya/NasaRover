using System;

namespace Nasa.RoverProject
{
    public class Rover
    {
        private Position CurrentPosition { get; set; }

        public Rover(string boundaryInput, string positionInput)
        {
            if (boundaryInput == null)
            {
                throw new ArgumentNullException("boundaryInput can not be null");
            }

            var coordinateCommands = boundaryInput.Split(' ');
            if (coordinateCommands.Length != 2)
            {
                throw new ArgumentException("Boundary input is incorrect");
            }

            if (!int.TryParse(coordinateCommands[0], out int bondaryCoordinateX))
            {
                throw new ArgumentException("Boundary coordinateX is incorrect");
            }

            if (!int.TryParse(coordinateCommands[1], out int bondaryCoordinateY))
            {
                throw new ArgumentException("Boundary coordinateY is incorrect");
            }
     
            var positionCommands = positionInput.Split(' ');
            if (positionCommands.Length != 3)
            {
                throw new ArgumentException("Position input is incorrect");
            }

            if (!int.TryParse(positionCommands[0], out int coordinateX))
            {
                throw new ArgumentException("Position coordinateX is incorrect");
            }

            if (!int.TryParse(positionCommands[1], out int coordinateY))
            {
                throw new ArgumentException("Position coordinateY is incorrect");
            }

            var directionSelector = new DirectionSelector();
            CurrentPosition = new Position(
                new Coordinate(bondaryCoordinateX, bondaryCoordinateY),
                new Coordinate(coordinateX, coordinateY),
                directionSelector.GetDirection((positionCommands[2])));
        }

        public void ExecuteComand(string commandsInput)
        {
            var comandHelper = new ComandSelector();

            foreach (var command in commandsInput)
            {
                comandHelper.GetCommand(command).Execute(CurrentPosition);
            }
        }

        public string PrintPosition()
        {
            return CurrentPosition.PrintPosition();
        }
    }
}
