using MarsRover.Interfaces;

namespace MarsRover;

public class Landscape : ILandscape
{
    public Landscape(int gridSize)
    {
        _gridSize = gridSize;
        CoordinateX = 0;
        CoordinateY = 0;
    }

    public int CoordinateX { get; private set; }

    public int CoordinateY { get; private set; }

    private readonly int _gridSize;

    public void MoveXForward()
    {
        if (CoordinateX < _gridSize)
        {
            CoordinateX++;
        }
    }

    public void MoveXBackward()
    {
        if (CoordinateX > 0)
        {
            CoordinateX--;
        }
    }

    public void MoveYForward()
    {
        if (CoordinateY < _gridSize)
        {
            CoordinateY++;
        }
    }

    public void MoveYBackward()
    {
        if (CoordinateY > 0)
        {
            CoordinateY--;
        }
    }
}