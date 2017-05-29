using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class MazeGame
    {
        public MazeGame() { }

        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }
    }
}
