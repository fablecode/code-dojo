namespace MarsRover.Interfaces;

public interface IRover
{
    IDirection Direction { get; }
    int CoordinateX { get; }
    int CoordinateY { get; }
    void TurnLeft();
    void TurnRight();
    void Forward();
}