using MarsRover.Interfaces;

namespace MarsRover.Commands;

public class ForwardCommand : ICommand
{
    public void Execute(IRover rover)
    {
        rover.Forward();
    }
}