using MarsRover.Interfaces;

namespace MarsRover.Commands;

public class TurnLeftCommand : ICommand
{
    public void Execute(IRover rover)
    {
        rover.TurnLeft();
    }
}