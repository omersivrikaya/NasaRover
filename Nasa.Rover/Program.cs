using System;

namespace Nasa.RoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var topRightBoundary = Console.ReadLine();

                var positionInput = Console.ReadLine();
                var roverOne = new Rover(topRightBoundary, positionInput);
                roverOne.ExecuteComand(Console.ReadLine());

                var positionInput2 = Console.ReadLine();
                var roverTwo = new Rover(topRightBoundary, positionInput2);
                roverTwo.ExecuteComand(Console.ReadLine());

                Console.WriteLine(roverOne.PrintPosition());
                Console.WriteLine(roverTwo.PrintPosition());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


    }
}
