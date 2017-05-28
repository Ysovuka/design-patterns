using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.AbstractFactory.Tests
{
    public class CreateBombedMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaze(new BombedMazeFactory());

            Assert.True(maze.GetRoom(1).GetType() == typeof(BombRoom));
        }
    }
}
