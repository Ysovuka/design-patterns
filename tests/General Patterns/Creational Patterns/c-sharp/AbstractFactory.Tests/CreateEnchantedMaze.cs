using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.AbstractFactory.Tests
{
    public class CreateEnchantedMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaze(new EnchantedFactory());

            Assert.True(maze.GetRoom(1).GetType() == typeof(EnchantedRoom));
        }
    }
}
