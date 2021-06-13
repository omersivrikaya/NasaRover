namespace Nasa.RoverProject
{
    public class DirectionSouth : IDirection
    {
        public string ShortName
        {
            get { return "S"; }
        }

        public IDirection TurnLeft()
        {
            return new DirectionEast();
        }

        public IDirection TurnRight()
        {
            return new DirectionWest();
        }

        public Coordinate GetNextCoordinate(Coordinate coordinate)
        {
            return new Coordinate(coordinate.CoordinateX, coordinate.CoordinateY - 1);
        }
    }
}
