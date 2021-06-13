namespace Nasa.RoverProject
{
    public class TurnRightCommand : IRoverCommand
    {
        public void Execute(Position position)
        {
            position.TurnRight();
        }
    }
}
