using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class MazeGame
    {
        public MazeGame() { }

        public Maze CreateMaze()
        {
            Maze maze = MakeMaze();

            Room room1 = MakeRoom(1);
            Room room2 = MakeRoom(2);
            Door door = MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, MakeWall());
            room1.SetSide(Direction.West, MakeWall());

            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.South, MakeWall());
            room2.SetSide(Direction.North, MakeWall());
            room2.SetSide(Direction.East, MakeWall());

            return maze;
        }

        public virtual Maze MakeMaze() => new Maze();
        public virtual Room MakeRoom(int id) => new Room(id);
        public virtual Wall MakeWall() => new Wall();
        public virtual Door MakeDoor(Room entranceRoom, Room exitRoom) => new Door(entranceRoom, exitRoom);
    }
}
