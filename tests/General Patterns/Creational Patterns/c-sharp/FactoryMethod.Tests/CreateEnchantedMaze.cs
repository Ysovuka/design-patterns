using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Creational.FactoryMethod.Tests
{
    public class CreateEnchantedMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new EnchantedMazeGame();
            Maze maze = game.CreateMaze();

            Assert.True(maze.GetRoom(1).GetType() == typeof(EnchantedRoom));
        }
    }
}
