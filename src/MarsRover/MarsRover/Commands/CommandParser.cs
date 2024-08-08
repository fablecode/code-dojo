namespace MarsRover.Commands;

public class CommandParser
{
    private readonly Dictionary<char, ICommand> _commands;

    public CommandParser(Dictionary<char, ICommand> commands)
    {
        _commands = commands;
    }

    public ICommand ParseCommand(char command) => _commands.ContainsKey(command) ? _commands[command] : new NotFoundCommand();
}