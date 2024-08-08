using MarsRover.Interfaces;

namespace MarsRover.Commands;

public interface ICommand
{
    void Execute(IRover rover);
}