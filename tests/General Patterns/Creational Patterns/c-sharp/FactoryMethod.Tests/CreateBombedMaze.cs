using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.FactoryMethod.Tests
{
    public class CreateBombedMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new BombedMazeGame();
            Maze maze = game.CreateMaze();

            Assert.True(maze.GetRoom(1).GetType() == typeof(BombRoom));
        }
    }
}
