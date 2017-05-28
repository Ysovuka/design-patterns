using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.AbstractFactory.Tests
{
    public class CreateRegularMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new MazeGame();

            Maze maze = game.CreateMaze(new MazeFactory());

            Assert.True(maze.GetRoom(1).GetType() == typeof(Room));
        }
    }
}
