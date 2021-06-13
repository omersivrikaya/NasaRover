namespace Nasa.RoverProject
{
    public class DirectionWest : IDirection
    {
        public string ShortName
        {
            get { return "W"; }
        }

        public IDirection TurnLeft()
        {
            return new DirectionSouth();
        }

        public IDirection TurnRight()
        {
            return new DirectionNorth();
        }

        public Coordinate GetNextCoordinate(Coordinate coordinate)
        {
            return new Coordinate(coordinate.CoordinateX - 1, coordinate.CoordinateY);
        }
    }
}
