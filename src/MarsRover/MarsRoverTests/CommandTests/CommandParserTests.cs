using FluentAssertions;
using MarsRover.Commands;
using NUnit.Framework;

namespace MarsRoverTests.CommandTests;

[TestFixture]
public class CommandParserTests
{
    private CommandParser _sut = null!;

    [SetUp]
    public void Setup()
    {
        _sut = new CommandParser(AvailableCommands.List);
    }

    [Test]
    public void Given_A_Move_Command_Should_Return_Correct_Command_To_Move_Forward()
    {
        // Arrange
        // Act
        var command = _sut.ParseCommand('M');

        // Assert
        command.Should().BeOfType<ForwardCommand>();
    }

    [Test]
    public void Given_A_Turn_Left_Command_Should_Return_Correct_Command_To_Turn_Left()
    {
        // Arrange
        // Act
        var command = _sut.ParseCommand('L');

        // Assert
        command.Should().BeOfType<TurnLeftCommand>();
    }

    [Test]
    public void Given_A_Turn_Right_Command_Should_Return_Correct_Command_To_Turn_Right()
    {
        // Arrange
        // Act
        var command = _sut.ParseCommand('R');

        // Assert
        command.Should().BeOfType<TurnRightCommand>();
    }
}