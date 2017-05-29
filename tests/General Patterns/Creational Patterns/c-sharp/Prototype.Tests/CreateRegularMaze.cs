using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Prototype.Tests
{
    public class CreateRegularMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaze(new MazePrototypeFactory(new Maze(), new Wall(), new Room(), new Door()));

            Assert.True(maze.Rooms.Count == 2);
        }
    }
}
