using System.Security.Cryptography;
using FluentAssertions;
using FluentAssertions.Execution;
using MarsRover;
using MarsRover.Direction;
using MarsRover.Interfaces;
using NUnit.Framework;

namespace MarsRoverTests;

[TestFixture]
public class RoverTests
{
    private Rover _sut = null!;
    private ILandscape _landscape = null!;

    [SetUp]
    public void Setup()
    {
        _landscape = new Landscape(5);
        _sut = new Rover(_landscape);
    }

    [Test]
    public void Given_A_Landscape_When_Rover_Is_Created_The_Rover_Starting_Direction_Should_Be_North()
    {
        // Arrange

        // Act
            
        // Assert
        _sut.Direction.Should().BeOfType<North>();
    }

    [Test]
    public void Given_A_New_Rover_And_A_Turn_Left_Command_Is_Executed_The_Rover_Direction_Should_Be_West()
    {
        // Arrange
        // Act
        _sut.TurnLeft();

        // Assert
        _sut.Direction.Should().BeOfType<West>();
    }

    [Test]
    public void Given_A_New_Rover_And_A_Turn_Right_Command_Is_Executed_The_Rover_Direction_Should_Be_East()
    {
        // Arrange
        // Act
        _sut.TurnRight();

        // Assert
        _sut.Direction.Should().BeOfType<East>();
    }

    [Test]
    public void Given_A_New_Rover_And_A_Move_Forward_Command_Is_Executed_The_Rover_Will_Be_At_Coordinates_0_1()
    {
        // Arrange
        // Act
        _sut.Forward();

        // Assert
        using (new AssertionScope())
        {
            _sut.CoordinateX.Should().Be(0);
            _sut.CoordinateY.Should().Be(1);
        }
    }
    [Test]
    public void Given_A_New_Rover_And_A_Turn_Right_And_Move_Command_Is_Executed_The_Rover_Will_Be_At_Coordinates_1_0()
    {
        // Arrange
        // Act
        _sut.TurnRight();
        _sut.Forward();

        // Assert
        using (new AssertionScope())
        {
            _sut.CoordinateX.Should().Be(1);
            _sut.CoordinateY.Should().Be(0);
        }
    }

    [Test]
    public void Given_A_New_Rover_That_Is_Facing_West_The_Rover_Will_Be_At_Coordinates_1_0()
    {
        // Arrange
        // Act
        _sut.TurnRight();
        _sut.Forward();
        _sut.Forward();
        _sut.TurnRight();
        _sut.TurnRight();
        _sut.Forward();

        // Assert
        using (new AssertionScope())
        {
            _sut.CoordinateX.Should().Be(1);
            _sut.CoordinateY.Should().Be(0);
            _sut.Direction.Should().BeOfType<West>();
        }
    }
    [Test]
    public void Given_A_New_Rover_That_Is_Facing_South_The_Rover_Will_Be_At_Coordinates_0_1()
    {
        // Arrange
        // Act
        _sut.Forward();
        _sut.Forward();
        _sut.TurnRight();
        _sut.TurnRight();
        _sut.Forward();

        // Assert
        using (new AssertionScope())
        {
            _sut.CoordinateX.Should().Be(0);
            _sut.CoordinateY.Should().Be(1);
            _sut.Direction.Should().BeOfType<South>();
        }
    }

    [Test]
    [TestCase("RMLMMRM", 2, 2, "East")]
    [TestCase("RULLU", 0, 0, "West")]
    public void Given_A_Valid_CommandString_Mars_Rover_Should_Move_To_Coordinates_And_Face_Correct_Direction(string commands, int xCoordinateExpected, int yCoordinateExpected, string directionExpected)
    {
        // Arrange
        // Act
        _sut.ExecuteCommands(commands);

        // Assert
        using (new AssertionScope())
        {
            _sut.CoordinateX.Should().Be(xCoordinateExpected);
            _sut.CoordinateY.Should().Be(yCoordinateExpected);
            _sut.Direction.ToString().Should().BeEquivalentTo(directionExpected);
        }
    }
}