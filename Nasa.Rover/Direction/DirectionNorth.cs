namespace Nasa.RoverProject
{
    public class DirectionNorth : IDirection
    {
        public string ShortName
        {
            get { return "N"; }
        }
        public IDirection TurnLeft()
        {
            return new DirectionWest();
        }

        public IDirection TurnRight()
        {
            return new DirectionEast();
        }

        public Coordinate GetNextCoordinate(Coordinate coordinate)
        {
            return new Coordinate(coordinate.CoordinateX, coordinate.CoordinateY + 1);
        }
    }
}
