using System;
using System.Collections.Generic;
using System.Drawing;

namespace FindPath.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[25, 25]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 4, 4, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 4, 4, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 7, 7, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0},
                {0, 0, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 7, 7, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            var path = FindShortestPath(arr);

            if (path != null)
            {
                foreach (var point in path)
                {
                    Console.WriteLine(point);
                }
            }
            else
            {
                Console.WriteLine("No path found.");
            }

            Console.ReadKey();
        }

        public static Point[] FindShortestPath(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            var start = new Point(0, 0);
            var end = new Point(rows - 1, cols - 1);

            var directions = new Point[] {
                new Point(0, 1),
                new Point(1, 0),
                new Point(0, -1),
                new Point(-1, 0),
                new Point(1, 1),
                new Point(1, -1),
                new Point(-1, 1),
                new Point(-1, -1)
            };

            var queue = new Queue<Point>();
            var visited = new HashSet<Point>();
            var parentMap = new Dictionary<Point, Point>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == end)
                {
                    return BuildPath(parentMap, start, end);
                }

                foreach (var direction in directions)
                {
                    var neighbor = new Point(current.X + direction.X, current.Y + direction.Y);

                    if (IsValid(neighbor, rows, cols, arr, visited, arr[current.X, current.Y]))
                    {
                        visited.Add(neighbor);
                        parentMap[neighbor] = current;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return null;
        }

        private static bool IsValid(Point point, int rows, int cols, int[,] arr, HashSet<Point> visited, int currentValue)
        {
            if (point.X < 0 || point.X >= rows || point.Y < 0 || point.Y >= cols || visited.Contains(point))
                return false;

            if (arr[point.X, point.Y] == 0)
            {
                return currentValue == 0;
            }
            else
            {
                return currentValue == arr[point.X, point.Y] || arr[point.X, point.Y] == 5;
            }
        }

        private static Point[] BuildPath(Dictionary<Point, Point> parentMap, Point start, Point end)
        {
            var path = new List<Point>();
            for (var at = end; !at.Equals(start); at = parentMap[at])
            {
                path.Add(at);
            }
            path.Add(start);
            path.Reverse();
            return path.ToArray();
        }
    }
}
