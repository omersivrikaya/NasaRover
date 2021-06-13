using System;

namespace Nasa.RoverProject
{
    public class DirectionEast : IDirection
    {
        public string ShortName
        {
            get { return "E"; }  
        }
        public IDirection TurnLeft()
        {
            return new DirectionNorth();
        }

        public IDirection TurnRight()
        {
            return new DirectionSouth();
        }

        public Coordinate GetNextCoordinate(Coordinate coordinate)
        {
            return new Coordinate(coordinate.CoordinateX + 1, coordinate.CoordinateY);
        }
    }
}
