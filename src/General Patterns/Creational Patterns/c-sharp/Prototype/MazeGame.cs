using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class MazeGame
    {
        public MazeGame() { }

        public Maze CreateMaze(MazePrototypeFactory factory)
        {
            Maze maze = factory.MakeMaze();

            Room room1 = factory.MakeRoom(1);
            Room room2 = factory.MakeRoom(2);
            Door door = factory.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, factory.MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, factory.MakeWall());
            room1.SetSide(Direction.West, factory.MakeWall());

            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.South, factory.MakeWall());
            room2.SetSide(Direction.North, factory.MakeWall());
            room2.SetSide(Direction.East, factory.MakeWall());

            return maze;
        }
    }
}
