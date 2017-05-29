using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class MazePrototypeFactory
    {
        private Maze _prototypeMaze;
        private Door _prototypeDoor;
        private Room _prototypeRoom;
        private Wall _prototypeWall;

        public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeMaze = maze;
            _prototypeWall = wall;
            _prototypeRoom = room;
            _prototypeDoor = door;
        }

        public virtual Maze MakeMaze() => _prototypeMaze.Clone();

        public virtual Room MakeRoom(int id)
        {
            Room room = _prototypeRoom.Clone();
            room.Initialize(id);

            return room;
        }

        public virtual Door MakeDoor(Room entrance, Room exit)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(entrance, exit);

            return door;
        }

        public virtual Wall MakeWall() => _prototypeWall.Clone();

    }
}
