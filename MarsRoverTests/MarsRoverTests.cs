using Xunit;
using MarsRover;
using FluentAssertions;
namespace MarsRoverTests
{
    public class MarsRoverTests
    {
        [Fact]
        public void RoverAcceptsInitialStartingAndDirection()
        {
            int x = 5;
            int y = 9;
            char dir = 'N';
            var rover = new MarsRover.MarsRover(x, y, dir);
            rover.X.Should().Be(x);
            rover.Y.Should().Be(y);
            rover.Direction.Should().Be(dir);
        }

    }
}