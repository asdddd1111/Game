using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class NextPosition
    {
        public List<Point> Get(List<Employee> employees)
        {
            int minCoordinate = 0;
            int maxCoordinate = 19;
            int maxIndex = 1;
            int minIndex = 0;
            int[] changeCoordinate = { -1, 1 };
            List<Point> points = new List<Point>();
            for (int i=0;i<employees.Count;i++)
            {
                if (employees[i].Position.X > minCoordinate && employees[i].Position.Y > minCoordinate && employees[i].Position.X < maxCoordinate && employees[i].Position.Y < maxCoordinate)
                {
                    points.Add(new Point { X = employees[i].Position.X + changeCoordinate[RandomNumber.Get(minIndex, maxIndex)], Y = employees[i].Position.Y + changeCoordinate[RandomNumber.Get(minIndex, maxIndex)] });
                }
                else
                {
                    points.Add(new Point { X = RandomNumber.Get(minCoordinate, maxCoordinate), Y = RandomNumber.Get(minCoordinate, maxCoordinate) });
                }
            }
            return points;
        }
    }
}
