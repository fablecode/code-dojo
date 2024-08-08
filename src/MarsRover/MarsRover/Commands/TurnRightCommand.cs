using MarsRover.Interfaces;

namespace MarsRover.Commands;

public class TurnRightCommand : ICommand
{
    public void Execute(IRover rover)
    {
        rover.TurnRight();
    }
}