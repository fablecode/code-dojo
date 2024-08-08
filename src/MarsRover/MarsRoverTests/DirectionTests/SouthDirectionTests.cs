using FluentAssertions;
using FluentAssertions.Execution;
using MarsRover;
using MarsRover.Direction;
using MarsRover.Interfaces;
using NUnit.Framework;

namespace MarsRoverTests.DirectionTests;

[TestFixture]
public class SouthDirectionTests
{
    private IDirection _sut = null!;
    private Landscape _landscape = null!;

    [SetUp]
    public void SetUp()
    {
        _landscape = new Landscape(5);
        _sut = new South(_landscape);
    }

    [Test]
    public void Given_A_Turn_Left_Command_Direction_Should_Be_East()
    {
        // Arrange
        // Act
        var result = _sut.TurnLeft();

        // Assert
        result.Should().BeOfType<East>();
    }

    [Test]
    public void Given_A_Turn_Right_Command_Direction_Should_Be_West()
    {
        // Arrange
        // Act
        var result = _sut.TurnRight();

        // Assert
        result.Should().BeOfType<West>();
    }

    [Test]
    public void Given_A_Move_Command_Should_Not_Pass_Boundary()
    {
        // Arrange
        // Act
        _sut.Move();

        // Assert
        using (new AssertionScope())
        {
            _landscape.CoordinateX.Should().Be(0);
            _landscape.CoordinateY.Should().Be(0);
        }
    }
}