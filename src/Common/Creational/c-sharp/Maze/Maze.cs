using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Common.Creational.Maze
{
    public class Maze
    {
        public Maze()
        {

        }

        public Maze(Maze maze)
        {
            Rooms = maze.Rooms;
        }

        public ICollection<Room> Rooms { get; } = new List<Room>();

        public void AddRoom(Room room) => Rooms.Add(room);
        public Room GetRoom(int id) => Rooms.FirstOrDefault(r => r.Id == id);

        public Maze Clone() => new Maze(this);
    }
}
