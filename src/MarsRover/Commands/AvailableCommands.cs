namespace MarsRover.Commands;

public static class AvailableCommands
{
    public static Dictionary<char, ICommand> List => new Dictionary<char, ICommand>()
    {
        ['M'] = new ForwardCommand(),
        ['L'] = new TurnLeftCommand(),
        ['R'] = new TurnRightCommand(),
    };
}