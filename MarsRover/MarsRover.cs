namespace MarsRover;

public class MarsRover
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public char Direction { get; private set; }

    public MarsRover(int x, int y, char dir)
    {
        X = x;
        Y = y;
        Direction = dir;
    }
}