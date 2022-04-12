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
        [Theory]
        [InlineData('N', 5, 10)]
        [InlineData('S', 5, 8)]
        [InlineData('W', 4, 9)]
        [InlineData('E', 6, 9)]
        public void RoverMovesCorrectlyForForwardCommand(char direction, int expectedX, int expectedY)
        {
            char command = 'f';

            int x = 5;
            int y = 9;

            var rover = new MarsRover.MarsRover(x, y, direction);
            rover.MoveForward(command);

            rover.X.Should().Be(expectedX);
            rover.Y.Should().Be(expectedY);
            rover.Direction.Should().Be(direction);
        }

        [Fact]
        [InlineData('N', 5, 8)]
        [InlineData('S', 5, 10)]
        [InlineData('W', 6, 9)]
        [InlineData('E', 4, 9)]
        public void RoverMovesCorrectlyForBackwordCommand()
        {
            char command = 'b';

            int x = 5;
            int y = 9;
            char dir = 'N';

            var rover = new MarsRover.MarsRover(x, y, dir);
            rover.MoveBackwards(command);

            rover.X.Should().Be(x);
            rover.Y.Should().Be(y - 1);
            rover.Direction.Should().Be(dir);
        }

    }
}