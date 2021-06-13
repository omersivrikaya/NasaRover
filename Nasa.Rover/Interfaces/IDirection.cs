namespace Nasa.RoverProject
{
    public interface IDirection
    {
        public string ShortName { get; }
        IDirection TurnLeft();
        IDirection TurnRight();
        Coordinate GetNextCoordinate(Coordinate coordinate);
    }
}
