namespace Nasa.RoverProject
{
    public class TurnLeftCommand : IRoverCommand
    {
        public void Execute(Position position)
        {
            position.TurnLeft();
        }
    }
}
