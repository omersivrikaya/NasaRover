using System;

namespace Nasa.RoverProject
{
    public class ComandSelector
    {
        public IRoverCommand GetCommand(char command)
        {
            switch (command)
            {
                case 'M':
                    return new MoveCommand();
                case 'L':
                    return new TurnLeftCommand();
                case 'R':
                    return new TurnRightCommand();
                default:
                    throw new ArgumentException("Command is incorrect");
            }
        }
    }
}
