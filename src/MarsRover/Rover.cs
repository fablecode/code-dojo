using MarsRover.Commands;
using MarsRover.Direction;
using MarsRover.Interfaces;

namespace MarsRover
{
    public class Rover : IRover
    {
        private readonly ILandscape _landscape;
        public IDirection Direction { get; private set; }
        public int CoordinateX => _landscape.CoordinateX;
        public int CoordinateY => _landscape.CoordinateY;


        public Rover(ILandscape landscape)
        {
            _landscape = landscape;
            Direction = new North(landscape);
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }
        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void Forward()
        {
            Direction.Move();
        }

        public void ExecuteCommands(string commandString)
        {
            var commandParser = new CommandParser(AvailableCommands.List);

            foreach (var command in commandString)
            {
                var commandToExecute = commandParser.ParseCommand(command);
                commandToExecute.Execute(this);
            }
        }
    }
}