using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Common.Creational.Maze
{
    public class Room : IMazeObject
    {
        public Room(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public IDictionary<Direction, IMazeObject> Sides { get; } = new Dictionary<Direction, IMazeObject>();

        public void SetSide(Direction direction, IMazeObject obj) => Sides.Add(direction, obj);
    }
}
