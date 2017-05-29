using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Common.Creational.Maze
{
    public class Room : IMazeObject
    {
        public Room() { }

        public Room(int id)
        {
            Id = id;
        }

        public Room(Room room)
        {
            Sides = room.Sides;
        }

        public int Id { get; private set; }

        public IDictionary<Direction, IMazeObject> Sides { get; protected set; } = new Dictionary<Direction, IMazeObject>();

        public void SetSide(Direction direction, IMazeObject obj)
        {
            if (!Sides.ContainsKey(direction))
            {
                Sides.Add(direction, obj);
            }
            else
            {
                Sides[direction] = obj;
            }
        }

        public virtual Room Clone() => new Room(this);
        public void Initialize(int id) => Id = id;
    }
}
