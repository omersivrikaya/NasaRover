namespace Nasa.RoverProject
{
    public class MoveCommand : IRoverCommand
    {
        public void Execute(Position position)
        {
            position.Move();
        }
    }
}
