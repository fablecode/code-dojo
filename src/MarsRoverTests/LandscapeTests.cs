using FluentAssertions;
using MarsRover;
using NUnit.Framework;

namespace MarsRoverTests;

[TestFixture]
public class LandscapeTests
{
    [Test]
    public void Given_A_GridSize_When_Landscape_Is_Created_Rover_CoordinateX_Position_Should_Be_0()
    {
        // Arrange
        var landscape = new Landscape(5);

        // Act
        // Assert
        landscape.CoordinateX.Should().Be(0);
    }
    [Test]
    public void Given_A_GridSize_When_Landscape_Is_Created_Rover_CoordinateY_Position_Should_Be_0()
    {
        // Arrange
        var landscape = new Landscape(5);

        // Act
        // Assert
        landscape.CoordinateY.Should().Be(0);
    }
}