using System;

namespace Nasa.RoverProject
{
    public class Position
    {
        private Coordinate TopRightBoundary { get; set; }
        public Coordinate CurrentCoordinate { get; private set; }
        public IDirection CurrentDirection { get; private set; }
        
        public Position(Coordinate topRightBoundary, Coordinate currentCoordinate, IDirection currentDirection)
        {
            if (topRightBoundary == null)
            {
                throw new ArgumentNullException("topRightBoundary can not bu null");
            }
            if (currentCoordinate == null)
            {
                throw new ArgumentNullException("currentCoordinate can not bu null");
            }
            if (currentDirection == null)
            {
                throw new ArgumentNullException("currentDirection can not bu null");
            }
            TopRightBoundary = topRightBoundary;

            if(!IsAvailablePosition(currentCoordinate))
            {
                throw new InvalidOperationException("Position is out of boundary");
            }

            CurrentCoordinate = currentCoordinate;
            CurrentDirection = currentDirection;
        }

        public void TurnLeft()
        {
            CurrentDirection = CurrentDirection.TurnLeft();
        }

        public void TurnRight()
        {
            CurrentDirection = CurrentDirection.TurnRight();
        }

        public int GetCoordinateXAfterPossibleMove()
        {
            return CurrentDirection.GetNextCoordinate(CurrentCoordinate).CoordinateX;
        }

        public int GetCoordinateYAfterPossibleMove()
        {
            return CurrentDirection.GetNextCoordinate(CurrentCoordinate).CoordinateY;
        }

        public void Move()
        {
            var nextCoordinate=  CurrentDirection.GetNextCoordinate(CurrentCoordinate);
            if(!IsAvailablePosition(nextCoordinate))
            {
                throw new InvalidOperationException("Next position is out of boundary");
            }

            CurrentCoordinate = CurrentDirection.GetNextCoordinate(CurrentCoordinate);
        }

        public string PrintPosition()
        {
            return $"{CurrentCoordinate.CoordinateX} {CurrentCoordinate.CoordinateY} {CurrentDirection.ShortName}";
        }

        private bool IsAvailablePosition(Coordinate coordinate)
        {
            return coordinate.CoordinateX >= 0
                && coordinate.CoordinateX <= TopRightBoundary.CoordinateX
                && coordinate.CoordinateY >= 0
                && coordinate.CoordinateY <= TopRightBoundary.CoordinateY;
        }
    }
}
