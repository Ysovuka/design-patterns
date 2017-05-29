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

        public ICollection<Room> Rooms { get; } = new List<Room>();

        public void AddRoom(Room room) => Rooms.Add(room);
        public Room GetRoom(int id) => Rooms.FirstOrDefault(r => r.Id == id);
    }
}
