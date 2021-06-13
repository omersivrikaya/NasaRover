using System;
using System.Collections.Generic;

namespace Nasa.RoverProject
{
    public class DirectionSelector
    {
        public IDirection GetDirection(string input)
        {
            switch (input)
            {
                case "N":
                    return new DirectionNorth();
                case "E":
                    return new DirectionEast();
                case "S":
                    return new DirectionSouth();
                case "W":
                    return new DirectionWest();
                default:
                    throw new ArgumentException("Position direction is incorrect");
            }

        }
    }
}
