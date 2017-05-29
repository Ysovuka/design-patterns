using DesignPatterns.Common.Creational.Maze;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class MazeBuilder
    {
        public MazeBuilder() { }

        private Maze _maze;

        public virtual void BuildMaze() { _maze = new Maze(); }
        public virtual void BuildRoom(int id)
        {
            if (_maze.GetRoom(id) == null)
            {
                Room room = new Room(id);
                _maze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
                room.SetSide(Direction.South, new Wall());
            }
        }
        public virtual void BuildDoor(int entranceRoomId, int exitRoomId)
        {
            Room entranceRoom = _maze.GetRoom(entranceRoomId);
            Room exitRoom = _maze.GetRoom(exitRoomId);
            Door door = new Door(entranceRoom, exitRoom);

            entranceRoom.SetSide(Direction.East, door);
            exitRoom.SetSide(Direction.West, door);
        }

        public virtual void BuildWall(int roomId, Direction direction)
        {
            Room room = _maze.GetRoom(roomId);

            room.SetSide(direction, new Wall());
        }

        public Maze GetMaze() => _maze;
    }
}
