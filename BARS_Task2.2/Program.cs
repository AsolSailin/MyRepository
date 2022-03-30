using System;
using System.Collections.Generic;

namespace BARS_Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Entity> list = new List<Entity>()
            {
                new Entity {Id = 1, ParentId = 0, Name = "Root entity"},
                new Entity {Id = 2, ParentId = 1, Name = "Child of 1 entity"},
                new Entity {Id = 3, ParentId = 1, Name = "Child of 1 entity"},
                new Entity {Id = 4, ParentId = 2, Name = "Child of 2 entity"},
                new Entity {Id = 5, ParentId = 4, Name = "Child of 4 entity"}
            };

            var search = Parents(list);
            Console.WriteLine(search);
        }

        public static Dictionary<int, List<Entity>> Parents(List<Entity> entities)
        {
            var result = new Dictionary<int, List<Entity>>();

            foreach (var en in entities)
            {
                result.TryAdd(en.ParentId, new List<Entity>());
                result[en.ParentId].Add(en);
            }

            return result;
        }
    }
}
