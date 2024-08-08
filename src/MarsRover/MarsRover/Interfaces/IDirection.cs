﻿namespace MarsRover.Interfaces;

public interface IDirection
{
    IDirection TurnLeft();
    IDirection TurnRight();
    void Move();
}