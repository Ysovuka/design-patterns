using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.Prototype.Tests
{
    public class CreateBombedMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaze(new MazePrototypeFactory(new Maze(), new BombedWall(), new BombRoom(), new Door()));

            Assert.True(maze.GetRoom(1).GetType() == typeof(BombRoom));
        }
    }
}
