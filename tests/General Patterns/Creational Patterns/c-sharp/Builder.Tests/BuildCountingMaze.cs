using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Builder.Tests
{
    public class BuildCountingMaze
    {
        [Fact]
        public void Build()
        {
            MazeGame game = new MazeGame();
            CountingMazeBuilder builder = new CountingMazeBuilder();
            Maze maze = game.CreateMaze(builder);

            Assert.True(builder.Rooms == 2);
            Assert.True(builder.Doors == 1);
        }
    }
}
