using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Builder.Tests
{
    public class BuildRegularMaze
    {
        [Fact]
        public void Build()
        {
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaze(new MazeBuilder());

            Assert.True(maze.Rooms.Count == 2);
        }
    }
}
