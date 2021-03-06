﻿using DesignPatterns.Common.Creational.Maze;
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

    public class CreateRegularMaze
    {
        [Fact]
        public void Create()
        {
            MazeGame game = new MazeGame();
            Maze maze = game.CreateMaze();

            Assert.True(maze.Rooms.Count == 2);
        }
    }
}
